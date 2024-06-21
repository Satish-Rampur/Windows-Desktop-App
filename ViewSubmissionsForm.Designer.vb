<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGithubLink = New TextBox()
        txtStopwatchTime = New TextBox()
        btnPrevious = New Button()
        btnNext = New Button()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(22, 30)
        txtName.Margin = New Padding(5, 6, 5, 6)
        txtName.Name = "txtName"
        txtName.ReadOnly = True
        txtName.Size = New Size(431, 31)
        txtName.TabIndex = 0
        txtName.Text = "Name"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(20, 73)
        txtEmail.Margin = New Padding(5, 6, 5, 6)
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(431, 31)
        txtEmail.TabIndex = 1
        txtEmail.Text = "Email"
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(20, 123)
        txtPhone.Margin = New Padding(5, 6, 5, 6)
        txtPhone.Name = "txtPhone"
        txtPhone.ReadOnly = True
        txtPhone.Size = New Size(431, 31)
        txtPhone.TabIndex = 2
        txtPhone.Text = "Phone No"
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.Location = New Point(20, 173)
        txtGithubLink.Margin = New Padding(5, 6, 5, 6)
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.ReadOnly = True
        txtGithubLink.Size = New Size(431, 31)
        txtGithubLink.TabIndex = 3
        txtGithubLink.Text = "Git Hub Link"
        ' 
        ' txtStopwatchTime
        ' 
        txtStopwatchTime.Location = New Point(20, 223)
        txtStopwatchTime.Margin = New Padding(5, 6, 5, 6)
        txtStopwatchTime.Name = "txtStopwatchTime"
        txtStopwatchTime.ReadOnly = True
        txtStopwatchTime.Size = New Size(431, 31)
        txtStopwatchTime.TabIndex = 4
        txtStopwatchTime.Text = "Stopwatch Time"
        ' 
        ' btnPrevious
        ' 
        btnPrevious.Location = New Point(20, 273)
        btnPrevious.Margin = New Padding(5, 6, 5, 6)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(125, 44)
        btnPrevious.TabIndex = 5
        btnPrevious.Text = "Previous"
        btnPrevious.UseVisualStyleBackColor = True
        ' 
        ' btnNext
        ' 
        btnNext.Location = New Point(328, 273)
        btnNext.Margin = New Padding(5, 6, 5, 6)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(125, 44)
        btnNext.TabIndex = 6
        btnNext.Text = "Next"
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(473, 340)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(txtStopwatchTime)
        Controls.Add(txtGithubLink)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Margin = New Padding(5, 6, 5, 6)
        Name = "ViewSubmissionsForm"
        Text = "View Submissions"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents txtStopwatchTime As TextBox
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
End Class
