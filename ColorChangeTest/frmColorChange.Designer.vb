<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmColorChange
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ftbShape1 = New FocusedTextBox.FocusedTextBox
        Me.lblFan1Cap = New System.Windows.Forms.Label
        Me.ftbShape2 = New FocusedTextBox.FocusedTextBox
        Me.MaualTest = New System.Windows.Forms.Button
        Me.lblFan2Cap = New System.Windows.Forms.Label
        Me.ftbTime = New FocusedTextBox.FocusedTextBox
        Me.lblFanFBCap = New System.Windows.Forms.Label
        Me.ftbSpeed = New FocusedTextBox.FocusedTextBox
        Me.pnlFeedBack = New System.Windows.Forms.Panel
        Me.lblTime = New System.Windows.Forms.Label
        Me.lblShape2 = New System.Windows.Forms.Label
        Me.lblShape1 = New System.Windows.Forms.Label
        Me.lblSpeed = New System.Windows.Forms.Label
        Me.lblFlow = New System.Windows.Forms.Label
        Me.lblFan2ActCap = New System.Windows.Forms.Label
        Me.gpbFlowParams = New System.Windows.Forms.GroupBox
        Me.proFlow = New System.Windows.Forms.ProgressBar
        Me.lblTotalCap = New System.Windows.Forms.Label
        Me.lblActualCap = New System.Windows.Forms.Label
        Me.lblValuesCap = New System.Windows.Forms.Label
        Me.ftbFlow = New FocusedTextBox.FocusedTextBox
        Me.lblTimeCap = New System.Windows.Forms.Label
        Me.lblFanCap = New System.Windows.Forms.Label
        Me.lblAtomCap = New System.Windows.Forms.Label
        Me.lblFlowCap = New System.Windows.Forms.Label
        Me.AutoTest = New System.Windows.Forms.Button
        Me.ColorChange = New System.Windows.Forms.Label
        Me.cboxCycle = New System.Windows.Forms.ComboBox
        Me.AutoCycle = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.SaveParameter = New System.Windows.Forms.GroupBox
        Me.SetUp = New System.Windows.Forms.Button
        Me.ValveTest = New System.Windows.Forms.GroupBox
        Me.btnValveTest = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.gbColorChange = New System.Windows.Forms.GroupBox
        Me.pnlFeedBack.SuspendLayout()
        Me.gpbFlowParams.SuspendLayout()
        Me.AutoCycle.SuspendLayout()
        Me.SaveParameter.SuspendLayout()
        Me.ValveTest.SuspendLayout()
        Me.SuspendLayout()
        '
        'ftbShape1
        '
        Me.ftbShape1.Enabled = False
        Me.ftbShape1.ForeColor = System.Drawing.Color.Red
        Me.ftbShape1.Location = New System.Drawing.Point(152, 146)
        Me.ftbShape1.Name = "ftbShape1"
        Me.ftbShape1.NumericOnly = True
        Me.ftbShape1.Size = New System.Drawing.Size(41, 22)
        Me.ftbShape1.TabIndex = 2
        Me.ftbShape1.TabStop = False
        Me.ftbShape1.Tag = "Shape1"
        Me.ftbShape1.Text = "0000"
        Me.ftbShape1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFan1Cap
        '
        Me.lblFan1Cap.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblFan1Cap.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblFan1Cap.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFan1Cap.Location = New System.Drawing.Point(145, 123)
        Me.lblFan1Cap.Name = "lblFan1Cap"
        Me.lblFan1Cap.Size = New System.Drawing.Size(54, 25)
        Me.lblFan1Cap.TabIndex = 53
        Me.lblFan1Cap.Text = "SA 1"
        Me.lblFan1Cap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ftbShape2
        '
        Me.ftbShape2.Enabled = False
        Me.ftbShape2.ForeColor = System.Drawing.Color.Red
        Me.ftbShape2.Location = New System.Drawing.Point(199, 146)
        Me.ftbShape2.Name = "ftbShape2"
        Me.ftbShape2.NumericOnly = True
        Me.ftbShape2.Size = New System.Drawing.Size(41, 22)
        Me.ftbShape2.TabIndex = 51
        Me.ftbShape2.TabStop = False
        Me.ftbShape2.Tag = "Shape2"
        Me.ftbShape2.Text = "0000"
        Me.ftbShape2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MaualTest
        '
        Me.MaualTest.Font = New System.Drawing.Font("SimSun", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.MaualTest.Location = New System.Drawing.Point(148, 278)
        Me.MaualTest.Name = "MaualTest"
        Me.MaualTest.Size = New System.Drawing.Size(87, 33)
        Me.MaualTest.TabIndex = 2
        Me.MaualTest.Tag = "Maual"
        Me.MaualTest.Text = "手动测试"
        Me.MaualTest.UseVisualStyleBackColor = True
        '
        'lblFan2Cap
        '
        Me.lblFan2Cap.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblFan2Cap.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblFan2Cap.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFan2Cap.Location = New System.Drawing.Point(192, 123)
        Me.lblFan2Cap.Name = "lblFan2Cap"
        Me.lblFan2Cap.Size = New System.Drawing.Size(54, 25)
        Me.lblFan2Cap.TabIndex = 52
        Me.lblFan2Cap.Text = "SA 2"
        Me.lblFan2Cap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ftbTime
        '
        Me.ftbTime.Enabled = False
        Me.ftbTime.ForeColor = System.Drawing.Color.Red
        Me.ftbTime.Location = New System.Drawing.Point(152, 186)
        Me.ftbTime.Name = "ftbTime"
        Me.ftbTime.NumericOnly = True
        Me.ftbTime.Size = New System.Drawing.Size(41, 22)
        Me.ftbTime.TabIndex = 4
        Me.ftbTime.TabStop = False
        Me.ftbTime.Tag = "Time"
        Me.ftbTime.Text = "0000"
        Me.ftbTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFanFBCap
        '
        Me.lblFanFBCap.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblFanFBCap.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblFanFBCap.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFanFBCap.Location = New System.Drawing.Point(7, 75)
        Me.lblFanFBCap.Name = "lblFanFBCap"
        Me.lblFanFBCap.Size = New System.Drawing.Size(48, 20)
        Me.lblFanFBCap.TabIndex = 10
        Me.lblFanFBCap.Text = "SA1"
        Me.lblFanFBCap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ftbSpeed
        '
        Me.ftbSpeed.Enabled = False
        Me.ftbSpeed.ForeColor = System.Drawing.Color.Red
        Me.ftbSpeed.Location = New System.Drawing.Point(152, 100)
        Me.ftbSpeed.Name = "ftbSpeed"
        Me.ftbSpeed.NumericOnly = True
        Me.ftbSpeed.Size = New System.Drawing.Size(41, 22)
        Me.ftbSpeed.TabIndex = 1
        Me.ftbSpeed.TabStop = False
        Me.ftbSpeed.Tag = "Speed"
        Me.ftbSpeed.Text = "0000"
        Me.ftbSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnlFeedBack
        '
        Me.pnlFeedBack.Controls.Add(Me.lblTime)
        Me.pnlFeedBack.Controls.Add(Me.lblShape2)
        Me.pnlFeedBack.Controls.Add(Me.lblShape1)
        Me.pnlFeedBack.Controls.Add(Me.lblSpeed)
        Me.pnlFeedBack.Controls.Add(Me.lblFlow)
        Me.pnlFeedBack.Controls.Add(Me.lblFan2ActCap)
        Me.pnlFeedBack.Controls.Add(Me.lblFanFBCap)
        Me.pnlFeedBack.Location = New System.Drawing.Point(246, 48)
        Me.pnlFeedBack.Name = "pnlFeedBack"
        Me.pnlFeedBack.Size = New System.Drawing.Size(118, 173)
        Me.pnlFeedBack.TabIndex = 49
        '
        'lblTime
        '
        Me.lblTime.Location = New System.Drawing.Point(8, 138)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(41, 22)
        Me.lblTime.TabIndex = 58
        Me.lblTime.Tag = "ActualTime"
        Me.lblTime.Text = "0"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblShape2
        '
        Me.lblShape2.Location = New System.Drawing.Point(66, 97)
        Me.lblShape2.Name = "lblShape2"
        Me.lblShape2.Size = New System.Drawing.Size(41, 22)
        Me.lblShape2.TabIndex = 57
        Me.lblShape2.Tag = "ActualShape2"
        Me.lblShape2.Text = "0"
        Me.lblShape2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblShape1
        '
        Me.lblShape1.Location = New System.Drawing.Point(8, 99)
        Me.lblShape1.Name = "lblShape1"
        Me.lblShape1.Size = New System.Drawing.Size(41, 22)
        Me.lblShape1.TabIndex = 56
        Me.lblShape1.Tag = "ActualShape1"
        Me.lblShape1.Text = "0"
        Me.lblShape1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSpeed
        '
        Me.lblSpeed.Location = New System.Drawing.Point(7, 53)
        Me.lblSpeed.Name = "lblSpeed"
        Me.lblSpeed.Size = New System.Drawing.Size(41, 22)
        Me.lblSpeed.TabIndex = 55
        Me.lblSpeed.Tag = "ActualSpeed"
        Me.lblSpeed.Text = "0"
        Me.lblSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFlow
        '
        Me.lblFlow.Location = New System.Drawing.Point(8, 9)
        Me.lblFlow.Name = "lblFlow"
        Me.lblFlow.Size = New System.Drawing.Size(41, 22)
        Me.lblFlow.TabIndex = 54
        Me.lblFlow.Tag = "ActualFlow"
        Me.lblFlow.Text = "0"
        Me.lblFlow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFan2ActCap
        '
        Me.lblFan2ActCap.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblFan2ActCap.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblFan2ActCap.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFan2ActCap.Location = New System.Drawing.Point(62, 73)
        Me.lblFan2ActCap.Name = "lblFan2ActCap"
        Me.lblFan2ActCap.Size = New System.Drawing.Size(54, 25)
        Me.lblFan2ActCap.TabIndex = 53
        Me.lblFan2ActCap.Text = "SA 2"
        Me.lblFan2ActCap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gpbFlowParams
        '
        Me.gpbFlowParams.Controls.Add(Me.ftbShape1)
        Me.gpbFlowParams.Controls.Add(Me.lblFan1Cap)
        Me.gpbFlowParams.Controls.Add(Me.ftbShape2)
        Me.gpbFlowParams.Controls.Add(Me.MaualTest)
        Me.gpbFlowParams.Controls.Add(Me.lblFan2Cap)
        Me.gpbFlowParams.Controls.Add(Me.ftbTime)
        Me.gpbFlowParams.Controls.Add(Me.ftbSpeed)
        Me.gpbFlowParams.Controls.Add(Me.pnlFeedBack)
        Me.gpbFlowParams.Controls.Add(Me.proFlow)
        Me.gpbFlowParams.Controls.Add(Me.lblTotalCap)
        Me.gpbFlowParams.Controls.Add(Me.lblActualCap)
        Me.gpbFlowParams.Controls.Add(Me.lblValuesCap)
        Me.gpbFlowParams.Controls.Add(Me.ftbFlow)
        Me.gpbFlowParams.Controls.Add(Me.lblTimeCap)
        Me.gpbFlowParams.Controls.Add(Me.lblFanCap)
        Me.gpbFlowParams.Controls.Add(Me.lblAtomCap)
        Me.gpbFlowParams.Controls.Add(Me.lblFlowCap)
        Me.gpbFlowParams.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.gpbFlowParams.Location = New System.Drawing.Point(30, 99)
        Me.gpbFlowParams.Name = "gpbFlowParams"
        Me.gpbFlowParams.Size = New System.Drawing.Size(373, 323)
        Me.gpbFlowParams.TabIndex = 15
        Me.gpbFlowParams.TabStop = False
        Me.gpbFlowParams.Text = "手动测试参数"
        '
        'proFlow
        '
        Me.proFlow.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.proFlow.Location = New System.Drawing.Point(35, 249)
        Me.proFlow.Name = "proFlow"
        Me.proFlow.Size = New System.Drawing.Size(305, 14)
        Me.proFlow.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.proFlow.TabIndex = 48
        Me.proFlow.Visible = False
        '
        'lblTotalCap
        '
        Me.lblTotalCap.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTotalCap.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalCap.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblTotalCap.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTotalCap.Location = New System.Drawing.Point(309, 3)
        Me.lblTotalCap.Name = "lblTotalCap"
        Me.lblTotalCap.Size = New System.Drawing.Size(53, 45)
        Me.lblTotalCap.TabIndex = 46
        Me.lblTotalCap.Text = "总量"
        Me.lblTotalCap.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblActualCap
        '
        Me.lblActualCap.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblActualCap.BackColor = System.Drawing.Color.Transparent
        Me.lblActualCap.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblActualCap.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblActualCap.Location = New System.Drawing.Point(254, 3)
        Me.lblActualCap.Name = "lblActualCap"
        Me.lblActualCap.Size = New System.Drawing.Size(53, 45)
        Me.lblActualCap.TabIndex = 45
        Me.lblActualCap.Text = "实际"
        Me.lblActualCap.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblValuesCap
        '
        Me.lblValuesCap.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblValuesCap.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblValuesCap.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblValuesCap.Location = New System.Drawing.Point(148, 27)
        Me.lblValuesCap.Name = "lblValuesCap"
        Me.lblValuesCap.Size = New System.Drawing.Size(56, 20)
        Me.lblValuesCap.TabIndex = 44
        Me.lblValuesCap.Text = "测试"
        Me.lblValuesCap.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ftbFlow
        '
        Me.ftbFlow.AcceptsReturn = True
        Me.ftbFlow.Enabled = False
        Me.ftbFlow.ForeColor = System.Drawing.Color.Red
        Me.ftbFlow.Location = New System.Drawing.Point(151, 54)
        Me.ftbFlow.Name = "ftbFlow"
        Me.ftbFlow.NumericOnly = True
        Me.ftbFlow.Size = New System.Drawing.Size(41, 22)
        Me.ftbFlow.TabIndex = 0
        Me.ftbFlow.TabStop = False
        Me.ftbFlow.Tag = "Flow"
        Me.ftbFlow.Text = "0000"
        Me.ftbFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTimeCap
        '
        Me.lblTimeCap.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTimeCap.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblTimeCap.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTimeCap.Location = New System.Drawing.Point(12, 187)
        Me.lblTimeCap.Name = "lblTimeCap"
        Me.lblTimeCap.Size = New System.Drawing.Size(139, 20)
        Me.lblTimeCap.TabIndex = 29
        Me.lblTimeCap.Text = "时间 (sec)"
        Me.lblTimeCap.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFanCap
        '
        Me.lblFanCap.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblFanCap.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblFanCap.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFanCap.Location = New System.Drawing.Point(12, 147)
        Me.lblFanCap.Name = "lblFanCap"
        Me.lblFanCap.Size = New System.Drawing.Size(139, 20)
        Me.lblFanCap.TabIndex = 27
        Me.lblFanCap.Text = "成型空气 (psi)"
        Me.lblFanCap.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAtomCap
        '
        Me.lblAtomCap.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblAtomCap.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblAtomCap.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAtomCap.Location = New System.Drawing.Point(12, 101)
        Me.lblAtomCap.Name = "lblAtomCap"
        Me.lblAtomCap.Size = New System.Drawing.Size(139, 20)
        Me.lblAtomCap.TabIndex = 26
        Me.lblAtomCap.Text = "旋杯转速 (krpm)"
        Me.lblAtomCap.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFlowCap
        '
        Me.lblFlowCap.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblFlowCap.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblFlowCap.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFlowCap.Location = New System.Drawing.Point(10, 55)
        Me.lblFlowCap.Name = "lblFlowCap"
        Me.lblFlowCap.Size = New System.Drawing.Size(142, 20)
        Me.lblFlowCap.TabIndex = 23
        Me.lblFlowCap.Text = "流量 (cc/min)"
        Me.lblFlowCap.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AutoTest
        '
        Me.AutoTest.Font = New System.Drawing.Font("SimSun", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutoTest.Location = New System.Drawing.Point(80, 275)
        Me.AutoTest.Name = "AutoTest"
        Me.AutoTest.Size = New System.Drawing.Size(87, 33)
        Me.AutoTest.TabIndex = 1
        Me.AutoTest.Text = "自动测试"
        Me.AutoTest.UseVisualStyleBackColor = True
        '
        'ColorChange
        '
        Me.ColorChange.Font = New System.Drawing.Font("SimSun", 42.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ColorChange.Location = New System.Drawing.Point(35, 17)
        Me.ColorChange.Name = "ColorChange"
        Me.ColorChange.Size = New System.Drawing.Size(576, 66)
        Me.ColorChange.TabIndex = 16
        Me.ColorChange.Text = "Color Change"
        Me.ColorChange.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cboxCycle
        '
        Me.cboxCycle.FormattingEnabled = True
        Me.cboxCycle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cboxCycle.ItemHeight = 16
        Me.cboxCycle.Items.AddRange(New Object() {"Cap Clean", "Clean out", "Fill", "Super Purge"})
        Me.cboxCycle.Location = New System.Drawing.Point(32, 45)
        Me.cboxCycle.Name = "cboxCycle"
        Me.cboxCycle.Size = New System.Drawing.Size(167, 24)
        Me.cboxCycle.TabIndex = 3
        '
        'AutoCycle
        '
        Me.AutoCycle.Controls.Add(Me.Label8)
        Me.AutoCycle.Controls.Add(Me.Label7)
        Me.AutoCycle.Controls.Add(Me.Label6)
        Me.AutoCycle.Controls.Add(Me.Label5)
        Me.AutoCycle.Controls.Add(Me.Label4)
        Me.AutoCycle.Controls.Add(Me.Label3)
        Me.AutoCycle.Controls.Add(Me.Label2)
        Me.AutoCycle.Controls.Add(Me.Label1)
        Me.AutoCycle.Controls.Add(Me.cboxCycle)
        Me.AutoCycle.Controls.Add(Me.AutoTest)
        Me.AutoCycle.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutoCycle.Location = New System.Drawing.Point(424, 102)
        Me.AutoCycle.Name = "AutoCycle"
        Me.AutoCycle.Size = New System.Drawing.Size(229, 320)
        Me.AutoCycle.TabIndex = 17
        Me.AutoCycle.TabStop = False
        Me.AutoCycle.Text = "自动测试"
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("SimSun", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.Location = New System.Drawing.Point(138, 207)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 23)
        Me.Label8.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("SimSun", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.Location = New System.Drawing.Point(138, 168)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 23)
        Me.Label7.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("SimSun", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.Location = New System.Drawing.Point(138, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 20)
        Me.Label6.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("SimSun", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(138, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 20)
        Me.Label5.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("SimSun", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Super Purge"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("SimSun", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Clean Out"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("SimSun", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Fill"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("SimSun", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Cap Clean"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("SimSun", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(80, 275)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 33)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "自动测试"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("SimSun", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label16.Location = New System.Drawing.Point(30, 97)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(102, 19)
        Me.Label16.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("SimSun", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label13.Location = New System.Drawing.Point(30, 207)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(102, 19)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Super Purge"
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("SimSun", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label9.Location = New System.Drawing.Point(138, 207)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 23)
        Me.Label9.TabIndex = 11
        '
        'SaveParameter
        '
        Me.SaveParameter.Controls.Add(Me.SetUp)
        Me.SaveParameter.Controls.Add(Me.Label9)
        Me.SaveParameter.Controls.Add(Me.Label13)
        Me.SaveParameter.Controls.Add(Me.Label16)
        Me.SaveParameter.Controls.Add(Me.Button1)
        Me.SaveParameter.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveParameter.Location = New System.Drawing.Point(30, 434)
        Me.SaveParameter.Name = "SaveParameter"
        Me.SaveParameter.Size = New System.Drawing.Size(373, 62)
        Me.SaveParameter.TabIndex = 18
        Me.SaveParameter.TabStop = False
        Me.SaveParameter.Text = "保存参数"
        '
        'SetUp
        '
        Me.SetUp.Font = New System.Drawing.Font("SimSun", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.SetUp.Location = New System.Drawing.Point(148, 18)
        Me.SetUp.Name = "SetUp"
        Me.SetUp.Size = New System.Drawing.Size(87, 33)
        Me.SetUp.TabIndex = 54
        Me.SetUp.Text = "设置"
        Me.SetUp.UseVisualStyleBackColor = True
        '
        'ValveTest
        '
        Me.ValveTest.Controls.Add(Me.btnValveTest)
        Me.ValveTest.Controls.Add(Me.Label10)
        Me.ValveTest.Controls.Add(Me.Label11)
        Me.ValveTest.Controls.Add(Me.Label12)
        Me.ValveTest.Controls.Add(Me.Button2)
        Me.ValveTest.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValveTest.Location = New System.Drawing.Point(424, 434)
        Me.ValveTest.Name = "ValveTest"
        Me.ValveTest.Size = New System.Drawing.Size(229, 62)
        Me.ValveTest.TabIndex = 19
        Me.ValveTest.TabStop = False
        Me.ValveTest.Text = "阀门测试"
        '
        'btnValveTest
        '
        Me.btnValveTest.Font = New System.Drawing.Font("SimSun", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnValveTest.Location = New System.Drawing.Point(80, 20)
        Me.btnValveTest.Name = "btnValveTest"
        Me.btnValveTest.Size = New System.Drawing.Size(87, 33)
        Me.btnValveTest.TabIndex = 56
        Me.btnValveTest.Text = "开始"
        Me.btnValveTest.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("SimSun", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label10.Location = New System.Drawing.Point(138, 207)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 23)
        Me.Label10.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("SimSun", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label11.Location = New System.Drawing.Point(30, 207)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 19)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Super Purge"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("SimSun", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label12.Location = New System.Drawing.Point(30, 97)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(102, 19)
        Me.Label12.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("SimSun", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(80, 275)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 33)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "自动测试"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'gbColorChange
        '
        Me.gbColorChange.Location = New System.Drawing.Point(680, 3)
        Me.gbColorChange.Name = "gbColorChange"
        Me.gbColorChange.Size = New System.Drawing.Size(400, 493)
        Me.gbColorChange.TabIndex = 20
        Me.gbColorChange.TabStop = False
        '
        'FrmColorChange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1115, 513)
        Me.Controls.Add(Me.gbColorChange)
        Me.Controls.Add(Me.ValveTest)
        Me.Controls.Add(Me.SaveParameter)
        Me.Controls.Add(Me.gpbFlowParams)
        Me.Controls.Add(Me.ColorChange)
        Me.Controls.Add(Me.AutoCycle)
        Me.Name = "FrmColorChange"
        Me.Text = "换色测试画面"
        Me.pnlFeedBack.ResumeLayout(False)
        Me.gpbFlowParams.ResumeLayout(False)
        Me.gpbFlowParams.PerformLayout()
        Me.AutoCycle.ResumeLayout(False)
        Me.SaveParameter.ResumeLayout(False)
        Me.ValveTest.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ftbShape1 As FocusedTextBox.FocusedTextBox
    Friend WithEvents lblFan1Cap As System.Windows.Forms.Label
    Friend WithEvents ftbShape2 As FocusedTextBox.FocusedTextBox
    Friend WithEvents MaualTest As System.Windows.Forms.Button
    Friend WithEvents lblFan2Cap As System.Windows.Forms.Label
    Friend WithEvents ftbTime As FocusedTextBox.FocusedTextBox
    Friend WithEvents lblFanFBCap As System.Windows.Forms.Label
    Friend WithEvents ftbSpeed As FocusedTextBox.FocusedTextBox
    Friend WithEvents pnlFeedBack As System.Windows.Forms.Panel
    Friend WithEvents lblFan2ActCap As System.Windows.Forms.Label
    Friend WithEvents gpbFlowParams As System.Windows.Forms.GroupBox
    Friend WithEvents proFlow As System.Windows.Forms.ProgressBar
    Friend WithEvents lblTotalCap As System.Windows.Forms.Label
    Friend WithEvents lblActualCap As System.Windows.Forms.Label
    Friend WithEvents lblValuesCap As System.Windows.Forms.Label
    Friend WithEvents ftbFlow As FocusedTextBox.FocusedTextBox
    Friend WithEvents lblTimeCap As System.Windows.Forms.Label
    Friend WithEvents lblFanCap As System.Windows.Forms.Label
    Friend WithEvents lblAtomCap As System.Windows.Forms.Label
    Friend WithEvents lblFlowCap As System.Windows.Forms.Label
    Friend WithEvents AutoTest As System.Windows.Forms.Button
    Friend WithEvents ColorChange As System.Windows.Forms.Label
    Friend WithEvents cboxCycle As System.Windows.Forms.ComboBox
    Friend WithEvents AutoCycle As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents SaveParameter As System.Windows.Forms.GroupBox
    Friend WithEvents ValveTest As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents SetUp As System.Windows.Forms.Button
    Friend WithEvents btnValveTest As System.Windows.Forms.Button
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblShape2 As System.Windows.Forms.Label
    Friend WithEvents lblShape1 As System.Windows.Forms.Label
    Friend WithEvents lblSpeed As System.Windows.Forms.Label
    Friend WithEvents lblFlow As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents gbColorChange As System.Windows.Forms.GroupBox
End Class
