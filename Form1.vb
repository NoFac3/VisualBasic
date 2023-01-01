'Name:          Controls and Events
'Purpose:       Application with a button that reveals hidden image and label and a button that closes the window.

Public Class frmAssignment1
    Private Sub btnMissions_Click(sender As Object, e As EventArgs) Handles btnMissions.Click   'Mission buttton for revealing Missionary label and picture
        picMissionary.Visible = True    'Show the missionary picture
        lblMissions.Visible = True      'Show the missionary label
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click           'Quit button for exiting application
        Me.Close()                      'Exit application (Close Window)
    End Sub
End Class
