﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoTelefonos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.db_sistemaDataSet = New Calculadora.db_sistemaDataSet()
        Me.empleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.empleadosTableAdapter = New Calculadora.db_sistemaDataSetTableAdapters.empleadosTableAdapter()
        CType(Me.db_sistemaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "dsListatelefono"
        ReportDataSource1.Value = Me.empleadosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Calculadora.ListaTelefonos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 4)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1225, 703)
        Me.ReportViewer1.TabIndex = 2
        '
        'db_sistemaDataSet
        '
        Me.db_sistemaDataSet.DataSetName = "db_sistemaDataSet"
        Me.db_sistemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'empleadosBindingSource
        '
        Me.empleadosBindingSource.DataMember = "empleados"
        Me.empleadosBindingSource.DataSource = Me.db_sistemaDataSet
        '
        'empleadosTableAdapter
        '
        Me.empleadosTableAdapter.ClearBeforeFill = True
        '
        'frmListadoTelefonos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1231, 711)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmListadoTelefonos"
        Me.Text = "frmListadoTelefonos"
        CType(Me.db_sistemaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.empleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents empleadosBindingSource As BindingSource
    Friend WithEvents db_sistemaDataSet As db_sistemaDataSet
    Friend WithEvents empleadosTableAdapter As db_sistemaDataSetTableAdapters.empleadosTableAdapter
End Class