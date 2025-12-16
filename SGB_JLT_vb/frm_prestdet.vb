Imports System.Data.SqlClient
Public Class frm_prestdet

    Private Sub DETALLEBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.DETALLEBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_BIBLIOTECA_V2DataSet)

    End Sub

    Private Sub frm_prestdet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BD_BIBLIOTECA_V2DataSet.PRESTACION_Y_DEVOLUCION' table. You can move, or remove it, as needed.
        Me.PRESTACION_Y_DEVOLUCIONTableAdapter.Fill(Me.BD_BIBLIOTECA_V2DataSet.PRESTACION_Y_DEVOLUCION)
        'TODO: This line of code loads data into the 'BD_BIBLIOTECA_V2DataSet.DETALLE' table. You can move, or remove it, as needed.
        Me.DETALLETableAdapter.Fill(Me.BD_BIBLIOTECA_V2DataSet.DETALLE)


    End Sub


End Class