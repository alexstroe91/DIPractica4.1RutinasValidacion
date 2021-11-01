Public Class metodosNif
    Public Function algoEscrito(frm As frmNif) As Boolean
        'compruebo si el texto está vacio y devuelvo true or false
        If frm.txtNif.Text = "" Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub nifValidado(frm As frmNif, e As KeyPressEventArgs)
        'si la longitud del texto es menor a 8 (se permiten 8 de longitud) se permite la introduccion de numeros
        If (frm.txtNif.TextLength < 8) Then
            If Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Or Char.IsLetter(e.KeyChar) Then
                e.Handled = True
            End If
        ElseIf frm.txtNif.TextLength = 8 Then
            'una vez se haya introducido el 8º caracter, solo se permite la introduccion de letras.
            'y como la longitud maxima de txtNif es de 9, ya no se permite introducir ningun caracter más
            If Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Or Char.IsNumber(e.KeyChar) Then
                e.Handled = True
            End If
        End If

    End Sub

    Public Sub pulsarIntro(frm As frmNif, e As KeyEventArgs)
        'al pulsar la tecla ENTER genero el texto del label pasado a mayúsculas en lblNif
        If e.KeyCode = 13 Then
            frm.lblNif.Text = frm.txtNif.Text.ToUpper()
        End If
    End Sub

End Class
