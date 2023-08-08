<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetFormat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetFormat))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFormat = New System.Windows.Forms.TextBox()
        Me.grpInfoFormat = New System.Windows.Forms.GroupBox()
        Me.llbName = New System.Windows.Forms.LinkLabel()
        Me.llbDeviceID = New System.Windows.Forms.LinkLabel()
        Me.llbAttendanceState = New System.Windows.Forms.LinkLabel()
        Me.llbCardID = New System.Windows.Forms.LinkLabel()
        Me.llbID = New System.Windows.Forms.LinkLabel()
        Me.llbAttendanceNo = New System.Windows.Forms.LinkLabel()
        Me.nudAttendanceID = New System.Windows.Forms.NumericUpDown()
        Me.chkAttendanceID = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.grpDateFormat = New System.Windows.Forms.GroupBox()
        Me.llbSecond = New System.Windows.Forms.LinkLabel()
        Me.llbMinute = New System.Windows.Forms.LinkLabel()
        Me.llbHour = New System.Windows.Forms.LinkLabel()
        Me.llbDay = New System.Windows.Forms.LinkLabel()
        Me.llbMonth = New System.Windows.Forms.LinkLabel()
        Me.llbROCYear = New System.Windows.Forms.LinkLabel()
        Me.llbADYear = New System.Windows.Forms.LinkLabel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtCardID = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtAttendanceID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbID = New System.Windows.Forms.ComboBox()
        Me.cmbCardID = New System.Windows.Forms.ComboBox()
        Me.cmbAttendanceID = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nudID = New System.Windows.Forms.NumericUpDown()
        Me.nudCardID = New System.Windows.Forms.NumericUpDown()
        Me.chkID = New System.Windows.Forms.CheckBox()
        Me.chkCardID = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtCheckOut_overtime = New System.Windows.Forms.TextBox()
        Me.txtCheckIn_overtime = New System.Windows.Forms.TextBox()
        Me.txtEndRest = New System.Windows.Forms.TextBox()
        Me.txtStartRest = New System.Windows.Forms.TextBox()
        Me.txtElse = New System.Windows.Forms.TextBox()
        Me.txtCheckOut = New System.Windows.Forms.TextBox()
        Me.txtCheckIn = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.grpInfoFormat.SuspendLayout()
        CType(Me.nudAttendanceID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDateFormat.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.nudID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCardID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "格式"
        '
        'txtFormat
        '
        Me.txtFormat.Location = New System.Drawing.Point(66, 20)
        Me.txtFormat.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtFormat.Name = "txtFormat"
        Me.txtFormat.Size = New System.Drawing.Size(782, 27)
        Me.txtFormat.TabIndex = 1
        '
        'grpInfoFormat
        '
        Me.grpInfoFormat.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpInfoFormat.Controls.Add(Me.llbName)
        Me.grpInfoFormat.Controls.Add(Me.llbDeviceID)
        Me.grpInfoFormat.Controls.Add(Me.llbAttendanceState)
        Me.grpInfoFormat.Controls.Add(Me.llbCardID)
        Me.grpInfoFormat.Controls.Add(Me.llbID)
        Me.grpInfoFormat.Controls.Add(Me.llbAttendanceNo)
        Me.grpInfoFormat.Location = New System.Drawing.Point(23, 102)
        Me.grpInfoFormat.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpInfoFormat.Name = "grpInfoFormat"
        Me.grpInfoFormat.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpInfoFormat.Size = New System.Drawing.Size(825, 53)
        Me.grpInfoFormat.TabIndex = 2
        Me.grpInfoFormat.TabStop = False
        Me.grpInfoFormat.Text = "資料格式"
        '
        'llbName
        '
        Me.llbName.AutoSize = True
        Me.llbName.Location = New System.Drawing.Point(762, 23)
        Me.llbName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.llbName.Name = "llbName"
        Me.llbName.Size = New System.Drawing.Size(56, 16)
        Me.llbName.TabIndex = 5
        Me.llbName.TabStop = True
        Me.llbName.Tag = "AAA"
        Me.llbName.Text = "[姓名]"
        '
        'llbDeviceID
        '
        Me.llbDeviceID.AutoSize = True
        Me.llbDeviceID.Location = New System.Drawing.Point(604, 23)
        Me.llbDeviceID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.llbDeviceID.Name = "llbDeviceID"
        Me.llbDeviceID.Size = New System.Drawing.Size(88, 16)
        Me.llbDeviceID.TabIndex = 4
        Me.llbDeviceID.TabStop = True
        Me.llbDeviceID.Tag = "456"
        Me.llbDeviceID.Text = "[設備編號]"
        '
        'llbAttendanceState
        '
        Me.llbAttendanceState.AutoSize = True
        Me.llbAttendanceState.Location = New System.Drawing.Point(446, 23)
        Me.llbAttendanceState.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.llbAttendanceState.Name = "llbAttendanceState"
        Me.llbAttendanceState.Size = New System.Drawing.Size(88, 16)
        Me.llbAttendanceState.TabIndex = 3
        Me.llbAttendanceState.TabStop = True
        Me.llbAttendanceState.Tag = "A"
        Me.llbAttendanceState.Text = "[考勤狀態]"
        '
        'llbCardID
        '
        Me.llbCardID.AutoSize = True
        Me.llbCardID.Location = New System.Drawing.Point(288, 23)
        Me.llbCardID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.llbCardID.Name = "llbCardID"
        Me.llbCardID.Size = New System.Drawing.Size(88, 16)
        Me.llbCardID.TabIndex = 2
        Me.llbCardID.TabStop = True
        Me.llbCardID.Tag = "0000123456"
        Me.llbCardID.Text = "[卡片號碼]"
        '
        'llbID
        '
        Me.llbID.AutoSize = True
        Me.llbID.Location = New System.Drawing.Point(162, 23)
        Me.llbID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.llbID.Name = "llbID"
        Me.llbID.Size = New System.Drawing.Size(56, 16)
        Me.llbID.TabIndex = 1
        Me.llbID.TabStop = True
        Me.llbID.Tag = "123"
        Me.llbID.Text = "[編號]"
        '
        'llbAttendanceNo
        '
        Me.llbAttendanceNo.AutoSize = True
        Me.llbAttendanceNo.Location = New System.Drawing.Point(4, 23)
        Me.llbAttendanceNo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.llbAttendanceNo.Name = "llbAttendanceNo"
        Me.llbAttendanceNo.Size = New System.Drawing.Size(88, 16)
        Me.llbAttendanceNo.TabIndex = 0
        Me.llbAttendanceNo.TabStop = True
        Me.llbAttendanceNo.Tag = "000000A123"
        Me.llbAttendanceNo.Text = "[考勤號碼]"
        '
        'nudAttendanceID
        '
        Me.nudAttendanceID.Location = New System.Drawing.Point(139, 26)
        Me.nudAttendanceID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.nudAttendanceID.Name = "nudAttendanceID"
        Me.nudAttendanceID.Size = New System.Drawing.Size(87, 27)
        Me.nudAttendanceID.TabIndex = 3
        '
        'chkAttendanceID
        '
        Me.chkAttendanceID.AutoSize = True
        Me.chkAttendanceID.Location = New System.Drawing.Point(4, 28)
        Me.chkAttendanceID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.chkAttendanceID.Name = "chkAttendanceID"
        Me.chkAttendanceID.Size = New System.Drawing.Size(123, 20)
        Me.chkAttendanceID.TabIndex = 4
        Me.chkAttendanceID.Text = "考勤號碼不足"
        Me.chkAttendanceID.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 67)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "結果"
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(66, 61)
        Me.txtResult.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.Size = New System.Drawing.Size(723, 27)
        Me.txtResult.TabIndex = 6
        '
        'grpDateFormat
        '
        Me.grpDateFormat.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpDateFormat.Controls.Add(Me.LinkLabel1)
        Me.grpDateFormat.Controls.Add(Me.llbSecond)
        Me.grpDateFormat.Controls.Add(Me.llbMinute)
        Me.grpDateFormat.Controls.Add(Me.llbHour)
        Me.grpDateFormat.Controls.Add(Me.llbDay)
        Me.grpDateFormat.Controls.Add(Me.llbMonth)
        Me.grpDateFormat.Controls.Add(Me.llbROCYear)
        Me.grpDateFormat.Controls.Add(Me.llbADYear)
        Me.grpDateFormat.Location = New System.Drawing.Point(23, 169)
        Me.grpDateFormat.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpDateFormat.Name = "grpDateFormat"
        Me.grpDateFormat.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpDateFormat.Size = New System.Drawing.Size(825, 53)
        Me.grpDateFormat.TabIndex = 3
        Me.grpDateFormat.TabStop = False
        Me.grpDateFormat.Text = "時間格式"
        '
        'llbSecond
        '
        Me.llbSecond.AutoSize = True
        Me.llbSecond.Location = New System.Drawing.Point(776, 23)
        Me.llbSecond.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.llbSecond.Name = "llbSecond"
        Me.llbSecond.Size = New System.Drawing.Size(40, 16)
        Me.llbSecond.TabIndex = 12
        Me.llbSecond.TabStop = True
        Me.llbSecond.Tag = "05"
        Me.llbSecond.Text = "[秒]"
        '
        'llbMinute
        '
        Me.llbMinute.AutoSize = True
        Me.llbMinute.Location = New System.Drawing.Point(684, 23)
        Me.llbMinute.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.llbMinute.Name = "llbMinute"
        Me.llbMinute.Size = New System.Drawing.Size(40, 16)
        Me.llbMinute.TabIndex = 11
        Me.llbMinute.TabStop = True
        Me.llbMinute.Tag = "04"
        Me.llbMinute.Text = "[分]"
        '
        'llbHour
        '
        Me.llbHour.AutoSize = True
        Me.llbHour.Location = New System.Drawing.Point(592, 23)
        Me.llbHour.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.llbHour.Name = "llbHour"
        Me.llbHour.Size = New System.Drawing.Size(40, 16)
        Me.llbHour.TabIndex = 10
        Me.llbHour.TabStop = True
        Me.llbHour.Tag = "03"
        Me.llbHour.Text = "[時]"
        '
        'llbDay
        '
        Me.llbDay.AutoSize = True
        Me.llbDay.Location = New System.Drawing.Point(500, 23)
        Me.llbDay.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.llbDay.Name = "llbDay"
        Me.llbDay.Size = New System.Drawing.Size(40, 16)
        Me.llbDay.TabIndex = 9
        Me.llbDay.TabStop = True
        Me.llbDay.Tag = "02"
        Me.llbDay.Text = "[日]"
        '
        'llbMonth
        '
        Me.llbMonth.AutoSize = True
        Me.llbMonth.Location = New System.Drawing.Point(408, 23)
        Me.llbMonth.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.llbMonth.Name = "llbMonth"
        Me.llbMonth.Size = New System.Drawing.Size(40, 16)
        Me.llbMonth.TabIndex = 8
        Me.llbMonth.TabStop = True
        Me.llbMonth.Tag = "01"
        Me.llbMonth.Text = "[月]"
        '
        'llbROCYear
        '
        Me.llbROCYear.AutoSize = True
        Me.llbROCYear.Location = New System.Drawing.Point(284, 23)
        Me.llbROCYear.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.llbROCYear.Name = "llbROCYear"
        Me.llbROCYear.Size = New System.Drawing.Size(72, 16)
        Me.llbROCYear.TabIndex = 7
        Me.llbROCYear.TabStop = True
        Me.llbROCYear.Tag = "112"
        Me.llbROCYear.Text = "[民國年]"
        '
        'llbADYear
        '
        Me.llbADYear.AutoSize = True
        Me.llbADYear.Location = New System.Drawing.Point(4, 23)
        Me.llbADYear.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.llbADYear.Name = "llbADYear"
        Me.llbADYear.Size = New System.Drawing.Size(72, 16)
        Me.llbADYear.TabIndex = 6
        Me.llbADYear.TabStop = True
        Me.llbADYear.Tag = "2023"
        Me.llbADYear.Text = "[西元年]"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.txtCardID)
        Me.GroupBox3.Controls.Add(Me.txtID)
        Me.GroupBox3.Controls.Add(Me.txtAttendanceID)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.cmbID)
        Me.GroupBox3.Controls.Add(Me.cmbCardID)
        Me.GroupBox3.Controls.Add(Me.cmbAttendanceID)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.nudID)
        Me.GroupBox3.Controls.Add(Me.nudCardID)
        Me.GroupBox3.Controls.Add(Me.chkID)
        Me.GroupBox3.Controls.Add(Me.chkCardID)
        Me.GroupBox3.Controls.Add(Me.chkAttendanceID)
        Me.GroupBox3.Controls.Add(Me.nudAttendanceID)
        Me.GroupBox3.Location = New System.Drawing.Point(23, 236)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox3.Size = New System.Drawing.Size(545, 141)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "補齊資料"
        '
        'txtCardID
        '
        Me.txtCardID.Location = New System.Drawing.Point(463, 66)
        Me.txtCardID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtCardID.Name = "txtCardID"
        Me.txtCardID.Size = New System.Drawing.Size(70, 27)
        Me.txtCardID.TabIndex = 18
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(463, 107)
        Me.txtID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(70, 27)
        Me.txtID.TabIndex = 17
        '
        'txtAttendanceID
        '
        Me.txtAttendanceID.Location = New System.Drawing.Point(463, 25)
        Me.txtAttendanceID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtAttendanceID.Name = "txtAttendanceID"
        Me.txtAttendanceID.Size = New System.Drawing.Size(70, 27)
        Me.txtAttendanceID.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(425, 69)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 16)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "補"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(425, 110)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 16)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "補"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(425, 29)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "補"
        '
        'cmbID
        '
        Me.cmbID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID.FormattingEnabled = True
        Me.cmbID.Items.AddRange(New Object() {"前面", "後面"})
        Me.cmbID.Location = New System.Drawing.Point(310, 107)
        Me.cmbID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmbID.Name = "cmbID"
        Me.cmbID.Size = New System.Drawing.Size(101, 24)
        Me.cmbID.TabIndex = 12
        '
        'cmbCardID
        '
        Me.cmbCardID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCardID.FormattingEnabled = True
        Me.cmbCardID.Items.AddRange(New Object() {"前面", "後面"})
        Me.cmbCardID.Location = New System.Drawing.Point(310, 66)
        Me.cmbCardID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmbCardID.Name = "cmbCardID"
        Me.cmbCardID.Size = New System.Drawing.Size(101, 24)
        Me.cmbCardID.TabIndex = 11
        '
        'cmbAttendanceID
        '
        Me.cmbAttendanceID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAttendanceID.FormattingEnabled = True
        Me.cmbAttendanceID.Items.AddRange(New Object() {"前面", "後面"})
        Me.cmbAttendanceID.Location = New System.Drawing.Point(310, 25)
        Me.cmbAttendanceID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmbAttendanceID.Name = "cmbAttendanceID"
        Me.cmbAttendanceID.Size = New System.Drawing.Size(101, 24)
        Me.cmbAttendanceID.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(240, 110)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "位，在"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(240, 69)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "位，在"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(240, 29)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "位，在"
        '
        'nudID
        '
        Me.nudID.Location = New System.Drawing.Point(139, 108)
        Me.nudID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.nudID.Name = "nudID"
        Me.nudID.Size = New System.Drawing.Size(87, 27)
        Me.nudID.TabIndex = 8
        '
        'nudCardID
        '
        Me.nudCardID.Location = New System.Drawing.Point(139, 67)
        Me.nudCardID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.nudCardID.Name = "nudCardID"
        Me.nudCardID.Size = New System.Drawing.Size(87, 27)
        Me.nudCardID.TabIndex = 7
        '
        'chkID
        '
        Me.chkID.AutoSize = True
        Me.chkID.Location = New System.Drawing.Point(4, 109)
        Me.chkID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.chkID.Name = "chkID"
        Me.chkID.Size = New System.Drawing.Size(91, 20)
        Me.chkID.TabIndex = 6
        Me.chkID.Text = "編號不足"
        Me.chkID.UseVisualStyleBackColor = True
        '
        'chkCardID
        '
        Me.chkCardID.AutoSize = True
        Me.chkCardID.Location = New System.Drawing.Point(4, 68)
        Me.chkCardID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.chkCardID.Name = "chkCardID"
        Me.chkCardID.Size = New System.Drawing.Size(123, 20)
        Me.chkCardID.TabIndex = 5
        Me.chkCardID.Text = "卡片號碼不足"
        Me.chkCardID.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.txtCheckOut_overtime)
        Me.GroupBox4.Controls.Add(Me.txtCheckIn_overtime)
        Me.GroupBox4.Controls.Add(Me.txtEndRest)
        Me.GroupBox4.Controls.Add(Me.txtStartRest)
        Me.GroupBox4.Controls.Add(Me.txtElse)
        Me.GroupBox4.Controls.Add(Me.txtCheckOut)
        Me.GroupBox4.Controls.Add(Me.txtCheckIn)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Location = New System.Drawing.Point(23, 399)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox4.Size = New System.Drawing.Size(462, 152)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "考勤狀態設定"
        '
        'txtCheckOut_overtime
        '
        Me.txtCheckOut_overtime.Location = New System.Drawing.Point(376, 67)
        Me.txtCheckOut_overtime.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtCheckOut_overtime.Name = "txtCheckOut_overtime"
        Me.txtCheckOut_overtime.Size = New System.Drawing.Size(70, 27)
        Me.txtCheckOut_overtime.TabIndex = 25
        '
        'txtCheckIn_overtime
        '
        Me.txtCheckIn_overtime.Location = New System.Drawing.Point(376, 26)
        Me.txtCheckIn_overtime.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtCheckIn_overtime.Name = "txtCheckIn_overtime"
        Me.txtCheckIn_overtime.Size = New System.Drawing.Size(70, 27)
        Me.txtCheckIn_overtime.TabIndex = 24
        '
        'txtEndRest
        '
        Me.txtEndRest.Location = New System.Drawing.Point(214, 67)
        Me.txtEndRest.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtEndRest.Name = "txtEndRest"
        Me.txtEndRest.Size = New System.Drawing.Size(70, 27)
        Me.txtEndRest.TabIndex = 23
        '
        'txtStartRest
        '
        Me.txtStartRest.Location = New System.Drawing.Point(214, 26)
        Me.txtStartRest.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtStartRest.Name = "txtStartRest"
        Me.txtStartRest.Size = New System.Drawing.Size(70, 27)
        Me.txtStartRest.TabIndex = 22
        '
        'txtElse
        '
        Me.txtElse.Location = New System.Drawing.Point(52, 108)
        Me.txtElse.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtElse.Name = "txtElse"
        Me.txtElse.Size = New System.Drawing.Size(70, 27)
        Me.txtElse.TabIndex = 21
        '
        'txtCheckOut
        '
        Me.txtCheckOut.Location = New System.Drawing.Point(52, 67)
        Me.txtCheckOut.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtCheckOut.Name = "txtCheckOut"
        Me.txtCheckOut.Size = New System.Drawing.Size(70, 27)
        Me.txtCheckOut.TabIndex = 20
        '
        'txtCheckIn
        '
        Me.txtCheckIn.Location = New System.Drawing.Point(52, 26)
        Me.txtCheckIn.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtCheckIn.Name = "txtCheckIn"
        Me.txtCheckIn.Size = New System.Drawing.Size(70, 27)
        Me.txtCheckIn.TabIndex = 19
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(298, 70)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 16)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "結束加班"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(298, 31)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 16)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "開始加班"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(136, 70)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 16)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "結束休息"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(136, 31)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 16)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "開始休息"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 111)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 16)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "其他"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 70)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 16)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "下班"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 29)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 16)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "上班"
        '
        'btnSave
        '
        Me.btnSave.AutoSize = True
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("標楷體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnSave.Location = New System.Drawing.Point(781, 473)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 35)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "儲存"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("標楷體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button2.Location = New System.Drawing.Point(781, 516)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 35)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "取消"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.AutoSize = True
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnClear.Location = New System.Drawing.Point(793, 58)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(55, 29)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "清除"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(128, 23)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(104, 16)
        Me.LinkLabel1.TabIndex = 13
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Tag = "23"
        Me.LinkLabel1.Text = "[西元後兩碼]"
        '
        'frmSetFormat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 569)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.grpDateFormat)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.grpInfoFormat)
        Me.Controls.Add(Me.txtFormat)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("標楷體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmSetFormat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "轉出格式設定"
        Me.grpInfoFormat.ResumeLayout(False)
        Me.grpInfoFormat.PerformLayout()
        CType(Me.nudAttendanceID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDateFormat.ResumeLayout(False)
        Me.grpDateFormat.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.nudID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCardID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtFormat As TextBox
    Friend WithEvents grpInfoFormat As GroupBox
    Friend WithEvents llbName As LinkLabel
    Friend WithEvents llbDeviceID As LinkLabel
    Friend WithEvents llbAttendanceState As LinkLabel
    Friend WithEvents llbCardID As LinkLabel
    Friend WithEvents llbID As LinkLabel
    Friend WithEvents llbAttendanceNo As LinkLabel
    Friend WithEvents nudAttendanceID As NumericUpDown
    Friend WithEvents chkAttendanceID As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtResult As TextBox
    Friend WithEvents grpDateFormat As GroupBox
    Friend WithEvents llbSecond As LinkLabel
    Friend WithEvents llbMinute As LinkLabel
    Friend WithEvents llbHour As LinkLabel
    Friend WithEvents llbDay As LinkLabel
    Friend WithEvents llbMonth As LinkLabel
    Friend WithEvents llbROCYear As LinkLabel
    Friend WithEvents llbADYear As LinkLabel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtCardID As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtAttendanceID As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbID As ComboBox
    Friend WithEvents cmbCardID As ComboBox
    Friend WithEvents cmbAttendanceID As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents nudID As NumericUpDown
    Friend WithEvents nudCardID As NumericUpDown
    Friend WithEvents chkID As CheckBox
    Friend WithEvents chkCardID As CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtCheckOut_overtime As TextBox
    Friend WithEvents txtCheckIn_overtime As TextBox
    Friend WithEvents txtEndRest As TextBox
    Friend WithEvents txtStartRest As TextBox
    Friend WithEvents txtElse As TextBox
    Friend WithEvents txtCheckOut As TextBox
    Friend WithEvents txtCheckIn As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
