Public Class frmNombre

    Dim logica As New metodos


    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        'depuro el nombre
        If Not logica.algoEscrito(Me) Then
            logica.esEspacio(Me, e)
        End If

        If logica.algoEscrito(Me) Then
            logica.soloUnEspacio(Me, e)
        End If

    End Sub

End Class