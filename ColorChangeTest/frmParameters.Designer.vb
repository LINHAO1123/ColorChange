<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMParameters
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMParameters))
        Me.parflow = New FocusedTextBox.FocusedTextBox
        Me.parSpeed = New FocusedTextBox.FocusedTextBox
        Me.prsShape2 = New FocusedTextBox.FocusedTextBox
        Me.parShape1 = New FocusedTextBox.FocusedTextBox
        Me.prsTime = New FocusedTextBox.FocusedTextBox
        Me.Cycle = New System.Windows.Forms.ComboBox
        Me.StepList = New System.Windows.Forms.ComboBox
        Me.LabCycle = New System.Windows.Forms.Label
        Me.ValveBOX = New System.Windows.Forms.CheckedListBox
        Me.LabStep = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.prslabSpeed = New System.Windows.Forms.Label
        Me.prslabTime = New System.Windows.Forms.Label
        Me.prslabShape2 = New System.Windows.Forms.Label
        Me.prslabShape1 = New System.Windows.Forms.Label
        Me.prslabflow = New System.Windows.Forms.Label
        Me.btnSave1 = New System.Windows.Forms.Button
        Me.btnSave2 = New System.Windows.Forms.Button
        Me.gbColorChange = New System.Windows.Forms.GroupBox
        Me.lblLineSolvAirOut1 = New System.Windows.Forms.Label
        Me.lblShared00 = New System.Windows.Forms.Label
        Me.lblLineColStk3 = New System.Windows.Forms.Label
        Me.picVersabellGearsPump01 = New System.Windows.Forms.PictureBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.lblLinePF = New System.Windows.Forms.Label
        Me.lblLineSolvAirOut2 = New System.Windows.Forms.Label
        Me.lblLineDump1 = New System.Windows.Forms.Label
        Me.lblLineColStk4 = New System.Windows.Forms.Label
        Me.lblLineBellMan1 = New System.Windows.Forms.Label
        Me.lblLineColStk5 = New System.Windows.Forms.Label
        Me.lblLineSolvAir2 = New System.Windows.Forms.Label
        Me.lblLineColStk2 = New System.Windows.Forms.Label
        Me.lblLineSolvAir1 = New System.Windows.Forms.Label
        Me.lblLineSolvAirout3 = New System.Windows.Forms.Label
        Me.lblLineBellMan2 = New System.Windows.Forms.Label
        Me.lblLineSealAir = New System.Windows.Forms.Label
        Me.lblLineSolvAir = New System.Windows.Forms.Label
        Me.lblGroup07 = New System.Windows.Forms.Label
        Me.lblColorHeader2 = New System.Windows.Forms.Label
        Me.lblAirHeaderLine2 = New System.Windows.Forms.Label
        Me.lblLineBW2 = New System.Windows.Forms.Label
        Me.lblLineDump2_2 = New System.Windows.Forms.Label
        Me.lblLineDump2_1 = New System.Windows.Forms.Label
        Me.lblAirHeaderLine3 = New System.Windows.Forms.Label
        Me.lblLineInjector = New System.Windows.Forms.Label
        Me.lblLineBW1 = New System.Windows.Forms.Label
        Me.lblSolventHeader3 = New System.Windows.Forms.Label
        Me.lblGroup00 = New System.Windows.Forms.Label
        Me.lblDumpTank = New System.Windows.Forms.Label
        Me.lblGroup04 = New System.Windows.Forms.Label
        Me.lblGroup03 = New System.Windows.Forms.Label
        Me.lblGroup06 = New System.Windows.Forms.Label
        Me.lblGroup05 = New System.Windows.Forms.Label
        Me.lblGroup01 = New System.Windows.Forms.Label
        Me.lblGroup02 = New System.Windows.Forms.Label
        Me.lblShared03 = New System.Windows.Forms.Label
        Me.lblLineColStk1 = New System.Windows.Forms.Label
        Me.lblGroup09 = New System.Windows.Forms.Label
        Me.lblGroup08 = New System.Windows.Forms.Label
        Me.picDumpTank = New System.Windows.Forms.PictureBox
        Me.lblOutPressure = New System.Windows.Forms.Label
        Me.lblOutPressureTag = New System.Windows.Forms.Label
        Me.lblAirHeaderLine1 = New System.Windows.Forms.Label
        Me.lblSolventHeader1 = New System.Windows.Forms.Label
        Me.lblPntHeader01 = New System.Windows.Forms.Label
        Me.lblAirHeader01 = New System.Windows.Forms.Label
        Me.lblSolventHeader2 = New System.Windows.Forms.Label
        Me.lblFlowTag = New System.Windows.Forms.Label
        Me.lblParameters = New System.Windows.Forms.Label
        Me.UctrlSharedValve0 = New ColorChangeTest.uctrlValve
        Me.UctrlSharedValve0b = New ColorChangeTest.uctrlValve
        Me.UctrlGroupValve9 = New ColorChangeTest.uctrlValve
        Me.UctrlGroupValve8 = New ColorChangeTest.uctrlValve
        Me.UctrlGroupValve7 = New ColorChangeTest.uctrlValve
        Me.UctrlGroupValve6 = New ColorChangeTest.uctrlValve
        Me.UctrlGroupValve5 = New ColorChangeTest.uctrlValve
        Me.UctrlGroupValve4 = New ColorChangeTest.uctrlValve
        Me.UctrlGroupValve3 = New ColorChangeTest.uctrlValve
        Me.UctrlGroupValve2 = New ColorChangeTest.uctrlValve
        Me.UctrlGroupValve1 = New ColorChangeTest.uctrlValve
        Me.UctrlSharedValve0a = New ColorChangeTest.uctrlValve
        Me.UctrlGroupValve0 = New ColorChangeTest.uctrlValve
        Me.UctrlSharedValve3 = New ColorChangeTest.uctrlValve
        Me.GroupBox1.SuspendLayout()
        Me.gbColorChange.SuspendLayout()
        CType(Me.picVersabellGearsPump01, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDumpTank, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'parflow
        '
        Me.parflow.AcceptsReturn = True
        Me.parflow.Font = New System.Drawing.Font("SimSun", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.parflow.ForeColor = System.Drawing.Color.Red
        Me.parflow.Location = New System.Drawing.Point(159, 44)
        Me.parflow.Name = "parflow"
        Me.parflow.NumericOnly = True
        Me.parflow.Size = New System.Drawing.Size(41, 23)
        Me.parflow.TabIndex = 1
        Me.parflow.TabStop = False
        Me.parflow.Tag = "Flow"
        Me.parflow.Text = "0000"
        Me.parflow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'parSpeed
        '
        Me.parSpeed.AcceptsReturn = True
        Me.parSpeed.Font = New System.Drawing.Font("SimSun", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.parSpeed.ForeColor = System.Drawing.Color.Red
        Me.parSpeed.Location = New System.Drawing.Point(159, 83)
        Me.parSpeed.Name = "parSpeed"
        Me.parSpeed.NumericOnly = True
        Me.parSpeed.Size = New System.Drawing.Size(41, 23)
        Me.parSpeed.TabIndex = 2
        Me.parSpeed.TabStop = False
        Me.parSpeed.Tag = "Flow"
        Me.parSpeed.Text = "0000"
        Me.parSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'prsShape2
        '
        Me.prsShape2.AcceptsReturn = True
        Me.prsShape2.Font = New System.Drawing.Font("SimSun", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.prsShape2.ForeColor = System.Drawing.Color.Red
        Me.prsShape2.Location = New System.Drawing.Point(159, 165)
        Me.prsShape2.Name = "prsShape2"
        Me.prsShape2.NumericOnly = True
        Me.prsShape2.Size = New System.Drawing.Size(41, 23)
        Me.prsShape2.TabIndex = 4
        Me.prsShape2.TabStop = False
        Me.prsShape2.Tag = "Flow"
        Me.prsShape2.Text = "0000"
        Me.prsShape2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'parShape1
        '
        Me.parShape1.AcceptsReturn = True
        Me.parShape1.Font = New System.Drawing.Font("SimSun", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.parShape1.ForeColor = System.Drawing.Color.Red
        Me.parShape1.Location = New System.Drawing.Point(159, 124)
        Me.parShape1.Name = "parShape1"
        Me.parShape1.NumericOnly = True
        Me.parShape1.Size = New System.Drawing.Size(41, 23)
        Me.parShape1.TabIndex = 3
        Me.parShape1.TabStop = False
        Me.parShape1.Tag = "Flow"
        Me.parShape1.Text = "0000"
        Me.parShape1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'prsTime
        '
        Me.prsTime.AcceptsReturn = True
        Me.prsTime.Font = New System.Drawing.Font("SimSun", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.prsTime.ForeColor = System.Drawing.Color.Red
        Me.prsTime.Location = New System.Drawing.Point(159, 208)
        Me.prsTime.Name = "prsTime"
        Me.prsTime.NumericOnly = True
        Me.prsTime.Size = New System.Drawing.Size(41, 23)
        Me.prsTime.TabIndex = 5
        Me.prsTime.TabStop = False
        Me.prsTime.Tag = "Flow"
        Me.prsTime.Text = "0000"
        Me.prsTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Cycle
        '
        Me.Cycle.FormattingEnabled = True
        Me.Cycle.Items.AddRange(New Object() {"Color Change", "Fill", "Cap Clean", "Super Purge"})
        Me.Cycle.Location = New System.Drawing.Point(54, 97)
        Me.Cycle.Name = "Cycle"
        Me.Cycle.Size = New System.Drawing.Size(154, 20)
        Me.Cycle.TabIndex = 33
        '
        'StepList
        '
        Me.StepList.FormattingEnabled = True
        Me.StepList.Items.AddRange(New Object() {"Step1", "Step2", "Step3", "Step4", "Step5", "Step6", "Step7", "Step8", "Step9", "Step10", "Step11", "Step12", "Step13", "Step14", "Step15", "Step16", "Step17", "Step18", "Step19", "Step20", "Step21", "Step22", "Step23", "Step24", "Step25", "Step26", "Step27", "Step28", "Step29", "Step30"})
        Me.StepList.Location = New System.Drawing.Point(297, 97)
        Me.StepList.Name = "StepList"
        Me.StepList.Size = New System.Drawing.Size(154, 20)
        Me.StepList.TabIndex = 34
        '
        'LabCycle
        '
        Me.LabCycle.Font = New System.Drawing.Font("SimSun", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabCycle.Location = New System.Drawing.Point(78, 65)
        Me.LabCycle.Name = "LabCycle"
        Me.LabCycle.Size = New System.Drawing.Size(130, 22)
        Me.LabCycle.TabIndex = 35
        Me.LabCycle.Text = "换色循环"
        '
        'ValveBOX
        '
        Me.ValveBOX.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ValveBOX.FormattingEnabled = True
        Me.ValveBOX.Items.AddRange(New Object() {"  BW", "  ENB", "  IW", "  p2T", "  pAIR", "  pCC", "  pCE", "  pDUMP", "  pDUMP2", "  pFLUSH", "  pSeal  ", "  pSOL", "  pVENT", "  TRIG"})
        Me.ValveBOX.Location = New System.Drawing.Point(285, 155)
        Me.ValveBOX.MultiColumn = True
        Me.ValveBOX.Name = "ValveBOX"
        Me.ValveBOX.Size = New System.Drawing.Size(180, 340)
        Me.ValveBOX.Sorted = True
        Me.ValveBOX.TabIndex = 36
        '
        'LabStep
        '
        Me.LabStep.Font = New System.Drawing.Font("SimSun", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabStep.Location = New System.Drawing.Point(321, 65)
        Me.LabStep.Name = "LabStep"
        Me.LabStep.Size = New System.Drawing.Size(130, 22)
        Me.LabStep.TabIndex = 37
        Me.LabStep.Text = "换色步骤"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.prslabSpeed)
        Me.GroupBox1.Controls.Add(Me.prslabTime)
        Me.GroupBox1.Controls.Add(Me.prslabShape2)
        Me.GroupBox1.Controls.Add(Me.prslabShape1)
        Me.GroupBox1.Controls.Add(Me.prslabflow)
        Me.GroupBox1.Controls.Add(Me.prsTime)
        Me.GroupBox1.Controls.Add(Me.prsShape2)
        Me.GroupBox1.Controls.Add(Me.parShape1)
        Me.GroupBox1.Controls.Add(Me.parSpeed)
        Me.GroupBox1.Controls.Add(Me.parflow)
        Me.GroupBox1.Font = New System.Drawing.Font("SimSun", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(17, 141)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(228, 251)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "参数设定"
        '
        'prslabSpeed
        '
        Me.prslabSpeed.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.prslabSpeed.Location = New System.Drawing.Point(26, 85)
        Me.prslabSpeed.Name = "prslabSpeed"
        Me.prslabSpeed.Size = New System.Drawing.Size(130, 22)
        Me.prslabSpeed.TabIndex = 46
        Me.prslabSpeed.Text = "旋杯转数"
        '
        'prslabTime
        '
        Me.prslabTime.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.prslabTime.Location = New System.Drawing.Point(26, 210)
        Me.prslabTime.Name = "prslabTime"
        Me.prslabTime.Size = New System.Drawing.Size(130, 22)
        Me.prslabTime.TabIndex = 45
        Me.prslabTime.Text = "步骤时间"
        '
        'prslabShape2
        '
        Me.prslabShape2.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.prslabShape2.Location = New System.Drawing.Point(26, 167)
        Me.prslabShape2.Name = "prslabShape2"
        Me.prslabShape2.Size = New System.Drawing.Size(130, 22)
        Me.prslabShape2.TabIndex = 44
        Me.prslabShape2.Text = "成型空气2"
        '
        'prslabShape1
        '
        Me.prslabShape1.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.prslabShape1.Location = New System.Drawing.Point(26, 126)
        Me.prslabShape1.Name = "prslabShape1"
        Me.prslabShape1.Size = New System.Drawing.Size(130, 22)
        Me.prslabShape1.TabIndex = 43
        Me.prslabShape1.Text = "成型空气1"
        '
        'prslabflow
        '
        Me.prslabflow.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.prslabflow.Location = New System.Drawing.Point(26, 44)
        Me.prslabflow.Name = "prslabflow"
        Me.prslabflow.Size = New System.Drawing.Size(130, 22)
        Me.prslabflow.TabIndex = 42
        Me.prslabflow.Text = "测试流量"
        '
        'btnSave1
        '
        Me.btnSave1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnSave1.Location = New System.Drawing.Point(71, 403)
        Me.btnSave1.Name = "btnSave1"
        Me.btnSave1.Size = New System.Drawing.Size(118, 37)
        Me.btnSave1.TabIndex = 40
        Me.btnSave1.Text = "Save To XML"
        Me.btnSave1.UseVisualStyleBackColor = True
        '
        'btnSave2
        '
        Me.btnSave2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnSave2.Location = New System.Drawing.Point(71, 457)
        Me.btnSave2.Name = "btnSave2"
        Me.btnSave2.Size = New System.Drawing.Size(118, 37)
        Me.btnSave2.TabIndex = 41
        Me.btnSave2.Text = "Save To PLC"
        Me.btnSave2.UseVisualStyleBackColor = True
        '
        'gbColorChange
        '
        Me.gbColorChange.Controls.Add(Me.lblLineSolvAirOut1)
        Me.gbColorChange.Controls.Add(Me.lblShared00)
        Me.gbColorChange.Controls.Add(Me.lblLineColStk3)
        Me.gbColorChange.Controls.Add(Me.picVersabellGearsPump01)
        Me.gbColorChange.Controls.Add(Me.Label14)
        Me.gbColorChange.Controls.Add(Me.lblLinePF)
        Me.gbColorChange.Controls.Add(Me.lblLineSolvAirOut2)
        Me.gbColorChange.Controls.Add(Me.lblLineDump1)
        Me.gbColorChange.Controls.Add(Me.lblLineColStk4)
        Me.gbColorChange.Controls.Add(Me.lblLineBellMan1)
        Me.gbColorChange.Controls.Add(Me.UctrlSharedValve0)
        Me.gbColorChange.Controls.Add(Me.lblLineColStk5)
        Me.gbColorChange.Controls.Add(Me.lblLineSolvAir2)
        Me.gbColorChange.Controls.Add(Me.lblLineColStk2)
        Me.gbColorChange.Controls.Add(Me.lblLineSolvAir1)
        Me.gbColorChange.Controls.Add(Me.lblLineSolvAirout3)
        Me.gbColorChange.Controls.Add(Me.lblLineBellMan2)
        Me.gbColorChange.Controls.Add(Me.UctrlSharedValve0b)
        Me.gbColorChange.Controls.Add(Me.lblLineSealAir)
        Me.gbColorChange.Controls.Add(Me.lblLineSolvAir)
        Me.gbColorChange.Controls.Add(Me.UctrlGroupValve9)
        Me.gbColorChange.Controls.Add(Me.UctrlGroupValve8)
        Me.gbColorChange.Controls.Add(Me.UctrlGroupValve7)
        Me.gbColorChange.Controls.Add(Me.UctrlGroupValve6)
        Me.gbColorChange.Controls.Add(Me.UctrlGroupValve5)
        Me.gbColorChange.Controls.Add(Me.UctrlGroupValve4)
        Me.gbColorChange.Controls.Add(Me.UctrlGroupValve3)
        Me.gbColorChange.Controls.Add(Me.UctrlGroupValve2)
        Me.gbColorChange.Controls.Add(Me.UctrlGroupValve1)
        Me.gbColorChange.Controls.Add(Me.UctrlSharedValve0a)
        Me.gbColorChange.Controls.Add(Me.lblGroup07)
        Me.gbColorChange.Controls.Add(Me.UctrlGroupValve0)
        Me.gbColorChange.Controls.Add(Me.UctrlSharedValve3)
        Me.gbColorChange.Controls.Add(Me.lblColorHeader2)
        Me.gbColorChange.Controls.Add(Me.lblAirHeaderLine2)
        Me.gbColorChange.Controls.Add(Me.lblLineBW2)
        Me.gbColorChange.Controls.Add(Me.lblLineDump2_2)
        Me.gbColorChange.Controls.Add(Me.lblLineDump2_1)
        Me.gbColorChange.Controls.Add(Me.lblAirHeaderLine3)
        Me.gbColorChange.Controls.Add(Me.lblLineInjector)
        Me.gbColorChange.Controls.Add(Me.lblLineBW1)
        Me.gbColorChange.Controls.Add(Me.lblSolventHeader3)
        Me.gbColorChange.Controls.Add(Me.lblGroup00)
        Me.gbColorChange.Controls.Add(Me.lblDumpTank)
        Me.gbColorChange.Controls.Add(Me.lblGroup04)
        Me.gbColorChange.Controls.Add(Me.lblGroup03)
        Me.gbColorChange.Controls.Add(Me.lblGroup06)
        Me.gbColorChange.Controls.Add(Me.lblGroup05)
        Me.gbColorChange.Controls.Add(Me.lblGroup01)
        Me.gbColorChange.Controls.Add(Me.lblGroup02)
        Me.gbColorChange.Controls.Add(Me.lblShared03)
        Me.gbColorChange.Controls.Add(Me.lblLineColStk1)
        Me.gbColorChange.Controls.Add(Me.lblGroup09)
        Me.gbColorChange.Controls.Add(Me.lblGroup08)
        Me.gbColorChange.Controls.Add(Me.picDumpTank)
        Me.gbColorChange.Controls.Add(Me.lblOutPressure)
        Me.gbColorChange.Controls.Add(Me.lblOutPressureTag)
        Me.gbColorChange.Controls.Add(Me.lblAirHeaderLine1)
        Me.gbColorChange.Controls.Add(Me.lblSolventHeader1)
        Me.gbColorChange.Controls.Add(Me.lblPntHeader01)
        Me.gbColorChange.Controls.Add(Me.lblAirHeader01)
        Me.gbColorChange.Controls.Add(Me.lblSolventHeader2)
        Me.gbColorChange.Controls.Add(Me.lblFlowTag)
        Me.gbColorChange.Location = New System.Drawing.Point(506, 4)
        Me.gbColorChange.Name = "gbColorChange"
        Me.gbColorChange.Size = New System.Drawing.Size(400, 493)
        Me.gbColorChange.TabIndex = 42
        Me.gbColorChange.TabStop = False
        '
        'lblLineSolvAirOut1
        '
        Me.lblLineSolvAirOut1.BackColor = System.Drawing.Color.Black
        Me.lblLineSolvAirOut1.ForeColor = System.Drawing.Color.Black
        Me.lblLineSolvAirOut1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLineSolvAirOut1.Location = New System.Drawing.Point(141, 218)
        Me.lblLineSolvAirOut1.MinimumSize = New System.Drawing.Size(3, 3)
        Me.lblLineSolvAirOut1.Name = "lblLineSolvAirOut1"
        Me.lblLineSolvAirOut1.Size = New System.Drawing.Size(3, 159)
        Me.lblLineSolvAirOut1.TabIndex = 335
        '
        'lblShared00
        '
        Me.lblShared00.BackColor = System.Drawing.Color.Transparent
        Me.lblShared00.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblShared00.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblShared00.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblShared00.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblShared00.Location = New System.Drawing.Point(207, 405)
        Me.lblShared00.Name = "lblShared00"
        Me.lblShared00.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblShared00.Size = New System.Drawing.Size(68, 17)
        Me.lblShared00.TabIndex = 282
        Me.lblShared00.Tag = "0"
        Me.lblShared00.Text = "Trigger"
        Me.lblShared00.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLineColStk3
        '
        Me.lblLineColStk3.BackColor = System.Drawing.Color.Black
        Me.lblLineColStk3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLineColStk3.Location = New System.Drawing.Point(244, 156)
        Me.lblLineColStk3.MinimumSize = New System.Drawing.Size(3, 3)
        Me.lblLineColStk3.Name = "lblLineColStk3"
        Me.lblLineColStk3.Size = New System.Drawing.Size(3, 176)
        Me.lblLineColStk3.TabIndex = 295
        '
        'picVersabellGearsPump01
        '
        Me.picVersabellGearsPump01.Cursor = System.Windows.Forms.Cursors.Default
        Me.picVersabellGearsPump01.Image = CType(resources.GetObject("picVersabellGearsPump01.Image"), System.Drawing.Image)
        Me.picVersabellGearsPump01.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.picVersabellGearsPump01.Location = New System.Drawing.Point(221, 237)
        Me.picVersabellGearsPump01.Name = "picVersabellGearsPump01"
        Me.picVersabellGearsPump01.Size = New System.Drawing.Size(49, 27)
        Me.picVersabellGearsPump01.TabIndex = 330
        Me.picVersabellGearsPump01.TabStop = False
        Me.picVersabellGearsPump01.Tag = "imlGears11"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label14.Location = New System.Drawing.Point(275, 256)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(39, 18)
        Me.Label14.TabIndex = 333
        Me.Label14.Text = "000.0"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblLinePF
        '
        Me.lblLinePF.BackColor = System.Drawing.Color.Black
        Me.lblLinePF.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLinePF.Location = New System.Drawing.Point(194, 247)
        Me.lblLinePF.MinimumSize = New System.Drawing.Size(3, 3)
        Me.lblLinePF.Name = "lblLinePF"
        Me.lblLinePF.Size = New System.Drawing.Size(28, 3)
        Me.lblLinePF.TabIndex = 332
        '
        'lblLineSolvAirOut2
        '
        Me.lblLineSolvAirOut2.BackColor = System.Drawing.Color.Black
        Me.lblLineSolvAirOut2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLineSolvAirOut2.Location = New System.Drawing.Point(143, 247)
        Me.lblLineSolvAirOut2.MinimumSize = New System.Drawing.Size(3, 3)
        Me.lblLineSolvAirOut2.Name = "lblLineSolvAirOut2"
        Me.lblLineSolvAirOut2.Size = New System.Drawing.Size(20, 3)
        Me.lblLineSolvAirOut2.TabIndex = 331
        '
        'lblLineDump1
        '
        Me.lblLineDump1.BackColor = System.Drawing.Color.Black
        Me.lblLineDump1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLineDump1.Location = New System.Drawing.Point(325, 305)
        Me.lblLineDump1.MinimumSize = New System.Drawing.Size(3, 3)
        Me.lblLineDump1.Name = "lblLineDump1"
        Me.lblLineDump1.Size = New System.Drawing.Size(3, 145)
        Me.lblLineDump1.TabIndex = 303
        '
        'lblLineColStk4
        '
        Me.lblLineColStk4.BackColor = System.Drawing.Color.Black
        Me.lblLineColStk4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLineColStk4.Location = New System.Drawing.Point(247, 302)
        Me.lblLineColStk4.MinimumSize = New System.Drawing.Size(3, 3)
        Me.lblLineColStk4.Name = "lblLineColStk4"
        Me.lblLineColStk4.Size = New System.Drawing.Size(50, 3)
        Me.lblLineColStk4.TabIndex = 329
        '
        'lblLineBellMan1
        '
        Me.lblLineBellMan1.BackColor = System.Drawing.Color.Black
        Me.lblLineBellMan1.ForeColor = System.Drawing.Color.Black
        Me.lblLineBellMan1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLineBellMan1.Location = New System.Drawing.Point(201, 357)
        Me.lblLineBellMan1.MinimumSize = New System.Drawing.Size(3, 3)
        Me.lblLineBellMan1.Name = "lblLineBellMan1"
        Me.lblLineBellMan1.Size = New System.Drawing.Size(46, 3)
        Me.lblLineBellMan1.TabIndex = 328
        '
        'lblLineColStk5
        '
        Me.lblLineColStk5.BackColor = System.Drawing.Color.Black
        Me.lblLineColStk5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLineColStk5.ForeColor = System.Drawing.Color.Black
        Me.lblLineColStk5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLineColStk5.Location = New System.Drawing.Point(244, 185)
        Me.lblLineColStk5.MinimumSize = New System.Drawing.Size(3, 3)
        Me.lblLineColStk5.Name = "lblLineColStk5"
        Me.lblLineColStk5.Size = New System.Drawing.Size(10, 3)
        Me.lblLineColStk5.TabIndex = 327
        '
        'lblLineSolvAir2
        '
        Me.lblLineSolvAir2.BackColor = System.Drawing.Color.Black
        Me.lblLineSolvAir2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLineSolvAir2.Location = New System.Drawing.Point(205, 101)
        Me.lblLineSolvAir2.MinimumSize = New System.Drawing.Size(3, 3)
        Me.lblLineSolvAir2.Name = "lblLineSolvAir2"
        Me.lblLineSolvAir2.Size = New System.Drawing.Size(3, 24)
        Me.lblLineSolvAir2.TabIndex = 326
        '
        'lblLineColStk2
        '
        Me.lblLineColStk2.BackColor = System.Drawing.Color.Black
        Me.lblLineColStk2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLineColStk2.Location = New System.Drawing.Point(205, 156)
        Me.lblLineColStk2.MinimumSize = New System.Drawing.Size(3, 3)
        Me.lblLineColStk2.Name = "lblLineColStk2"
        Me.lblLineColStk2.Size = New System.Drawing.Size(69, 3)
        Me.lblLineColStk2.TabIndex = 298
        '
        'lblLineSolvAir1
        '
        Me.lblLineSolvAir1.BackColor = System.Drawing.Color.Black
        Me.lblLineSolvAir1.ForeColor = System.Drawing.Color.Black
        Me.lblLineSolvAir1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLineSolvAir1.Location = New System.Drawing.Point(143, 98)
        Me.lblLineSolvAir1.MinimumSize = New System.Drawing.Size(3, 3)
        Me.lblLineSolvAir1.Name = "lblLineSolvAir1"
        Me.lblLineSolvAir1.Size = New System.Drawing.Size(65, 3)
        Me.lblLineSolvAir1.TabIndex = 325
        '
        'lblLineSolvAirout3
        '
        Me.lblLineSolvAirout3.BackColor = System.Drawing.Color.Black
        Me.lblLineSolvAirout3.ForeColor = System.Drawing.Color.Black
        Me.lblLineSolvAirout3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLineSolvAirout3.Location = New System.Drawing.Point(143, 357)
        Me.lblLineSolvAirout3.MinimumSize = New System.Drawing.Size(3, 3)
        Me.lblLineSolvAirout3.Name = "lblLineSolvAirout3"
        Me.lblLineSolvAirout3.Size = New System.Drawing.Size(26, 3)
        Me.lblLineSolvAirout3.TabIndex = 324
        '
        'lblLineBellMan2
        '
        Me.lblLineBellMan2.BackColor = System.Drawing.Color.Black
        Me.lblLineBellMan2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLineBellMan2.Location = New System.Drawing.Point(198, 358)
        Me.lblLineBellMan2.MinimumSize = New System.Drawing.Size(3, 3)
        Me.lblLineBellMan2.Name = "lblLineBellMan2"
        Me.lblLineBellMan2.Size = New System.Drawing.Size(3, 32)
        Me.lblLineBellMan2.TabIndex = 305
        '
        'lblLineSealAir
        '
        Me.lblLineSealAir.BackColor = System.Drawing.Color.Black
        Me.lblLineSealAir.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLineSealAir.Location = New System.Drawing.Point(103, 348)
        Me.lblLineSealAir.MinimumSize = New System.Drawing.Size(3, 3)
        Me.lblLineSealAir.Name = "lblLineSealAir"
        Me.lblLineSealAir.Size = New System.Drawing.Size(3, 18)
        Me.lblLineSealAir.TabIndex = 307
        '
        'lblLineSolvAir
        '
        Me.lblLineSolvAir.BackColor = System.Drawing.Color.Black
        Me.lblLineSolvAir.ForeColor = System.Drawing.Color.Black
        Me.lblLineSolvAir.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLineSolvAir.Location = New System.Drawing.Point(141, 98)
        Me.lblLineSolvAir.MinimumSize = New System.Drawing.Size(3, 3)
        Me.lblLineSolvAir.Name = "lblLineSolvAir"
        Me.lblLineSolvAir.Size = New System.Drawing.Size(3, 120)
        Me.lblLineSolvAir.TabIndex = 296
        '
        'lblGroup07
        '
        Me.lblGroup07.BackColor = System.Drawing.Color.Transparent
        Me.lblGroup07.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblGroup07.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblGroup07.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblGroup07.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGroup07.Location = New System.Drawing.Point(150, 203)
        Me.lblGroup07.Name = "lblGroup07"
        Me.lblGroup07.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblGroup07.Size = New System.Drawing.Size(57, 20)
        Me.lblGroup07.TabIndex = 312
        Me.lblGroup07.Text = "Flush"
        Me.lblGroup07.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblColorHeader2
        '
        Me.lblColorHeader2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblColorHeader2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColorHeader2.Location = New System.Drawing.Point(271, 25)
        Me.lblColorHeader2.Name = "lblColorHeader2"
        Me.lblColorHeader2.Size = New System.Drawing.Size(3, 51)
        Me.lblColorHeader2.TabIndex = 301
        '
        'lblAirHeaderLine2
        '
        Me.lblAirHeaderLine2.BackColor = System.Drawing.Color.Blue
        Me.lblAirHeaderLine2.ForeColor = System.Drawing.Color.Black
        Me.lblAirHeaderLine2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAirHeaderLine2.Location = New System.Drawing.Point(56, 348)
        Me.lblAirHeaderLine2.MinimumSize = New System.Drawing.Size(3, 3)
        Me.lblAirHeaderLine2.Name = "lblAirHeaderLine2"
        Me.lblAirHeaderLine2.Size = New System.Drawing.Size(18, 3)
        Me.lblAirHeaderLine2.TabIndex = 306
        Me.lblAirHeaderLine2.Text = "_linAirHeader_40"
        '
        'lblLineBW2
        '
        Me.lblLineBW2.BackColor = System.Drawing.Color.Black
        Me.lblLineBW2.ForeColor = System.Drawing.Color.Black
        Me.lblLineBW2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLineBW2.Location = New System.Drawing.Point(143, 437)
        Me.lblLineBW2.MinimumSize = New System.Drawing.Size(3, 3)
        Me.lblLineBW2.Name = "lblLineBW2"
        Me.lblLineBW2.Size = New System.Drawing.Size(19, 3)
        Me.lblLineBW2.TabIndex = 302
        '
        'lblLineDump2_2
        '
        Me.lblLineDump2_2.BackColor = System.Drawing.Color.Black
        Me.lblLineDump2_2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLineDump2_2.Location = New System.Drawing.Point(337, 186)
        Me.lblLineDump2_2.MinimumSize = New System.Drawing.Size(3, 3)
        Me.lblLineDump2_2.Name = "lblLineDump2_2"
        Me.lblLineDump2_2.Size = New System.Drawing.Size(3, 263)
        Me.lblLineDump2_2.TabIndex = 292
        '
        'lblLineDump2_1
        '
        Me.lblLineDump2_1.BackColor = System.Drawing.Color.Black
        Me.lblLineDump2_1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLineDump2_1.Location = New System.Drawing.Point(278, 185)
        Me.lblLineDump2_1.MinimumSize = New System.Drawing.Size(3, 3)
        Me.lblLineDump2_1.Name = "lblLineDump2_1"
        Me.lblLineDump2_1.Size = New System.Drawing.Size(60, 3)
        Me.lblLineDump2_1.TabIndex = 293
        '
        'lblAirHeaderLine3
        '
        Me.lblAirHeaderLine3.BackColor = System.Drawing.Color.Blue
        Me.lblAirHeaderLine3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAirHeaderLine3.Location = New System.Drawing.Point(56, 98)
        Me.lblAirHeaderLine3.MinimumSize = New System.Drawing.Size(3, 3)
        Me.lblAirHeaderLine3.Name = "lblAirHeaderLine3"
        Me.lblAirHeaderLine3.Size = New System.Drawing.Size(57, 3)
        Me.lblAirHeaderLine3.TabIndex = 294
        '
        'lblLineInjector
        '
        Me.lblLineInjector.BackColor = System.Drawing.Color.Black
        Me.lblLineInjector.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLineInjector.Location = New System.Drawing.Point(198, 411)
        Me.lblLineInjector.MinimumSize = New System.Drawing.Size(3, 3)
        Me.lblLineInjector.Name = "lblLineInjector"
        Me.lblLineInjector.Size = New System.Drawing.Size(3, 23)
        Me.lblLineInjector.TabIndex = 297
        '
        'lblLineBW1
        '
        Me.lblLineBW1.BackColor = System.Drawing.Color.Black
        Me.lblLineBW1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLineBW1.Location = New System.Drawing.Point(141, 406)
        Me.lblLineBW1.MinimumSize = New System.Drawing.Size(3, 3)
        Me.lblLineBW1.Name = "lblLineBW1"
        Me.lblLineBW1.Size = New System.Drawing.Size(3, 34)
        Me.lblLineBW1.TabIndex = 299
        '
        'lblSolventHeader3
        '
        Me.lblSolventHeader3.BackColor = System.Drawing.Color.Red
        Me.lblSolventHeader3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSolventHeader3.Location = New System.Drawing.Point(47, 155)
        Me.lblSolventHeader3.MinimumSize = New System.Drawing.Size(3, 3)
        Me.lblSolventHeader3.Name = "lblSolventHeader3"
        Me.lblSolventHeader3.Size = New System.Drawing.Size(65, 3)
        Me.lblSolventHeader3.TabIndex = 300
        '
        'lblGroup00
        '
        Me.lblGroup00.BackColor = System.Drawing.Color.Transparent
        Me.lblGroup00.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblGroup00.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblGroup00.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblGroup00.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGroup00.Location = New System.Drawing.Point(250, 337)
        Me.lblGroup00.Name = "lblGroup00"
        Me.lblGroup00.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblGroup00.Size = New System.Drawing.Size(47, 29)
        Me.lblGroup00.TabIndex = 291
        Me.lblGroup00.Text = "Paint Enb"
        Me.lblGroup00.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDumpTank
        '
        Me.lblDumpTank.BackColor = System.Drawing.Color.Transparent
        Me.lblDumpTank.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDumpTank.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblDumpTank.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDumpTank.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDumpTank.Location = New System.Drawing.Point(244, 448)
        Me.lblDumpTank.Name = "lblDumpTank"
        Me.lblDumpTank.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDumpTank.Size = New System.Drawing.Size(57, 29)
        Me.lblDumpTank.TabIndex = 290
        Me.lblDumpTank.Text = "Waste Recovery"
        Me.lblDumpTank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGroup04
        '
        Me.lblGroup04.BackColor = System.Drawing.Color.Transparent
        Me.lblGroup04.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblGroup04.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblGroup04.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblGroup04.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGroup04.Location = New System.Drawing.Point(71, 69)
        Me.lblGroup04.Name = "lblGroup04"
        Me.lblGroup04.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblGroup04.Size = New System.Drawing.Size(40, 29)
        Me.lblGroup04.TabIndex = 289
        Me.lblGroup04.Text = "Purge Air"
        Me.lblGroup04.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGroup03
        '
        Me.lblGroup03.BackColor = System.Drawing.Color.Transparent
        Me.lblGroup03.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblGroup03.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblGroup03.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblGroup03.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGroup03.Location = New System.Drawing.Point(59, 121)
        Me.lblGroup03.Name = "lblGroup03"
        Me.lblGroup03.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblGroup03.Size = New System.Drawing.Size(53, 31)
        Me.lblGroup03.TabIndex = 288
        Me.lblGroup03.Text = "Purge Solvent"
        Me.lblGroup03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGroup06
        '
        Me.lblGroup06.BackColor = System.Drawing.Color.Transparent
        Me.lblGroup06.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblGroup06.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblGroup06.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblGroup06.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGroup06.Location = New System.Drawing.Point(266, 309)
        Me.lblGroup06.Name = "lblGroup06"
        Me.lblGroup06.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblGroup06.Size = New System.Drawing.Size(56, 26)
        Me.lblGroup06.TabIndex = 287
        Me.lblGroup06.Text = "Dump"
        Me.lblGroup06.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGroup05
        '
        Me.lblGroup05.BackColor = System.Drawing.Color.Transparent
        Me.lblGroup05.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblGroup05.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblGroup05.ForeColor = System.Drawing.Color.Black
        Me.lblGroup05.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGroup05.Location = New System.Drawing.Point(212, 126)
        Me.lblGroup05.Name = "lblGroup05"
        Me.lblGroup05.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblGroup05.Size = New System.Drawing.Size(53, 21)
        Me.lblGroup05.TabIndex = 286
        Me.lblGroup05.Text = "pCC "
        Me.lblGroup05.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGroup01
        '
        Me.lblGroup01.BackColor = System.Drawing.Color.Transparent
        Me.lblGroup01.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblGroup01.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblGroup01.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblGroup01.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGroup01.Location = New System.Drawing.Point(165, 302)
        Me.lblGroup01.Name = "lblGroup01"
        Me.lblGroup01.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblGroup01.Size = New System.Drawing.Size(49, 30)
        Me.lblGroup01.TabIndex = 285
        Me.lblGroup01.Text = "Injector Wash"
        Me.lblGroup01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGroup02
        '
        Me.lblGroup02.BackColor = System.Drawing.Color.Transparent
        Me.lblGroup02.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblGroup02.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblGroup02.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblGroup02.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGroup02.Location = New System.Drawing.Point(76, 382)
        Me.lblGroup02.Name = "lblGroup02"
        Me.lblGroup02.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblGroup02.Size = New System.Drawing.Size(47, 29)
        Me.lblGroup02.TabIndex = 284
        Me.lblGroup02.Text = "Bell Wash"
        Me.lblGroup02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblShared03
        '
        Me.lblShared03.BackColor = System.Drawing.Color.Transparent
        Me.lblShared03.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblShared03.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblShared03.ForeColor = System.Drawing.Color.Black
        Me.lblShared03.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblShared03.Location = New System.Drawing.Point(280, 72)
        Me.lblShared03.Name = "lblShared03"
        Me.lblShared03.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblShared03.Size = New System.Drawing.Size(55, 28)
        Me.lblShared03.TabIndex = 283
        Me.lblShared03.Text = "Color Enable"
        Me.lblShared03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLineColStk1
        '
        Me.lblLineColStk1.BackColor = System.Drawing.Color.Black
        Me.lblLineColStk1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLineColStk1.Location = New System.Drawing.Point(271, 97)
        Me.lblLineColStk1.MinimumSize = New System.Drawing.Size(3, 3)
        Me.lblLineColStk1.Name = "lblLineColStk1"
        Me.lblLineColStk1.Size = New System.Drawing.Size(3, 60)
        Me.lblLineColStk1.TabIndex = 304
        '
        'lblGroup09
        '
        Me.lblGroup09.BackColor = System.Drawing.Color.Transparent
        Me.lblGroup09.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblGroup09.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblGroup09.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblGroup09.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGroup09.Location = New System.Drawing.Point(280, 162)
        Me.lblGroup09.Name = "lblGroup09"
        Me.lblGroup09.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblGroup09.Size = New System.Drawing.Size(65, 23)
        Me.lblGroup09.TabIndex = 281
        Me.lblGroup09.Text = "Dump2"
        Me.lblGroup09.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGroup08
        '
        Me.lblGroup08.BackColor = System.Drawing.Color.Transparent
        Me.lblGroup08.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblGroup08.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblGroup08.ForeColor = System.Drawing.Color.Black
        Me.lblGroup08.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGroup08.Location = New System.Drawing.Point(65, 292)
        Me.lblGroup08.Name = "lblGroup08"
        Me.lblGroup08.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblGroup08.Size = New System.Drawing.Size(41, 29)
        Me.lblGroup08.TabIndex = 280
        Me.lblGroup08.Text = "Seal Air"
        Me.lblGroup08.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picDumpTank
        '
        Me.picDumpTank.Cursor = System.Windows.Forms.Cursors.Default
        Me.picDumpTank.Image = CType(resources.GetObject("picDumpTank.Image"), System.Drawing.Image)
        Me.picDumpTank.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.picDumpTank.Location = New System.Drawing.Point(306, 440)
        Me.picDumpTank.Name = "picDumpTank"
        Me.picDumpTank.Size = New System.Drawing.Size(41, 43)
        Me.picDumpTank.TabIndex = 308
        Me.picDumpTank.TabStop = False
        '
        'lblOutPressure
        '
        Me.lblOutPressure.BackColor = System.Drawing.SystemColors.Control
        Me.lblOutPressure.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutPressure.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblOutPressure.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblOutPressure.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblOutPressure.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblOutPressure.Location = New System.Drawing.Point(202, 273)
        Me.lblOutPressure.Name = "lblOutPressure"
        Me.lblOutPressure.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblOutPressure.Size = New System.Drawing.Size(39, 18)
        Me.lblOutPressure.TabIndex = 279
        Me.lblOutPressure.Text = "000.0"
        Me.lblOutPressure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOutPressureTag
        '
        Me.lblOutPressureTag.BackColor = System.Drawing.Color.Transparent
        Me.lblOutPressureTag.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblOutPressureTag.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblOutPressureTag.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblOutPressureTag.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblOutPressureTag.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblOutPressureTag.Location = New System.Drawing.Point(150, 261)
        Me.lblOutPressureTag.Name = "lblOutPressureTag"
        Me.lblOutPressureTag.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblOutPressureTag.Size = New System.Drawing.Size(54, 43)
        Me.lblOutPressureTag.TabIndex = 278
        Me.lblOutPressureTag.Text = "Outlet Pressure  (psi)"
        Me.lblOutPressureTag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAirHeaderLine1
        '
        Me.lblAirHeaderLine1.BackColor = System.Drawing.Color.Blue
        Me.lblAirHeaderLine1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAirHeaderLine1.Location = New System.Drawing.Point(54, 41)
        Me.lblAirHeaderLine1.MinimumSize = New System.Drawing.Size(3, 3)
        Me.lblAirHeaderLine1.Name = "lblAirHeaderLine1"
        Me.lblAirHeaderLine1.Size = New System.Drawing.Size(3, 313)
        Me.lblAirHeaderLine1.TabIndex = 273
        '
        'lblSolventHeader1
        '
        Me.lblSolventHeader1.BackColor = System.Drawing.Color.Red
        Me.lblSolventHeader1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblSolventHeader1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblSolventHeader1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSolventHeader1.Location = New System.Drawing.Point(43, 51)
        Me.lblSolventHeader1.Name = "lblSolventHeader1"
        Me.lblSolventHeader1.Size = New System.Drawing.Size(314, 15)
        Me.lblSolventHeader1.TabIndex = 275
        Me.lblSolventHeader1.Text = "Purge Solvent"
        Me.lblSolventHeader1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPntHeader01
        '
        Me.lblPntHeader01.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPntHeader01.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblPntHeader01.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPntHeader01.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPntHeader01.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPntHeader01.Location = New System.Drawing.Point(43, 11)
        Me.lblPntHeader01.Name = "lblPntHeader01"
        Me.lblPntHeader01.Size = New System.Drawing.Size(314, 19)
        Me.lblPntHeader01.TabIndex = 276
        Me.lblPntHeader01.Text = "Paint"
        Me.lblPntHeader01.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblAirHeader01
        '
        Me.lblAirHeader01.BackColor = System.Drawing.Color.Blue
        Me.lblAirHeader01.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblAirHeader01.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblAirHeader01.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAirHeader01.Location = New System.Drawing.Point(43, 33)
        Me.lblAirHeader01.Name = "lblAirHeader01"
        Me.lblAirHeader01.Size = New System.Drawing.Size(314, 14)
        Me.lblAirHeader01.TabIndex = 277
        Me.lblAirHeader01.Text = "Purge Air"
        Me.lblAirHeader01.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblSolventHeader2
        '
        Me.lblSolventHeader2.BackColor = System.Drawing.Color.Red
        Me.lblSolventHeader2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSolventHeader2.Location = New System.Drawing.Point(47, 57)
        Me.lblSolventHeader2.MinimumSize = New System.Drawing.Size(3, 3)
        Me.lblSolventHeader2.Name = "lblSolventHeader2"
        Me.lblSolventHeader2.Size = New System.Drawing.Size(3, 106)
        Me.lblSolventHeader2.TabIndex = 274
        '
        'lblFlowTag
        '
        Me.lblFlowTag.BackColor = System.Drawing.Color.Transparent
        Me.lblFlowTag.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFlowTag.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblFlowTag.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFlowTag.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFlowTag.Location = New System.Drawing.Point(266, 202)
        Me.lblFlowTag.Name = "lblFlowTag"
        Me.lblFlowTag.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFlowTag.Size = New System.Drawing.Size(72, 47)
        Me.lblFlowTag.TabIndex = 334
        Me.lblFlowTag.Text = "Commanded Flow Rate (cc/min)"
        Me.lblFlowTag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblParameters
        '
        Me.lblParameters.Font = New System.Drawing.Font("Microsoft YaHei", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblParameters.Location = New System.Drawing.Point(96, -4)
        Me.lblParameters.Name = "lblParameters"
        Me.lblParameters.Size = New System.Drawing.Size(306, 59)
        Me.lblParameters.TabIndex = 43
        Me.lblParameters.Text = "Parameters"
        '
        'UctrlSharedValve0
        '
        Me.UctrlSharedValve0.AutoFit = True
        Me.UctrlSharedValve0.Location = New System.Drawing.Point(192, 379)
        Me.UctrlSharedValve0.Name = "UctrlSharedValve0"
        Me.UctrlSharedValve0.Size = New System.Drawing.Size(32, 32)
        Me.UctrlSharedValve0.TabIndex = 323
        Me.UctrlSharedValve0.Tag = "0"
        Me.UctrlSharedValve0.ValveColor = ColorChangeTest.uctrlValve.eValveColor.Green
        Me.UctrlSharedValve0.ValveType = ColorChangeTest.uctrlValve.eValveType.HorzRight
        Me.UctrlSharedValve0.ValvState = False
        '
        'UctrlSharedValve0b
        '
        Me.UctrlSharedValve0b.AutoFit = True
        Me.UctrlSharedValve0b.Location = New System.Drawing.Point(168, 434)
        Me.UctrlSharedValve0b.Name = "UctrlSharedValve0b"
        Me.UctrlSharedValve0b.Size = New System.Drawing.Size(63, 35)
        Me.UctrlSharedValve0b.TabIndex = 309
        Me.UctrlSharedValve0b.Tag = "0"
        Me.UctrlSharedValve0b.ValveColor = ColorChangeTest.uctrlValve.eValveColor.Green
        Me.UctrlSharedValve0b.ValveType = ColorChangeTest.uctrlValve.eValveType.BellCup
        Me.UctrlSharedValve0b.ValvState = False
        '
        'UctrlGroupValve9
        '
        Me.UctrlGroupValve9.AutoFit = True
        Me.UctrlGroupValve9.Location = New System.Drawing.Point(252, 162)
        Me.UctrlGroupValve9.Name = "UctrlGroupValve9"
        Me.UctrlGroupValve9.Size = New System.Drawing.Size(32, 32)
        Me.UctrlGroupValve9.TabIndex = 322
        Me.UctrlGroupValve9.Tag = "9"
        Me.UctrlGroupValve9.ValveColor = ColorChangeTest.uctrlValve.eValveColor.Green
        Me.UctrlGroupValve9.ValveType = ColorChangeTest.uctrlValve.eValveType.VertRight
        Me.UctrlGroupValve9.ValvState = False
        '
        'UctrlGroupValve8
        '
        Me.UctrlGroupValve8.AutoFit = True
        Me.UctrlGroupValve8.Location = New System.Drawing.Point(74, 324)
        Me.UctrlGroupValve8.Name = "UctrlGroupValve8"
        Me.UctrlGroupValve8.Size = New System.Drawing.Size(32, 32)
        Me.UctrlGroupValve8.TabIndex = 321
        Me.UctrlGroupValve8.Tag = "8"
        Me.UctrlGroupValve8.ValveColor = ColorChangeTest.uctrlValve.eValveColor.Green
        Me.UctrlGroupValve8.ValveType = ColorChangeTest.uctrlValve.eValveType.VertRight
        Me.UctrlGroupValve8.ValvState = False
        '
        'UctrlGroupValve7
        '
        Me.UctrlGroupValve7.AutoFit = True
        Me.UctrlGroupValve7.Location = New System.Drawing.Point(163, 224)
        Me.UctrlGroupValve7.Name = "UctrlGroupValve7"
        Me.UctrlGroupValve7.Size = New System.Drawing.Size(32, 32)
        Me.UctrlGroupValve7.TabIndex = 320
        Me.UctrlGroupValve7.Tag = "7"
        Me.UctrlGroupValve7.ValveColor = ColorChangeTest.uctrlValve.eValveColor.Green
        Me.UctrlGroupValve7.ValveType = ColorChangeTest.uctrlValve.eValveType.VertRight
        Me.UctrlGroupValve7.ValvState = False
        '
        'UctrlGroupValve6
        '
        Me.UctrlGroupValve6.AutoFit = True
        Me.UctrlGroupValve6.Location = New System.Drawing.Point(296, 280)
        Me.UctrlGroupValve6.Name = "UctrlGroupValve6"
        Me.UctrlGroupValve6.Size = New System.Drawing.Size(32, 32)
        Me.UctrlGroupValve6.TabIndex = 319
        Me.UctrlGroupValve6.Tag = "6"
        Me.UctrlGroupValve6.ValveColor = ColorChangeTest.uctrlValve.eValveColor.Green
        Me.UctrlGroupValve6.ValveType = ColorChangeTest.uctrlValve.eValveType.VertRight
        Me.UctrlGroupValve6.ValvState = False
        '
        'UctrlGroupValve5
        '
        Me.UctrlGroupValve5.AutoFit = True
        Me.UctrlGroupValve5.Location = New System.Drawing.Point(182, 125)
        Me.UctrlGroupValve5.Name = "UctrlGroupValve5"
        Me.UctrlGroupValve5.Size = New System.Drawing.Size(32, 32)
        Me.UctrlGroupValve5.TabIndex = 318
        Me.UctrlGroupValve5.Tag = "5"
        Me.UctrlGroupValve5.ValveColor = ColorChangeTest.uctrlValve.eValveColor.Green
        Me.UctrlGroupValve5.ValveType = ColorChangeTest.uctrlValve.eValveType.HorzLeft
        Me.UctrlGroupValve5.ValvState = False
        '
        'UctrlGroupValve4
        '
        Me.UctrlGroupValve4.AutoFit = True
        Me.UctrlGroupValve4.Location = New System.Drawing.Point(112, 75)
        Me.UctrlGroupValve4.Name = "UctrlGroupValve4"
        Me.UctrlGroupValve4.Size = New System.Drawing.Size(32, 32)
        Me.UctrlGroupValve4.TabIndex = 317
        Me.UctrlGroupValve4.Tag = "4"
        Me.UctrlGroupValve4.ValveColor = ColorChangeTest.uctrlValve.eValveColor.Green
        Me.UctrlGroupValve4.ValveType = ColorChangeTest.uctrlValve.eValveType.VertRight
        Me.UctrlGroupValve4.ValvState = False
        '
        'UctrlGroupValve3
        '
        Me.UctrlGroupValve3.AutoFit = True
        Me.UctrlGroupValve3.Location = New System.Drawing.Point(112, 131)
        Me.UctrlGroupValve3.Name = "UctrlGroupValve3"
        Me.UctrlGroupValve3.Size = New System.Drawing.Size(32, 32)
        Me.UctrlGroupValve3.TabIndex = 316
        Me.UctrlGroupValve3.Tag = "3"
        Me.UctrlGroupValve3.ValveColor = ColorChangeTest.uctrlValve.eValveColor.Green
        Me.UctrlGroupValve3.ValveType = ColorChangeTest.uctrlValve.eValveType.VertRight
        Me.UctrlGroupValve3.ValvState = False
        '
        'UctrlGroupValve2
        '
        Me.UctrlGroupValve2.AutoFit = True
        Me.UctrlGroupValve2.Location = New System.Drawing.Point(118, 376)
        Me.UctrlGroupValve2.Name = "UctrlGroupValve2"
        Me.UctrlGroupValve2.Size = New System.Drawing.Size(32, 32)
        Me.UctrlGroupValve2.TabIndex = 315
        Me.UctrlGroupValve2.Tag = "2"
        Me.UctrlGroupValve2.ValveColor = ColorChangeTest.uctrlValve.eValveColor.Green
        Me.UctrlGroupValve2.ValveType = ColorChangeTest.uctrlValve.eValveType.HorzLeft
        Me.UctrlGroupValve2.ValvState = False
        '
        'UctrlGroupValve1
        '
        Me.UctrlGroupValve1.AutoFit = True
        Me.UctrlGroupValve1.Location = New System.Drawing.Point(168, 334)
        Me.UctrlGroupValve1.Name = "UctrlGroupValve1"
        Me.UctrlGroupValve1.Size = New System.Drawing.Size(32, 32)
        Me.UctrlGroupValve1.TabIndex = 314
        Me.UctrlGroupValve1.Tag = "1"
        Me.UctrlGroupValve1.ValveColor = ColorChangeTest.uctrlValve.eValveColor.Green
        Me.UctrlGroupValve1.ValveType = ColorChangeTest.uctrlValve.eValveType.VertRight
        Me.UctrlGroupValve1.ValvState = False
        '
        'UctrlSharedValve0a
        '
        Me.UctrlSharedValve0a.AutoFit = True
        Me.UctrlSharedValve0a.Location = New System.Drawing.Point(157, 470)
        Me.UctrlSharedValve0a.Name = "UctrlSharedValve0a"
        Me.UctrlSharedValve0a.Size = New System.Drawing.Size(85, 45)
        Me.UctrlSharedValve0a.TabIndex = 313
        Me.UctrlSharedValve0a.ValveColor = ColorChangeTest.uctrlValve.eValveColor.Green
        Me.UctrlSharedValve0a.ValveType = ColorChangeTest.uctrlValve.eValveType.SprayPattern
        Me.UctrlSharedValve0a.ValvState = False
        '
        'UctrlGroupValve0
        '
        Me.UctrlGroupValve0.AutoFit = True
        Me.UctrlGroupValve0.Location = New System.Drawing.Point(221, 328)
        Me.UctrlGroupValve0.Name = "UctrlGroupValve0"
        Me.UctrlGroupValve0.Size = New System.Drawing.Size(32, 32)
        Me.UctrlGroupValve0.TabIndex = 311
        Me.UctrlGroupValve0.Tag = "0"
        Me.UctrlGroupValve0.ValveColor = ColorChangeTest.uctrlValve.eValveColor.Green
        Me.UctrlGroupValve0.ValveType = ColorChangeTest.uctrlValve.eValveType.HorzLeft
        Me.UctrlGroupValve0.ValvState = False
        '
        'UctrlSharedValve3
        '
        Me.UctrlSharedValve3.AutoFit = True
        Me.UctrlSharedValve3.Location = New System.Drawing.Point(248, 72)
        Me.UctrlSharedValve3.Name = "UctrlSharedValve3"
        Me.UctrlSharedValve3.Size = New System.Drawing.Size(32, 32)
        Me.UctrlSharedValve3.TabIndex = 310
        Me.UctrlSharedValve3.Tag = "3"
        Me.UctrlSharedValve3.ValveColor = ColorChangeTest.uctrlValve.eValveColor.Green
        Me.UctrlSharedValve3.ValveType = ColorChangeTest.uctrlValve.eValveType.HorzLeft
        Me.UctrlSharedValve3.ValvState = False
        '
        'FRMParameters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 519)
        Me.Controls.Add(Me.lblParameters)
        Me.Controls.Add(Me.gbColorChange)
        Me.Controls.Add(Me.btnSave2)
        Me.Controls.Add(Me.btnSave1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LabStep)
        Me.Controls.Add(Me.ValveBOX)
        Me.Controls.Add(Me.LabCycle)
        Me.Controls.Add(Me.StepList)
        Me.Controls.Add(Me.Cycle)
        Me.Name = "FRMParameters"
        Me.Text = "Parameters"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbColorChange.ResumeLayout(False)
        CType(Me.picVersabellGearsPump01, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDumpTank, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents parflow As FocusedTextBox.FocusedTextBox
    Friend WithEvents parSpeed As FocusedTextBox.FocusedTextBox
    Friend WithEvents prsShape2 As FocusedTextBox.FocusedTextBox
    Friend WithEvents parShape1 As FocusedTextBox.FocusedTextBox
    Friend WithEvents prsTime As FocusedTextBox.FocusedTextBox
    Friend WithEvents Cycle As System.Windows.Forms.ComboBox
    Friend WithEvents StepList As System.Windows.Forms.ComboBox
    Friend WithEvents LabCycle As System.Windows.Forms.Label
    Friend WithEvents ValveBOX As System.Windows.Forms.CheckedListBox
    Friend WithEvents LabStep As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSave1 As System.Windows.Forms.Button
    Friend WithEvents btnSave2 As System.Windows.Forms.Button
    Friend WithEvents prslabSpeed As System.Windows.Forms.Label
    Friend WithEvents prslabTime As System.Windows.Forms.Label
    Friend WithEvents prslabShape2 As System.Windows.Forms.Label
    Friend WithEvents prslabShape1 As System.Windows.Forms.Label
    Friend WithEvents prslabflow As System.Windows.Forms.Label
    Friend WithEvents gbColorChange As System.Windows.Forms.GroupBox
    Private WithEvents lblLineSolvAirOut1 As System.Windows.Forms.Label
    Private WithEvents lblShared00 As System.Windows.Forms.Label
    Private WithEvents lblLineColStk3 As System.Windows.Forms.Label
    Private WithEvents picVersabellGearsPump01 As System.Windows.Forms.PictureBox
    Private WithEvents Label14 As System.Windows.Forms.Label
    Private WithEvents lblLinePF As System.Windows.Forms.Label
    Private WithEvents lblLineSolvAirOut2 As System.Windows.Forms.Label
    Private WithEvents lblLineDump1 As System.Windows.Forms.Label
    Private WithEvents lblLineColStk4 As System.Windows.Forms.Label
    Private WithEvents lblLineBellMan1 As System.Windows.Forms.Label
    Private WithEvents UctrlSharedValve0 As ColorChangeTest.uctrlValve
    Private WithEvents lblLineColStk5 As System.Windows.Forms.Label
    Private WithEvents lblLineSolvAir2 As System.Windows.Forms.Label
    Private WithEvents lblLineColStk2 As System.Windows.Forms.Label
    Private WithEvents lblLineSolvAir1 As System.Windows.Forms.Label
    Private WithEvents lblLineSolvAirout3 As System.Windows.Forms.Label
    Private WithEvents lblLineBellMan2 As System.Windows.Forms.Label
    Private WithEvents UctrlSharedValve0b As ColorChangeTest.uctrlValve
    Private WithEvents lblLineSealAir As System.Windows.Forms.Label
    Private WithEvents lblLineSolvAir As System.Windows.Forms.Label
    Private WithEvents UctrlGroupValve9 As ColorChangeTest.uctrlValve
    Private WithEvents UctrlGroupValve8 As ColorChangeTest.uctrlValve
    Private WithEvents UctrlGroupValve7 As ColorChangeTest.uctrlValve
    Private WithEvents UctrlGroupValve6 As ColorChangeTest.uctrlValve
    Private WithEvents UctrlGroupValve5 As ColorChangeTest.uctrlValve
    Private WithEvents UctrlGroupValve4 As ColorChangeTest.uctrlValve
    Private WithEvents UctrlGroupValve3 As ColorChangeTest.uctrlValve
    Private WithEvents UctrlGroupValve2 As ColorChangeTest.uctrlValve
    Private WithEvents UctrlGroupValve1 As ColorChangeTest.uctrlValve
    Private WithEvents UctrlSharedValve0a As ColorChangeTest.uctrlValve
    Private WithEvents lblGroup07 As System.Windows.Forms.Label
    Private WithEvents UctrlGroupValve0 As ColorChangeTest.uctrlValve
    Private WithEvents UctrlSharedValve3 As ColorChangeTest.uctrlValve
    Private WithEvents lblColorHeader2 As System.Windows.Forms.Label
    Private WithEvents lblAirHeaderLine2 As System.Windows.Forms.Label
    Private WithEvents lblLineBW2 As System.Windows.Forms.Label
    Private WithEvents lblLineDump2_2 As System.Windows.Forms.Label
    Private WithEvents lblLineDump2_1 As System.Windows.Forms.Label
    Private WithEvents lblAirHeaderLine3 As System.Windows.Forms.Label
    Private WithEvents lblLineInjector As System.Windows.Forms.Label
    Private WithEvents lblLineBW1 As System.Windows.Forms.Label
    Private WithEvents lblSolventHeader3 As System.Windows.Forms.Label
    Private WithEvents lblGroup00 As System.Windows.Forms.Label
    Private WithEvents lblDumpTank As System.Windows.Forms.Label
    Private WithEvents lblGroup04 As System.Windows.Forms.Label
    Private WithEvents lblGroup03 As System.Windows.Forms.Label
    Private WithEvents lblGroup06 As System.Windows.Forms.Label
    Private WithEvents lblGroup05 As System.Windows.Forms.Label
    Private WithEvents lblGroup01 As System.Windows.Forms.Label
    Private WithEvents lblGroup02 As System.Windows.Forms.Label
    Private WithEvents lblShared03 As System.Windows.Forms.Label
    Private WithEvents lblLineColStk1 As System.Windows.Forms.Label
    Private WithEvents lblGroup09 As System.Windows.Forms.Label
    Private WithEvents lblGroup08 As System.Windows.Forms.Label
    Private WithEvents picDumpTank As System.Windows.Forms.PictureBox
    Private WithEvents lblOutPressure As System.Windows.Forms.Label
    Private WithEvents lblOutPressureTag As System.Windows.Forms.Label
    Private WithEvents lblAirHeaderLine1 As System.Windows.Forms.Label
    Private WithEvents lblSolventHeader1 As System.Windows.Forms.Label
    Private WithEvents lblPntHeader01 As System.Windows.Forms.Label
    Private WithEvents lblAirHeader01 As System.Windows.Forms.Label
    Private WithEvents lblSolventHeader2 As System.Windows.Forms.Label
    Private WithEvents lblFlowTag As System.Windows.Forms.Label
    Friend WithEvents lblParameters As System.Windows.Forms.Label
End Class
