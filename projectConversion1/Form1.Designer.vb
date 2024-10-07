<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblConversion = New System.Windows.Forms.Label()
        Me.lblConvert = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblConversion
        '
        Me.lblConversion.AutoSize = True
        Me.lblConversion.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.lblConversion.Font = New System.Drawing.Font("Cambria", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConversion.Location = New System.Drawing.Point(258, 121)
        Me.lblConversion.Name = "lblConversion"
        Me.lblConversion.Size = New System.Drawing.Size(259, 34)
        Me.lblConversion.TabIndex = 0
        Me.lblConversion.Text = "Conversion System"
        '
        'lblConvert
        '
        Me.lblConvert.AutoSize = True
        Me.lblConvert.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.lblConvert.Font = New System.Drawing.Font("Cambria", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConvert.Location = New System.Drawing.Point(412, 168)
        Me.lblConvert.Name = "lblConvert"
        Me.lblConvert.Size = New System.Drawing.Size(139, 15)
        Me.lblConvert.TabIndex = 1
        Me.lblConvert.Text = "Convert What You Like"
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnEnter.Font = New System.Drawing.Font("Cambria", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.Location = New System.Drawing.Point(329, 224)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(149, 33)
        Me.btnEnter.TabIndex = 2
        Me.btnEnter.Text = "ENTER"
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblConvert)
        Me.Controls.Add(Me.lblConversion)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblConversion As Label
    Friend WithEvents lblConvert As Label
    Friend WithEvents btnEnter As Button
End Class
