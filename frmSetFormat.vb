Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions

Public Class frmSetFormat
    Private lstLinkLabel As New List(Of LinkLabel)

    Private Sub frmSetFormat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetLinkLabelClickHandler(grpInfoFormat, AddressOf LinkLabel_LinkClicked)
        SetLinkLabelClickHandler(grpDateFormat, AddressOf LinkLabel_LinkClicked)

        '初始化ComboBox
        cmbAttendanceID.SelectedIndex = 0
        cmbCardID.SelectedIndex = 0

        '讀取設定紀錄
        Using streamReader = New StreamReader(formatSetPath)
            Dim line = streamReader.ReadLine

            While line IsNot Nothing
                Dim data = Split(line, ":", 2)
                Dim s As String()

                Select Case data(0)
                    Case "格式"
                        txtFormat.Text = data(1)

                    Case "結果"
                        txtResult.Text = data(1)

                    Case "考勤號碼"
                        s = Split(data(1), ",")
                        chkAttendanceID.Checked = s(0)
                        nudAttendanceID.Value = s(1)
                        cmbAttendanceID.SelectedIndex = cmbAttendanceID.FindStringExact(s(2))
                        txtAttendanceID.Text = s(3)

                    Case "卡片號碼"
                        s = Split(data(1), ",")
                        chkCardID.Checked = s(0)
                        nudCardID.Value = s(1)
                        cmbCardID.SelectedIndex = cmbCardID.FindStringExact(s(2))
                        txtCardID.Text = s(3)

                    Case "上班"
                        txtCheckIn.Text = data(1)

                    Case "下班"
                        txtCheckOut.Text = data(1)

                    Case "開始休息"
                        txtStartRest.Text = data(1)

                    Case "結束休息"
                        txtEndRest.Text = data(1)

                    Case "開始加班"
                        txtCheckIn_overtime.Text = data(1)

                    Case "結束加班"
                        txtCheckOut_overtime.Text = data(1)

                    Case "其他"
                        txtElse.Text = data(1)

                    Case "自訂欄位1"
                        nudCustom1.Value = data(1)

                    Case "自訂欄位2"
                        nudCustom2.Value = data(1)

                    Case Else

                End Select

                line = streamReader.ReadLine
            End While

            streamReader.Close()
        End Using
    End Sub

    'Private Sub LinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
    '    Dim linkLabel As LinkLabel = CType(sender, LinkLabel)
    '    Dim insertText As String = linkLabel.Text
    '    Dim insertPos As Integer = txtFormat.SelectionStart

    '    ' 進行插入或移除操作
    '    InsertOrRemoveText(insertText, insertPos)
    'End Sub

    'Private Sub InsertOrRemoveText(insertText As String, insertPos As Integer)
    '    ' 檢查insertText是否已出現在txtFormat中
    '    If txtFormat.Text.Contains(insertText) Then
    '        ' 移除文字
    '        txtFormat.Text = txtFormat.Text.Replace(insertText, "")
    '    Else
    '        ' 如果insertText未出現，檢查插入點是否在方括號[]之外
    '        If Not IsInsertionPointInsideBrackets(txtFormat.Text, insertPos) Then
    '            ' 在插入點添加文字
    '            txtFormat.Text = txtFormat.Text.Substring(0, insertPos) & insertText & txtFormat.Text.Substring(insertPos)
    '            ' 更新游標位置
    '            txtFormat.SelectionStart = insertPos + insertText.Length
    '        End If
    '    End If
    'End Sub


    'Private Function IsInsertionPointInsideBrackets(text As String, position As Integer) As Boolean
    '    Dim bracketDepth As Integer = 0

    '    For i As Integer = 0 To position - 1
    '        If text(i) = "[" Then
    '            bracketDepth += 1
    '        ElseIf text(i) = "]" Then
    '            If bracketDepth > 0 Then
    '                bracketDepth -= 1
    '            End If
    '        End If
    '    Next

    '    Return bracketDepth > 0
    'End Function

    Private Sub LinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Dim linkLabel As LinkLabel = CType(sender, LinkLabel)
        InsertOrRemoveText(linkLabel.Text, txtFormat.SelectionStart)
    End Sub

    Private Sub InsertOrRemoveText(insertText As String, insertPos As Integer)
        Dim formatText As New StringBuilder(txtFormat.Text)

        If formatText.ToString().Contains(insertText) Then
            formatText.Replace(insertText, "")
        ElseIf Not IsInsertionPointInsideBrackets(formatText.ToString(), insertPos) Then
            formatText.Insert(insertPos, insertText)
            insertPos += insertText.Length
        End If

        txtFormat.Text = formatText.ToString()
        txtFormat.SelectionStart = insertPos
    End Sub

    Private Function IsInsertionPointInsideBrackets(text As String, position As Integer) As Boolean
        Dim bracketDepth As Integer = 0

        For i As Integer = 0 To position - 1
            If text(i) = "["c Then
                bracketDepth += 1
            ElseIf text(i) = "]"c Then
                bracketDepth -= 1
                If bracketDepth < 0 Then Exit For
            End If
        Next

        Return bracketDepth > 0
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFormat.Clear()
    End Sub

    Private Sub txtFormat_TextChanged(sender As Object, e As EventArgs) Handles txtFormat.TextChanged
        txtResult.Text = txtFormat.Text
        Dim regex As New Regex("\[(.*?)\]") ' 定義正則表達式模式
        Dim matches As MatchCollection = regex.Matches(txtResult.Text)

        For Each match As Match In matches
            Dim tagText As String = match.Value ' 取得 match 的內容
            Dim linkLabel As LinkLabel = grpInfoFormat.Controls.OfType(Of LinkLabel)().FirstOrDefault(Function(lbl) lbl.Text = tagText)
            If linkLabel IsNot Nothing Then
                ' 使用 LinkLabel.Tag 代替文字
                txtResult.Text = txtResult.Text.Replace(match.Value, $"{linkLabel.Tag}")
            Else
                linkLabel = grpDateFormat.Controls.OfType(Of LinkLabel)().FirstOrDefault(Function(lbl) lbl.Text = tagText)
                If linkLabel IsNot Nothing Then
                    ' 使用 LinkLabel.Tag 代替文字
                    txtResult.Text = txtResult.Text.Replace(match.Value, $"{linkLabel.Tag}")
                End If
            End If
        Next
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        '防呆
        If chkAttendanceID.Checked AndAlso cmbAttendanceID.SelectedIndex = -1 Then
            MsgBox($"請選擇 考勤號碼不足{nudAttendanceID.Value}位時在 [哪裡] 補 {txtAttendanceID.Text}")
            Exit Sub

        ElseIf chkCardID.Checked AndAlso cmbCardID.SelectedIndex = -1 Then
            MsgBox($"請選擇 卡片號碼不足{nudCardID.Value}位時在 [哪裡] 補 {txtCardID.Text}")
            Exit Sub
        End If

        Using streamWriter As New StreamWriter(formatSetPath)
            With streamWriter
                .WriteLine($"格式:{txtFormat.Text}")
                .WriteLine($"結果:{txtResult.Text}")
                .WriteLine($"考勤號碼:{chkAttendanceID.Checked},{nudAttendanceID.Value},{cmbAttendanceID.Text},{txtAttendanceID.Text}")
                .WriteLine($"卡片號碼:{chkCardID.Checked},{nudCardID.Value},{cmbCardID.Text},{txtCardID.Text}")
                .WriteLine($"上班:{txtCheckIn.Text}")
                .WriteLine($"下班:{txtCheckOut.Text}")
                .WriteLine($"開始休息:{txtStartRest.Text}")
                .WriteLine($"結束休息:{txtEndRest.Text}")
                .WriteLine($"開始加班:{txtCheckIn_overtime.Text}")
                .WriteLine($"結束加班:{txtCheckOut_overtime.Text}")
                .WriteLine($"其他:{txtElse.Text}")
                .WriteLine($"自訂欄位1:{nudCustom1.Value}")
                .WriteLine($"自訂欄位2:{nudCustom2.Value}")
                .Close()
            End With
        End Using

        frmMain.GetFormat()
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class