<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Conversion2
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
        Me.lblptod = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblConversion
        '
        Me.lblConversion.AutoSize = True
        Me.lblConversion.Font = New System.Drawing.Font("Cambria", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConversion.Location = New System.Drawing.Point(284, 29)
        Me.lblConversion.Name = "lblConversion"
        Me.lblConversion.Size = New System.Drawing.Size(234, 43)
        Me.lblConversion.TabIndex = 2
        Me.lblConversion.Text = "CONVERSION"
        '
        'lblptod
        '
        Me.lblptod.AutoSize = True
        Me.lblptod.Font = New System.Drawing.Font("Cambria", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblptod.Location = New System.Drawing.Point(12, 72)
        Me.lblptod.Name = "lblptod"
        Me.lblptod.Size = New System.Drawing.Size(371, 34)
        Me.lblptod.TabIndex = 3
        Me.lblptod.Text = "Convert Kilograms To Pounds"
        '
        'Conversion2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblptod)
        Me.Controls.Add(Me.lblConversion)
        Me.Name = "Conversion2"
        Me.Text = "Conversion2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblConversion As Label
    Friend WithEvents lblptod As Label
End Class
