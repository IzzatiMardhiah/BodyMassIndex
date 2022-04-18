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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lblBMI = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Height(m) :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Weight(kg) :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(109, 228)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "BMI :"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(159, 93)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(125, 27)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(157, 164)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(125, 27)
        Me.TextBox2.TabIndex = 4
        '
        'lblBMI
        '
        Me.lblBMI.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblBMI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBMI.Location = New System.Drawing.Point(157, 227)
        Me.lblBMI.Name = "lblBMI"
        Me.lblBMI.Size = New System.Drawing.Size(127, 32)
        Me.lblBMI.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(119, 289)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(190, 32)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "CALCULATE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Ravie", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(43, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(462, 42)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Body Mass Index(BMI)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 451)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblBMI)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lblBMI As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
End Class
