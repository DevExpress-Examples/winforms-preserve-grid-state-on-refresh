Imports System
Imports System.Drawing
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Helpers

Namespace RefreshHelperApp

    ''' <summary>
    ''' Summary description for Form1.
    ''' </summary>
    Public Class Form1
        Inherits Form

        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As GridView

        Private simpleButton1 As DevExpress.XtraEditors.SimpleButton

        Private simpleButton2 As DevExpress.XtraEditors.SimpleButton

        Private gridView2 As GridView

        Private colCustomerID1 As DevExpress.XtraGrid.Columns.GridColumn

        Private colEmployeeID As DevExpress.XtraGrid.Columns.GridColumn

        Private colFreight As DevExpress.XtraGrid.Columns.GridColumn

        Private colOrderDate As DevExpress.XtraGrid.Columns.GridColumn

        Private colOrderID As DevExpress.XtraGrid.Columns.GridColumn

        Private colRequiredDate As DevExpress.XtraGrid.Columns.GridColumn

        Private colShipAddress As DevExpress.XtraGrid.Columns.GridColumn

        Private colShipCity As DevExpress.XtraGrid.Columns.GridColumn

        Private colShipCountry As DevExpress.XtraGrid.Columns.GridColumn

        Private colShipName As DevExpress.XtraGrid.Columns.GridColumn

        Private colShippedDate As DevExpress.XtraGrid.Columns.GridColumn

        Private colShipPostalCode As DevExpress.XtraGrid.Columns.GridColumn

        Private colShipRegion As DevExpress.XtraGrid.Columns.GridColumn

        Private colShipVia As DevExpress.XtraGrid.Columns.GridColumn

        Private panel1 As Panel

        Private components As IContainer

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
        '
        ' TODO: Add any constructor code after InitializeComponent call
        '
        End Sub

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If components IsNot Nothing Then
                    components.Dispose()
                End If
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Dim gridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
            gridView2 = New GridView()
            colCustomerID1 = New DevExpress.XtraGrid.Columns.GridColumn()
            colEmployeeID = New DevExpress.XtraGrid.Columns.GridColumn()
            colFreight = New DevExpress.XtraGrid.Columns.GridColumn()
            colOrderDate = New DevExpress.XtraGrid.Columns.GridColumn()
            colOrderID = New DevExpress.XtraGrid.Columns.GridColumn()
            colRequiredDate = New DevExpress.XtraGrid.Columns.GridColumn()
            colShipAddress = New DevExpress.XtraGrid.Columns.GridColumn()
            colShipCity = New DevExpress.XtraGrid.Columns.GridColumn()
            colShipCountry = New DevExpress.XtraGrid.Columns.GridColumn()
            colShipName = New DevExpress.XtraGrid.Columns.GridColumn()
            colShippedDate = New DevExpress.XtraGrid.Columns.GridColumn()
            colShipPostalCode = New DevExpress.XtraGrid.Columns.GridColumn()
            colShipRegion = New DevExpress.XtraGrid.Columns.GridColumn()
            colShipVia = New DevExpress.XtraGrid.Columns.GridColumn()
            gridControl1 = New DevExpress.XtraGrid.GridControl()
            gridView1 = New GridView()
            simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            simpleButton2 = New DevExpress.XtraEditors.SimpleButton()
            panel1 = New Panel()
            CType(gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            panel1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' gridView2
            ' 
            gridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {colCustomerID1, colEmployeeID, colFreight, colOrderDate, colOrderID, colRequiredDate, colShipAddress, colShipCity, colShipCountry, colShipName, colShippedDate, colShipPostalCode, colShipRegion, colShipVia})
            gridView2.GridControl = gridControl1
            gridView2.Name = "gridView2"
            ' 
            ' colCustomerID1
            ' 
            colCustomerID1.Caption = "CustomerID"
            colCustomerID1.FieldName = "CustomerID"
            colCustomerID1.Name = "colCustomerID1"
            colCustomerID1.Visible = True
            colCustomerID1.VisibleIndex = 0
            ' 
            ' colEmployeeID
            ' 
            colEmployeeID.Caption = "EmployeeID"
            colEmployeeID.FieldName = "EmployeeID"
            colEmployeeID.Name = "colEmployeeID"
            colEmployeeID.Visible = True
            colEmployeeID.VisibleIndex = 1
            ' 
            ' colFreight
            ' 
            colFreight.Caption = "Freight"
            colFreight.FieldName = "Freight"
            colFreight.Name = "colFreight"
            colFreight.Visible = True
            colFreight.VisibleIndex = 2
            ' 
            ' colOrderDate
            ' 
            colOrderDate.Caption = "OrderDate"
            colOrderDate.FieldName = "OrderDate"
            colOrderDate.Name = "colOrderDate"
            colOrderDate.Visible = True
            colOrderDate.VisibleIndex = 3
            ' 
            ' colOrderID
            ' 
            colOrderID.Caption = "OrderID"
            colOrderID.FieldName = "OrderID"
            colOrderID.Name = "colOrderID"
            colOrderID.Visible = True
            colOrderID.VisibleIndex = 4
            ' 
            ' colRequiredDate
            ' 
            colRequiredDate.Caption = "RequiredDate"
            colRequiredDate.FieldName = "RequiredDate"
            colRequiredDate.Name = "colRequiredDate"
            colRequiredDate.Visible = True
            colRequiredDate.VisibleIndex = 5
            ' 
            ' colShipAddress
            ' 
            colShipAddress.Caption = "ShipAddress"
            colShipAddress.FieldName = "ShipAddress"
            colShipAddress.Name = "colShipAddress"
            colShipAddress.Visible = True
            colShipAddress.VisibleIndex = 6
            ' 
            ' colShipCity
            ' 
            colShipCity.Caption = "ShipCity"
            colShipCity.FieldName = "ShipCity"
            colShipCity.Name = "colShipCity"
            colShipCity.Visible = True
            colShipCity.VisibleIndex = 7
            ' 
            ' colShipCountry
            ' 
            colShipCountry.Caption = "ShipCountry"
            colShipCountry.FieldName = "ShipCountry"
            colShipCountry.Name = "colShipCountry"
            colShipCountry.Visible = True
            colShipCountry.VisibleIndex = 8
            ' 
            ' colShipName
            ' 
            colShipName.Caption = "ShipName"
            colShipName.FieldName = "ShipName"
            colShipName.Name = "colShipName"
            colShipName.Visible = True
            colShipName.VisibleIndex = 9
            ' 
            ' colShippedDate
            ' 
            colShippedDate.Caption = "ShippedDate"
            colShippedDate.FieldName = "ShippedDate"
            colShippedDate.Name = "colShippedDate"
            colShippedDate.Visible = True
            colShippedDate.VisibleIndex = 10
            ' 
            ' colShipPostalCode
            ' 
            colShipPostalCode.Caption = "ShipPostalCode"
            colShipPostalCode.FieldName = "ShipPostalCode"
            colShipPostalCode.Name = "colShipPostalCode"
            colShipPostalCode.Visible = True
            colShipPostalCode.VisibleIndex = 11
            ' 
            ' colShipRegion
            ' 
            colShipRegion.Caption = "ShipRegion"
            colShipRegion.FieldName = "ShipRegion"
            colShipRegion.Name = "colShipRegion"
            colShipRegion.Visible = True
            colShipRegion.VisibleIndex = 12
            ' 
            ' colShipVia
            ' 
            colShipVia.Caption = "ShipVia"
            colShipVia.FieldName = "ShipVia"
            colShipVia.Name = "colShipVia"
            colShipVia.Visible = True
            colShipVia.VisibleIndex = 13
            ' 
            ' gridControl1
            ' 
            gridControl1.Dock = DockStyle.Fill
            gridLevelNode1.LevelTemplate = gridView2
            gridLevelNode1.RelationName = "CustomersOrders"
            gridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {gridLevelNode1})
            gridControl1.Location = New System.Drawing.Point(0, 40)
            gridControl1.MainView = gridView1
            gridControl1.Name = "gridControl1"
            gridControl1.Size = New System.Drawing.Size(875, 510)
            gridControl1.TabIndex = 0
            gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {gridView1, gridView2})
            ' 
            ' gridView1
            ' 
            gridView1.GridControl = gridControl1
            gridView1.Name = "gridView1"
            gridView1.OptionsSelection.MultiSelect = True
            ' 
            ' simpleButton1
            ' 
            simpleButton1.Location = New System.Drawing.Point(8, 8)
            simpleButton1.Name = "simpleButton1"
            simpleButton1.Size = New System.Drawing.Size(75, 23)
            simpleButton1.TabIndex = 1
            simpleButton1.Text = "Save"
            AddHandler simpleButton1.Click, New EventHandler(AddressOf simpleButton1_Click)
            ' 
            ' simpleButton2
            ' 
            simpleButton2.Location = New System.Drawing.Point(104, 8)
            simpleButton2.Name = "simpleButton2"
            simpleButton2.Size = New System.Drawing.Size(72, 24)
            simpleButton2.TabIndex = 2
            simpleButton2.Text = "Load"
            AddHandler simpleButton2.Click, New EventHandler(AddressOf simpleButton2_Click)
            ' 
            ' panel1
            ' 
            panel1.Controls.Add(simpleButton1)
            panel1.Controls.Add(simpleButton2)
            panel1.Dock = DockStyle.Top
            panel1.Location = New System.Drawing.Point(0, 0)
            panel1.Name = "panel1"
            panel1.Size = New System.Drawing.Size(875, 40)
            panel1.TabIndex = 3
            ' 
            ' Form1
            ' 
            AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            ClientSize = New System.Drawing.Size(875, 550)
            Me.Controls.Add(gridControl1)
            Me.Controls.Add(panel1)
            Name = "Form1"
            Text = "Form1"
            AddHandler Load, New EventHandler(AddressOf Form1_Load)
            CType(gridView2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            panel1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Shared Sub Main()
            Call Application.Run(New Form1())
        End Sub

        Private helper As RefreshHelper

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            helper = New RefreshHelper(gridView1, "ID")
            Dim dataSet11 As DataSet = New DataSet()
            dataSet11.Tables.Add(GetCustomerDataTable())
            dataSet11.Tables.Add(GetPersonDataTable())
            Dim keyColumn As DataColumn = dataSet11.Tables("Customers").Columns("ID")
            Dim foreignKeyColumn As DataColumn = dataSet11.Tables("Persons").Columns("ID")
            dataSet11.Relations.Add("CustomersPersons", keyColumn, foreignKeyColumn)
            gridControl1.DataSource = dataSet11.Tables("Customers")
            gridControl1.ForceInitialize()
        End Sub

        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            helper.SaveViewInfo()
        End Sub

        Private Sub simpleButton2_Click(ByVal sender As Object, ByVal e As EventArgs)
            helper.LoadViewInfo()
        End Sub

        Private Function GetCustomerDataTable() As DataTable
            Dim table As DataTable = New DataTable()
            table.TableName = "Customers"
            table.Columns.Add(New DataColumn("Items", GetType(String)))
            table.Columns.Add(New DataColumn("Money", GetType(Double)))
            table.Columns.Add(New DataColumn("ID", GetType(Integer)))
            For i As Integer = 0 To 10 - 1
                table.Rows.Add("Product " & i, 3000 + i * 298.55D, i)
            Next

            Return table
        End Function

        Private Function GetPersonDataTable() As DataTable
            Dim table As DataTable = New DataTable()
            table.TableName = "Persons"
            table.Columns.Add(New DataColumn("FirstName", GetType(String)))
            table.Columns.Add(New DataColumn("SecondName", GetType(String)))
            table.Columns.Add(New DataColumn("Age", GetType(Integer)))
            table.Columns.Add(New DataColumn("ID", GetType(Integer)))
            For i As Integer = 0 To 50 - 1
                Dim name As String = "Adam"
                Dim secondName As String = "Smith"
                If i Mod 2 = 0 Then
                    name = "Ben"
                    secondName = "Black"
                End If

                table.Rows.Add(name, secondName, 20 + i \ 2, i Mod 10)
            Next

            Return table
        End Function
    End Class
End Namespace
