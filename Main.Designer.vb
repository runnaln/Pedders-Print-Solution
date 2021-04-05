<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txBarcode = New System.Windows.Forms.TextBox()
        Me.btSelect = New System.Windows.Forms.Button()
        Me.btPrint = New System.Windows.Forms.Button()
        Me.txProduct = New System.Windows.Forms.TextBox()
        Me.txSpec = New System.Windows.Forms.TextBox()
        Me.btCancel = New System.Windows.Forms.Button()
        Me.LblPrintMessage = New System.Windows.Forms.Label()
        Me.btSettings = New System.Windows.Forms.Button()
        Me.cbManualEntry = New System.Windows.Forms.CheckBox()
        Me.ms = New System.Windows.Forms.MenuStrip()
        Me.file = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackupMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestoreMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NudMM = New System.Windows.Forms.NumericUpDown()
        Me.NudYY = New System.Windows.Forms.NumericUpDown()
        Me.PicCi3500 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cbPrintLogo = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PicCI5300 = New System.Windows.Forms.PictureBox()
        Me.cbCi3500 = New System.Windows.Forms.CheckBox()
        Me.cbCi5300 = New System.Windows.Forms.CheckBox()
        Me.ms.SuspendLayout()
        CType(Me.NudMM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudYY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicCi3500, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicCI5300, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(175, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 43)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Scan Barcode or Enter Product Code"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txBarcode
        '
        Me.txBarcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txBarcode.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txBarcode.Location = New System.Drawing.Point(180, 101)
        Me.txBarcode.Name = "txBarcode"
        Me.txBarcode.Size = New System.Drawing.Size(243, 33)
        Me.txBarcode.TabIndex = 1
        '
        'btSelect
        '
        Me.btSelect.Location = New System.Drawing.Point(608, 79)
        Me.btSelect.Name = "btSelect"
        Me.btSelect.Size = New System.Drawing.Size(118, 63)
        Me.btSelect.TabIndex = 2
        Me.btSelect.Text = "&Select"
        Me.btSelect.UseVisualStyleBackColor = True
        '
        'btPrint
        '
        Me.btPrint.Enabled = False
        Me.btPrint.Location = New System.Drawing.Point(486, 391)
        Me.btPrint.Name = "btPrint"
        Me.btPrint.Size = New System.Drawing.Size(118, 63)
        Me.btPrint.TabIndex = 9
        Me.btPrint.Text = "Send to &Printer"
        Me.btPrint.UseVisualStyleBackColor = True
        '
        'txProduct
        '
        Me.txProduct.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txProduct.Font = New System.Drawing.Font("Verdana", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txProduct.Location = New System.Drawing.Point(34, 192)
        Me.txProduct.Name = "txProduct"
        Me.txProduct.ReadOnly = True
        Me.txProduct.Size = New System.Drawing.Size(545, 50)
        Me.txProduct.TabIndex = 2
        Me.txProduct.Text = "2255"
        Me.txProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txSpec
        '
        Me.txSpec.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txSpec.Font = New System.Drawing.Font("Verdana", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txSpec.Location = New System.Drawing.Point(180, 283)
        Me.txSpec.Name = "txSpec"
        Me.txSpec.ReadOnly = True
        Me.txSpec.Size = New System.Drawing.Size(89, 66)
        Me.txSpec.TabIndex = 4
        Me.txSpec.Text = "B"
        Me.txSpec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btCancel
        '
        Me.btCancel.Enabled = False
        Me.btCancel.Location = New System.Drawing.Point(642, 391)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(118, 63)
        Me.btCancel.TabIndex = 10
        Me.btCancel.Text = "&Cancel Print"
        Me.btCancel.UseVisualStyleBackColor = True
        '
        'LblPrintMessage
        '
        Me.LblPrintMessage.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrintMessage.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LblPrintMessage.Location = New System.Drawing.Point(36, 450)
        Me.LblPrintMessage.Name = "LblPrintMessage"
        Me.LblPrintMessage.Size = New System.Drawing.Size(310, 90)
        Me.LblPrintMessage.TabIndex = 9
        Me.LblPrintMessage.Text = "printMessage"
        '
        'btSettings
        '
        Me.btSettings.Location = New System.Drawing.Point(642, 537)
        Me.btSettings.Name = "btSettings"
        Me.btSettings.Size = New System.Drawing.Size(117, 45)
        Me.btSettings.TabIndex = 13
        Me.btSettings.Text = "Se&ttings"
        Me.btSettings.UseVisualStyleBackColor = True
        '
        'cbManualEntry
        '
        Me.cbManualEntry.AutoSize = True
        Me.cbManualEntry.Location = New System.Drawing.Point(375, 560)
        Me.cbManualEntry.Name = "cbManualEntry"
        Me.cbManualEntry.Size = New System.Drawing.Size(133, 22)
        Me.cbManualEntry.TabIndex = 12
        Me.cbManualEntry.Text = "Manual Entry"
        Me.cbManualEntry.UseVisualStyleBackColor = True
        '
        'ms
        '
        Me.ms.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.file})
        Me.ms.Location = New System.Drawing.Point(0, 0)
        Me.ms.Name = "ms"
        Me.ms.Size = New System.Drawing.Size(828, 24)
        Me.ms.TabIndex = 13
        Me.ms.Text = "MenuStrip1"
        '
        'file
        '
        Me.file.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackupMI, Me.RestoreMI, Me.ExitMI})
        Me.file.Name = "file"
        Me.file.Size = New System.Drawing.Size(37, 20)
        Me.file.Text = "File"
        '
        'BackupMI
        '
        Me.BackupMI.Name = "BackupMI"
        Me.BackupMI.Size = New System.Drawing.Size(151, 22)
        Me.BackupMI.Text = "Backup Printer"
        '
        'RestoreMI
        '
        Me.RestoreMI.Enabled = False
        Me.RestoreMI.Name = "RestoreMI"
        Me.RestoreMI.Size = New System.Drawing.Size(151, 22)
        Me.RestoreMI.Text = "Restore Printer"
        '
        'ExitMI
        '
        Me.ExitMI.Name = "ExitMI"
        Me.ExitMI.Size = New System.Drawing.Size(151, 22)
        Me.ExitMI.Text = "Exit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(328, 291)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "MM/YY"
        '
        'NudMM
        '
        Me.NudMM.AccessibleDescription = "MM"
        Me.NudMM.Enabled = False
        Me.NudMM.Location = New System.Drawing.Point(406, 288)
        Me.NudMM.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.NudMM.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NudMM.Name = "NudMM"
        Me.NudMM.ReadOnly = True
        Me.NudMM.Size = New System.Drawing.Size(48, 27)
        Me.NudMM.TabIndex = 6
        Me.NudMM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NudMM.Value = New Decimal(New Integer() {12, 0, 0, 0})
        '
        'NudYY
        '
        Me.NudYY.AccessibleDescription = "YY"
        Me.NudYY.Enabled = False
        Me.NudYY.Location = New System.Drawing.Point(469, 288)
        Me.NudYY.Maximum = New Decimal(New Integer() {35, 0, 0, 0})
        Me.NudYY.Minimum = New Decimal(New Integer() {17, 0, 0, 0})
        Me.NudYY.Name = "NudYY"
        Me.NudYY.ReadOnly = True
        Me.NudYY.Size = New System.Drawing.Size(48, 27)
        Me.NudYY.TabIndex = 7
        Me.NudYY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NudYY.Value = New Decimal(New Integer() {17, 0, 0, 0})
        '
        'PicCi3500
        '
        Me.PicCi3500.Image = Global.PeddersPrint.My.Resources.Resources.citronixTif
        Me.PicCi3500.InitialImage = Nothing
        Me.PicCi3500.Location = New System.Drawing.Point(585, 148)
        Me.PicCi3500.Name = "PicCi3500"
        Me.PicCi3500.Size = New System.Drawing.Size(151, 118)
        Me.PicCi3500.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicCi3500.TabIndex = 7
        Me.PicCi3500.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = Global.PeddersPrint.My.Resources.Resources.PeddersLogo
        Me.PictureBox1.Location = New System.Drawing.Point(0, 28)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(167, 70)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'cbPrintLogo
        '
        Me.cbPrintLogo.AutoSize = True
        Me.cbPrintLogo.Checked = True
        Me.cbPrintLogo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbPrintLogo.Location = New System.Drawing.Point(205, 560)
        Me.cbPrintLogo.Name = "cbPrintLogo"
        Me.cbPrintLogo.Size = New System.Drawing.Size(110, 22)
        Me.cbPrintLogo.TabIndex = 11
        Me.cbPrintLogo.Text = "Print Logo"
        Me.cbPrintLogo.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(36, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(183, 27)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Product Code"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PicCI5300
        '
        Me.PicCI5300.Image = Global.PeddersPrint.My.Resources.Resources.ci5300
        Me.PicCI5300.InitialImage = Nothing
        Me.PicCI5300.Location = New System.Drawing.Point(585, 267)
        Me.PicCI5300.Name = "PicCI5300"
        Me.PicCI5300.Size = New System.Drawing.Size(151, 118)
        Me.PicCI5300.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicCI5300.TabIndex = 16
        Me.PicCI5300.TabStop = False
        '
        'cbCi3500
        '
        Me.cbCi3500.AutoSize = True
        Me.cbCi3500.Location = New System.Drawing.Point(773, 192)
        Me.cbCi3500.Name = "cbCi3500"
        Me.cbCi3500.Size = New System.Drawing.Size(15, 14)
        Me.cbCi3500.TabIndex = 17
        Me.cbCi3500.UseVisualStyleBackColor = True
        '
        'cbCi5300
        '
        Me.cbCi5300.AutoSize = True
        Me.cbCi5300.Location = New System.Drawing.Point(773, 309)
        Me.cbCi5300.Name = "cbCi5300"
        Me.cbCi5300.Size = New System.Drawing.Size(15, 14)
        Me.cbCi5300.TabIndex = 18
        Me.cbCi5300.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(828, 606)
        Me.Controls.Add(Me.cbCi5300)
        Me.Controls.Add(Me.cbCi3500)
        Me.Controls.Add(Me.PicCI5300)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbPrintLogo)
        Me.Controls.Add(Me.NudYY)
        Me.Controls.Add(Me.NudMM)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbManualEntry)
        Me.Controls.Add(Me.btSettings)
        Me.Controls.Add(Me.LblPrintMessage)
        Me.Controls.Add(Me.btCancel)
        Me.Controls.Add(Me.txSpec)
        Me.Controls.Add(Me.txProduct)
        Me.Controls.Add(Me.btPrint)
        Me.Controls.Add(Me.btSelect)
        Me.Controls.Add(Me.PicCi3500)
        Me.Controls.Add(Me.txBarcode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ms)
        Me.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.ms
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Main"
        Me.Text = "Pedders Print Form"
        Me.ms.ResumeLayout(False)
        Me.ms.PerformLayout()
        CType(Me.NudMM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudYY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicCi3500, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicCI5300, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txBarcode As TextBox
    Friend WithEvents PicCi3500 As PictureBox
    Friend WithEvents btSelect As Button
    Friend WithEvents btPrint As Button
    Friend WithEvents txProduct As TextBox
    Friend WithEvents txSpec As TextBox
    Friend WithEvents btCancel As Button
    Friend WithEvents LblPrintMessage As Label
    Friend WithEvents btSettings As Button
    Friend WithEvents cbManualEntry As CheckBox
    Friend WithEvents ms As MenuStrip
    Friend WithEvents file As ToolStripMenuItem
    Friend WithEvents BackupMI As ToolStripMenuItem
    Friend WithEvents RestoreMI As ToolStripMenuItem
    Friend WithEvents ExitMI As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents NudMM As NumericUpDown
    Friend WithEvents NudYY As NumericUpDown
    Friend WithEvents cbPrintLogo As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PicCI5300 As PictureBox
    Friend WithEvents cbCi3500 As CheckBox
    Friend WithEvents cbCi5300 As CheckBox
End Class
