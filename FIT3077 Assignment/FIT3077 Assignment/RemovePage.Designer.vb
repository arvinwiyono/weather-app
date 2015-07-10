<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RemovePage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RemovePage))
        Me.Header = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RemoveLocationList = New System.Windows.Forms.ListBox()
        Me.BackLbl = New System.Windows.Forms.Label()
        Me.RemoveLbl = New System.Windows.Forms.Label()
        Me.SelectLocationLbl = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Header
        '
        Me.Header.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header.Location = New System.Drawing.Point(0, 0)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(375, 53)
        Me.Header.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox1.Image = Global.FIT3077_Assignment.My.Resources.Resources.footer_logo
        Me.PictureBox1.Location = New System.Drawing.Point(18, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(190, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'RemoveLocationList
        '
        Me.RemoveLocationList.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveLocationList.FormattingEnabled = True
        Me.RemoveLocationList.ItemHeight = 19
        Me.RemoveLocationList.Location = New System.Drawing.Point(65, 105)
        Me.RemoveLocationList.Name = "RemoveLocationList"
        Me.RemoveLocationList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.RemoveLocationList.Size = New System.Drawing.Size(242, 365)
        Me.RemoveLocationList.TabIndex = 21
        '
        'BackLbl
        '
        Me.BackLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BackLbl.Font = New System.Drawing.Font("Lato", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackLbl.ForeColor = System.Drawing.Color.White
        Me.BackLbl.Location = New System.Drawing.Point(-1, 493)
        Me.BackLbl.Name = "BackLbl"
        Me.BackLbl.Padding = New System.Windows.Forms.Padding(32, 12, 0, 0)
        Me.BackLbl.Size = New System.Drawing.Size(189, 53)
        Me.BackLbl.TabIndex = 22
        Me.BackLbl.Text = "< Back"
        '
        'RemoveLbl
        '
        Me.RemoveLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RemoveLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RemoveLbl.Font = New System.Drawing.Font("Lato", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveLbl.ForeColor = System.Drawing.Color.White
        Me.RemoveLbl.Location = New System.Drawing.Point(187, 493)
        Me.RemoveLbl.Name = "RemoveLbl"
        Me.RemoveLbl.Padding = New System.Windows.Forms.Padding(55, 12, 0, 0)
        Me.RemoveLbl.Size = New System.Drawing.Size(188, 53)
        Me.RemoveLbl.TabIndex = 23
        Me.RemoveLbl.Text = "Remove >"
        '
        'SelectLocationLbl
        '
        Me.SelectLocationLbl.AutoSize = True
        Me.SelectLocationLbl.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectLocationLbl.ForeColor = System.Drawing.Color.Black
        Me.SelectLocationLbl.Location = New System.Drawing.Point(66, 78)
        Me.SelectLocationLbl.Name = "SelectLocationLbl"
        Me.SelectLocationLbl.Size = New System.Drawing.Size(241, 19)
        Me.SelectLocationLbl.TabIndex = 24
        Me.SelectLocationLbl.Text = "Select location(s) to be removed :"
        '
        'RemovePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(375, 546)
        Me.Controls.Add(Me.SelectLocationLbl)
        Me.Controls.Add(Me.RemoveLbl)
        Me.Controls.Add(Me.BackLbl)
        Me.Controls.Add(Me.RemoveLocationList)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Header)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RemovePage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Weather Monitor"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Header As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents RemoveLocationList As System.Windows.Forms.ListBox
    Friend WithEvents BackLbl As System.Windows.Forms.Label
    Friend WithEvents RemoveLbl As System.Windows.Forms.Label
    Friend WithEvents SelectLocationLbl As System.Windows.Forms.Label
End Class
