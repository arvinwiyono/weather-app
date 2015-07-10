<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainPage))
        Me.Header = New System.Windows.Forms.Label()
        Me.AddLocationLbl = New System.Windows.Forms.Label()
        Me.LocationsListBox = New System.Windows.Forms.ListBox()
        Me.SelectLocationLbl = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MonitorComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ServerComboBox = New System.Windows.Forms.ComboBox()
        Me.SelectServerLbl = New System.Windows.Forms.Label()
        Me.RainfallCheck = New System.Windows.Forms.CheckBox()
        Me.TemperatureCheck = New System.Windows.Forms.CheckBox()
        Me.SelectInfoLbl = New System.Windows.Forms.Label()
        Me.Footer = New System.Windows.Forms.Label()
        Me.RemoveLocationLbl = New System.Windows.Forms.Label()
        Me.UpdateBar = New System.Windows.Forms.ProgressBar()
        Me.TimeLapseTimer = New System.Windows.Forms.Timer(Me.components)
        Me.FlowPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.IntroPict = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RefreshPict = New System.Windows.Forms.PictureBox()
        Me.Graphic = New System.Windows.Forms.PictureBox()
        Me.LiveTimer = New System.Windows.Forms.Timer(Me.components)
        Me.UpdateNumberLbl = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.IntroPict, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RefreshPict, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Graphic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Header
        '
        Me.Header.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header.Location = New System.Drawing.Point(0, 0)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(1444, 53)
        Me.Header.TabIndex = 0
        '
        'AddLocationLbl
        '
        Me.AddLocationLbl.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.AddLocationLbl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddLocationLbl.Font = New System.Drawing.Font("Lato", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddLocationLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AddLocationLbl.Location = New System.Drawing.Point(0, 0)
        Me.AddLocationLbl.Name = "AddLocationLbl"
        Me.AddLocationLbl.Padding = New System.Windows.Forms.Padding(50, 12, 0, 0)
        Me.AddLocationLbl.Size = New System.Drawing.Size(264, 53)
        Me.AddLocationLbl.TabIndex = 1
        Me.AddLocationLbl.Text = "+ Add Location"
        '
        'LocationsListBox
        '
        Me.LocationsListBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LocationsListBox.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocationsListBox.FormattingEnabled = True
        Me.LocationsListBox.ItemHeight = 19
        Me.LocationsListBox.Location = New System.Drawing.Point(24, 217)
        Me.LocationsListBox.Name = "LocationsListBox"
        Me.LocationsListBox.Size = New System.Drawing.Size(215, 441)
        Me.LocationsListBox.TabIndex = 2
        '
        'SelectLocationLbl
        '
        Me.SelectLocationLbl.AutoSize = True
        Me.SelectLocationLbl.BackColor = System.Drawing.Color.Transparent
        Me.SelectLocationLbl.Font = New System.Drawing.Font("Lato", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectLocationLbl.ForeColor = System.Drawing.Color.Black
        Me.SelectLocationLbl.Location = New System.Drawing.Point(20, 184)
        Me.SelectLocationLbl.Name = "SelectLocationLbl"
        Me.SelectLocationLbl.Size = New System.Drawing.Size(138, 21)
        Me.SelectLocationLbl.TabIndex = 3
        Me.SelectLocationLbl.Text = "Select a location:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.MonitorComboBox)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ServerComboBox)
        Me.Panel1.Controls.Add(Me.SelectServerLbl)
        Me.Panel1.Controls.Add(Me.SelectLocationLbl)
        Me.Panel1.Controls.Add(Me.LocationsListBox)
        Me.Panel1.Location = New System.Drawing.Point(-1, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(265, 686)
        Me.Panel1.TabIndex = 4
        '
        'MonitorComboBox
        '
        Me.MonitorComboBox.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonitorComboBox.FormattingEnabled = True
        Me.MonitorComboBox.Items.AddRange(New Object() {"Text Monitor", "Graph Monitor"})
        Me.MonitorComboBox.Location = New System.Drawing.Point(24, 126)
        Me.MonitorComboBox.Name = "MonitorComboBox"
        Me.MonitorComboBox.Size = New System.Drawing.Size(215, 27)
        Me.MonitorComboBox.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lato", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(20, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 21)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Select monitor type:"
        '
        'ServerComboBox
        '
        Me.ServerComboBox.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServerComboBox.FormattingEnabled = True
        Me.ServerComboBox.Items.AddRange(New Object() {"Live Server", "Time Lapse Server"})
        Me.ServerComboBox.Location = New System.Drawing.Point(24, 43)
        Me.ServerComboBox.Name = "ServerComboBox"
        Me.ServerComboBox.Size = New System.Drawing.Size(215, 27)
        Me.ServerComboBox.TabIndex = 5
        '
        'SelectServerLbl
        '
        Me.SelectServerLbl.AutoSize = True
        Me.SelectServerLbl.BackColor = System.Drawing.Color.Transparent
        Me.SelectServerLbl.Font = New System.Drawing.Font("Lato", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectServerLbl.ForeColor = System.Drawing.Color.Black
        Me.SelectServerLbl.Location = New System.Drawing.Point(20, 17)
        Me.SelectServerLbl.Name = "SelectServerLbl"
        Me.SelectServerLbl.Size = New System.Drawing.Size(122, 21)
        Me.SelectServerLbl.TabIndex = 4
        Me.SelectServerLbl.Text = "Select a server:"
        '
        'RainfallCheck
        '
        Me.RainfallCheck.AutoSize = True
        Me.RainfallCheck.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RainfallCheck.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RainfallCheck.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RainfallCheck.ForeColor = System.Drawing.Color.White
        Me.RainfallCheck.Location = New System.Drawing.Point(402, 27)
        Me.RainfallCheck.Name = "RainfallCheck"
        Me.RainfallCheck.Size = New System.Drawing.Size(81, 23)
        Me.RainfallCheck.TabIndex = 6
        Me.RainfallCheck.Text = "Rainfall"
        Me.RainfallCheck.UseVisualStyleBackColor = False
        '
        'TemperatureCheck
        '
        Me.TemperatureCheck.AutoSize = True
        Me.TemperatureCheck.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TemperatureCheck.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TemperatureCheck.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TemperatureCheck.ForeColor = System.Drawing.Color.White
        Me.TemperatureCheck.Location = New System.Drawing.Point(280, 27)
        Me.TemperatureCheck.Name = "TemperatureCheck"
        Me.TemperatureCheck.Size = New System.Drawing.Size(116, 23)
        Me.TemperatureCheck.TabIndex = 5
        Me.TemperatureCheck.Text = "Temperature"
        Me.TemperatureCheck.UseVisualStyleBackColor = False
        '
        'SelectInfoLbl
        '
        Me.SelectInfoLbl.AutoSize = True
        Me.SelectInfoLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SelectInfoLbl.Font = New System.Drawing.Font("Lato", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectInfoLbl.ForeColor = System.Drawing.Color.White
        Me.SelectInfoLbl.Location = New System.Drawing.Point(277, 5)
        Me.SelectInfoLbl.Name = "SelectInfoLbl"
        Me.SelectInfoLbl.Size = New System.Drawing.Size(160, 21)
        Me.SelectInfoLbl.TabIndex = 4
        Me.SelectInfoLbl.Text = "Select weather info:"
        '
        'Footer
        '
        Me.Footer.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Footer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Footer.Location = New System.Drawing.Point(0, 739)
        Me.Footer.Name = "Footer"
        Me.Footer.Size = New System.Drawing.Size(1444, 53)
        Me.Footer.TabIndex = 5
        '
        'RemoveLocationLbl
        '
        Me.RemoveLocationLbl.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.RemoveLocationLbl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RemoveLocationLbl.Font = New System.Drawing.Font("Lato", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveLocationLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RemoveLocationLbl.Location = New System.Drawing.Point(1217, 1)
        Me.RemoveLocationLbl.Margin = New System.Windows.Forms.Padding(0)
        Me.RemoveLocationLbl.Name = "RemoveLocationLbl"
        Me.RemoveLocationLbl.Padding = New System.Windows.Forms.Padding(33, 12, 0, 0)
        Me.RemoveLocationLbl.Size = New System.Drawing.Size(227, 52)
        Me.RemoveLocationLbl.TabIndex = 13
        Me.RemoveLocationLbl.Text = "Remove Location"
        '
        'UpdateBar
        '
        Me.UpdateBar.Enabled = False
        Me.UpdateBar.Location = New System.Drawing.Point(900, 770)
        Me.UpdateBar.Name = "UpdateBar"
        Me.UpdateBar.Size = New System.Drawing.Size(514, 8)
        Me.UpdateBar.TabIndex = 16
        Me.UpdateBar.Visible = False
        '
        'TimeLapseTimer
        '
        Me.TimeLapseTimer.Interval = 1
        '
        'FlowPanel
        '
        Me.FlowPanel.AutoScroll = True
        Me.FlowPanel.BackColor = System.Drawing.Color.Transparent
        Me.FlowPanel.Location = New System.Drawing.Point(265, 53)
        Me.FlowPanel.Name = "FlowPanel"
        Me.FlowPanel.Padding = New System.Windows.Forms.Padding(15, 8, 0, 0)
        Me.FlowPanel.Size = New System.Drawing.Size(1179, 666)
        Me.FlowPanel.TabIndex = 21
        Me.FlowPanel.Visible = False
        '
        'IntroPict
        '
        Me.IntroPict.BackColor = System.Drawing.Color.Transparent
        Me.IntroPict.Image = Global.FIT3077_Assignment.My.Resources.Resources.intro_logo2
        Me.IntroPict.Location = New System.Drawing.Point(551, 155)
        Me.IntroPict.Name = "IntroPict"
        Me.IntroPict.Size = New System.Drawing.Size(644, 458)
        Me.IntroPict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IntroPict.TabIndex = 20
        Me.IntroPict.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox1.Image = Global.FIT3077_Assignment.My.Resources.Resources.footer_logo
        Me.PictureBox1.Location = New System.Drawing.Point(23, 745)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(230, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'RefreshPict
        '
        Me.RefreshPict.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RefreshPict.Image = Global.FIT3077_Assignment.My.Resources.Resources.Refresh
        Me.RefreshPict.Location = New System.Drawing.Point(912, 747)
        Me.RefreshPict.Name = "RefreshPict"
        Me.RefreshPict.Size = New System.Drawing.Size(16, 16)
        Me.RefreshPict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RefreshPict.TabIndex = 18
        Me.RefreshPict.TabStop = False
        Me.RefreshPict.Visible = False
        '
        'Graphic
        '
        Me.Graphic.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Graphic.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Graphic.Image = Global.FIT3077_Assignment.My.Resources.Resources.icon_white
        Me.Graphic.Location = New System.Drawing.Point(805, 11)
        Me.Graphic.Name = "Graphic"
        Me.Graphic.Size = New System.Drawing.Size(34, 32)
        Me.Graphic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Graphic.TabIndex = 12
        Me.Graphic.TabStop = False
        '
        'LiveTimer
        '
        Me.LiveTimer.Interval = 1
        '
        'UpdateNumberLbl
        '
        Me.UpdateNumberLbl.AutoSize = True
        Me.UpdateNumberLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.UpdateNumberLbl.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateNumberLbl.ForeColor = System.Drawing.Color.White
        Me.UpdateNumberLbl.Location = New System.Drawing.Point(934, 747)
        Me.UpdateNumberLbl.Name = "UpdateNumberLbl"
        Me.UpdateNumberLbl.Size = New System.Drawing.Size(50, 16)
        Me.UpdateNumberLbl.TabIndex = 17
        Me.UpdateNumberLbl.Text = "Update"
        Me.UpdateNumberLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UpdateNumberLbl.Visible = False
        '
        'MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1444, 792)
        Me.Controls.Add(Me.FlowPanel)
        Me.Controls.Add(Me.IntroPict)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.RainfallCheck)
        Me.Controls.Add(Me.TemperatureCheck)
        Me.Controls.Add(Me.RefreshPict)
        Me.Controls.Add(Me.SelectInfoLbl)
        Me.Controls.Add(Me.UpdateNumberLbl)
        Me.Controls.Add(Me.UpdateBar)
        Me.Controls.Add(Me.RemoveLocationLbl)
        Me.Controls.Add(Me.Graphic)
        Me.Controls.Add(Me.Footer)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.AddLocationLbl)
        Me.Controls.Add(Me.Header)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Weather Monitor"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.IntroPict, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RefreshPict, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Graphic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Header As System.Windows.Forms.Label
    Friend WithEvents AddLocationLbl As System.Windows.Forms.Label
    Friend WithEvents LocationsListBox As System.Windows.Forms.ListBox
    Friend WithEvents SelectLocationLbl As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Footer As System.Windows.Forms.Label
    Friend WithEvents RemoveLocationLbl As System.Windows.Forms.Label
    Friend WithEvents UpdateBar As System.Windows.Forms.ProgressBar
    Friend WithEvents RefreshPict As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TimeLapseTimer As System.Windows.Forms.Timer
    Friend WithEvents RainfallCheck As System.Windows.Forms.CheckBox
    Friend WithEvents TemperatureCheck As System.Windows.Forms.CheckBox
    Friend WithEvents SelectInfoLbl As System.Windows.Forms.Label
    Friend WithEvents Graphic As System.Windows.Forms.PictureBox
    Friend WithEvents IntroPict As System.Windows.Forms.PictureBox
    Friend WithEvents FlowPanel As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents SelectServerLbl As System.Windows.Forms.Label
    Friend WithEvents ServerComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents MonitorComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LiveTimer As System.Windows.Forms.Timer
    Friend WithEvents UpdateNumberLbl As System.Windows.Forms.Label

End Class
