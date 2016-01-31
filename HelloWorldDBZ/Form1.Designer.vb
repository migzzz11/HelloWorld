<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_main))
        Me.btn_summon = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_summon
        '
        Me.btn_summon.BackColor = System.Drawing.Color.Gold
        Me.btn_summon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_summon.Location = New System.Drawing.Point(118, 106)
        Me.btn_summon.Name = "btn_summon"
        Me.btn_summon.Size = New System.Drawing.Size(117, 52)
        Me.btn_summon.TabIndex = 0
        Me.btn_summon.Text = "Summon Shenron!"
        Me.btn_summon.UseVisualStyleBackColor = False
        '
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(356, 282)
        Me.Controls.Add(Me.btn_summon)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seven dragonballs have been gathered"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_summon As System.Windows.Forms.Button

End Class
