Imports System.Xml
Imports PLCComm

Public Class FrmColorChange

    Private WithEvents mPLC As clsPLCComm = Nothing
    Private msPLCdata(5) As String
    Private Testtimeduring As String


    Friend Property PLCData() As String()
        Get
            Return msPLCdata
        End Get
        Set(ByVal value As String())
            msPLCdata = value
            lblFlow.Text = msPLCdata(0)
            lblSpeed.Text = msPLCdata(1)
            lblShape1.Text = msPLCdata(2)
            lblShape2.Text = msPLCdata(3)

            Testtimeduring = msPLCdata(5) ' PLC 内部编写程序使用计时器返回时间
        End Set
    End Property

    'Private Sub mPLC1_NewData(ByVal ZoneName As String, ByVal TagName As String, _
    '                                                 ByVal Data() As String) Handles mPLC.NewData

    '    Dim sPLCData() As String
    '    sPLCData = Data
    '    PLCData = sPLCData
    '    'frmProcess.lblProcessValue.Text = sPLCData(0)

    'End Sub

    Private Sub frmColorChange_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim stag(4) As String
        Dim sPLCData(4) As String
        Dim sTmpPLCData(0) As String
        If mPLC Is Nothing Then
            mPLC = New clsPLCComm

            If mPLC IsNot Nothing Then

                mPLC.XMLPath = "C:\Users\18604\Desktop\ColorChangeTest_Version2019\ColorChangeTest\SiemensLNDComm.xml"
                mPLC.ZoneName = "APTTest"
                stag(0) = ftbFlow.Tag.ToString
                stag(1) = ftbSpeed.Tag.ToString
                stag(2) = ftbShape1.Tag.ToString
                stag(3) = ftbShape2.Tag.ToString
                stag(4) = ftbTime.Tag.ToString

                sPLCData(0) = ftbFlow.Text.ToString
                sPLCData(1) = ftbSpeed.Text.ToString
                sPLCData(2) = ftbShape1.Text.ToString
                sPLCData(3) = ftbShape2.Text.ToString
                sPLCData(4) = ftbTime.Text.ToString

                For i As Integer = 0 To 4

                    mPLC.TagName = stag(i)
                    sTmpPLCData(0) = sPLCData(i)
                    mPLC.PLCData = sTmpPLCData
                Next
            End If
        End If
        ftbFlow.Enabled = True
        ftbShape1.Enabled = True
        ftbShape2.Enabled = True
        ftbSpeed.Enabled = True
        ftbTime.Enabled = True
    End Sub

    Private Sub MaualTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaualTest.Click


        Dim sPLCData(0) As String

        If mPLC IsNot Nothing Then
            mPLC.TagName = "Manual"
            sPLCData(0) = 1
            mPLC.PLCData = sPLCData
        End If

        proFlow.Visible = True
        proFlow.Minimum = 0
        proFlow.Maximum = CInt(ftbTime.Text) + 1
        Timer1.Enabled = True
    End Sub
  
    Private Sub Timer_Tick() Handles Timer1.Tick


        Dim nWorkingWord As Integer = 0

      
        If CInt(ftbTime.Text) - CInt(Testtimeduring) <= 0 Then
            MsgBox("手动测试完成")
            Timer1.Enabled = False
        Else
            nWorkingWord = CInt(Testtimeduring)
            proFlow.Value = CInt(ftbTime.Text) - nWorkingWord
            lblTime.Text = CInt(ftbTime.Text) - nWorkingWord
        End If


    End Sub

    Private Sub SetUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetUp.Click

        FRMParameters.Show()

    End Sub

    Private Sub ftbFlow_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ftbFlow.TextChanged
        Dim sPLCData(0) As String
        If mPLC IsNot Nothing Then
            mPLC.TagName = ftbFlow.Tag
            sPLCData(0) = ftbFlow.Text
            mPLC.PLCData = sPLCData
        End If
    End Sub

    Private Sub ftbSpeed_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ftbSpeed.TextChanged
        Dim sPLCData(0) As String
        If mPLC IsNot Nothing Then
            mPLC.TagName = ftbSpeed.Tag
            sPLCData(0) = ftbSpeed.Text
            mPLC.PLCData = sPLCData
        End If
    End Sub

    Private Sub ftbShape1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ftbShape1.TextChanged
        Dim sPLCData(0) As String
        If mPLC IsNot Nothing Then
            mPLC.TagName = ftbShape1.Tag
            sPLCData(0) = ftbShape1.Text
            mPLC.PLCData = sPLCData
        End If
    End Sub

    Private Sub ftbShape2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ftbShape2.TextChanged
        Dim sPLCData(0) As String
        If mPLC IsNot Nothing Then
            mPLC.TagName = ftbShape2.Tag
            sPLCData(0) = ftbShape2.Text
            mPLC.PLCData = sPLCData
        End If
    End Sub

    Private Sub ftbTime_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ftbTime.TextChanged
        Dim sPLCData(0) As String
        If mPLC IsNot Nothing Then
            mPLC.TagName = ftbTime.Tag
            sPLCData(0) = ftbTime.Text
            mPLC.PLCData = sPLCData
        End If
    End Sub

    Private Sub AutoTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutoTest.Click
        Dim ColorChangeCycle As String = Nothing
        Dim CCCycle(0) As String
        Dim sPLCData() As String
        If cboxCycle.Text = "" Then
            MsgBox("请选择换色循环")
            Exit Sub
        Else
            ColorChangeCycle = CStr(cboxCycle.Text)
            Select Case ColorChangeCycle
                Case Is = "Cap Clean"
                    CCCycle(0) = "0"
                Case Is = "Clean out"
                    CCCycle(0) = "1"
                Case Is = "Fill"
                    CCCycle(0) = "2"
                Case Is = "Super Purge"
                    CCCycle(0) = "3"
            End Select
        End If
        If mPLC IsNot Nothing Then
            mPLC.TagName = "ColorChangeCycle"
            sPLCData = CCCycle
            mPLC.PLCData = sPLCData
        End If
    End Sub


End Class
