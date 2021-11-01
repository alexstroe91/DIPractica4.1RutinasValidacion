Public Class frmNif
    Dim logica As New metodosNif

    Private Sub txtNif_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNif.KeyDown
        'al pulsar la tecla ENTER llamo al método donde le doy las instrucciones a realizar
        logica.pulsarIntro(Me, e)
    End Sub

    Private Sub txtNif_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNif.KeyPress
        'por cada tecla que se pulsa, llamo al método que hace la correspondiente verificacion
        logica.nifValidado(Me, e)
    End Sub
End Class