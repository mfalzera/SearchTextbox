Public Class formSearchTextBoxMain
    Private Const FAST_PING_TEXT As String =
"Once the Fast Ping timer has elapsed and there are " +
"valid Fast Track items in the queue, a new instance of the ServiceProcess object is created.  " +
"If the current client information does Not already exist, the service makes a Call To the SSC " +
"API (CurrentClient/client) and stores the response in an SSC.ClientRequest.  The ClientRequest is then used to " +
"create a New QueryProcessor And a New thread Is created And All Pending Queries are processed.  For a detailed " +
"explanation of the Query Process, please see the Query Processing section of this document."

    Friend WithEvents sd As SearchDialog

    Private Sub formSearchTextBoxMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PopulateTextToSearch()
    End Sub

    Private Sub SearchDialog_SearchText(ASearchString As String) Handles sd.SearchTextEvent
        Me.SearchTextBox(ASearchString, Me.textboxTextToSearch.SelectionStart)
    End Sub


    Private Sub UpdateCursorLocation()
        Me.Label1.Text = String.Format("Cursor Position: {0}", Me.textboxTextToSearch.SelectionStart)
    End Sub

    Private Sub PopulateTextToSearch()
        Me.textboxTextToSearch.Text = FAST_PING_TEXT + FAST_PING_TEXT + FAST_PING_TEXT + FAST_PING_TEXT
    End Sub

    Private Sub buttonSearch_Click(sender As Object, e As EventArgs) Handles buttonSearch.Click
        'Me.SearchTextBox(Me.textboxTextToSearch.SelectionStart)
    End Sub

    Private Sub SearchTextBox(ByVal searchString As String, ByVal startPosition As Integer)
        'Dim searchString As String = Me.textboxSearchString.Text
        ' Dim searchString As String = InputBox("Enter Search String: ")
        Dim searchLength As Integer = searchString.Length
        Dim index As Integer = startPosition

        index = Me.textboxTextToSearch.Text.IndexOf(searchString, index + 1)

        If index <> -1 Then
            Me.textboxTextToSearch.Focus()
            Me.textboxTextToSearch.SelectionStart = index
            Me.textboxTextToSearch.SelectionLength = searchLength
            Me.textboxTextToSearch.ScrollToCaret()
        Else
            If MessageBox.Show("End reached. Do you want to start from the beginning?",
                               "Search Results", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Me.SearchTextBox(searchString, 0)
            End If
        End If
    End Sub

    Private Sub textboxTextToSearch_CursorChanged(sender As Object, e As EventArgs) Handles textboxTextToSearch.CursorChanged
    End Sub

    Private Sub textboxTextToSearch_TextChanged(sender As Object, e As EventArgs) Handles textboxTextToSearch.TextChanged
        Me.UpdateCursorLocation()
    End Sub

    Private Sub textboxTextToSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textboxTextToSearch.KeyPress

    End Sub

    Private Sub textboxTextToSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles textboxTextToSearch.KeyDown
        If Control.ModifierKeys = Keys.Control Then
            If e.KeyCode = Keys.F Then
                e.Handled = True
                sd = New SearchDialog
                sd.Show()
            End If
        End If
    End Sub
End Class
