<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_shenron
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_shenron))
        Me.lbl_helloWorld = New System.Windows.Forms.Label()
        Me.lbl_wish = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_helloWorld
        '
        Me.lbl_helloWorld.AutoSize = True
        Me.lbl_helloWorld.BackColor = System.Drawing.Color.Transparent
        Me.lbl_helloWorld.Font = New System.Drawing.Font("Lucida Sans", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_helloWorld.ForeColor = System.Drawing.Color.Gold
        Me.lbl_helloWorld.Location = New System.Drawing.Point(90, 22)
        Me.lbl_helloWorld.Name = "lbl_helloWorld"
        Me.lbl_helloWorld.Size = New System.Drawing.Size(188, 33)
        Me.lbl_helloWorld.TabIndex = 0
        Me.lbl_helloWorld.Text = "Hello World!"
        '
        'lbl_wish
        '
        Me.lbl_wish.AutoSize = True
        Me.lbl_wish.BackColor = System.Drawing.Color.Transparent
        Me.lbl_wish.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_wish.ForeColor = System.Drawing.Color.Gainsboro
        Me.lbl_wish.Location = New System.Drawing.Point(64, 234)
        Me.lbl_wish.Name = "lbl_wish"
        Me.lbl_wish.Size = New System.Drawing.Size(238, 39)
        Me.lbl_wish.TabIndex = 1
        Me.lbl_wish.Text = "What is your wish?"
        '
        'frm_shenron
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(356, 282)
        Me.Controls.Add(Me.lbl_wish)
        Me.Controls.Add(Me.lbl_helloWorld)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_shenron"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shenron has been summoned"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_helloWorld As System.Windows.Forms.Label
    Friend WithEvents lbl_wish As System.Windows.Forms.Label
End Class
