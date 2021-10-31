Public Class metodos
    Public Function algoEscrito(frm As frmNombre) As Boolean
        'compruebo si el text box esta vacio o nos
        If frm.txtNombre.Text = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub primerCaracter(frm As frmNombre, e As KeyPressEventArgs)
        'prohibe la escritura de cualquier caracter que no sea una letra
        If Char.IsWhiteSpace(e.KeyChar) Or Char.IsNumber(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Public Sub soloUnEspacio(frm As frmNombre, e As KeyPressEventArgs)
        'prohibe la escritura de mas de un espacio y cualquier otra caracter
        If Char.IsWhiteSpace(e.KeyChar) AndAlso frm.txtNombre.Text.Contains(" ") Or Char.IsNumber(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Public Sub pulsarEnter(frm As frmNombre, e As KeyEventArgs)
        'captura la pulsacion dela tecla ENTER y muestra informacion en el label indicado
        If e.KeyCode = 13 Then
            frm.lblNombre.Text = StrConv(frm.txtNombre.Text, vbProperCase)
        End If
    End Sub

End Class
