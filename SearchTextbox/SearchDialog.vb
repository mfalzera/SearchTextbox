Public Class SearchDialog
    Public Shared Event SearchTextEvent(ByVal [messageText] As String)

    Private Sub buttonSearch_Click(sender As Object, e As EventArgs) Handles buttonSearch.Click
        RaiseEvent SearchTextEvent(Me.textboxSearchString.Text)
    End Sub

    Private Sub buttonCloseDialog_Click(sender As Object, e As EventArgs) Handles buttonCloseDialog.Click
        Close()
    End Sub

    Private Sub SearchDialog_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
End Class