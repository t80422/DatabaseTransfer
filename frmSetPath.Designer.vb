<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetPath
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetPath))
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.txtSavePath = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.grpDateFormat = New System.Windows.Forms.GroupBox()
        Me.llbSecond = New System.Windows.Forms.LinkLabel()
        Me.llbMinute = New System.Windows.Forms.LinkLabel()
        Me.llbHour = New System.Windows.Forms.LinkLabel()
        Me.llbDay = New System.Windows.Forms.LinkLabel()
        Me.llbMonth = New System.Windows.Forms.LinkLabel()
        Me.llbROCYear = New System.Windows.Forms.LinkLabel()
        Me.llbADYear = New System.Windows.Forms.LinkLabel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.grpDateFormat.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(696, 68)
        Me.Label17.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(28, 16)
        Me.Label17.TabIndex = 52
        Me.Label17.Text = ".txt"
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(104, 65)
        Me.txtFileName.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(580, 27)
        Me.txtFileName.TabIndex = 50
        '
        'txtSavePath
        '
        Me.txtSavePath.Location = New System.Drawing.Point(104, 20)
        Me.txtSavePath.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtSavePath.Name = "txtSavePath"
        Me.txtSavePath.Size = New System.Drawing.Size(580, 27)
        Me.txtSavePath.TabIndex = 47
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(20, 68)
        Me.Label14.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 16)
        Me.Label14.TabIndex = 49
        Me.Label14.Text = "檔案名稱"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(20, 23)
        Me.Label15.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 16)
        Me.Label15.TabIndex = 48
        Me.Label15.Text = "儲存路徑"
        '
        'grpDateFormat
        '
        Me.grpDateFormat.BackColor = System.Drawing.Color.Transparent
        Me.grpDateFormat.Controls.Add(Me.llbSecond)
        Me.grpDateFormat.Controls.Add(Me.llbMinute)
        Me.grpDateFormat.Controls.Add(Me.llbHour)
        Me.grpDateFormat.Controls.Add(Me.llbDay)
        Me.grpDateFormat.Controls.Add(Me.llbMonth)
        Me.grpDateFormat.Controls.Add(Me.llbROCYear)
        Me.grpDateFormat.Controls.Add(Me.llbADYear)
        Me.grpDateFormat.Location = New System.Drawing.Point(20, 109)
        Me.grpDateFormat.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpDateFormat.Name = "grpDateFormat"
        Me.grpDateFormat.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpDateFormat.Size = New System.Drawing.Size(418, 68)
        Me.grpDateFormat.TabIndex = 53
        Me.grpDateFormat.TabStop = False
        Me.grpDateFormat.Text = "時間格式"
        '
        'llbSecond
        '
        Me.llbSecond.AutoSize = True
        Me.llbSecond.Location = New System.Drawing.Point(375, 31)
        Me.llbSecond.Name = "llbSecond"
        Me.llbSecond.Size = New System.Drawing.Size(34, 16)
        Me.llbSecond.TabIndex = 12
        Me.llbSecond.TabStop = True
        Me.llbSecond.Tag = "05"
        Me.llbSecond.Text = "[秒]"
        '
        'llbMinute
        '
        Me.llbMinute.AutoSize = True
        Me.llbMinute.Location = New System.Drawing.Point(326, 31)
        Me.llbMinute.Name = "llbMinute"
        Me.llbMinute.Size = New System.Drawing.Size(34, 16)
        Me.llbMinute.TabIndex = 11
        Me.llbMinute.TabStop = True
        Me.llbMinute.Tag = "04"
        Me.llbMinute.Text = "[分]"
        '
        'llbHour
        '
        Me.llbHour.AutoSize = True
        Me.llbHour.Location = New System.Drawing.Point(276, 31)
        Me.llbHour.Name = "llbHour"
        Me.llbHour.Size = New System.Drawing.Size(34, 16)
        Me.llbHour.TabIndex = 10
        Me.llbHour.TabStop = True
        Me.llbHour.Tag = "03"
        Me.llbHour.Text = "[時]"
        '
        'llbDay
        '
        Me.llbDay.AutoSize = True
        Me.llbDay.Location = New System.Drawing.Point(226, 31)
        Me.llbDay.Name = "llbDay"
        Me.llbDay.Size = New System.Drawing.Size(34, 16)
        Me.llbDay.TabIndex = 9
        Me.llbDay.TabStop = True
        Me.llbDay.Tag = "02"
        Me.llbDay.Text = "[日]"
        '
        'llbMonth
        '
        Me.llbMonth.AutoSize = True
        Me.llbMonth.Location = New System.Drawing.Point(177, 31)
        Me.llbMonth.Name = "llbMonth"
        Me.llbMonth.Size = New System.Drawing.Size(34, 16)
        Me.llbMonth.TabIndex = 8
        Me.llbMonth.TabStop = True
        Me.llbMonth.Tag = "01"
        Me.llbMonth.Text = "[月]"
        '
        'llbROCYear
        '
        Me.llbROCYear.AutoSize = True
        Me.llbROCYear.Location = New System.Drawing.Point(92, 31)
        Me.llbROCYear.Name = "llbROCYear"
        Me.llbROCYear.Size = New System.Drawing.Size(66, 16)
        Me.llbROCYear.TabIndex = 7
        Me.llbROCYear.TabStop = True
        Me.llbROCYear.Tag = "112"
        Me.llbROCYear.Text = "[民國年]"
        '
        'llbADYear
        '
        Me.llbADYear.AutoSize = True
        Me.llbADYear.Location = New System.Drawing.Point(6, 31)
        Me.llbADYear.Name = "llbADYear"
        Me.llbADYear.Size = New System.Drawing.Size(66, 16)
        Me.llbADYear.TabIndex = 6
        Me.llbADYear.TabStop = True
        Me.llbADYear.Tag = "2023"
        Me.llbADYear.Text = "[西元年]"
        '
        'btnSave
        '
        Me.btnSave.AutoSize = True
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnSave.Location = New System.Drawing.Point(659, 142)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(65, 35)
        Me.btnSave.TabIndex = 54
        Me.btnSave.Text = "儲存"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'frmSetPath
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 195)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.grpDateFormat)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.txtSavePath)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmSetPath"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "路徑設定"
        Me.grpDateFormat.ResumeLayout(False)
        Me.grpDateFormat.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label17 As Label
    Friend WithEvents txtFileName As TextBox
    Friend WithEvents txtSavePath As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents grpDateFormat As GroupBox
    Friend WithEvents llbSecond As LinkLabel
    Friend WithEvents llbMinute As LinkLabel
    Friend WithEvents llbHour As LinkLabel
    Friend WithEvents llbDay As LinkLabel
    Friend WithEvents llbMonth As LinkLabel
    Friend WithEvents llbROCYear As LinkLabel
    Friend WithEvents llbADYear As LinkLabel
    Friend WithEvents btnSave As Button
End Class
