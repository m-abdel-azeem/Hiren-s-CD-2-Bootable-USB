<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.ComboBox_usblist = New System.Windows.Forms.ComboBox()
        Me.install_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.refresh_btn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.update_timer = New System.Windows.Forms.Timer(Me.components)
        Me.Iso_open_btn = New System.Windows.Forms.Button()
        Me.Iso_open_txtbx = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.inprogress_lbl = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.mMenu = New System.Windows.Forms.MenuStrip()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BrowseForIsoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstallIsoToUSBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestUSBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_FacePage = New System.Windows.Forms.Button()
        Me.BgWorker_install = New System.ComponentModel.BackgroundWorker()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.StatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BgWorker_delete = New System.ComponentModel.BackgroundWorker()
        Me.mMenu.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBox_usblist
        '
        Me.ComboBox_usblist.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_usblist.ForeColor = System.Drawing.Color.Blue
        Me.ComboBox_usblist.FormattingEnabled = True
        Me.ComboBox_usblist.Location = New System.Drawing.Point(112, 89)
        Me.ComboBox_usblist.Name = "ComboBox_usblist"
        Me.ComboBox_usblist.Size = New System.Drawing.Size(407, 27)
        Me.ComboBox_usblist.TabIndex = 0
        '
        'install_btn
        '
        Me.install_btn.Enabled = False
        Me.install_btn.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.install_btn.Image = Global.Hirens2BootableUSB.My.Resources.Resources.Install
        Me.install_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.install_btn.Location = New System.Drawing.Point(181, 196)
        Me.install_btn.Name = "install_btn"
        Me.install_btn.Size = New System.Drawing.Size(285, 57)
        Me.install_btn.TabIndex = 4
        Me.install_btn.Text = "               Install Hiren's iso to USB"
        Me.install_btn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(15, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "USB Drive:"
        '
        'refresh_btn
        '
        Me.refresh_btn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refresh_btn.Image = Global.Hirens2BootableUSB.My.Resources.Resources.Refresh
        Me.refresh_btn.Location = New System.Drawing.Point(525, 87)
        Me.refresh_btn.Name = "refresh_btn"
        Me.refresh_btn.Size = New System.Drawing.Size(100, 33)
        Me.refresh_btn.TabIndex = 1
        Me.refresh_btn.Text = "      Refresh"
        Me.refresh_btn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.6!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(37, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(223, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Select Your USB Drive,      "
        '
        'update_timer
        '
        Me.update_timer.Interval = 1500
        '
        'Iso_open_btn
        '
        Me.Iso_open_btn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Iso_open_btn.Image = Global.Hirens2BootableUSB.My.Resources.Resources.CD
        Me.Iso_open_btn.Location = New System.Drawing.Point(525, 135)
        Me.Iso_open_btn.Name = "Iso_open_btn"
        Me.Iso_open_btn.Size = New System.Drawing.Size(100, 33)
        Me.Iso_open_btn.TabIndex = 2
        Me.Iso_open_btn.Text = "      Browse"
        Me.Iso_open_btn.UseVisualStyleBackColor = True
        '
        'Iso_open_txtbx
        '
        Me.Iso_open_txtbx.AllowDrop = True
        Me.Iso_open_txtbx.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Iso_open_txtbx.ForeColor = System.Drawing.Color.Blue
        Me.Iso_open_txtbx.Location = New System.Drawing.Point(112, 137)
        Me.Iso_open_txtbx.Name = "Iso_open_txtbx"
        Me.Iso_open_txtbx.Size = New System.Drawing.Size(407, 27)
        Me.Iso_open_txtbx.TabIndex = 3
        Me.Iso_open_txtbx.Text = "Browse for Hiren's iso file or drop it here"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(15, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 18)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Iso File:"
        '
        'inprogress_lbl
        '
        Me.inprogress_lbl.AutoSize = True
        Me.inprogress_lbl.BackColor = System.Drawing.Color.Transparent
        Me.inprogress_lbl.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inprogress_lbl.ForeColor = System.Drawing.Color.Red
        Me.inprogress_lbl.Location = New System.Drawing.Point(177, 171)
        Me.inprogress_lbl.Name = "inprogress_lbl"
        Me.inprogress_lbl.Size = New System.Drawing.Size(294, 18)
        Me.inprogress_lbl.TabIndex = 9
        Me.inprogress_lbl.Text = "Installation in progress, Please wait..."
        Me.inprogress_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.inprogress_lbl.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightGray
        Me.Label4.Location = New System.Drawing.Point(4, 277)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Mohamad Abd El-Azeem"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 11.6!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(227, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 19)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Select Iso File, "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 11.6!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(357, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(255, 19)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Then Click Install BootLoader."
        '
        'mMenu
        '
        Me.mMenu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.mMenu.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolsToolStripMenuItem, Me.TestUSBToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.mMenu.Location = New System.Drawing.Point(0, 0)
        Me.mMenu.Name = "mMenu"
        Me.mMenu.Size = New System.Drawing.Size(643, 24)
        Me.mMenu.TabIndex = 14
        Me.mMenu.Text = "MenuStrip1"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem, Me.BrowseForIsoToolStripMenuItem, Me.InstallIsoToUSBToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'BrowseForIsoToolStripMenuItem
        '
        Me.BrowseForIsoToolStripMenuItem.Name = "BrowseForIsoToolStripMenuItem"
        Me.BrowseForIsoToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.BrowseForIsoToolStripMenuItem.Text = "Browse For Hiren's iso"
        '
        'InstallIsoToUSBToolStripMenuItem
        '
        Me.InstallIsoToUSBToolStripMenuItem.Enabled = False
        Me.InstallIsoToUSBToolStripMenuItem.Name = "InstallIsoToUSBToolStripMenuItem"
        Me.InstallIsoToUSBToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.InstallIsoToUSBToolStripMenuItem.Text = "Install iso To USB"
        '
        'TestUSBToolStripMenuItem
        '
        Me.TestUSBToolStripMenuItem.Name = "TestUSBToolStripMenuItem"
        Me.TestUSBToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.TestUSBToolStripMenuItem.Text = "Test USB"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'btn_FacePage
        '
        Me.btn_FacePage.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_FacePage.Image = Global.Hirens2BootableUSB.My.Resources.Resources.facebook
        Me.btn_FacePage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_FacePage.Location = New System.Drawing.Point(500, 257)
        Me.btn_FacePage.Name = "btn_FacePage"
        Me.btn_FacePage.Size = New System.Drawing.Size(138, 33)
        Me.btn_FacePage.TabIndex = 15
        Me.btn_FacePage.Text = "       FaceBook Page"
        Me.btn_FacePage.UseVisualStyleBackColor = True
        '
        'BgWorker_install
        '
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 296)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(643, 22)
        Me.StatusStrip1.TabIndex = 16
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StatusLabel1
        '
        Me.StatusLabel1.Name = "StatusLabel1"
        Me.StatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'BgWorker_delete
        '
        '
        'Main
        '
        Me.AcceptButton = Me.install_btn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Hirens2BootableUSB.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(643, 318)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btn_FacePage)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.inprogress_lbl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Iso_open_txtbx)
        Me.Controls.Add(Me.Iso_open_btn)
        Me.Controls.Add(Me.refresh_btn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.install_btn)
        Me.Controls.Add(Me.ComboBox_usblist)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.mMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mMenu
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hiren's CD to Bootable USB."
        Me.mMenu.ResumeLayout(False)
        Me.mMenu.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox_usblist As System.Windows.Forms.ComboBox
    Friend WithEvents install_btn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents refresh_btn As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents update_timer As System.Windows.Forms.Timer
    Friend WithEvents Iso_open_btn As System.Windows.Forms.Button
    Friend WithEvents Iso_open_txtbx As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents inprogress_lbl As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents mMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BrowseForIsoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InstallIsoToUSBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TestUSBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_FacePage As System.Windows.Forms.Button
    Friend WithEvents BgWorker_install As System.ComponentModel.BackgroundWorker
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents StatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents BgWorker_delete As System.ComponentModel.BackgroundWorker

End Class
