Public Class frmStudentTrip

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnTotalDue_Click(sender As Object, e As EventArgs) Handles btnTotalDue.Click
        'Declare variables
        Dim strName = " "
        Dim strSurname = " "
        Dim decLevelPrice As Decimal = 0
        Dim decOptionalPrice As Decimal = 0
        Dim decTotalDue As Decimal = 0

        'Input
        strName = txtName.Text
        strSurname = txtSurname.Text

        'Processing
        'Determine the price per person
        If radLevel2.Checked = True Then
            decLevelPrice = 1000
        End If
        If radLevel3.Checked = True Then
            decLevelPrice = 900
        End If
        If radLevel4.Checked = True Then
            decLevelPrice = 800
        End If

        'Determine the optional extras
        If chkTshirt.Checked = True Then
            decOptionalPrice = decOptionalPrice + 70
        End If
        If chkCap.Checked = True Then
            decOptionalPrice = decOptionalPrice + 45
        End If
        If chkBag.Checked = True Then
            decOptionalPrice = decOptionalPrice + 90
        End If

        'Calculate the total amount due
        decTotalDue = decLevelPrice + decOptionalPrice

        'Output
        lblResults.Text = strName & " " & strSurname & " " & " " & " You must pay " & " " & decTotalDue.ToString("C2") & " " & " for the Trip"
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear input & output on the GUI
        txtName.Clear()
        txtSurname.Clear()

        radLevel2.Checked = False
        radLevel3.Checked = False
        radLevel4.Checked = False

        chkTshirt.Checked = False
        chkCap.Checked = False
        chkBag.Checked = False

        lblResults.Text = " "
        txtName.Focus()


    End Sub
End Class
