Imports PLCComm

Public Class frmMain
    Private WithEvents mPLC As clsPLCComm = Nothing
    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim sPLCData() As String

        If mPLC Is Nothing Then
            mPLC = New clsPLCComm
        End If

        If mPLC IsNot Nothing Then
            mPLC.XMLPath = "C:\Users\18604\Desktop\ColorChangeTest_Version2019\ColorChangeTest\SiemensLNDComm.xml"
            mPLC.ZoneName = "APTTest"
            mPLC.TagName = "ActualData"
            sPLCData = mPLC.PLCData

        End If

    End Sub
   

    Private Sub ColorChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorChange.Click

        FrmColorChange.Show()


    End Sub


    Private Sub mPLC1_NewData(ByVal ZoneName As String, ByVal TagName As String, _
                                                     ByVal Data() As String) Handles mPLC.NewData

        Dim sPLCData() As String

        sPLCData = Data
        FrmColorChange.PLCData = sPLCData
        'frmProcess.lblProcessValue.Text = sPLCData(0)


    End Sub

End Class





