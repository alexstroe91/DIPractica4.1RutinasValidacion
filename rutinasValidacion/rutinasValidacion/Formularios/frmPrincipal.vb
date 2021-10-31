Public Class frmPrincipal
    Private Sub button_CLICK(sender As Object, e As EventArgs) Handles btnNombre.Click, btnNumero.Click, btnNif.Click
        Dim objFrm As Form = Nothing

        Select Case CType(sender, Button).Name
            'recojo el nombre de del boton pulsado y abro el formulario correspondiente
            Case "btnNombre"
                objFrm = New frmNombre
                objFrm.Show()
            Case "btnNumero"
                objFrm = New frmNumeros
                objFrm.Show()
            Case "btnNif"
                objFrm = New frmNif
                objFrm.Show()
        End Select

    End Sub
End Class
