Imports System.Xml

Public Class FRMParameters
    'Private Sub subSaveData()

    '    Try

    '        'Progress = 5
    '        ''make sure its good data
    '        'If Not bValidateData() Then Exit Sub


    '        ' do save
    '        If bSaveToRobots(mRobot.SystemColors) Then
    '            If bSaveToPLC(mRobot.SystemColors) Then
    '                If bSaveToGUI(mRobot.SystemColors) Then
    '                    mRobot.SystemColors.Update()
    '                    'mPWCommon.SaveToChangeLog(colZones.ActiveZone.DatabasePath)
    '                    'For SQL database - remove above eventually
    '                    mPWCommon.SaveToChangeLog(colZones.ActiveZone)
    '                    ' save done
    '                    EditsMade = False
    '                    subShowNewPage()

    '                Else
    '                    'save failed
    '                    Status = gcsRM.GetString("csSAVEFAILED")
    '                End If  'SaveToRobot()
    '            Else
    '                'save failed
    '                Status = gcsRM.GetString("csSAVEFAILED")
    '            End If    ' bSaveToPLC()
    '        Else
    '            'save failed
    '            Status = gcsRM.GetString("csSAVEFAILED")
    '        End If      'bSaveToGUI()

    '        If mbPLCFail Then
    '            Status = gcsRM.GetString("csSAVEFAILED")
    '        End If

    '    Catch ex As Exception
    '        Trace.WriteLine(ex.Message)
    '        ShowErrorMessagebox(gcsRM.GetString("csERROR"), ex, msSCREEN_NAME, _
    '                            Status, MessageBoxButtons.OK)

    '    Finally

    '        Me.Cursor = System.Windows.Forms.Cursors.Default
    '        Progress = 100
    '        Status = gcsRM.GetString("csSAVE_DONE")

    '    End Try


    'End Sub

  
End Class