Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions
Imports Npgsql

Public Class frmMain
    Private connect As New NpgsqlConnection

    '自動排程-開啟工作排程器
    Private Sub btnTaskSchedule_Click(sender As Object, e As EventArgs) Handles btnTaskSchedule.Click
        Process.Start("taskschd.msc")
    End Sub

    '資料轉出-轉出
    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        btnExport.Enabled = False
        Cursor.Current = Cursors.WaitCursor
        ExportFile(dtpStrat.Value.ToString("yyyy-MM-dd") + " 00:00:00", dtpEnd.Value.ToString("yyyy-MM-dd") + " 23:59:59", False)
        Cursor.Current = Cursors.Default
        btnExport.Enabled = True
    End Sub

    ''' <summary>
    ''' 自動排程轉出
    ''' </summary>
    Private Sub AutoExport()
        Dim data = Split(File.ReadAllText(Application.StartupPath + "\SaveTime.set"), ",")
        Dim day As String = Now.ToString("yyyy-MM-dd") + " 23:59:59"
        Dim newDay As String
        If UBound(data) < 1 Then
            newDay = Now.ToString("yyyy-MM-dd") + " 00:00:00"
            GoTo Finish
        End If

        Select Case data(1)
            Case "日"
                newDay = Now.AddDays(Double.Parse($"-{data(0)}")).ToString("yyyy-MM-dd ") + " 00:00:00"

            Case "月"
                newDay = Now.AddMonths(Double.Parse($"-{data(0)}")).ToString("yyyy-MM-dd") + " 00:00:00"

            Case "年"
                newDay = Now.AddYears(Double.Parse($"-{data(0)}")).ToString("yyyy-MM-dd") + " 00:00:00"

            Case Else
                newDay = Now.ToString("yyyy-MM-dd") + " 00:00:00"

        End Select
Finish:
        ExportFile(newDay, day, True)
    End Sub

    ''' <summary>
    ''' 匯出資料
    ''' </summary>
    ''' <param name="startTime"></param>
    ''' <param name="endTime"></param>
    ''' <param name="auto">true:自動 false:手動</param>
    ''' <returns></returns>
    Private Function ExportFile(startTime As Date, endTime As Date, auto As Boolean) As Boolean
        Try
            Dim sql = "SELECT b.person_code, b.given_name, a.card_number, a.attendance_status, c.cr_name, b.family_name, a.swip_card_rev_time, a.person_id " &
                        "FROM attendance.sync_event_record a, platform.person b, deviceaccess.card_reader c " &
                        "WHERE a.card_read_id = c.id " &
                        "AND a.person_id = b.id " &
                        "AND a.swip_card_rev_time >= @startTime " &
                        "AND a.swip_card_rev_time <= @endTime " &
                        "AND a.auth_result = 1 " &
                        "ORDER BY a.swip_card_rev_time"
            Dim dicData As New Dictionary(Of String, Object) From
            {
                {"startTime", startTime},
                {"endTime", endTime}
            }
            Dim pgSQL = New PGSQL(txtIP.Text, txtUserName.Text, txtPsw.Text)
            Dim dt = pgSQL.SelectTable(sql, dicData)

            '將資料打包
            Dim regex As New Regex("\[(.*?)\]")
            Dim matches As MatchCollection = regex.Matches(txtFormat.Text)
            Dim sBuilder As New StringBuilder
            For Each row As DataRow In dt.Rows
                '取得資料格式
                Dim dataString = txtFormat.Text
                Dim dic = GetValueFromColumn(row)

                For Each match As Match In matches
                    '替換文字
                    dataString = Regex.Replace(dataString, Regex.Escape(match.Value), dic(match.Groups(1).Value))
                Next
                sBuilder.AppendLine(dataString)
            Next

            '取得輸出位置
            For Each row As DataGridViewRow In dgvFilePath.Rows
                Dim folderPath As String = row.Cells("儲存路徑").Value
                If Not Directory.Exists(folderPath) Then
                    Dim msg = $"存檔失敗 - {folderPath} 不存在"
                    LogMsg(msg)
                    If Not auto Then MsgBox(msg)
                    Continue For
                End If
                File.WriteAllText(folderPath + "\" + ReplaceDate(row.Cells("檔案名稱").Value) + ".txt", sBuilder.ToString)
            Next

            Dim count = dt.Rows.Count
            Dim result As String
            LogMsg($"{dtpStrat.Value:yyyy-MM-dd HH:mm:ss} 到 {dtpEnd.Value:yyyy-MM-dd HH:mm:ss} 共 {count}筆資料 ")
            If count = 0 Then
                result = "無資料需要轉出!"
            Else
                result = "轉出完成!"
            End If
            LogMsg(result)
            If Not auto Then MsgBox(result)
        Catch ex As Exception
            Dim msg = "轉出失敗 : " + ex.Message
            Console.WriteLine(ex.StackTrace)
            LogMsg(msg)
            If Not auto Then MsgBox(msg)
        End Try
        Return True
    End Function

    Private Function GetCustomize(id As Integer, customID As Integer) As String
        Dim pgSQL = New PGSQL(txtIP.Text, txtUserName.Text, txtPsw.Text)
        Dim dic As New Dictionary(Of String, Object) From
        {
            {"id", id},
            {"customID", customID}
        }
        Dim sql = "SELECT custom_value FROM platform.custom_field_person WHERE person_id = @id AND custom_id = @customID"
        Dim rows = pgSQL.SelectTable(sql, dic).Rows
        Dim result = If(rows.Count = 0, "", rows(0)("custom_value"))

        Return result
    End Function

    Private Function ReplaceDate(fileName As String) As String
        Dim replaceDict As New Dictionary(Of String, String) From {
            {"[西元年]", Now.Year.ToString()},
            {"[西元後兩碼]", Now.Year.ToString().Substring(2)},
            {"[民國年]", (Now.Year - 1911).ToString()},
            {"[月]", Now.Month.ToString("D2")},
            {"[日]", Now.Day.ToString("D2")},
            {"[時]", Now.Hour.ToString("D2")},
            {"[分]", Now.Minute.ToString("D2")},
            {"[秒]", Now.Second.ToString("D2")}
        }

        For Each kvp In replaceDict
            fileName = fileName.Replace(kvp.Key, kvp.Value)
        Next

        Return fileName
    End Function

    ''' <summary>
    ''' 取得各欄位的資料
    ''' </summary>
    ''' <param name="dr"></param>
    ''' <returns></returns>
    Private Function GetValueFromColumn(dr As DataRow) As Dictionary(Of String, String)
        Dim dic As New Dictionary(Of String, String) From {
                {"設備編號", dr("cr_name")},
                {"姓名", dr("family_name")}
            }
        Dim line = File.ReadAllLines(formatSetPath)
        Dim dicAttStatus As New Dictionary(Of String, String)

        For Each l In line
            Dim format = Split(l, ":")
            Select Case format(0)
                Case "考勤號碼"
                    dic.Add(format(0), SetPad(format(1), dr("person_code")))

                Case "卡片號碼"
                    dic.Add(format(0), SetPad(format(1), dr("card_number")))

                Case "自訂欄位1"
                    If IsNumeric(format(1)) Then dic.Add(format(0), GetCustomize(dr("person_id"), format(1)))

                Case "自訂欄位2"
                    If IsNumeric(format(1)) Then dic.Add(format(0), GetCustomize(dr("person_id"), format(1)))

                Case Else
                    dicAttStatus.Add(format(0), format(1))
            End Select
        Next

        Dim status As String = ""

        '考勤状态，默认0,0-未定义，1-上班，2-下班，3-开始休息，4-结束休息，5-开始加班，6-结束加班
        Select Case dr("attendance_status")
            Case 1
                status = dicAttStatus("上班")

            Case 2
                status = dicAttStatus("下班")

            Case 3
                status = dicAttStatus("開始休息")

            Case 4
                status = dicAttStatus("結束休息")

            Case 5
                status = dicAttStatus("開始加班")

            Case 6
                status = dicAttStatus("結束加班")

            Case 0
                status = dicAttStatus("其他")
        End Select
        dic.Add("考勤狀態", status)
        Dim day = Date.Parse(dr("swip_card_rev_time"))
        dic.Add("西元年", day.Year)
        dic.Add("西元後兩碼", Now.Year.ToString().Substring(2))
        dic.Add("民國年", day.Year - 1911)
        dic.Add("月", day.Month.ToString("D2"))
        dic.Add("日", day.Day.ToString("D2"))
        dic.Add("時", day.Hour.ToString("D2"))
        dic.Add("分", day.Minute.ToString("D2"))
        dic.Add("秒", day.Second.ToString("D2"))

        Return dic
    End Function

    ''' <summary>
    ''' 補字元
    ''' </summary>
    ''' <returns></returns>
    Private Function SetPad(format As String, data As String) As String
        Dim temp = Split(format, ",")
        '有勾選考勤號碼不足,且字數不足n位
        If temp(0) = "True" AndAlso Len(data) < temp(1) Then
            '補指定字元
            If temp(2) = "前面" Then
                Return data.PadLeft(temp(1), temp(3))
            Else
                Return data.PadRight(temp(1), temp(3))
            End If

        Else
            Return data
        End If
    End Function

    Private Sub btnSetFormat_Click(sender As Object, e As EventArgs) Handles btnSetFormat.Click
        frmSetFormat.Show()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Process.GetProcessesByName(Process.GetCurrentProcess.ProcessName).Length > 1 Then
            MsgBox("程式重複開啟")
            End
        End If

        Dim line As String()
        Dim str As String()
        cmbDBType.SelectedIndex = 0
        '初始化轉出設定-格式、結果
        GetFormat()

        '讀取資料庫設定
        If Not File.Exists(Application.StartupPath + "\Database.set") Then
            File.Create(Application.StartupPath + "\Database.set").Close()
        Else
            line = File.ReadAllLines(Application.StartupPath + "\Database.set")
            For Each l In line
                str = Split(l, ":")
                Select Case str(0)
                    Case "IP"
                        txtIP.Text = str(1)

                    Case "UserName"
                        txtUserName.Text = str(1)

                    Case "Password"
                        txtPsw.Text = str(1)
                End Select
            Next
        End If

        '讀取轉出設定-轉出路徑資料
        SetDataGridViewStyle(Me)
        dgvFilePath.Columns.Add("儲存路徑", "儲存路徑")
        dgvFilePath.Columns.Add("檔案名稱", "檔案名稱")
        If Not File.Exists(exportPathSet_path) Then
            File.Create(exportPathSet_path).Close()
        Else
            line = File.ReadAllLines(exportPathSet_path)
            For Each l In line
                str = Split(l, ",")
                dgvFilePath.Rows.Add(str(0), str(1))
            Next
        End If

        '讀取轉出設定-轉出xx前設定
        If Not File.Exists(Application.StartupPath + "\SaveTime.set") Then File.Create(Application.StartupPath + "\SaveTime.set").Close()
        line = File.ReadAllLines(Application.StartupPath + "\SaveTime.set")
        For Each l In line
            str = Split(l, ",")
            nudExport.Value = str(0)
            cmbExport.SelectedIndex = cmbExport.FindStringExact(str(1))
        Next

        '判斷是否為排程執行
        If My.Application.CommandLineArgs.Contains("--auto") Then
            AutoExport()
            End
        End If
    End Sub

    '系統管理-測試連線
    Private Sub btnTestConnect_Click(sender As Object, e As EventArgs) Handles btnTestConnect.Click
        Dim sql As New PGSQL(txtIP.Text, txtUserName.Text, txtPsw.Text)
        sql.TestConnect()
    End Sub

    '系統管理-儲存
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim content As String = $"IP:{txtIP.Text}" + vbCrLf +
                                                           $"UserName:{txtUserName.Text}" + vbCrLf +
                                                           $"Password:{txtPsw.Text}"
            File.WriteAllText(Application.StartupPath + "\Database.set", content)
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
        MsgBox("儲存成功")
    End Sub

    '系統管理-清除
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        tpSystem.Controls.OfType(Of TextBox).ToList.ForEach(Sub(txt) txt.Clear())
    End Sub

    Public Sub GetFormat()
        If Not File.Exists(formatSetPath) Then
            File.Create(formatSetPath).Close()
        Else
            Dim line = File.ReadAllLines(formatSetPath)
            For Each l In line
                Dim Str = Split(l, ":", 2)
                Select Case Str(0)
                    Case "格式"
                        txtFormat.Text = Str(1)

                    Case "結果"
                        txtResult.Text = Str(1)

                    Case Else

                End Select
            Next
        End If
    End Sub

    '轉出設定-轉出xx前紀錄
    Private Sub btnSaveTime_Click(sender As Object, e As EventArgs) Handles btnSaveTime.Click
        File.WriteAllText(Application.StartupPath + "\SaveTime.set", $"{nudExport.Value},{cmbExport.Text}")
        MsgBox("儲存成功")
    End Sub

    Private Sub btnSetPath_Click(sender As Object, e As EventArgs) Handles btnSetPath.Click, btnModify.Click
        Dim btn As Button = sender
        frmSetPath.status = btn.Text
        frmSetPath.Show()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        dgvFilePath.Rows.RemoveAt(dgvFilePath.SelectedRows(0).Index)
    End Sub

    Private Sub btnSave_exportPath_Click(sender As Object, e As EventArgs) Handles btnSave_exportPath.Click
        Try
            If dgvFilePath.RowCount = 0 Then
                File.WriteAllText(exportPathSet_path, "")
                Exit Sub
            Else
                Using sw As New StreamWriter(exportPathSet_path)
                    ' 寫入資料
                    For Each row As DataGridViewRow In dgvFilePath.Rows
                        Dim rowData As String = String.Join(",", row.Cells.Cast(Of DataGridViewCell).Select(Function(cell) cell.Value.ToString()))
                        sw.WriteLine(rowData)
                    Next
                End Using
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        '刷新
        Dim line = File.ReadAllLines(exportPathSet_path)
        dgvFilePath.Rows.Clear()

        For Each l In line
            Dim Str = Split(l, ",")
            dgvFilePath.Rows.Add(Str(0), Str(1))
        Next
        MsgBox("儲存成功")
    End Sub
End Class
