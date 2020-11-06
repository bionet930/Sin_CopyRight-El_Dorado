Public Class Imprimir_Factura

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim x As Integer = 170
        Dim y As Integer = 360
        Dim xwidth As Integer = 190
        Dim yheight As Integer = 20
        Dim cellwidth As Integer = 300
        Dim cellheight As Integer = 370

        Dim fon As New Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular)
        Dim rect As New Rectangle(x, 10, xwidth, yheight)
        Dim strings As New StringFormat


        strings.Alignment = StringAlignment.Center
        strings.LineAlignment = StringAlignment.Center
        e.Graphics.FillRectangle(Brushes.WhiteSmoke, rect)
        e.Graphics.DrawRectangle(Pens.Black, rect)
        e.Graphics.DrawString(ventasprincipal.dgvFactura.Columns(0).HeaderText, fon, Brushes.Brown, rect, strings)



        '----------------------------------------------------------------------------------------------------------------------------------------------------------


        Dim rek As New Rectangle(y, 10, cellwidth, yheight)
        e.Graphics.DrawRectangle(Pens.Black, rek)
        'Dim row = ventasprincipal.dgvFactura.CurrentCell.RowIndex
        e.Graphics.DrawString(ventasprincipal.dgvFactura.CurrentRow.Cells(0).Value.ToString, fon, Brushes.Black, cellheight, 12)





    End Sub

    Private Sub btnzoommas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnzoommas.Click

        PrintPreviewControl1.Zoom = 1.2

    End Sub

    Private Sub btnzoommenos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnzoommenos.Click

        PrintPreviewControl1.AutoZoom = True

    End Sub

    Private Sub bntimprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntimprimir.Click

        PrintDialog1.Document = PrintDocument1
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.Yes Then
            PrintDocument1.Print()
        End If

    End Sub
End Class