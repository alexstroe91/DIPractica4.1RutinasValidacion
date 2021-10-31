Public Class frmNumeros
    Dim logica As New metodosNumeros

    Private Sub txtNumero_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNumero.KeyDown
        logica.pulsarIntro(Me, e)
    End Sub

    Private Sub txtNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumero.KeyPress
        'compruebo si hay algo escrito o no y ejecuto los metodos siguientes
        '(ya comentados en la clase metodosNumeros)
        If Not logica.algoEscrito(Me) Then
            logica.primerCarater(Me, e)
        Else
            logica.soloUnaComa(Me, e)
        End If
    End Sub



End Class