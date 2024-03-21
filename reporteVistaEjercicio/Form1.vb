Imports Microsoft.Reporting.WinForms
Public Class Form1







    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'miproductosDataSet.productos' Puede moverla o quitarla según sea necesario.
        Me.productosTableAdapter.Fill(Me.miproductosDataSet.productos)


        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub ReportViewer1_Load_1(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class
