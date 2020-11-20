Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports MessagingToolkit.QRCode


Imports System.Data
Imports System.Data.DataRow
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms



Public Class Verificar_Venta

    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public adt As MySqlDataAdapter
    Public ds As DataSet

    Dim conexion As New MySqlConnection()


    Dim consulta As ConexionPablo = New ConexionPablo()



    Dim conex As New MySqlConnection("data source=localhost;user id=prueba; password=prueba;database=eldorado")
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim comando As MySqlCommand

    Dim QR_Generador As New MessagingToolkit.QRCode.Codec.QRCodeEncoder


    Dim doc As New Document(iTextSharp.text.PageSize.A4, 15.0F, 15.0F, 30.0F, 30.0F)
    Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(doc, New FileStream("C:\Mantenimiento\demopdf.pdf", FileMode.Create))

    Public Sub PintaLinea(ByVal numGrosor As Double,
                           ByVal X1 As Integer, ByVal Y1 As Integer,
                           ByVal X2 As Integer, ByVal Y2 As Integer)

        Dim linea As PdfContentByte
        linea = pdfWrite.DirectContent
        linea.SetLineWidth(numGrosor)
        linea.MoveTo(X1, Y1)
        linea.LineTo(X2, Y2)
        linea.Stroke()

    End Sub

    Public Sub PintaCuadrado(ByVal numGrosor As Double,
                              ByVal X1 As Integer, ByVal Y1 As Integer,
                              ByVal X2 As Integer, ByVal Y2 As Integer)

        Dim linea As PdfContentByte
        linea = pdfWrite.DirectContent
        linea.SetLineWidth(numGrosor)
        linea.MoveTo(X1, Y1)
        linea.LineTo(X2, Y1)
        linea.Stroke()

        linea.MoveTo(X2, Y1)
        linea.LineTo(X2, Y2)
        linea.Stroke()

        linea.MoveTo(X2, Y2)
        linea.LineTo(X1, Y2)
        linea.Stroke()

        linea.MoveTo(X1, Y2)
        linea.LineTo(X1, Y1)
        linea.Stroke()

        doc.Add(Chunk.NEWLINE)

    End Sub



    Private Sub Verificar_Venta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub mostrarlosdatos()

        Try
            'sql = "Select * from tblventas"
            sql = "SELECT * FROM tblventas ORDER BY Id_Ventas DESC LIMIT 1"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            dgvverfactura.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub btnverventa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnverventa.Click

        Call mostrarlosdatos()

        Try
            PictureBox1.Image = QR_Generador.Encode(dgvverfactura.Item(0, 0).Value())

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        PictureBox1.Image.Save("C:\Mantenimiento\QRVenta.png", Drawing.Imaging.ImageFormat.Png)
        'SaveFileDialog1.ShowDialog()

        lblempleadoventa.Text = consulta.consultaConRetorno("Select NombreEmpl from tblempleados where `id_Empleado`= '" & dgvverfactura.Item(1, 0).Value() & "' ;")
        lblclienteventa.Text = consulta.consultaConRetorno("Select NombreCli from tblclientes where `id_Cliente`= '" & dgvverfactura.Item(6, 0).Value() & "' ;")
        lbldireccioncliente.Text = consulta.consultaConRetorno("Select DomicilioCli from tblclientes where `id_Cliente`= '" & dgvverfactura.Item(6, 0).Value() & "' ;")
    End Sub

    Private Sub AltoFila() 'Para Configurar el alto de la fuila del DGVW
        For Each row As DataGridView In dgvverfactura.Rows
            'Se asigna el alto de la fila para poder ver Imagenes en el DG
            row.Height = 120
        Next
    End Sub



    Public Function GetColumnasSize(ByVal dg As DataGridView) As Single()
        'funcion para obtener el tamaño de las columnas del datagridview
        Dim values As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1
            values(i) = CSng(dg.Columns(i).Width)

        Next
        Return values

    End Function

    Public Sub ExportarDatosPDF(ByVal doc As Document)

        Dim font8 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.NORMAL))
        Dim fontB8 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.BOLD))
        Dim font12 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 12, iTextSharp.text.Font.BOLD))

        Dim CVacio As PdfPCell = New PdfPCell(New Phrase(""))
        CVacio.Border = 0

        doc.Open()

        Dim Table1 As PdfPTable = New PdfPTable(4)
        Dim Col1 As PdfPCell
        Dim Col2 As PdfPCell
        Dim Col3 As PdfPCell
        Dim Col4 As PdfPCell
        Dim Col5 As PdfPCell
        Dim Col6 As PdfPCell
        Dim Iline As Integer
        Dim IFila As Integer
        Table1.WidthPercentage = 95


        Dim widths As Single() = New Single() {4.0F, 7.0F, 1.0F, 4.0F}
        Table1.SetWidths(widths)

        'Tabla 1 del Encabezado
        Dim imagenURL As String = "C:\Mantenimiento\dorado.jpg"
        Dim imagenJPG As iTextSharp.text.Image
        imagenJPG = iTextSharp.text.Image.GetInstance(imagenURL)
        imagenJPG.ScaleToFit(50.0F, 65.0F)
        imagenJPG.SpacingBefore = 40.0F
        imagenJPG.SpacingAfter = 40.0F
        imagenJPG.SetAbsolutePosition(60, 750)
        doc.Add(imagenJPG)


        Table1.AddCell(CVacio)
        Col2 = New PdfPCell(New Phrase("Provisión EL DORADO", fontB8))
        Col2.Border = 0
        Table1.AddCell(Col2)
        Table1.AddCell(CVacio)
        Col3 = New PdfPCell(New Phrase("Detalle de Venta", fontB8))
        Col3.Border = 0

        Table1.AddCell(Col3)

        Table1.AddCell(CVacio)
        Col2 = New PdfPCell(New Phrase("Direccion de la empresa proveedora", font8))
        Col2.Border = 0
        Table1.AddCell(Col2)
        Table1.AddCell(CVacio)
        Col3 = New PdfPCell(New Phrase("Detalle Local", fontB8))
        Col3.Border = 0

        Table1.AddCell(Col3)

        Table1.AddCell(CVacio)
        Col2 = New PdfPCell(New Phrase("Salto, Uruguay", font8))
        Col2.Border = 0
        Table1.AddCell(Col2)
        Table1.AddCell(CVacio)
        Col3 = New PdfPCell(New Phrase("RUT 215216217218", fontB8))
        Col3.Border = 0

        Table1.AddCell(Col3)

        Table1.AddCell(CVacio)
        Col2 = New PdfPCell(New Phrase(" (+598) 4734 0056 - CEL: 092213571", font8))
        Col2.Border = 0
        Table1.AddCell(Col2)
        Table1.AddCell(CVacio)
        Col3 = New PdfPCell(New Phrase("Detalle N°", fontB8))
        Col3.Border = 0

        Table1.AddCell(Col3)

        Table1.AddCell(CVacio)
        Col2 = New PdfPCell(New Phrase("www.paginawebdelcliente.com.uy", font8))
        Col2.Border = 0
        Table1.AddCell(Col2)
        Table1.AddCell(CVacio)
        Col3 = New PdfPCell(New Phrase(dgvverfactura.Item(0, 0).Value(), font8))
        Col3.Border = 0

        Table1.AddCell(Col3)

        doc.Add(Table1)

        PintaCuadrado(0.7, 410, 740, 530, 820)
        PintaLinea(0.5, 30, 733, 530, 733)
        doc.Add(New Paragraph("."))

        'Tabla 2 Contenido Cliente
        Dim table2 As PdfPTable = New PdfPTable(4)
        Dim widths2 As Single() = New Single() {2.0F, 8.0F, 3.0F, 2.0F}
        table2.WidthPercentage = 95
        table2.SetWidths(widths2)
        table2.AddCell(CVacio)
        table2.AddCell(CVacio)
        table2.AddCell(CVacio)
        table2.AddCell(CVacio)
        Col1 = New PdfPCell(New Phrase("CLIENTE", fontB8))
        Col1.Border = 0
        table2.AddCell(Col1)
        Col2 = New PdfPCell(New Phrase(lblclienteventa.Text, font8))
        Col2.Border = 0
        table2.AddCell(Col2)
        Col3 = New PdfPCell(New Phrase("Fecha de Emisión", fontB8))
        Col3.Border = 0
        table2.AddCell(Col3)
        Col4 = New PdfPCell(New Phrase(Now.Date, font8))
        Col4.Border = 0
        table2.AddCell(Col4)

        table2.AddCell(CVacio)
        table2.AddCell(CVacio)
        Col3 = New PdfPCell(New Phrase("N° de Detalle: ", fontB8))
        Col3.Border = 0
        table2.AddCell(Col3)
        Col4 = New PdfPCell(New Phrase(dgvverfactura.Item(0, 0).Value(), font8))
        Col4.Border = 0
        table2.AddCell(Col4)

        Col1 = New PdfPCell(New Phrase("RUT/CI: ", fontB8))
        Col1.Border = 0
        table2.AddCell(Col1)
        Col2 = New PdfPCell(New Phrase(dgvverfactura.Item(6, 0).Value(), font8))
        Col2.Border = 0
        table2.AddCell(Col2)
        Col3 = New PdfPCell(New Phrase("Moneda: ", fontB8))
        Col3.Border = 0
        table2.AddCell(Col3)
        Col4 = New PdfPCell(New Phrase("$UY", font8))
        Col4.Border = 0
        table2.AddCell(Col4)

        Col1 = New PdfPCell(New Phrase("Dirección:", fontB8))
        Col1.Border = 0
        table2.AddCell(Col1)
        Col2 = New PdfPCell(New Phrase(lbldireccioncliente.Text, font8))
        Col2.Border = 0
        table2.AddCell(Col2)
        table2.AddCell(CVacio)
        table2.AddCell(CVacio)

        doc.Add(table2)

        PintaLinea(0.5, 30, 680, 530, 680)

        'Tabla 3 Cabecera de los datos
        Dim table3 As PdfPTable = New PdfPTable(7)
        Dim widths3 As Single() = New Single() {1.0F, 8.0F, 3.0F, 1.0F, 2.0F, 2.0F, 1.0F}

        table3.WidthPercentage = 95
        table3.SetWidths(widths3)
        Col1 = New PdfPCell(New Phrase("ID", fontB8))
        Col1.Border = 0
        table3.AddCell(Col1)
        Col2 = New PdfPCell(New Phrase("Empleado", fontB8))
        Col2.Border = 0
        table3.AddCell(Col2)
        Col3 = New PdfPCell(New Phrase("Fecha", fontB8))
        Col3.Border = 0
        table3.AddCell(Col3)
        Col4 = New PdfPCell(New Phrase("$/C", fontB8))
        Col4.Border = 0
        table3.AddCell(Col4)
        Col5 = New PdfPCell(New Phrase("$/Venta", fontB8))
        Col5.Border = 0
        table3.AddCell(Col5)
        Col6 = New PdfPCell(New Phrase("Cantidad", fontB8))
        Col6.Border = 0
        Col6.HorizontalAlignment = 2
        table3.AddCell(Col6)
        table3.AddCell(CVacio)

        doc.Add(table3)

        PintaLinea(0.5, 30, 668, 530, 668)


        'Tabla 4 Datos de Contenido
        Dim Table4 As PdfPTable = New PdfPTable(7)
        Dim widths4 As Single() = New Single() {1.0F, 8.0F, 3.0F, 1.0F, 2.0F, 2.0F, 1.0F}
        Table4.WidthPercentage = 95
        Table4.SetWidths(widths4)
        Col1 = New PdfPCell(New Phrase(dgvverfactura.Item(0, 0).Value(), font8))
        Col1.Border = 0
        Table4.AddCell(Col1)
        Col2 = New PdfPCell(New Phrase(lblempleadoventa.Text, font8))
        Col2.Border = 0
        Table4.AddCell(Col2)
        Col3 = New PdfPCell(New Phrase(dgvverfactura.Item(2, 0).Value(), font8))
        Col3.Border = 0
        Table4.AddCell(Col3)
        Col4 = New PdfPCell(New Phrase("xxxx", font8))
        Col4.Border = 0
        Table4.AddCell(Col4)
        Col5 = New PdfPCell(New Phrase(dgvverfactura.Item(4, 0).Value(), font8))
        Col5.Border = 0
        Table4.AddCell(Col5)
        Col6 = New PdfPCell(New Phrase(dgvverfactura.Item(5, 0).Value(), font8))
        Col6.Border = 0
        Col6.HorizontalAlignment = 2
        Table4.AddCell(Col6)
        Table4.AddCell(CVacio)
        doc.Add(Table4)

        PintaLinea(0.5, 30, 200, 530, 200)

        For IFila = 1 To 40
            doc.Add(New Paragraph("."))
            Iline = pdfWrite.GetVerticalPosition(True)
            If Iline < 200 Then
                Exit For
            End If
        Next

        'Tabla 5 Final de Documento
        Dim Table5 As PdfPTable = New PdfPTable(5)
        Dim widths5 As Single() = New Single() {8.0F, 1.0F, 2.0F, 2.0F, 1.0F}
        Table5.WidthPercentage = 95
        Table5.SetWidths(widths5)

        Col1 = New PdfPCell(New Phrase("OBSERVACIONES", fontB8))
        Col1.Border = 0
        Table5.AddCell(Col1)
        Table5.AddCell(CVacio)
        Col3 = New PdfPCell(New Phrase("TOTAL", fontB8))
        Col3.Border = 0
        Table5.AddCell(Col3)
        Col4 = New PdfPCell(New Phrase(dgvverfactura.Item(4, 0).Value(), fontB8))
        Col4.Border = 0
        Col4.HorizontalAlignment = 2
        Table5.AddCell(Col4)
        Table5.AddCell(CVacio)

        Col1 = New PdfPCell(New Phrase("Sin Observaciones", font8))
        Col1.Border = 0
        Table5.AddCell(Col1)
        Table5.AddCell(CVacio)
        Col3 = New PdfPCell(New Phrase("IVA", font8))
        Col3.Border = 0
        Table5.AddCell(Col3)
        Col4 = New PdfPCell(New Phrase("0%", font8))
        Col4.Border = 0
        Col4.HorizontalAlignment = 2
        Table5.AddCell(Col4)
        Table5.AddCell(CVacio)

        Col1 = New PdfPCell(New Phrase("", font8))
        Col1.Border = 0
        Table5.AddCell(Col1)
        Table5.AddCell(CVacio)
        Col3 = New PdfPCell(New Phrase("", font8))
        Col3.Border = 0
        Table5.AddCell(Col3)
        Col4 = New PdfPCell(New Phrase("", font8))
        Col4.Border = 0
        Col4.HorizontalAlignment = 2
        Table5.AddCell(Col4)
        Table5.AddCell(CVacio)

        doc.Add(Table5)


        Dim imagenURL2 As String = "C:\Mantenimiento\QRVenta.png"
        Dim imagenPNG As iTextSharp.text.Image
        imagenPNG = iTextSharp.text.Image.GetInstance(imagenURL2)
        imagenPNG.ScaleToFit(100.0F, 100.0F)
        imagenPNG.SpacingBefore = 20.0F
        imagenPNG.SpacingAfter = 10.0F
        imagenPNG.SetAbsolutePosition(200, 60)
        doc.Add(imagenPNG)


        'Se crea objeto PDFTable con el numero de columnas del DataGridView
        Dim datatable As New PdfPTable(dgvverfactura.ColumnCount)
        'Se asigna algunas propiedades para el diseño del PDF
        datatable.DefaultCell.Padding = 3
        Dim headerwidths As Single() = GetColumnasSize(dgvverfactura)
        datatable.SetWidths(headerwidths)
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER
        'Se crea el encabezado en el PDF
        'Dim encabezado As New Paragraph("Detalle de Ventas", New Font(Font.Name = "Tahoma", 16, Font.Bold))

        'Se crea el sub-texto del encabezado
        'Dim texto As New Phrase("Datos obtenidos de la Venta :" + Now.Date(), New Font(Font.Name = "Tahoma", 12, Font.Bold))

        'Se toman los nombres de los encabezados del DataGridView
        For i As Integer = 0 To dgvverfactura.ColumnCount - 1
            datatable.AddCell(dgvverfactura.Columns(i).HeaderText)
        Next
        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 1

        'Se generan las columnas del DataGridView
        For i As Integer = 0 To dgvverfactura.RowCount - 1
            For j As Integer = 0 To dgvverfactura.ColumnCount - 1
                datatable.AddCell(dgvverfactura(j, i).Value.ToString())
            Next
            datatable.CompleteRow()
        Next

        'Se agrega el PDFTable al documentos
        'document.Add(encabezado)
        'doc.Add(imagenJPG)
        'doc.Add(Table1)
        'doc.Add(table2)
        'doc.Add(table3)
        'doc.Add(Table4)
        'doc.Add(Table5)
        'document.Add(texto)
        'document.Add(datatable)

    End Sub


    Private Sub btnimprimirfactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimprimirfactura.Click

        'Imprimir_Factura.Show()

        doc.Open()
        ExportarDatosPDF(doc)
        doc.Close()
        Process.Start("C:\Mantenimiento\demopdf.pdf")

        'Try
        'Intenta generar el Documento
        'Dim doc As New Document(iTextSharp.text.PageSize.A4, 15.0F, 15.0F, 30.0F, 30.0F)
        'Path que guarda el reporte en el Escritorio
        'Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\factura.pdf"
        'Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
        'PdfWriter.GetInstance(doc, file)

        'doc.Open()
        'ExportarDatosPDF(doc)
        'doc.Close()
        'Process.Start(filename)
        'Catch ex As Exception
        'Si el intento no es correcto que devuelva el error
        'MessageBox.Show("No se pudo generar Factura de venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'MsgBox(ex.Message)
        'End Try

        Me.Close()
        panelsupprincipal.Show()
    End Sub

    Private Sub dgvverfactura_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvverfactura.CellContentClick

    End Sub

    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk

        Try
            Dim imagenqr As New Bitmap(PictureBox1.Image)
            PictureBox1.Image.Save("C:\QRVenta.png", Drawing.Imaging.ImageFormat.Png)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

   
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbldireccioncliente.Click

    End Sub
End Class