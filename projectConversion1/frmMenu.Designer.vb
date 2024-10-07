<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.lblSelect = New System.Windows.Forms.Label()
        Me.btnPounds = New System.Windows.Forms.Button()
        Me.btnKilograms = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMenu
        '
        Me.lblMenu.AutoSize = True
        Me.lblMenu.Font = New System.Drawing.Font("Cambria", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.Location = New System.Drawing.Point(257, 44)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(118, 43)
        Me.lblMenu.TabIndex = 0
        Me.lblMenu.Text = "MENU"
        '
        'lblSelect
        '
        Me.lblSelect.AutoSize = True
        Me.lblSelect.Font = New System.Drawing.Font("Cambria", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelect.Location = New System.Drawing.Point(12, 87)
        Me.lblSelect.Name = "lblSelect"
        Me.lblSelect.Size = New System.Drawing.Size(476, 37)
        Me.lblSelect.TabIndex = 1
        Me.lblSelect.Text = "Select One Of The Options Below:"
        '
        'btnPounds
        '
        Me.btnPounds.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnPounds.Location = New System.Drawing.Point(118, 176)
        Me.btnPounds.Name = "btnPounds"
        Me.btnPounds.Size = New System.Drawing.Size(256, 56)
        Me.btnPounds.TabIndex = 2
        Me.btnPounds.Text = "Pounds & Dollars"
        Me.btnPounds.UseVisualStyleBackColor = False
        '
        'btnKilograms
        '
        Me.btnKilograms.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnKilograms.Location = New System.Drawing.Point(405, 176)
        Me.btnKilograms.Name = "btnKilograms"
        Me.btnKilograms.Size = New System.Drawing.Size(256, 56)
        Me.btnKilograms.TabIndex = 3
        Me.btnKilograms.Text = "Kilograms & Pounds"
        Me.btnKilograms.UseVisualStyleBackColor = False
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnKilograms)
        Me.Controls.Add(Me.btnPounds)
        Me.Controls.Add(Me.lblSelect)
        Me.Controls.Add(Me.lblMenu)
        Me.Name = "frmMenu"
        Me.Text = "frmMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMenu As Label
    Friend WithEvents lblSelect As Label
    Friend WithEvents btnPounds As Button
    Friend WithEvents btnKilograms As Button
End Class
