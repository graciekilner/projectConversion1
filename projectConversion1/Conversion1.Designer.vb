<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Conversion1
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
        Me.lblKilograms = New System.Windows.Forms.Label()
        Me.lblDollars = New System.Windows.Forms.Label()
        Me.lblEnterDollars = New System.Windows.Forms.Label()
        Me.lblPounds = New System.Windows.Forms.Label()
        Me.lblDtop = New System.Windows.Forms.Label()
        Me.txt = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblConversion
        '
        Me.lblConversion.AutoSize = True
        Me.lblConversion.Font = New System.Drawing.Font("Cambria", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConversion.Location = New System.Drawing.Point(306, 40)
        Me.lblConversion.Name = "lblConversion"
        Me.lblConversion.Size = New System.Drawing.Size(234, 43)
        Me.lblConversion.TabIndex = 1
        Me.lblConversion.Text = "CONVERSION"
        '
        'lblptod
        '
        Me.lblptod.AutoSize = True
        Me.lblptod.Font = New System.Drawing.Font("Cambria", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblptod.Location = New System.Drawing.Point(12, 83)
        Me.lblptod.Name = "lblptod"
        Me.lblptod.Size = New System.Drawing.Size(343, 34)
        Me.lblptod.TabIndex = 2
        Me.lblptod.Text = "Convert Pounds To Dollars:"
        '
        'lblKilograms
        '
        Me.lblKilograms.AutoSize = True
        Me.lblKilograms.Location = New System.Drawing.Point(12, 139)
        Me.lblKilograms.Name = "lblKilograms"
        Me.lblKilograms.Size = New System.Drawing.Size(83, 13)
        Me.lblKilograms.TabIndex = 3
        Me.lblKilograms.Text = "Enter Kilograms:"
        '
        'lblDollars
        '
        Me.lblDollars.AutoSize = True
        Me.lblDollars.Location = New System.Drawing.Point(12, 169)
        Me.lblDollars.Name = "lblDollars"
        Me.lblDollars.Size = New System.Drawing.Size(74, 13)
        Me.lblDollars.TabIndex = 4
        Me.lblDollars.Text = "Pounds(result)"
        '
        'lblEnterDollars
        '
        Me.lblEnterDollars.AutoSize = True
        Me.lblEnterDollars.Location = New System.Drawing.Point(15, 253)
        Me.lblEnterDollars.Name = "lblEnterDollars"
        Me.lblEnterDollars.Size = New System.Drawing.Size(70, 13)
        Me.lblEnterDollars.TabIndex = 5
        Me.lblEnterDollars.Text = "Enter Dollars:"
        '
        'lblPounds
        '
        Me.lblPounds.AutoSize = True
        Me.lblPounds.Location = New System.Drawing.Point(15, 284)
        Me.lblPounds.Name = "lblPounds"
        Me.lblPounds.Size = New System.Drawing.Size(80, 13)
        Me.lblPounds.TabIndex = 6
        Me.lblPounds.Text = "Pounds (result):"
        '
        'lblDtop
        '
        Me.lblDtop.AutoSize = True
        Me.lblDtop.Font = New System.Drawing.Font("Cambria", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDtop.Location = New System.Drawing.Point(9, 200)
        Me.lblDtop.Name = "lblDtop"
        Me.lblDtop.Size = New System.Drawing.Size(338, 34)
        Me.lblDtop.TabIndex = 7
        Me.lblDtop.Text = "Convert Dollars to Pounds:"
        '
        'txt
        '
        Me.txt.Location = New System.Drawing.Point(102, 131)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(100, 20)
        Me.txt.TabIndex = 8
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(102, 284)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 9
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(102, 246)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 10
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(102, 166)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 11
        '
        'Conversion1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.txt)
        Me.Controls.Add(Me.lblDtop)
        Me.Controls.Add(Me.lblPounds)
        Me.Controls.Add(Me.lblEnterDollars)
        Me.Controls.Add(Me.lblDollars)
        Me.Controls.Add(Me.lblKilograms)
        Me.Controls.Add(Me.lblptod)
        Me.Controls.Add(Me.lblConversion)
        Me.Name = "Conversion1"
        Me.Text = "Conversion1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblConversion As Label
    Friend WithEvents lblptod As Label
    Friend WithEvents lblKilograms As Label
    Friend WithEvents lblDollars As Label
    Friend WithEvents lblEnterDollars As Label
    Friend WithEvents lblPounds As Label
    Friend WithEvents lblDtop As Label
    Friend WithEvents txt As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
End Class
