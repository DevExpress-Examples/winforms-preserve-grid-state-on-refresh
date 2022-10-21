Imports System
Imports System.Collections
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid

Namespace DevExpress.XtraGrid.Helpers

    Public Class RefreshHelper

        <Serializable>
        Public Structure RowInfo

            Public Id As Object

            Public level As Integer
        End Structure

        Private view As GridView

        Private keyFieldName As String

        Private saveExpListField As ArrayList

        Private saveSelListField As ArrayList

        Private saveMasterRowsListField As ArrayList

        Private visibleRowIndex As Integer = -1

        Public Sub New(ByVal view As GridView, ByVal keyFieldName As String)
            Me.view = view
            Me.keyFieldName = keyFieldName
        End Sub

        Public ReadOnly Property SaveExpList As ArrayList
            Get
                If saveExpListField Is Nothing Then saveExpListField = New ArrayList()
                Return saveExpListField
            End Get
        End Property

        Public ReadOnly Property SaveSelList As ArrayList
            Get
                If saveSelListField Is Nothing Then saveSelListField = New ArrayList()
                Return saveSelListField
            End Get
        End Property

        Public ReadOnly Property SaveMasterRowsList As ArrayList
            Get
                If saveMasterRowsListField Is Nothing Then saveMasterRowsListField = New ArrayList()
                Return saveMasterRowsListField
            End Get
        End Property

        Protected Function FindParentRowHandle(ByVal rowInfo As RowInfo, ByVal rowHandle As Integer) As Integer
            Dim result As Integer = view.GetParentRowHandle(rowHandle)
            While view.GetRowLevel(result) <> rowInfo.level AndAlso view.IsValidRowHandle(result)
                result = view.GetParentRowHandle(result)
            End While

            Return result
        End Function

        Protected Sub ExpandRowByRowInfo(ByVal rowInfo As RowInfo)
            Dim dataRowHandle As Integer = view.LocateByValue(0, view.Columns(keyFieldName), rowInfo.Id)
            If dataRowHandle <> GridControl.InvalidRowHandle Then
                Dim parentRowHandle As Integer = FindParentRowHandle(rowInfo, dataRowHandle)
                view.SetRowExpanded(parentRowHandle, True, False)
            End If
        End Sub

        Protected Function GetRowHandleToSelect(ByVal rowInfo As RowInfo) As Integer
            Dim dataRowHandle As Integer = view.LocateByValue(0, view.Columns(keyFieldName), rowInfo.Id)
            If dataRowHandle <> GridControl.InvalidRowHandle Then
                If view.GetRowLevel(dataRowHandle) <> rowInfo.level Then Return FindParentRowHandle(rowInfo, dataRowHandle)
            End If

            Return dataRowHandle
        End Function

        Protected Sub SelectRowByRowInfo(ByVal rowInfo As RowInfo, ByVal isFocused As Boolean)
            If isFocused Then
                view.FocusedRowHandle = GetRowHandleToSelect(rowInfo)
            Else
                view.SelectRow(GetRowHandleToSelect(rowInfo))
            End If
        End Sub

        Public Sub SaveSelectionViewInfo(ByVal list As ArrayList)
            list.Clear()
            Dim column As GridColumn = view.Columns(keyFieldName)
            Dim rowInfo As RowInfo
            Dim selectionArray As Integer() = view.GetSelectedRows()
            If selectionArray IsNot Nothing Then ' otherwise we have a single focused but not selected row
                For i As Integer = 0 To selectionArray.Length - 1
                    Dim dataRowHandle As Integer = selectionArray(i)
                    rowInfo.level = view.GetRowLevel(dataRowHandle)
                    If dataRowHandle < 0 Then dataRowHandle = view.GetDataRowHandleByGroupRowHandle(dataRowHandle) ' group row
                    rowInfo.Id = view.GetRowCellValue(dataRowHandle, column)
                    list.Add(rowInfo)
                Next
            End If

            rowInfo.Id = view.GetRowCellValue(view.FocusedRowHandle, column)
            rowInfo.level = view.GetRowLevel(view.FocusedRowHandle)
            list.Add(rowInfo)
        End Sub

        Public Sub SaveExpansionViewInfo(ByVal list As ArrayList)
            If view.GroupedColumns.Count = 0 Then Return
            list.Clear()
            Dim column As GridColumn = view.Columns(keyFieldName)
            For i As Integer = -1 To Integer.MinValue + 1 Step -1
                If Not view.IsValidRowHandle(i) Then Exit For
                If view.GetRowExpanded(i) Then
                    Dim rowInfo As RowInfo
                    Dim dataRowHandle As Integer = view.GetDataRowHandleByGroupRowHandle(i)
                    rowInfo.Id = view.GetRowCellValue(dataRowHandle, column)
                    rowInfo.level = view.GetRowLevel(i)
                    list.Add(rowInfo)
                End If
            Next
        End Sub

        Public Sub SaveExpandedMasterRows(ByVal list As ArrayList)
            If view.GridControl.Views.Count = 1 Then Return
            list.Clear()
            Dim column As GridColumn = view.Columns(keyFieldName)
            For i As Integer = 0 To view.DataRowCount - 1
                If view.GetMasterRowExpanded(i) Then list.Add(view.GetRowCellValue(i, column))
            Next
        End Sub

        Public Sub SaveVisibleIndex()
            visibleRowIndex = view.GetVisibleIndex(view.FocusedRowHandle) - view.TopRowIndex
        End Sub

        Public Sub LoadVisibleIndex()
            view.MakeRowVisible(view.FocusedRowHandle, True)
            view.TopRowIndex = view.GetVisibleIndex(view.FocusedRowHandle) - visibleRowIndex
        End Sub

        Public Sub LoadSelectionViewInfo(ByVal list As ArrayList)
            view.BeginSelection()
            Try
                view.ClearSelection()
                For i As Integer = 0 To list.Count - 1
                    SelectRowByRowInfo(CType(list(i), RowInfo), i = list.Count - 1)
                Next
            Finally
                view.EndSelection()
            End Try
        End Sub

        Public Sub LoadExpansionViewInfo(ByVal list As ArrayList)
            If view.GroupedColumns.Count = 0 Then Return
            view.BeginUpdate()
            Try
                view.CollapseAllGroups()
                For Each info As RowInfo In list
                    ExpandRowByRowInfo(info)
                Next
            Finally
                view.EndUpdate()
            End Try
        End Sub

        Public Sub LoadExpandedMasterRows(ByVal list As ArrayList)
            view.BeginUpdate()
            Try
                view.CollapseAllDetails()
                Dim column As GridColumn = view.Columns(keyFieldName)
                For i As Integer = 0 To list.Count - 1
                    Dim rowHandle As Integer = view.LocateByValue(0, column, list(i))
                    view.SetMasterRowExpanded(rowHandle, True)
                Next
            Finally
                view.EndUpdate()
            End Try
        End Sub

        Public Sub SaveViewInfo()
            SaveExpandedMasterRows(SaveMasterRowsList)
            SaveExpansionViewInfo(SaveExpList)
            SaveSelectionViewInfo(SaveSelList)
            SaveVisibleIndex()
        End Sub

        Public Sub LoadViewInfo()
            LoadExpandedMasterRows(SaveMasterRowsList)
            LoadExpansionViewInfo(SaveExpList)
            LoadSelectionViewInfo(SaveSelList)
            LoadVisibleIndex()
        End Sub
    End Class
End Namespace
