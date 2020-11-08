Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Imports System.Data
Imports System.Data.DataRow
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class Verificar_Venta

    Dim conex As New MySqlConnection("data source=localhost;user id=prueba; password=prueba;database=eldorado")
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim comando As MySqlCommand


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

    Private Sub btnverventa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnverventa.Click

        Call mostrarlosdatos()

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

    Public Sub ExportarDatosPDF(ByVal document As Document)
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
        Dim encabezado As New Paragraph("Factura de Venta", New Font(Font.Name = "Tahoma", 20, Font.Bold))

        'Se crea el sub-texto del encabezado
        Dim texto As New Phrase("Datos obtenidos de la Venta :" + Now.Date(), New Font(Font.Name = "Tahoma", 14, Font.Bold))

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
        document.Add(encabezado)
        document.Add(texto)
        document.Add(datatable)

    End Sub


    Private Sub btnimprimirfactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimprimirfactura.Click

        'Imprimir_Factura.Show()

        Try
            'Intenta generar el Documento
            Dim doc As New Document(PageSize.A4.Rotate(), 10, 10, 10, 10)
            'Path que guarda el reporte en el Escritorio
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\factura.pdf"
            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
            PdfWriter.GetInstance(doc, file)

            doc.Open()
            ExportarDatosPDF(doc)
            doc.Close()
            Process.Start(filename)
        Catch ex As Exception
            'Si el intento no es correcto que devuelva el error
            MessageBox.Show("No se pudo generar Factura de venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'MsgBox(ex.Message)
        End Try

        Me.Close()
        panelsupprincipal.Show()
    End Sub

End Class