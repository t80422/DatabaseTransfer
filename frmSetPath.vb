Imports System.Text
Imports System.Text.RegularExpressions

Public Class frmSetPath
    Public status As String

    Private Sub frmSetPath_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetLinkLabelClickHandler(grpDateFormat, AddressOf LinkLabel_LinkClicked)
        If status = "修改" Then
            Dim row As DataGridViewRow = frmMain.dgvFilePath.SelectedRows(0)
            txtSavePath.Text = row.Cells("儲存路徑").Value
            txtFileName.Text = row.Cells("檔案名稱").Value
        End If
    End Sub

    Private Sub LinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Dim linkLabel As LinkLabel = sender
        Dim regex As New Regex("\[(.*?)\]")
        Dim matches As MatchCollection = regex.Matches(txtFileName.Text)

        If matches.Count = 0 Then
            ' 若目前沒有任何文字，直接設定為 LinkLabel 的 Text
            txtFileName.Text = linkLabel.Text
            txtFileName.SelectionStart = linkLabel.Text.Length
        Else
            ' 使用 HashSet 儲存已經存在的文字，加快查找效率
            Dim existingTexts As New HashSet(Of String)(matches.Cast(Of Match).Select(Function(m) m.Value))

            If existingTexts.Contains(linkLabel.Text) Then
                ' 若已經存在，則從文字中移除該文字
                txtFileName.Text = txtFileName.Text.Replace(linkLabel.Text, "")
                txtFileName.SelectionStart = txtFileName.Text.Length
            Else
                ' 否則，取得目前插入點位置，並將 LinkLabel 的 Text 插入到該位置
                Dim insertPoint As Integer = txtFileName.SelectionStart
                Dim result As New StringBuilder(txtFileName.Text)

                ' 插入文字
                result.Insert(insertPoint, linkLabel.Text)

                ' 更新文字和插入點位置
                txtFileName.Text = result.ToString()
                txtFileName.SelectionStart = insertPoint + linkLabel.Text.Length
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If status = "新增" Then
            frmMain.dgvFilePath.Rows.Add(txtSavePath.Text, txtFileName.Text)
        ElseIf status = "修改" Then
            Dim row As DataGridViewRow = frmMain.dgvFilePath.SelectedRows(0)
            row.Cells("儲存路徑").Value = txtSavePath.Text
            row.Cells("檔案名稱").Value = txtFileName.Text
        End If
        Close()
    End Sub
End Class