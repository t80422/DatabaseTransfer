Imports System.IO
Imports System.Text.RegularExpressions

Public Class frmSetFormat
    Private lstLinkLabel As New List(Of LinkLabel)

    Private Sub frmSetFormat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetLinkLabelClickHandler(grpInfoFormat, AddressOf LinkLabel_LinkClicked)
        SetLinkLabelClickHandler(grpDateFormat, AddressOf LinkLabel_LinkClicked)

        '初始化ComboBox
        cmbAttendanceID.SelectedIndex = 0
        cmbCardID.SelectedIndex = 0
        cmbID.SelectedIndex = 0

        '讀取設定紀錄
        Dim streamReader = New StreamReader(formatSetPath)
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

                Case "編號"
                    s = Split(data(1), ",")
                    chkID.Checked = s(0)
                    nudID.Value = s(1)
                    cmbID.SelectedIndex = cmbID.FindStringExact(s(2))
                    txtID.Text = s(3)

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

                Case Else

            End Select
            line = streamReader.ReadLine
        End While
        streamReader.Close()

    End Sub

    Private Sub LinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Dim linkLabel As LinkLabel = sender
        Dim formatParts As String() = txtFormat.Text.Split(","c)
        If formatParts.Contains(linkLabel.Text) Then
            txtFormat.Text = String.Join(",", formatParts.Where(Function(part) part <> linkLabel.Text))
        Else
            txtFormat.Text = If(String.IsNullOrEmpty(txtFormat.Text), linkLabel.Text, $"{txtFormat.Text},{linkLabel.Text}")
        End If
    End Sub

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

        ElseIf chkID.Checked AndAlso cmbID.SelectedIndex = -1 Then
            MsgBox($"請選擇 編號不足{nudID.Value}位時在 [哪裡] 補 {txtID.Text}")
            Exit Sub
        End If

        Dim streamWriter As New StreamWriter(formatSetPath)
        With streamWriter
            .WriteLine($"格式:{txtFormat.Text}")
            .WriteLine($"結果:{txtResult.Text}")
            .WriteLine($"考勤號碼:{chkAttendanceID.Checked},{nudAttendanceID.Value},{cmbAttendanceID.Text},{txtAttendanceID.Text}")
            .WriteLine($"卡片號碼:{chkCardID.Checked},{nudCardID.Value},{cmbCardID.Text},{txtCardID.Text}")
            .WriteLine($"編號:{chkID.Checked},{nudID.Value},{cmbID.Text},{txtID.Text}")
            .WriteLine($"上班:{txtCheckIn.Text}")
            .WriteLine($"下班:{txtCheckOut.Text}")
            .WriteLine($"開始休息:{txtStartRest.Text}")
            .WriteLine($"結束休息:{txtEndRest.Text}")
            .WriteLine($"開始加班:{txtCheckIn_overtime.Text}")
            .WriteLine($"結束加班:{txtCheckOut_overtime.Text}")
            .WriteLine($"其他:{txtElse.Text}")
            .Close()
        End With
        frmMain.GetFormat()
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class