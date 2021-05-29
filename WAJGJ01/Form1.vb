Public Class Form1

    Private Sub BTNSaludo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSaludo.Click

        Me.LBLSaludo.Text = "Hola " & Me.TXTNombre.Text

    End Sub
End Class
