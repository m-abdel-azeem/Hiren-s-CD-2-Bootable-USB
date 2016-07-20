<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Version_lbl = New System.Windows.Forms.Label()
        Me.copyright_lbl = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = Global.Hirens2BootableUSB.My.Resources.Resources.LOGO_2
        Me.PictureBox1.Location = New System.Drawing.Point(9, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(154, 154)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(619, 204)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(170, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 14)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Hiren's CD to Bootable USB"
        '
        'Version_lbl
        '
        Me.Version_lbl.AutoSize = True
        Me.Version_lbl.BackColor = System.Drawing.Color.Transparent
        Me.Version_lbl.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Version_lbl.ForeColor = System.Drawing.Color.White
        Me.Version_lbl.Location = New System.Drawing.Point(342, 14)
        Me.Version_lbl.Name = "Version_lbl"
        Me.Version_lbl.Size = New System.Drawing.Size(116, 14)
        Me.Version_lbl.TabIndex = 3
        Me.Version_lbl.Text = "@version_number"
        '
        'copyright_lbl
        '
        Me.copyright_lbl.AutoSize = True
        Me.copyright_lbl.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.copyright_lbl.Location = New System.Drawing.Point(31, 200)
        Me.copyright_lbl.Name = "copyright_lbl"
        Me.copyright_lbl.Size = New System.Drawing.Size(74, 14)
        Me.copyright_lbl.TabIndex = 4
        Me.copyright_lbl.Text = "@copyrights"
        Me.copyright_lbl.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(39, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Freeware 2015"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(170, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 14)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "For Bugs and Suggestions"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ForeColor = System.Drawing.Color.Silver
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Chartreuse
        Me.LinkLabel1.Location = New System.Drawing.Point(318, 185)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(166, 14)
        Me.LinkLabel1.TabIndex = 7
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "m.abdel-azeem@hotmail.com"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(182, 45)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(506, 84)
        Me.TextBox1.TabIndex = 8
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.ForeColor = System.Drawing.Color.Silver
        Me.LinkLabel2.LinkColor = System.Drawing.Color.Chartreuse
        Me.LinkLabel2.Location = New System.Drawing.Point(225, 140)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(269, 14)
        Me.LinkLabel2.TabIndex = 9
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "http://sourceforge.net/p/hirenscd2bootableusb"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(170, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 14)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Website:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(170, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 14)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "FaceBook:"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel3.ForeColor = System.Drawing.Color.Silver
        Me.LinkLabel3.LinkColor = System.Drawing.Color.Chartreuse
        Me.LinkLabel3.Location = New System.Drawing.Point(232, 161)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(461, 14)
        Me.LinkLabel3.TabIndex = 11
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "https://www.facebook.com/pages/Hirens-CD-2-Bootable-USB/1440129386302328"
        '
        'About
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Hirens2BootableUSB.My.Resources.Resources.Background
        Me.ClientSize = New System.Drawing.Size(704, 235)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LinkLabel3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.copyright_lbl)
        Me.Controls.Add(Me.Version_lbl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "About"
        Me.Opacity = 0.98R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About Hiren's CD to Bootable USB"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Version_lbl As System.Windows.Forms.Label
    Friend WithEvents copyright_lbl As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
End Class
