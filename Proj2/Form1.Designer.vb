<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Submit = New Button()
        lblName = New TextBox()
        tbx = New TextBox()
        Label1 = New Label()
        X = New Button()
        SuspendLayout()
        ' 
        ' Submit
        ' 
        Submit.BackColor = Color.Lime
        Submit.Location = New Point(235, 235)
        Submit.Name = "Submit"
        Submit.Size = New Size(94, 29)
        Submit.TabIndex = 0
        Submit.Text = "Submit"
        Submit.UseVisualStyleBackColor = False
        ' 
        ' lblName
        ' 
        lblName.BackColor = SystemColors.ActiveBorder
        lblName.BorderStyle = BorderStyle.None
        lblName.Font = New Font("Arial", 10.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblName.ForeColor = SystemColors.ActiveCaptionText
        lblName.Location = New Point(126, 104)
        lblName.Name = "lblName"
        lblName.Size = New Size(401, 21)
        lblName.TabIndex = 1
        lblName.Visible = False
        ' 
        ' tbx
        ' 
        tbx.Location = New Point(126, 178)
        tbx.Name = "tbx"
        tbx.Size = New Size(401, 27)
        tbx.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI Variable Small", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(51, 178)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 27)
        Label1.TabIndex = 3
        Label1.Text = "Name"
        ' 
        ' X
        ' 
        X.BackColor = Color.Red
        X.Location = New Point(335, 235)
        X.Name = "X"
        X.Size = New Size(31, 29)
        X.TabIndex = 4
        X.Text = "X"
        X.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        ClientSize = New Size(622, 346)
        Controls.Add(X)
        Controls.Add(Label1)
        Controls.Add(tbx)
        Controls.Add(lblName)
        Controls.Add(Submit)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Submit As Button
    Friend WithEvents lblName As TextBox
    Friend WithEvents tbx As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents X As Button

End Class
