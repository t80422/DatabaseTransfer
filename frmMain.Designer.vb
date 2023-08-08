<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpSystem = New System.Windows.Forms.TabPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPsw = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnTaskSchedule = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnTestConnect = New System.Windows.Forms.Button()
        Me.cmbDBType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpStrat = New System.Windows.Forms.DateTimePicker()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.btnSaveTime = New System.Windows.Forms.Button()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSave_exportPath = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.btnSetPath = New System.Windows.Forms.Button()
        Me.dgvFilePath = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnSetFormat = New System.Windows.Forms.Button()
        Me.txtFormat = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.nudExport = New System.Windows.Forms.NumericUpDown()
        Me.cmbExport = New System.Windows.Forms.ComboBox()
        Me.TabControl1.SuspendLayout()
        Me.tpSystem.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvFilePath, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudExport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpSystem)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        resources.ApplyResources(Me.TabControl1, "TabControl1")
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        '
        'tpSystem
        '
        Me.tpSystem.Controls.Add(Me.Label12)
        Me.tpSystem.Controls.Add(Me.txtUserName)
        Me.tpSystem.Controls.Add(Me.Label2)
        Me.tpSystem.Controls.Add(Me.txtPsw)
        Me.tpSystem.Controls.Add(Me.Label4)
        Me.tpSystem.Controls.Add(Me.txtIP)
        Me.tpSystem.Controls.Add(Me.Label3)
        Me.tpSystem.Controls.Add(Me.btnTaskSchedule)
        Me.tpSystem.Controls.Add(Me.btnClear)
        Me.tpSystem.Controls.Add(Me.btnSave)
        Me.tpSystem.Controls.Add(Me.btnTestConnect)
        Me.tpSystem.Controls.Add(Me.cmbDBType)
        Me.tpSystem.Controls.Add(Me.Label1)
        resources.ApplyResources(Me.tpSystem, "tpSystem")
        Me.tpSystem.Name = "tpSystem"
        Me.tpSystem.UseVisualStyleBackColor = True
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.Name = "Label12"
        '
        'txtUserName
        '
        resources.ApplyResources(Me.txtUserName, "txtUserName")
        Me.txtUserName.Name = "txtUserName"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'txtPsw
        '
        resources.ApplyResources(Me.txtPsw, "txtPsw")
        Me.txtPsw.Name = "txtPsw"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'txtIP
        '
        resources.ApplyResources(Me.txtIP, "txtIP")
        Me.txtIP.Name = "txtIP"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'btnTaskSchedule
        '
        resources.ApplyResources(Me.btnTaskSchedule, "btnTaskSchedule")
        Me.btnTaskSchedule.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnTaskSchedule.Name = "btnTaskSchedule"
        Me.btnTaskSchedule.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        resources.ApplyResources(Me.btnClear, "btnClear")
        Me.btnClear.Name = "btnClear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        resources.ApplyResources(Me.btnSave, "btnSave")
        Me.btnSave.Name = "btnSave"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnTestConnect
        '
        Me.btnTestConnect.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        resources.ApplyResources(Me.btnTestConnect, "btnTestConnect")
        Me.btnTestConnect.Name = "btnTestConnect"
        Me.btnTestConnect.UseVisualStyleBackColor = False
        '
        'cmbDBType
        '
        Me.cmbDBType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.cmbDBType, "cmbDBType")
        Me.cmbDBType.FormattingEnabled = True
        Me.cmbDBType.Items.AddRange(New Object() {resources.GetString("cmbDBType.Items")})
        Me.cmbDBType.Name = "cmbDBType"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.dtpStrat)
        Me.TabPage3.Controls.Add(Me.dtpEnd)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.btnExport)
        resources.ApplyResources(Me.TabPage3, "TabPage3")
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'dtpStrat
        '
        resources.ApplyResources(Me.dtpStrat, "dtpStrat")
        Me.dtpStrat.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStrat.Name = "dtpStrat"
        '
        'dtpEnd
        '
        resources.ApplyResources(Me.dtpEnd, "dtpEnd")
        Me.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEnd.Name = "dtpEnd"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'btnExport
        '
        resources.ApplyResources(Me.btnExport, "btnExport")
        Me.btnExport.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnExport.Name = "btnExport"
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.Transparent
        Me.TabPage5.Controls.Add(Me.btnSaveTime)
        Me.TabPage5.Controls.Add(Me.txtResult)
        Me.TabPage5.Controls.Add(Me.Label9)
        Me.TabPage5.Controls.Add(Me.GroupBox2)
        Me.TabPage5.Controls.Add(Me.Label11)
        Me.TabPage5.Controls.Add(Me.btnSetFormat)
        Me.TabPage5.Controls.Add(Me.txtFormat)
        Me.TabPage5.Controls.Add(Me.Label10)
        Me.TabPage5.Controls.Add(Me.Label8)
        Me.TabPage5.Controls.Add(Me.nudExport)
        Me.TabPage5.Controls.Add(Me.cmbExport)
        resources.ApplyResources(Me.TabPage5, "TabPage5")
        Me.TabPage5.Name = "TabPage5"
        '
        'btnSaveTime
        '
        resources.ApplyResources(Me.btnSaveTime, "btnSaveTime")
        Me.btnSaveTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSaveTime.Name = "btnSaveTime"
        Me.btnSaveTime.UseVisualStyleBackColor = False
        '
        'txtResult
        '
        resources.ApplyResources(Me.txtResult, "txtResult")
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btnSave_exportPath)
        Me.GroupBox2.Controls.Add(Me.btnDelete)
        Me.GroupBox2.Controls.Add(Me.btnModify)
        Me.GroupBox2.Controls.Add(Me.btnSetPath)
        Me.GroupBox2.Controls.Add(Me.dgvFilePath)
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'btnSave_exportPath
        '
        resources.ApplyResources(Me.btnSave_exportPath, "btnSave_exportPath")
        Me.btnSave_exportPath.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSave_exportPath.Name = "btnSave_exportPath"
        Me.btnSave_exportPath.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        resources.ApplyResources(Me.btnDelete, "btnDelete")
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnModify
        '
        resources.ApplyResources(Me.btnModify, "btnModify")
        Me.btnModify.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnModify.Name = "btnModify"
        Me.btnModify.UseVisualStyleBackColor = False
        '
        'btnSetPath
        '
        resources.ApplyResources(Me.btnSetPath, "btnSetPath")
        Me.btnSetPath.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSetPath.Name = "btnSetPath"
        Me.btnSetPath.UseVisualStyleBackColor = False
        '
        'dgvFilePath
        '
        Me.dgvFilePath.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        resources.ApplyResources(Me.dgvFilePath, "dgvFilePath")
        Me.dgvFilePath.Name = "dgvFilePath"
        Me.dgvFilePath.RowTemplate.Height = 24
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.Name = "Label11"
        '
        'btnSetFormat
        '
        resources.ApplyResources(Me.btnSetFormat, "btnSetFormat")
        Me.btnSetFormat.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSetFormat.Name = "btnSetFormat"
        Me.btnSetFormat.UseVisualStyleBackColor = False
        '
        'txtFormat
        '
        resources.ApplyResources(Me.txtFormat, "txtFormat")
        Me.txtFormat.Name = "txtFormat"
        Me.txtFormat.ReadOnly = True
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Name = "Label10"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'nudExport
        '
        resources.ApplyResources(Me.nudExport, "nudExport")
        Me.nudExport.Name = "nudExport"
        '
        'cmbExport
        '
        Me.cmbExport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbExport.FormattingEnabled = True
        Me.cmbExport.Items.AddRange(New Object() {resources.GetString("cmbExport.Items"), resources.GetString("cmbExport.Items1"), resources.GetString("cmbExport.Items2")})
        resources.ApplyResources(Me.cmbExport, "cmbExport")
        Me.cmbExport.Name = "cmbExport"
        '
        'frmMain
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.TabControl1.ResumeLayout(False)
        Me.tpSystem.ResumeLayout(False)
        Me.tpSystem.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvFilePath, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudExport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpSystem As TabPage
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnTestConnect As Button
    Friend WithEvents cmbDBType As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents dtpEnd As DateTimePicker
    Friend WithEvents btnExport As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpStrat As DateTimePicker
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSetFormat As Button
    Friend WithEvents cmbExport As ComboBox
    Friend WithEvents nudExport As NumericUpDown
    Friend WithEvents txtFormat As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnSaveTime As Button
    Friend WithEvents txtResult As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnTaskSchedule As Button
    Friend WithEvents txtPsw As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtIP As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btnSetPath As Button
    Friend WithEvents dgvFilePath As DataGridView
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnModify As Button
    Friend WithEvents btnSave_exportPath As Button
End Class
