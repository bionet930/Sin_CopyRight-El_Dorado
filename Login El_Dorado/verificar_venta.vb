Public Class verificar_venta

    Private Sub btncerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub


    Private Sub btnimprimirfac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimprimirfac.Click
        impresion_factura.Show()
    End Sub

    Private Sub dgvimprimir_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvimprimir.CellContentClick




    End Sub
End Class