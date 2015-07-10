<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoadingPage
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoadingPage))
        Me.LoadingBar = New System.Windows.Forms.ProgressBar()
        Me.LoadingTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LoadingBar
        '
        Me.LoadingBar.BackColor = System.Drawing.SystemColors.ControlDark
        Me.LoadingBar.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.LoadingBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LoadingBar.ForeColor = System.Drawing.SystemColors.Control
        Me.LoadingBar.Location = New System.Drawing.Point(0, 498)
        Me.LoadingBar.Name = "LoadingBar"
        Me.LoadingBar.Size = New System.Drawing.Size(493, 14)
        Me.LoadingBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.LoadingBar.TabIndex = 0
        '
        'LoadingTimer
        '
        Me.LoadingTimer.Interval = 500
        '
        'Logo
        '
        Me.Logo.BackColor = System.Drawing.Color.Transparent
        Me.Logo.Image = Global.FIT3077_Assignment.My.Resources.Resources.logo
        Me.Logo.Location = New System.Drawing.Point(116, 156)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(266, 167)
        Me.Logo.TabIndex = 1
        Me.Logo.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.FIT3077_Assignment.My.Resources.Resources.monash
        Me.PictureBox1.Location = New System.Drawing.Point(142, 111)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(223, 26)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'LoadingPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FIT3077_Assignment.My.Resources.Resources.Loading_Page_Background
        Me.ClientSize = New System.Drawing.Size(493, 512)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Logo)
        Me.Controls.Add(Me.LoadingBar)
        Me.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LoadingPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Weather Monitor"
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LoadingBar As System.Windows.Forms.ProgressBar
    Friend WithEvents LoadingTimer As System.Windows.Forms.Timer
    Friend WithEvents Logo As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
