Public Class frmNombre

    Dim logica As New metodosNombre

    Private Sub txtNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombre.KeyDown
        logica.pulsarEnter(Me, e)
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        'compruebo si hay algo escrito o no y ejecuto los metodos siguientes
        '(ya comentados en la clase metodosNombre)
        If Not logica.algoEscrito(Me) Then
            logica.primerCaracter(Me, e)
        Else
            logica.soloUnEspacio(Me, e)
        End If
    End Sub



End Class