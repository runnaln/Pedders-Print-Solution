<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Me.txPath = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ssFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbLogo = New System.Windows.Forms.ComboBox()
        Me.btBrowse = New System.Windows.Forms.Button()
        Me.txSave = New System.Windows.Forms.Button()
        Me.txCancel = New System.Windows.Forms.Button()
        Me.txPrinterIP3500 = New System.Windows.Forms.TextBox()
        Me.txPrinterIP5300 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txPath
        '
        Me.txPath.Location = New System.Drawing.Point(104, 81)
        Me.txPath.Name = "txPath"
        Me.txPath.ReadOnly = True
        Me.txPath.Size = New System.Drawing.Size(215, 20)
        Me.txPath.TabIndex = 3
        Me.txPath.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Spreadsheet Path"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Printer IP Ci3500"
        '
        'ssFolder
        '
        Me.ssFolder.Description = "Folder where the Spring and the Batch Required spreadsheet are held "
        Me.ssFolder.RootFolder = System.Environment.SpecialFolder.MyDocuments
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.Text = "Logo"
        '
        'Label4
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 54)
        Me.Label3.Name = "Label4"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Printer IP Ci5300"
        '
        'cbLogo
        '
        Me.cbLogo.FormattingEnabled = True
        Me.cbLogo.Items.AddRange(New Object() {"Pedders", "easyprint"})
        Me.cbLogo.Location = New System.Drawing.Point(108, 117)
        Me.cbLogo.Name = "cbLogo"
        Me.cbLogo.Size = New System.Drawing.Size(124, 51)
        Me.cbLogo.TabIndex = 4
        Me.cbLogo.Text = "Pedders"
        '
        'btBrowse
        '
        Me.btBrowse.Location = New System.Drawing.Point(325, 82)
        Me.btBrowse.Name = "btBrowse"
        Me.btBrowse.Size = New System.Drawing.Size(69, 23)
        Me.btBrowse.TabIndex = 3
        Me.btBrowse.Text = "Browse"
        Me.btBrowse.UseVisualStyleBackColor = True
        '
        'txSave
        '
        Me.txSave.Location = New System.Drawing.Point(108, 170)
        Me.txSave.Name = "txSave"
        Me.txSave.Size = New System.Drawing.Size(75, 23)
        Me.txSave.TabIndex = 6
        Me.txSave.Text = "&Save"
        Me.txSave.UseVisualStyleBackColor = True
        '
        'txCancel
        '
        Me.txCancel.Location = New System.Drawing.Point(244, 170)
        Me.txCancel.Name = "txCancel"
        Me.txCancel.Size = New System.Drawing.Size(75, 23)
        Me.txCancel.TabIndex = 7
        Me.txCancel.Text = "&Cancel"
        Me.txCancel.UseVisualStyleBackColor = True
        '
        'txPrinterIP 3500
        '
        Me.txPrinterIP3500.Location = New System.Drawing.Point(109, 22)
        Me.txPrinterIP3500.Name = "txPrinterIP3500"
        Me.txPrinterIP3500.Size = New System.Drawing.Size(100, 20)
        Me.txPrinterIP3500.TabIndex = 1

        'txPrinterIP 5300
        '
        Me.txPrinterIP5300.Location = New System.Drawing.Point(109, 52)
        Me.txPrinterIP5300.Name = "txPrinterIP5300"
        Me.txPrinterIP5300.Size = New System.Drawing.Size(100, 20)
        Me.txPrinterIP5300.TabIndex = 2
        '
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 223)

        Me.Controls.Add(Me.txCancel)
        Me.Controls.Add(Me.txSave)
        Me.Controls.Add(Me.btBrowse)
        Me.Controls.Add(Me.cbLogo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txPath)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txPrinterIP3500)
        Me.Controls.Add(Me.txPrinterIP5300)
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txPath As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ssFolder As FolderBrowserDialog
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbLogo As ComboBox
    Friend WithEvents btBrowse As Button
    Friend WithEvents txPrinterIP3500 As TextBox
    Friend WithEvents txPrinterIP5300 As TextBox

    Private Sub btBrowse_Click(sender As Object, e As EventArgs) Handles btBrowse.Click
        ssFolder.SelectedPath = txPath.Text

        If (ssFolder.ShowDialog() = DialogResult.OK) Then
            txPath.Text = ssFolder.SelectedPath
        End If
    End Sub

    Friend WithEvents txSave As Button
    Friend WithEvents txCancel As Button

    Private Sub txCancel_Click(sender As Object, e As EventArgs) Handles txCancel.Click
        Me.Close()
    End Sub

    Private Sub txSave_Click(sender As Object, e As EventArgs) Handles txSave.Click
        If My.Settings.Logo <> cbLogo.Text Then
            My.Settings.Logo = cbLogo.Text
            'Set  Logo from Settings
            If My.Settings.Logo = "Pedders" Then
                Main.PictureBox1.Image = My.Resources.PeddersLogo
            Else
                Main.PictureBox1.Image = My.Resources.easyprintLogo
            End If
        End If
        My.Settings.SpreadsheetPath = txPath.Text
        My.Settings.PrinterIP3500 = txPrinterIP3500.Text
        My.Settings.PrinterIP5300 = txPrinterIP5300.Text
        My.Settings.Save()
        Me.Close()
    End Sub


End Class
