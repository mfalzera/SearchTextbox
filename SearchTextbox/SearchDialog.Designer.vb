<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchDialog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.textboxSearchString = New System.Windows.Forms.TextBox()
        Me.buttonSearch = New System.Windows.Forms.Button()
        Me.buttonCloseDialog = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'textboxSearchString
        '
        Me.textboxSearchString.Location = New System.Drawing.Point(12, 14)
        Me.textboxSearchString.Name = "textboxSearchString"
        Me.textboxSearchString.Size = New System.Drawing.Size(179, 20)
        Me.textboxSearchString.TabIndex = 0
        '
        'buttonSearch
        '
        Me.buttonSearch.Location = New System.Drawing.Point(197, 12)
        Me.buttonSearch.Name = "buttonSearch"
        Me.buttonSearch.Size = New System.Drawing.Size(75, 23)
        Me.buttonSearch.TabIndex = 1
        Me.buttonSearch.Text = "Search"
        Me.buttonSearch.UseVisualStyleBackColor = True
        '
        'buttonCloseDialog
        '
        Me.buttonCloseDialog.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.buttonCloseDialog.Location = New System.Drawing.Point(19, 38)
        Me.buttonCloseDialog.Name = "buttonCloseDialog"
        Me.buttonCloseDialog.Size = New System.Drawing.Size(172, 13)
        Me.buttonCloseDialog.TabIndex = 2
        Me.buttonCloseDialog.Text = "Button1"
        Me.buttonCloseDialog.UseVisualStyleBackColor = True
        '
        'SearchDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 48)
        Me.Controls.Add(Me.buttonCloseDialog)
        Me.Controls.Add(Me.buttonSearch)
        Me.Controls.Add(Me.textboxSearchString)
        Me.KeyPreview = True
        Me.Name = "SearchDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Search Dialog"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents textboxSearchString As TextBox
    Friend WithEvents buttonSearch As Button
    Friend WithEvents buttonCloseDialog As Button
End Class
