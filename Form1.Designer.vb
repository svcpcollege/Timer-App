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
        components = New ComponentModel.Container()
        Button1 = New Button()
        Button2 = New Button()
        Timer1 = New Timer(components)
        Label1 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(54, 234)
        Button1.Name = "Button1"
        Button1.Size = New Size(141, 68)
        Button1.TabIndex = 1
        Button1.Text = "Start"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(201, 234)
        Button2.Name = "Button2"
        Button2.Size = New Size(141, 68)
        Button2.TabIndex = 2
        Button2.Text = "Stop"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(54, 177)
        Label1.Name = "Label1"
        Label1.Size = New Size(173, 54)
        Label1.TabIndex = 0
        Label1.Text = "00:00:00"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(54, 110)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 3
        TextBox1.Text = "00"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(160, 110)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 4
        TextBox2.Text = "00"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(266, 110)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 5
        TextBox3.Text = "00"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(54, 79)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 28)
        Label3.TabIndex = 7
        Label3.Text = "Hours"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(266, 79)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 28)
        Label4.TabIndex = 8
        Label4.Text = "Seconds"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(160, 79)
        Label5.Name = "Label5"
        Label5.Size = New Size(82, 28)
        Label5.TabIndex = 9
        Label5.Text = "Minutes"
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(372, 79)
        Button3.Name = "Button3"
        Button3.Size = New Size(63, 54)
        Button3.TabIndex = 10
        Button3.Text = "Set Time"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(484, 461)
        Controls.Add(Button3)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button3 As Button
End Class
