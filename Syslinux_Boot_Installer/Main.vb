Imports System
Imports System.IO

Public Class Main
    Public usblist()
    Public usbletter As String
    Public filesok As Boolean
    Public usbformattype As String
    Public usbcount As Integer = 0
    Public isopath As String = ""
    Public drives2extract As String = ""
    'Public lastdir As String = My.Computer.FileSystem.SpecialDirectories.Desktop
    Public lastdir As String = My.Settings.DefaultPath
    Public tempisthere As Boolean
    Public roller As Integer = 0
    Public lastokdir As String = My.Computer.FileSystem.SpecialDirectories.Desktop
    Public Dragged_file() As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If isopath <> "" Then
            If File.Exists(isopath) Then
                Iso_open_txtbx.Text = isopath
            End If
        Else
        End If

        Control.CheckForIllegalCrossThreadCalls = False

loadContinue:
        update_timer.Enabled = True
        load_usb_drives()
        ComboBox_usblist.Refresh()

        ' Process.Start("https://www.facebook.com/pages/Hirens-CD-2-Bootable-USB/1440129386302328")

    End Sub

    Private Sub load_usb_drives()
        ' Dim Variables with intial values.
        drives2extract = ""
        usbcount = 0
        Dim i As Integer = 1
        Dim allDrives() As DriveInfo = DriveInfo.GetDrives()
        Dim d As DriveInfo

        ' Check if there are USB drives. and check if free space in other drives.
        For Each d In allDrives
            If d.DriveType = DriveType.Removable And d.IsReady Then
                usbcount = usbcount + 1
            End If

            If d.DriveType = DriveType.Fixed Then
                If d.AvailableFreeSpace > 1073741824 Then
                    drives2extract = drives2extract + d.Name
                End If
            End If
        Next

        If Directory.Exists(drives2extract.Substring(0, 2) + "\temp") Then
            tempisthere = True
        Else
            tempisthere = False
        End If
        'MsgBox(usbcount)
        'MsgBox(drives2extract)

        ' Clear USB list.
        ComboBox_usblist.Items.Clear()

        If usbcount > 0 Then
            ReDim usblist(usbcount)
            Iso_open_btn.Enabled = True
            BrowseForIsoToolStripMenuItem.Enabled = True
            Iso_open_txtbx.Enabled = True
            Iso_open_txtbx.Text = "Browse for Hiren's iso file or drop it here"
            ComboBox_usblist.Text = ""
        Else
            Iso_open_btn.Enabled = False
            BrowseForIsoToolStripMenuItem.Enabled = False
            install_btn.Enabled = False
            InstallIsoToUSBToolStripMenuItem.Enabled = False
            Iso_open_txtbx.Enabled = False
            Iso_open_txtbx.Text = ""
            ComboBox_usblist.ForeColor = Color.Red
            Iso_open_txtbx.Text = ""
            ComboBox_usblist.Text = "No USB Drives have been detected..."
            Return
        End If

        ComboBox_usblist.ForeColor = Color.Blue

        For Each d In allDrives
            If d.DriveType = DriveType.Removable And d.IsReady Then
                usblist(i) = "(" + d.Name + "  -  " + d.VolumeLabel + "  -  " + d.DriveFormat + "  -  " + (d.TotalSize / 1024 / 1024 / 1024).ToString("0.00") + "GB)"
                'MsgBox(usblist(i))
                ComboBox_usblist.Items.Add(usblist(i))
            End If
            'Console.WriteLine("Drive {0}", d.Name)
            'Console.WriteLine("  Drive type: {0}", d.DriveType)
            'Console.WriteLine("  Volume label: {0}", d.VolumeLabel)
            'Console.WriteLine("  File system: {0}", d.DriveFormat)
            'Console.WriteLine( _
            '    "  Available space to current user:{0, 15} bytes", _
            '    d.AvailableFreeSpace)
            'Console.WriteLine( _
            '    "  Total available space:          {0, 15} bytes", _
            '    d.TotalFreeSpace)
            'Console.WriteLine( _
            '    "  Total size of drive:            {0, 15} bytes ", _
            '    d.TotalSize)
        Next

        ComboBox_usblist.SelectedIndex = 0

    End Sub

    Private Sub ComboBox_usblist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_usblist.SelectedIndexChanged
        Dim selectedusbinfoarr() = ComboBox_usblist.SelectedItem.ToString.Split("-")
        usbletter = selectedusbinfoarr(0).Substring(1, 2)
        usbformattype = selectedusbinfoarr(2).Substring(2, 5)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles install_btn.Click
        If Not BgWorker_install.IsBusy Then BgWorker_install.RunWorkerAsync()
    End Sub

    Private Sub refresh_btn_Click(sender As Object, e As EventArgs) Handles refresh_btn.Click
        load_usb_drives()
    End Sub

    Private Sub Iso_open_btn_Click(sender As Object, e As EventArgs) Handles Iso_open_btn.Click
        Browse_For_ISO_SUB()
    End Sub


    Private Sub Browse_For_ISO_SUB()
        Dim dDilaoge As New OpenFileDialog
        dDilaoge.Filter = "Iso Files|*.iso"
        dDilaoge.Title = "Browse for Hiren's ISO File."
        dDilaoge.InitialDirectory = lastdir
        'dDilaoge.FileName = "CMD_Projectname"
        'dDilaoge.ShowDialog()

        If dDilaoge.ShowDialog() = DialogResult.OK Then
            Dim filename As String = dDilaoge.FileName
            isopath = filename
            Iso_open_txtbx.Text = filename
            install_btn.Enabled = True
            InstallIsoToUSBToolStripMenuItem.Enabled = True
            Dim pathparts As String() = filename.Split("\")
            lastdir = pathparts(0)
            'MsgBox(pathparts.Length.ToString)
            For i = 1 To pathparts.Length - 2
                lastdir = lastdir + "\" + pathparts(i)
            Next
            'MsgBox(lastdir)
            lastokdir = lastdir
        Else
            isopath = ""
            Iso_open_txtbx.Text = ""
            install_btn.Enabled = False
            InstallIsoToUSBToolStripMenuItem.Enabled = False
            lastdir = lastokdir
        End If
    End Sub
    Private Sub DeleteTempFiles()

        If Not BgWorker_delete.IsBusy Then BgWorker_delete.RunWorkerAsync()

    End Sub


    Private Sub update_timer_Tick(sender As Object, e As EventArgs) Handles update_timer.Tick
        Select Case roller
            Case 0
                Label2.ForeColor = Color.LimeGreen
                Me.Text = "Hiren 's CD to Bootable USB.     1- Select your USB drive"
            Case 1
                Me.Text = "Hiren 's CD to Bootable USB.     2- Select Hiren's iso file"
                Label2.ForeColor = Color.White
                Label5.ForeColor = Color.LimeGreen
            Case 2
                Me.Text = "Hiren 's CD to Bootable USB.     3- Install it"
                Label5.ForeColor = Color.White
                Label6.ForeColor = Color.LimeGreen
            Case 3
                Me.Text = "Hiren 's CD to Bootable USB. - Mohamad AbdelAzeem - m.abdel-azeem@hotmail.com"
                Label6.ForeColor = Color.White
            Case 4
                Me.Text = "Hiren 's CD to Bootable USB."
                roller = 0
                Return
        End Select

        roller = roller + 1

    End Sub

    Private Sub load_fixed_drives()
        ' Dim Variables with intial values.
        drives2extract = ""

        Dim i As Integer = 1

        Dim allDrives() As DriveInfo = DriveInfo.GetDrives()
        Dim d As DriveInfo

        ' Check if there are USB drives. and check if free space in other drives.
        For Each d In allDrives
            If d.DriveType = DriveType.Fixed Then
                If d.AvailableFreeSpace > 1073741824 Then
                    drives2extract = drives2extract + d.Name
                End If
            End If
        Next

        If Directory.Exists(drives2extract.Substring(0, 2) + "\temp") Then
            tempisthere = True
        Else
            tempisthere = False
        End If
        'MsgBox(usbcount)
        'MsgBox(drives2extract)

    End Sub

    Private Sub Iso_open_txtbx_DragDrop(sender As Object, e As DragEventArgs) Handles Iso_open_txtbx.DragDrop

        isopath = Dragged_file(0)
        Iso_open_txtbx.Text = Dragged_file(0)
        install_btn.Enabled = True
        InstallIsoToUSBToolStripMenuItem.Enabled = True
        Dim pathparts As String() = Dragged_file(0).Split("\")
        lastdir = pathparts(0)
        For i = 1 To pathparts.Length - 2
            lastdir = lastdir + "\" + pathparts(i)
        Next
        lastokdir = lastdir

    End Sub

    Private Sub Iso_open_txtbx_DragEnter(sender As Object, e As DragEventArgs) Handles Iso_open_txtbx.DragEnter

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dragged_file = e.Data.GetData(DataFormats.FileDrop)
            Dim Pathparts() = Split(Dragged_file(0), ".")
            If Pathparts(Pathparts.Length - 1) = "iso" Then
                e.Effect = DragDropEffects.All
            End If
        End If

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim dABOUT As New About
        dABOUT.ShowDialog()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        load_usb_drives()
    End Sub

    Private Sub BrowseForIsoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BrowseForIsoToolStripMenuItem.Click
        Browse_For_ISO_SUB()
    End Sub


    Private Sub InstallIsoToUSBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstallIsoToUSBToolStripMenuItem.Click
        If Not BgWorker_install.IsBusy Then BgWorker_install.RunWorkerAsync()
    End Sub

    Private Sub TestUSBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TestUSBToolStripMenuItem.Click

        If Directory.Exists(usbletter) Then
            GoTo QEMU_Start
        Else
            MsgBox("No USB disk has been detected or it has been removed. Connect a USB disk and try again.", MsgBoxStyle.Exclamation, "Testing Failed")
            Return
        End If

QEMU_Start:
        'Extract qemu file.
        My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.Temp + "\cc7zx")
        My.Computer.FileSystem.WriteAllBytes(My.Computer.FileSystem.SpecialDirectories.Temp + "\cc7zx\7z.exe", My.Resources.exe7z, False)
        My.Computer.FileSystem.WriteAllBytes(My.Computer.FileSystem.SpecialDirectories.Temp + "\cc7zx\7z.dll", My.Resources.dll7z, False)
        My.Computer.FileSystem.WriteAllBytes(My.Computer.FileSystem.SpecialDirectories.Temp + "\cc7zx\qemu.7z", My.Resources.qemu_7z, False)

        Dim qemu_extract As New Process
        With qemu_extract
            .StartInfo.UseShellExecute = False
            .StartInfo.FileName = My.Computer.FileSystem.SpecialDirectories.Temp + "\cc7zx\7z.exe"
            .StartInfo.Arguments = "x -y " + My.Computer.FileSystem.SpecialDirectories.Temp + "\cc7zx\qemu.7z" + " -o" + My.Computer.FileSystem.SpecialDirectories.Temp + "\cc7zx"
            .StartInfo.WorkingDirectory = My.Computer.FileSystem.SpecialDirectories.Temp + "\cc7zx"
            .StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            .StartInfo.CreateNoWindow = True
            ' MsgBox(.StartInfo.FileName + " " + .StartInfo.Arguments)
        End With
        qemu_extract.Start()
        qemu_extract.WaitForExit()
        qemu_extract.Dispose()

        Dim driveInfoEx As New clsDiskInfoEx

        Dim qemu_run As New Process
        '
        With qemu_run
            '.StartInfo.UseShellExecute = False
            .StartInfo.FileName = My.Computer.FileSystem.SpecialDirectories.Temp + "\cc7zx\qemu.exe"
            .StartInfo.WorkingDirectory = My.Computer.FileSystem.SpecialDirectories.Temp + "\cc7zx"
            .StartInfo.Arguments = " -hda \\.\PhysicalDrive" + Split(driveInfoEx.GetPhysicalDiskParentFor(usbletter))(2)
            .StartInfo.Verb = "runas"
            .StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            'MsgBox(.StartInfo.FileName + .StartInfo.Arguments)
            '.StartInfo.CreateNoWindow = True
        End With
        'Threading.Thread.Sleep(2000)
        Try
            qemu_run.Start()
            qemu_run.WaitForExit()
            qemu_run.Dispose()
        Catch ex As Exception
            MsgBox("Testing USB has been canceled by the user.", MsgBoxStyle.Exclamation, "Testing Canceled")

        End Try


        'Delete Temp files
        Try
            My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.Temp + "\cc7zx\7z.exe", _
                                                 FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
            My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.Temp + "\cc7zx\7z.dll", _
                                         FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
            My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.Temp + "\cc7zx", _
                                                                        FileIO.DeleteDirectoryOption.DeleteAllContents)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_FacePage_Click(sender As Object, e As EventArgs) Handles btn_FacePage.Click
        Process.Start("https://www.facebook.com/pages/Hirens-CD-2-Bootable-USB/1440129386302328")
    End Sub

    Private Sub BgWorker_install_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles BgWorker_install.DoWork
        ' check your drives
        'load_usb_drive()
        If Directory.Exists(usbletter) Then
            GoTo Installation_Start
        Else
            MsgBox("USB disk has been removed. Connect a USB disk and try again.", MsgBoxStyle.Exclamation, "Installation Failed")
            load_usb_drives()
            Return
        End If

Installation_Start:
        update_timer.Enabled = False
        install_btn.Enabled = False
        InstallIsoToUSBToolStripMenuItem.Enabled = False

        StatusLabel1.Text = "Intializing, Please wait..."

        'Threading.Thread.Sleep(1000)

        ' check if it is ok to strat.
        If usbcount > 0 And isopath <> "" And drives2extract <> "" Then
            'MsgBox("Yes" + vbNewLine + usbcount.ToString + vbNewLine + isopath + vbNewLine + drives2extract)
            ' if yes
            If usbformattype <> "FAT32" Then
                ' Format USb Drive.
                If MsgBox("USB drive " + usbletter + " file system is not FAT32. it will be formatted." + vbNewLine + " All data on " + usbletter + " will be lost. Are you sure you want to continue ?", MsgBoxStyle.OkCancel, "Format USB Disk") = MsgBoxResult.Ok Then
                    Dim format As New Process
                    With format
                        .StartInfo.UseShellExecute = False
                        .StartInfo.RedirectStandardOutput = True
                        .StartInfo.RedirectStandardError = True
                        .StartInfo.FileName = "format.com"
                        .StartInfo.Arguments = usbletter + " /FS:FAT32 /V:BOOTMENU /Q"
                        .StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                        .StartInfo.CreateNoWindow = True
                    End With

                    Try
                        StatusLabel1.Text = usbletter + " Format has been started."
                        format.Start()
                    Catch ex As Exception
                        MsgBox(ex.ToString + "Error occurred, Please try again.", MsgBoxStyle.OkOnly, "Error")
                        install_btn.Enabled = True
                        InstallIsoToUSBToolStripMenuItem.Enabled = True
                        update_timer.Enabled = True
                        StatusLabel1.Text = ex.ToString
                        Return
                    End Try
                    format.Dispose()
                    MsgBox("Format Complete.", MsgBoxStyle.Information, "Formating " + usbletter)
                    StatusLabel1.Text = "Format Complete."
                    load_usb_drives()
                    Threading.Thread.Sleep(2000)
                Else
                    MsgBox("Format has been cancelled. Installation failed", MsgBoxStyle.Exclamation, "Installation Failed")
                    install_btn.Enabled = True
                    InstallIsoToUSBToolStripMenuItem.Enabled = True
                    update_timer.Enabled = True
                    StatusLabel1.Text = "Installation Cancelled."
                    Return
                End If
            End If

            StatusLabel1.Text = "Installation in progress, Please wait..."

            ' Install syslinux.
            My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.Temp + "\hb2usb")
            My.Computer.FileSystem.WriteAllBytes(My.Computer.FileSystem.SpecialDirectories.Temp + "\hb2usb\slnx.exe", My.Resources.syslinux, False)
            Dim install As New Process
            With install
                .StartInfo.UseShellExecute = False
                .StartInfo.RedirectStandardOutput = True
                .StartInfo.RedirectStandardError = True
                .StartInfo.FileName = My.Computer.FileSystem.SpecialDirectories.Temp + "\hb2usb\slnx.exe"
                .StartInfo.Arguments = "-m -a " + usbletter
                .StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                .StartInfo.CreateNoWindow = True
            End With

            Try
                install.Start()
            Catch ex As Exception
                MsgBox("Error occurred, Please try again.", MsgBoxStyle.OkOnly, "Error")
                install.Dispose()
                Try
                    My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.Temp + "\hb2usb", _
                                                           FileIO.DeleteDirectoryOption.DeleteAllContents)
                Catch ex0 As Exception
                End Try
                install_btn.Enabled = True
                InstallIsoToUSBToolStripMenuItem.Enabled = True
                update_timer.Enabled = True
                Return
            End Try

            install.Dispose()
            Try
                My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.Temp + "\hb2usb", _
                                                       FileIO.DeleteDirectoryOption.DeleteAllContents)
            Catch ex As Exception
            End Try

            'Extract Iso file.
            My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.Temp + "\cc7z")
            My.Computer.FileSystem.WriteAllBytes(My.Computer.FileSystem.SpecialDirectories.Temp + "\cc7z\7z.exe", My.Resources.exe7z, False)
            My.Computer.FileSystem.WriteAllBytes(My.Computer.FileSystem.SpecialDirectories.Temp + "\cc7z\7z.dll", My.Resources.dll7z, False)

            Dim extract As New Process

            With extract
                .StartInfo.UseShellExecute = False
                .StartInfo.FileName = My.Computer.FileSystem.SpecialDirectories.Temp + "\cc7z\7z.exe"
                .StartInfo.Arguments = "x -y " + isopath + " -o" + drives2extract.Substring(0, 2) + "\temp"
                .StartInfo.WorkingDirectory = My.Computer.FileSystem.SpecialDirectories.Temp + "\cc7z"
                .StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                .StartInfo.CreateNoWindow = True
                ' MsgBox(.StartInfo.FileName + " " + .StartInfo.Arguments)
            End With
            extract.Start()
            extract.WaitForExit()
            extract.Dispose()

            Threading.Thread.Sleep(2000)

            'Delete Temp files
            My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.Temp + "\cc7z\7z.exe", _
                                         FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
            My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.Temp + "\cc7z\7z.dll", _
                                         FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
            My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.Temp + "\cc7z", _
                                                                        FileIO.DeleteDirectoryOption.DeleteAllContents)

            load_fixed_drives()

            StatusLabel1.Text = "Copying Files, Please wait..."

CopyFiles:
            If Directory.Exists(drives2extract.Substring(0, 2) + "\temp\HBCD") And File.Exists(drives2extract.Substring(0, 2) + "\temp\HBCD\menu.lst") _
                                And File.Exists(drives2extract.Substring(0, 2) + "\temp\HBCD\grldr") Then

                If Directory.Exists(drives2extract.Substring(0, 2) + "\temp\Windows Menu.cmd") Then
                    My.Computer.FileSystem.CopyFile(drives2extract.Substring(0, 2) + "\temp\Windows Menu.cmd", usbletter + "\Windows Menu.cmd", True)
                End If

                If Directory.Exists(drives2extract.Substring(0, 2) + "\temp\HBCDMenu.cmd") Then
                    My.Computer.FileSystem.CopyFile(drives2extract.Substring(0, 2) + "\temp\HBCDMenu.cmd", usbletter + "\HBCDMenu.cmd", True)
                End If

                My.Computer.FileSystem.CopyFile(drives2extract.Substring(0, 2) + "\temp\HBCD\menu.lst", usbletter + "\menu.lst", True)
                My.Computer.FileSystem.CopyFile(drives2extract.Substring(0, 2) + "\temp\HBCD\grldr", usbletter + "\grldr", True)

                Try
                    My.Computer.FileSystem.CopyDirectory(drives2extract.Substring(0, 2) + "\temp\HBCD", usbletter + "\HBCD", FileIO.UIOption.AllDialogs, FileIO.UICancelOption.ThrowException)
                Catch ex As Exception
                    If MsgBox("Copying files has been Canceled. Do you want to retry?", MsgBoxStyle.RetryCancel, "Operation Canceled.") = MsgBoxResult.Retry Then
                        GoTo CopyFiles
                    Else
                        MsgBox("Not all files have been copied, incomplete operation." + vbNewLine + "You can try again.", MsgBoxStyle.Exclamation, "Incomplete Operation.")

                        DeleteTempFiles()

                        install_btn.Enabled = True
                        InstallIsoToUSBToolStripMenuItem.Enabled = True
                        update_timer.Enabled = True
                        Return
                    End If
                End Try

                ' Copy files to USB.
                My.Computer.FileSystem.WriteAllBytes(usbletter + "\grub.exe", My.Resources.grub, False)
                My.Computer.FileSystem.WriteAllBytes(usbletter + "\syslinux.cfg", My.Resources.syslinuxcfg, False)

                StatusLabel1.Text = "Deleting temporary files..."
                DeleteTempFiles()

            Else
                MsgBox("Invalid iso file or error while extracting files. Please check iso file and try again.", MsgBoxStyle.Exclamation, "No files.")
                install_btn.Enabled = True
                InstallIsoToUSBToolStripMenuItem.Enabled = True
                update_timer.Enabled = True
                Return
            End If

            StatusLabel1.Text = ""
            MsgBox("Installation finished successfully.", MsgBoxStyle.Information, "Congratulations.")

        Else
            'MsgBox("No" + vbNewLine + usbcount.ToString + vbNewLine + isopath + vbNewLine + drives2extract)
            ' if No ( if not every thing is Ok.)
            If usbcount = 0 Then
                MsgBox("No USB drives have been detected.", MsgBoxStyle.Critical, "No USB Drives")
            End If
            If isopath = "" Then
                MsgBox("Hiren's iso file is not selected, Please select it and try again", MsgBoxStyle.Critical, "No Hiren's iso file")
            End If
            If drives2extract = "" Then
                MsgBox("No space is available. Free", MsgBoxStyle.Critical, "No free space.")
            End If
        End If

        'install_btn.Enabled = True
        Iso_open_txtbx.Text = ""
        update_timer.Enabled = True
    End Sub

    Private Sub BgWorker_delete_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles BgWorker_delete.DoWork

        If tempisthere Then
            If Directory.Exists(drives2extract.Substring(0, 2) + "\temp\[BOOT]") Then
                My.Computer.FileSystem.DeleteDirectory(drives2extract.Substring(0, 2) + "\temp\[BOOT]", _
                                                                           FileIO.DeleteDirectoryOption.DeleteAllContents)
            End If
            If Directory.Exists(drives2extract.Substring(0, 2) + "\temp\HBCD") Then
                My.Computer.FileSystem.DeleteDirectory(drives2extract.Substring(0, 2) + "\temp\HBCD", _
                                                       FileIO.DeleteDirectoryOption.DeleteAllContents)
            End If
            If File.Exists(drives2extract.Substring(0, 2) + "\temp\autorun.inf") Then
                My.Computer.FileSystem.DeleteFile(drives2extract.Substring(0, 2) + "\temp\autorun.inf")
            End If
            If File.Exists(drives2extract.Substring(0, 2) + "\temp\BootCD.txt") Then
                My.Computer.FileSystem.DeleteFile(drives2extract.Substring(0, 2) + "\temp\BootCD.txt")
            End If
            If File.Exists(drives2extract.Substring(0, 2) + "\temp\Windows Menu.cmd") Then
                My.Computer.FileSystem.DeleteFile(drives2extract.Substring(0, 2) + "\temp\Windows Menu.cmd")
            End If
        Else
            If Directory.Exists(drives2extract.Substring(0, 2) + "\temp") Then
                My.Computer.FileSystem.DeleteDirectory(drives2extract.Substring(0, 2) + "\temp", _
                                                                           FileIO.DeleteDirectoryOption.DeleteAllContents)
            End If
        End If

    End Sub
End Class
