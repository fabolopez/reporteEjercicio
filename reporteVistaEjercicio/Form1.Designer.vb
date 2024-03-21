<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.miproductosDataSet = New reporteVistaEjercicio.miproductosDataSet()
        Me.productosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.productosTableAdapter = New reporteVistaEjercicio.miproductosDataSetTableAdapters.productosTableAdapter()
        CType(Me.miproductosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.productosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "datosreporte"
        ReportDataSource1.Value = Me.productosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "reporteVistaEjercicio.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(575, 310)
        Me.ReportViewer1.TabIndex = 0
        '
        'miproductosDataSet
        '
        Me.miproductosDataSet.DataSetName = "miproductosDataSet"
        Me.miproductosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'productosBindingSource
        '
        Me.productosBindingSource.DataMember = "productos"
        Me.productosBindingSource.DataSource = Me.miproductosDataSet
        '
        'productosTableAdapter
        '
        Me.productosTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 310)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.miproductosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.productosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents productosBindingSource As BindingSource
    Friend WithEvents miproductosDataSet As miproductosDataSet
    Friend WithEvents productosTableAdapter As miproductosDataSetTableAdapters.productosTableAdapter
End Class
