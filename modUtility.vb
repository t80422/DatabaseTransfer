
Imports System.IO

Module modUtility
    Public exportPathSet_path As String = Application.StartupPath + "\ExportPath.set"
    Public formatSetPath As String = Application.StartupPath + "\Format.set"

    Public Sub LogMsg(str As String)
        Dim dir = Application.StartupPath + "\Log"
        Directory.CreateDirectory(dir)
        Dim filePath = dir + $"\{Now:yyyyMMdd}.txt"
        Dim msg = $"【{Now:yyyy-MM-dd HH:mm:ss}】{str + vbCrLf}"
        File.AppendAllText(filePath, msg)
    End Sub

    ''' <summary>
    ''' LinkLabel動態設定點擊事件
    ''' </summary>
    ''' <param name="ctrl">父容器</param>
    Public Sub SetLinkLabelClickHandler(ctrl As Control, func As LinkLabelLinkClickedEventHandler)
        ctrl.Controls.OfType(Of LinkLabel)().ToList().ForEach(
            Sub(linkLabel)
                ' 設定每個 LinkLabel 的點擊事件處理程式
                AddHandler linkLabel.LinkClicked, func
            End Sub
            )
    End Sub

    ''' <summary>
    ''' 設定DataGridView的樣式屬性
    ''' </summary>
    ''' <param name="ctrl"></param>
    Public Sub SetDataGridViewStyle(ctrl As Control)
        For Each dgv In GetControlInParent(Of DataGridView)(ctrl)
            With dgv
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .ColumnHeadersDefaultCellStyle.Font = New Font("標楷體", 12, FontStyle.Bold)
                .DefaultCellStyle.Font = New Font("標楷體", 12, FontStyle.Bold)
                .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(224, 224, 224)
                .EnableHeadersVisualStyles = False
                .ColumnHeadersDefaultCellStyle.BackColor = Color.MediumTurquoise
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
            End With
        Next
    End Sub

    ''' <summary>
    ''' 取得指定控制項內所有的目標控制項
    ''' </summary>
    ''' <typeparam name="T">目標控制項</typeparam>
    ''' <param name="parent">指定控制項</param>
    ''' <returns></returns>
    Public Function GetControlInParent(Of T As Control)(parent As Control) As List(Of T)
        Dim lst As New List(Of T)
        If parent.Controls.Count > 0 Then
            For Each ctrl In parent.Controls
                If TypeOf ctrl Is T Then lst.Add(ctrl)
                lst.AddRange(GetControlInParent(Of T)(ctrl))
            Next
        End If
        Return lst
    End Function
End Module
