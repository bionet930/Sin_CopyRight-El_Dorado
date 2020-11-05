Public Class impresion_factura

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
        e.Graphics.DrawString(verificar_venta.Id_Mercaderia.HeaderText, fon, Brushes.Black, rect, strings)


        Dim rect2 As New Rectangle(x, 30, xwidth, yheight)
        Dim strings2 As New StringFormat

        strings2.Alignment = StringAlignment.Center
        strings2.LineAlignment = StringAlignment.Center
        e.Graphics.FillRectangle(Brushes.WhiteSmoke, rect2)
        e.Graphics.DrawRectangle(Pens.Black, rect2)
        e.Graphics.DrawString(verificar_venta.NombreMerc.HeaderText, fon, Brushes.Black, rect2, strings2)


        Dim rect3 As New Rectangle(x, 50, xwidth, yheight)
        Dim strings3 As New StringFormat

        strings3.Alignment = StringAlignment.Center
        strings3.LineAlignment = StringAlignment.Center
        e.Graphics.FillRectangle(Brushes.WhiteSmoke, rect3)
        e.Graphics.DrawRectangle(Pens.Black, rect3)
        e.Graphics.DrawString(verificar_venta.CantidadMerc.HeaderText, fon, Brushes.Black, rect3, strings3)


        Dim rect4 As New Rectangle(x, 70, xwidth, yheight)
        Dim strings4 As New StringFormat

        strings4.Alignment = StringAlignment.Center
        strings4.LineAlignment = StringAlignment.Center
        e.Graphics.FillRectangle(Brushes.WhiteSmoke, rect4)
        e.Graphics.DrawRectangle(Pens.Black, rect4)
        e.Graphics.DrawString(verificar_venta.PrecioMerc.HeaderText, fon, Brushes.Black, rect4, strings4)


        '---------------------------------------------------------------------------------------------------------------------

        'Dim rek As New Rectangle(y, 10, cellwidth, yheight)
        'e.Graphics.DrawRectangle(Pens.Black, rek)
        'Dim row = verificar_venta.dgvimprimir.CurrentCell.RowIndex


        'e.Graphics.DrawString(verificar_venta.dgvimprimir.Item(verificar_venta.Id_Mercaderia.HeaderText, row).Value.ToString, fon, Brushes.Black, cellheight, 12)



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        PrintPreviewControl1.Zoom = 1.2

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        PrintPreviewControl1.AutoZoom = True

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        PrintDialog1.Document = PrintDocument1
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.Yes Then
            PrintDocument1.Print()

        End If

    End Sub
End Class