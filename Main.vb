Imports System.Data.OleDb
Imports System.Net.Sockets
Imports PeddersPrint.MinimalisticTelnet




Public Class Main
    Dim Full_Stop As String = ""
    Dim TelnetClient As New TcpClient
    Public host As String = "192.168.0.36"
    Public Shared SpringPath As String
    Public Shared BatchPath As String
    Public MessageChecked As Boolean = False
    Public Shared ReadOnly Property MyDocuments As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments



    Private Sub btSelect_Click(sender As Object, e As EventArgs) Handles btSelect.Click

        If txBarcode.Text = "" Then
            MsgBox("ProductName Code must be Entered",, "Error")
            txBarcode.Focus()
            Return
        End If

        Me.Cursor = Cursors.WaitCursor
        'If Length > 11 then assume barcode has been entered
        Dim ConnStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source='" & SpringPath & "';Extended Properties='Excel 8.0;HDR=YES;IMEX=1;';"
        Dim cn As New OleDbConnection(ConnStr)
        Dim ct As String
        If Len(txBarcode.Text) > 11 And IsNumeric(txBarcode.Text) Then
            ct = "Select [Part No], [Spec Code], Colour,[Free Hgt], [Pedders Barcode Number] from [Spring M-Spec$] where [Pedders Barcode Number] = " & txBarcode.Text
        Else
            ct = "Select [Part No], [Spec Code], Colour,[Free Hgt], [Pedders Barcode Number] from [Spring M-Spec$] where [Part No] = '" & txBarcode.Text & "'"
        End If
        Dim cm As New OleDb.OleDbCommand(ct, cn)
        cn.Open()
        Dim reader As OleDbDataReader = cm.ExecuteReader()
        If reader.HasRows Then
            reader.Read()
            If reader.Item("Colour") = "Red" Then
                txProduct.ForeColor = Color.IndianRed
            Else
                txProduct.ForeColor = Color.Gray
            End If
            txProduct.Text = reader.Item("Part No").ToString
            txSpec.Text = reader.Item("Spec Code").ToString
            txBarcode.Text = reader.Item("Pedders Barcode Number").ToString

        Else
            Me.Cursor = Cursors.Default
            MsgBox("Product not found in spreadsheet")
            'txBarcode.Text = ""
            txBarcode.Focus()

            Return
        End If
        reader.Close()
        cn.Close()
        If txBarcode.Text = "" Then
            MsgBox("Product " & txProduct.Text & " has no Barcode Cannot Proceeed",, "Error")
            txBarcode.Focus()
            Return
        End If
        ' Check if product
        NudBatch.Value = "0"
        txProduct.BackColor = Color.WhiteSmoke
        txSpec.BackColor = Color.WhiteSmoke
        ConnStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source='" & BatchPath & "';Extended Properties='Excel 8.0;HDR=YES;IMEX=1;';"
        Dim cn2 As New OleDbConnection(ConnStr)
        ct = "Select Barcode from [Sheet1$] where Barcode = " & txBarcode.Text
        Dim cm2 As New OleDb.OleDbCommand(ct, cn2)
        cn2.Open()
        Dim reader2 As OleDbDataReader = cm2.ExecuteReader()

        If reader2.HasRows Then
            NudBatch.ReadOnly = False
            NudBatch.Enabled = True
            NudBatch.Value = 0
            NudBatch.Focus()
        Else
            Me.AcceptButton = btPrint
            btPrint.Enabled = True
            btCancel.Enabled = True
            btSelect.Enabled = False
            btPrint.Focus()
            txBarcode.ReadOnly = True

        End If
        reader2.Close()
        cn2.Close()
        NudMM.ReadOnly = False
        NudMM.Enabled = True
        NudYY.ReadOnly = False
        NudYY.Enabled = True
        LblPrintMessage.Text = ""
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub btPrint_Click(sender As Object, e As EventArgs) Handles btPrint.Click


        host = My.Settings.PrinterIP
        Dim TCPClient As New TcpClient
        Dim str As String
        Dim MessageCode As String

        Me.Cursor = Cursors.WaitCursor
        LblPrintMessage.Text = "Connecteing to Ci3500 at " & host & vbCr



        'Connect to telnet
        Try
            'create a new telnet connection to hostname host on port "3028" 
            Dim tc As New TelnetConnection(host, 3028)
            If tc.IsConnected Then

                ' First time check that messages are loaded into printer.
                If Not MessageChecked Then
                    'First check that messages are loaded in Printer.
                    tc.WriteLine("ML")
                    'Wait 0.5 sec
                    System.Threading.Thread.Sleep(500)
                    ' Read Return from Printer
                    str = tc.Read()
                    'Check that LOGO message is in printer. 
                    If InStr(str, "LOGO") < 1 Then
                        MessageBox.Show("Printer is missing the LOGO message. Reload from Backup")
                    End If
                    'Check that TEXT message is in printer. 
                    ' If InStr(str, "TEXT") = -1 Then
                    '   MessageBox.Show("Printer is missing the LOGObatch message. Reload from Backup")
                    ' End If
                    MessageChecked = True
                End If

                LblPrintMessage.Text = "Sending message to Ci3500" & vbCr

                'If Logo then Print SMLogo else SMTEXT
                If cbPrintLogo.CheckState Then MessageCode = "SMLOGO" Else MessageCode = "SMTEXT"
                If NudBatch.Value = "0" Then
                    LblPrintMessage.Text = LblPrintMessage.Text & MessageCode & vbCr
                    tc.WriteLine(MessageCode)
                    If tc.Read() <> "" Then MessageBox.Show("Error Message not sent successfully", "Connection Error")
                    If cbPrintLogo.CheckState Then
                        LblPrintMessage.Text = LblPrintMessage.Text & "MD,," & txProduct.Text & " " & txSpec.Text & " " & NudMM.Value & "/" & NudYY.Value
                        tc.WriteLine("MD,," & txProduct.Text & " " & txSpec.Text & " " & NudMM.Value & "/" & NudYY.Value)
                    Else
                        LblPrintMessage.Text = LblPrintMessage.Text & "MD," & txProduct.Text & " " & txSpec.Text & " " & NudMM.Value & "/" & NudYY.Value
                        tc.WriteLine("MD," & txProduct.Text & " " & txSpec.Text & " " & NudMM.Value & "/" & NudYY.Value)
                    End If
                    If tc.Read() <> "" Then MessageBox.Show("Error Message not sent successfully", "Connection Error")
                Else
                    LblPrintMessage.Text = LblPrintMessage.Text & MessageCode & vbCr
                    tc.WriteLine(MessageCode)
                    If tc.Read() <> "" Then MessageBox.Show("Error Message not sent successfully", "Connection Error")
                    If cbPrintLogo.CheckState Then
                        LblPrintMessage.Text = LblPrintMessage.Text & "'MD,," & txProduct.Text & " " & txSpec.Text & " " & NudMM.Value & "/" & NudYY.Value & "/" & NudBatch.Value
                        tc.WriteLine("MD,," & txProduct.Text & " " & txSpec.Text & " " & NudMM.Value & "/" & NudYY.Value & "/" & NudBatch.Value)
                    Else
                        LblPrintMessage.Text = LblPrintMessage.Text & "'MD,," & txProduct.Text & " " & txSpec.Text & " " & NudMM.Value & "/" & NudYY.Value & "/" & NudBatch.Value
                        tc.WriteLine("MD," & txProduct.Text & " " & txSpec.Text & " " & NudMM.Value & "/" & NudYY.Value & "/" & NudBatch.Value)
                    End If
                    If tc.Read() <> "" Then MessageBox.Show("Error Message not sent successfully", "Connection Error")
                End If
            Else
                MessageBox.Show("Error connecting to Ci3500, ensure it is powered up, and connection cable is secure")
            End If

        Catch ex As Exception
            MessageBox.Show("Error connecting to Ci3500, ensure it is powered up, and connection cable is secure" & vbCr & ex.Message, "Connection Error")
            Me.Cursor = Cursors.Default
            txBarcode.Focus()
            Return
        End Try

        'Clear Barcode and Prepare for new code to be scanned.
        txBarcode.Text = ""
        If cbManualEntry.Checked Then
            btSelect.Enabled = False
            txBarcode.Enabled = False
            txProduct.ReadOnly = False
            txProduct.Focus()
            txSpec.ReadOnly = False
            NudBatch.ReadOnly = False
            btCancel.Enabled = True
            btPrint.Enabled = True
            Me.AcceptButton = btPrint
        Else
            txBarcode.ReadOnly = False
            txBarcode.Focus()
            NudMM.Enabled = False
            NudYY.Enabled = False
            NudBatch.Enabled = False
            NudBatch.Value = 0
            btSelect.Enabled = True
            Me.AcceptButton = btSelect
            btPrint.Enabled = False
            btCancel.Enabled = False
        End If
        Me.Cursor = Cursors.Default

        TelnetClient.Close()
    End Sub


    Private Sub NudBatchNo_Leave(sender As Object, e As EventArgs)

    End Sub

    Private Sub btCancel_Click(sender As Object, e As EventArgs) Handles btCancel.Click
        btPrint.Enabled = False
        btCancel.Enabled = False
        txBarcode.Text = ""
        NudBatch.ReadOnly = True
        NudMM.ReadOnly = True
        NudMM.Enabled = False
        NudYY.ReadOnly = True
        NudYY.Enabled = False
        NudBatch.Enabled = False
        NudBatch.Value = "0"
        txBarcode.ReadOnly = False
        txProduct.Text = ""
        txSpec.Text = ""
        cbManualEntry_CheckedChanged(Me, e)

    End Sub

    Private Sub btSettings_Click(sender As Object, e As EventArgs) Handles btSettings.Click
        If My.Settings.PrinterIP <> "" Then
            Settings.txPrinterIP.Text = My.Settings.PrinterIP
        Else
            Settings.txPrinterIP.Text = "192.168.0.36"
        End If
        Settings.txPath.Text = My.Settings.SpreadsheetPath
        Settings.cbLogo.Text = My.Settings.Logo
        Settings.ShowDialog()
    End Sub

    Private Sub cbManualEntry_CheckedChanged(sender As Object, e As EventArgs) Handles cbManualEntry.CheckedChanged
        If cbManualEntry.Checked Then
            btSelect.Enabled = False
            txBarcode.Enabled = False
            txProduct.ReadOnly = False
            txProduct.Focus()
            txSpec.ReadOnly = False
            NudBatch.Value = 0
            NudBatch.ReadOnly = False
            NudBatch.Enabled = True
            NudMM.Enabled = True
            NudYY.Enabled = True
            btCancel.Enabled = True
            btPrint.Enabled = True
            Me.AcceptButton = btPrint
        Else
            btSelect.Enabled = True
            txBarcode.Enabled = True
            txProduct.ReadOnly = True
            txSpec.ReadOnly = True
            NudBatch.ReadOnly = True
            NudBatch.Enabled = False
            NudMM.Enabled = False
            NudYY.Enabled = False
            txBarcode.ReadOnly = False
            txBarcode.Focus()
            Me.AcceptButton = btSelect
            btPrint.Enabled = False
            btCancel.Enabled = False
            txBarcode.Text = ""
            txProduct.Text = ""
            NudBatch.Value = 0
            txSpec.Text = ""

        End If
    End Sub

    Private Sub txProduct_ModifiedChanged(sender As Object, e As EventArgs) Handles txSpec.ModifiedChanged, txProduct.ModifiedChanged
        If cbManualEntry.Checked Then
            If txSpec.Text <> "" And txProduct.Text <> "" Then
                btPrint.Enabled = True
            Else
                btPrint.Enabled = False
            End If
        End If
    End Sub

    Private Sub ExitMI_Click(sender As Object, e As EventArgs) Handles ExitMI.Click
        End
    End Sub

    Private Sub BackupMI_Click(sender As Object, e As EventArgs) Handles BackupMI.Click

        Dim str As String
        'Connect to telnet
        Try

            'create a new telnet connection to hostname host on port "23" 

            Dim tc As New TelnetConnection(host, 3028)
            If tc.IsConnected Then
                'First check that messages are loaded in Printer.
                tc.WriteLine("BB")

                'Wait 1 sec
                System.Threading.Thread.Sleep(1000)

                ' Read Return from Printer
                str = tc.Read()
                'Write Back to file 
                If str <> "" Then
                    Dim file As System.IO.StreamWriter
                    file = My.Computer.FileSystem.OpenTextFileWriter(My.Settings.SpreadsheetPath & "\Ci3500Backup.xml", False)
                    file.WriteLine(str)
                    file.Close()
                    MessageBox.Show("Backup sucessful file ci3500Backup.xml saved in directory " & My.Settings.SpreadsheetPath, "Backup Success", MessageBoxButtons.OK)
                Else
                    MessageBox.Show("Backup Failed", "Error")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error connecting to Ci3500, ensure it is powered up, and connection cable is secure" & vbCr & ex.Message, "Connection Error")
            Me.Cursor = Cursors.Default
            Return
        End Try
    End Sub

    Private Sub NudBatch_ValueChanged(sender As Object, e As EventArgs) Handles NudBatch.ValueChanged
        If cbManualEntry.Checked = False Then

            If NudBatch.Value <> 0 Then
                btPrint.Enabled = True
                btCancel.Enabled = True
            Else
                btPrint.Enabled = False
                btCancel.Enabled = False
            End If

        End If
    End Sub

    Private Sub NudBatch_Leave(sender As Object, e As EventArgs) Handles NudBatch.Leave
        If NudBatch.Value <> 0 Then
            btSelect.Enabled = False
            btPrint.Focus()
        End If
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim version As String = System.Windows.Forms.Application.ProductVersion
        Me.Text = Me.Text & " Version : " & version
        Me.Icon = My.Resources.PedderIcon
        cbManualEntry.Checked = False


        If My.Settings.SpreadsheetPath = "" Then
            SpringPath = MyDocuments & "\Spring.xls"
            BatchPath = MyDocuments & "\Batch_Required.xls"
        Else
            SpringPath = My.Settings.SpreadsheetPath & "\Spring.xls"
            BatchPath = My.Settings.SpreadsheetPath & "\Batch_Required.xls"
        End If
        'Set  Logo from Settings
        If My.Settings.Logo = "Pedders" Then
            PictureBox1.Image = My.Resources.PeddersLogo
        Else
            PictureBox1.Image = My.Resources.easyprintLogo
        End If

        txBarcode.Text = ""
        txProduct.Text = ""
        txSpec.Text = ""
        NudMM.Value = Month(Now)
        NudYY.Value = Convert.ToInt32(Now.ToString("yy"))
        Me.AcceptButton = btSelect
        LblPrintMessage.Text = ""
        txBarcode.Focus()
        txBarcode.Select(0, 0)
    End Sub

End Class


