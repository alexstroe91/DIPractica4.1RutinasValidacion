Public Class metodos
    Public Function algoEscrito(frm As frmNombre) As Boolean
        If frm.txtNombre.Text = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub esEspacio(frm As frmNombre, e As KeyPressEventArgs)
        'compruebo si no hay nada escrito y si es asi prohibo que el primer caracter sea un espacio
        If Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Public Sub soloUnEspacio(frm As frmNombre, e As KeyPressEventArgs)
        'compruebo si el caracter presionado es un espacio
        'y si el texto que hay en txtNombre ya contiene un espacio
        'si es así, no se le permite introducir mas
        If Char.IsWhiteSpace(e.KeyChar) AndAlso frm.txtNombre.Text.Contains(" ") Then
            e.Handled = True
        End If
    End Sub


End Class
