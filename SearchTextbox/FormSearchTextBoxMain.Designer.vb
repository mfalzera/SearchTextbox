<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formSearchTextBoxMain
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
        Me.textboxTextToSearch = New System.Windows.Forms.TextBox()
        Me.buttonSearch = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'textboxSearchString
        '
        Me.textboxSearchString.Location = New System.Drawing.Point(12, 182)
        Me.textboxSearchString.Name = "textboxSearchString"
        Me.textboxSearchString.Size = New System.Drawing.Size(251, 20)
        Me.textboxSearchString.TabIndex = 0
        '
        'textboxTextToSearch
        '
        Me.textboxTextToSearch.Location = New System.Drawing.Point(12, 208)
        Me.textboxTextToSearch.Multiline = True
        Me.textboxTextToSearch.Name = "textboxTextToSearch"
        Me.textboxTextToSearch.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxTextToSearch.Size = New System.Drawing.Size(366, 220)
        Me.textboxTextToSearch.TabIndex = 1
        '
        'buttonSearch
        '
        Me.buttonSearch.Location = New System.Drawing.Point(269, 180)
        Me.buttonSearch.Name = "buttonSearch"
        Me.buttonSearch.Size = New System.Drawing.Size(75, 23)
        Me.buttonSearch.TabIndex = 2
        Me.buttonSearch.Text = "Search"
        Me.buttonSearch.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(481, 354)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'formSearchTextBoxMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 440)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.buttonSearch)
        Me.Controls.Add(Me.textboxTextToSearch)
        Me.Controls.Add(Me.textboxSearchString)
        Me.Name = "formSearchTextBoxMain"
        Me.Text = "Search Text Box Example"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents textboxSearchString As TextBox
    Friend WithEvents textboxTextToSearch As TextBox
    Friend WithEvents buttonSearch As Button
    Friend WithEvents Label1 As Label
End Class
