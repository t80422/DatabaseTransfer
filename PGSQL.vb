Imports System.Reflection
Imports System.Text.RegularExpressions
Imports Npgsql
'MySQL相關
Public Class PGSQL
    Friend _conn As NpgsqlConnection
    Private title = "MySQL"

    Sub New(ip As String, userID As String, pwd As String)
        '設定連線
        Dim myConnectionString As String = $"Server={ip};Port=5432;Database=cms;username={userID};password={pwd}"
        _conn = New NpgsqlConnection(myConnectionString)
    End Sub

    Public Sub TestConnect()
        '測試連線
        Try
            _conn.Open()
        Catch ex As Exception
            MsgBox("未開啟資料庫連線", MsgBoxStyle.Exclamation, "資料庫")
            End
        End Try

        _conn.Close()
    End Sub

    ''' <summary>
    ''' 查詢資料表
    ''' </summary>
    ''' <returns></returns>
    Public Function SelectTable(query As String, parameters As Dictionary(Of String, Object)) As DataTable
        Dim dt As New DataTable()
        Try
            _conn.Open()
            Using cmd As New NpgsqlCommand(query, _conn)
                parameters.ToList.ForEach(Function(p) cmd.Parameters.AddWithValue(p.Key, p.Value))

                Dim adapter As New NpgsqlDataAdapter(cmd)

                adapter.Fill(dt)
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, title)
        End Try
        _conn.Close()
        Return dt
    End Function

    ''' <summary>
    ''' 新增資料至資料表
    ''' </summary>
    ''' <param name="sTable"></param>
    ''' <param name="dicData">key:ColumnName</param>
    ''' <returns></returns>
    Public Function InserTable(sTable As String, dicData As Dictionary(Of String, String)) As Boolean
        Dim result As Boolean
        Dim cmd As New NpgsqlCommand($"INSERT INTO {sTable} ({String.Join(",", dicData.Keys)}) VALUES ({String.Join(",", dicData.Keys.Select(Function(key) $"@{key}"))})", _conn)
        Try
            _conn.Open()
            For Each kvp In dicData
                cmd.Parameters.AddWithValue($"@{kvp.Key}", Trim(kvp.Value))
            Next
            If cmd.ExecuteNonQuery() > 0 Then result = True
        Catch ex As Exception
            MsgBox(ex.Message, Title:=title)
        End Try
        _conn.Close()
        Return result
    End Function

    ''' <summary>
    ''' 更新表格
    ''' </summary>
    ''' <param name="table">表格名稱</param>
    ''' <param name="dicFields">更新對象集合</param>
    ''' <param name="condition">Where</param>
    Public Function UpdateTable(table As String, dicFields As Dictionary(Of String, String), condition As String) As Boolean
        Dim result As Boolean = False

        Try
            _conn.Open()
            Dim sql = $"UPDATE {table} SET "
            Dim lst As New List(Of String)

            For Each kvp In dicFields
                lst.Add($"{kvp.Key} = @{kvp.Key}")
            Next

            sql += String.Join(",", lst) + $" WHERE {condition}"
            Dim cmd As New NpgsqlCommand(sql, _conn)

            For Each kvp In dicFields
                cmd.Parameters.AddWithValue($"@{kvp.Key}", Trim(kvp.Value))
            Next

            If cmd.ExecuteNonQuery() > 0 Then
                result = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, Title:=MethodBase.GetCurrentMethod.Name)
        Finally
            _conn.Close()
        End Try

        Return result
    End Function

    ''' <summary>
    ''' MySQL Delete
    ''' </summary>
    ''' <param name="sTable">資料表</param>
    ''' <param name="sWhere">條件</param>
    ''' <returns></returns>
    Public Function DeleteData(sTable As String, sWhere As String) As Boolean
        Dim rowsAffected As Integer
        Dim cmd As New NpgsqlCommand($"DELETE FROM {sTable} WHERE {sWhere}", _conn)
        Try
            _conn.Open()
            rowsAffected = cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, Title:="警告")
        End Try
        _conn.Close()
        Return rowsAffected > 0
    End Function

    ''' <summary>
    ''' 取得SQL語句中的表格名稱
    ''' </summary>
    ''' <param name="query"></param>
    ''' <returns></returns>
    Public Function GetTableNamesFromQuery(query As String) As List(Of String)
        Dim tableNames As New List(Of String)

        ' 使用正則表達式搜尋 FROM 和 JOIN 子句中的表名
        Dim regex As New Regex("(?:FROM|JOIN)\s+(\w+)", RegexOptions.IgnoreCase)
        Dim matches As MatchCollection = regex.Matches(query)

        ' 迭代匹配的結果，並將表名加入列表
        For Each match As Match In matches
            Dim tableName As String = match.Groups(1).Value
            tableNames.Add(tableName)
        Next

        Return tableNames
    End Function
End Class
