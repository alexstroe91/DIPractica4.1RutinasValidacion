Public Class metodosNumeros
    Public Function algoEscrito(frm As frmNumeros) As Boolean
        'compruebo si el text box esta vacio o nos
        If frm.txtNumero.Text = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub primerCarater(frm As frmNumeros, e As KeyPressEventArgs)
        'prohibe la escritura de cualquier caracter salvo numeros
        If Char.IsPunctuation(e.KeyChar) Or Char.IsLetter(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Public Sub soloUnaComa(frm As frmNumeros, e As KeyPressEventArgs)
        'prohibo escribir coma si el texto de txtNumero tiene ya una coma y cualquier caracter que no sea un numero 
        If (Char.IsPunctuation(e.KeyChar) AndAlso frm.txtNumero.Text.Contains(",")) Or Char.IsLetter(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub

    Public Sub pulsarIntro(frm As frmNumeros, e As KeyEventArgs)
        'al pulsar intro fomatea el texto que hay en el txtNumero con 2 decimales utilizando el metodo de abajo
        If e.KeyCode = 13 Then
            frm.lblNumero.Text = FormatNumber(frm.txtNumero.Text, 2) & " €"
        End If
    End Sub

End Class
