Public Class frmNombre

    Dim logica As New metodos

    Private Sub txtNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombre.KeyDown
        logica.pulsarEnter(Me, e)
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        'depuro el TextBox txtNombre con los metodos comentados en la clase metodos
        If Not logica.algoEscrito(Me) Then
            logica.primerCaracter(Me, e)
        End If

        If logica.algoEscrito(Me) Then
            logica.soloUnEspacio(Me, e)
        End If

    End Sub



End Class