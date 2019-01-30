Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
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
		Inherits System.Windows.Forms.Form
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents simpleButton2 As DevExpress.XtraEditors.SimpleButton
		Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
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
		Private panel1 As System.Windows.Forms.Panel
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
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim gridLevelNode1 As New DevExpress.XtraGrid.GridLevelNode()
			Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colCustomerID1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colEmployeeID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colFreight = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colOrderDate = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colOrderID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colRequiredDate = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colShipAddress = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colShipCity = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colShipCountry = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colShipName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colShippedDate = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colShipPostalCode = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colShipRegion = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colShipVia = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton2 = New DevExpress.XtraEditors.SimpleButton()
			Me.panel1 = New System.Windows.Forms.Panel()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' gridView2
			' 
			Me.gridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colCustomerID1, Me.colEmployeeID, Me.colFreight, Me.colOrderDate, Me.colOrderID, Me.colRequiredDate, Me.colShipAddress, Me.colShipCity, Me.colShipCountry, Me.colShipName, Me.colShippedDate, Me.colShipPostalCode, Me.colShipRegion, Me.colShipVia})
			Me.gridView2.GridControl = Me.gridControl1
			Me.gridView2.Name = "gridView2"
			' 
			' colCustomerID1
			' 
			Me.colCustomerID1.Caption = "CustomerID"
			Me.colCustomerID1.FieldName = "CustomerID"
			Me.colCustomerID1.Name = "colCustomerID1"
			Me.colCustomerID1.Visible = True
			Me.colCustomerID1.VisibleIndex = 0
			' 
			' colEmployeeID
			' 
			Me.colEmployeeID.Caption = "EmployeeID"
			Me.colEmployeeID.FieldName = "EmployeeID"
			Me.colEmployeeID.Name = "colEmployeeID"
			Me.colEmployeeID.Visible = True
			Me.colEmployeeID.VisibleIndex = 1
			' 
			' colFreight
			' 
			Me.colFreight.Caption = "Freight"
			Me.colFreight.FieldName = "Freight"
			Me.colFreight.Name = "colFreight"
			Me.colFreight.Visible = True
			Me.colFreight.VisibleIndex = 2
			' 
			' colOrderDate
			' 
			Me.colOrderDate.Caption = "OrderDate"
			Me.colOrderDate.FieldName = "OrderDate"
			Me.colOrderDate.Name = "colOrderDate"
			Me.colOrderDate.Visible = True
			Me.colOrderDate.VisibleIndex = 3
			' 
			' colOrderID
			' 
			Me.colOrderID.Caption = "OrderID"
			Me.colOrderID.FieldName = "OrderID"
			Me.colOrderID.Name = "colOrderID"
			Me.colOrderID.Visible = True
			Me.colOrderID.VisibleIndex = 4
			' 
			' colRequiredDate
			' 
			Me.colRequiredDate.Caption = "RequiredDate"
			Me.colRequiredDate.FieldName = "RequiredDate"
			Me.colRequiredDate.Name = "colRequiredDate"
			Me.colRequiredDate.Visible = True
			Me.colRequiredDate.VisibleIndex = 5
			' 
			' colShipAddress
			' 
			Me.colShipAddress.Caption = "ShipAddress"
			Me.colShipAddress.FieldName = "ShipAddress"
			Me.colShipAddress.Name = "colShipAddress"
			Me.colShipAddress.Visible = True
			Me.colShipAddress.VisibleIndex = 6
			' 
			' colShipCity
			' 
			Me.colShipCity.Caption = "ShipCity"
			Me.colShipCity.FieldName = "ShipCity"
			Me.colShipCity.Name = "colShipCity"
			Me.colShipCity.Visible = True
			Me.colShipCity.VisibleIndex = 7
			' 
			' colShipCountry
			' 
			Me.colShipCountry.Caption = "ShipCountry"
			Me.colShipCountry.FieldName = "ShipCountry"
			Me.colShipCountry.Name = "colShipCountry"
			Me.colShipCountry.Visible = True
			Me.colShipCountry.VisibleIndex = 8
			' 
			' colShipName
			' 
			Me.colShipName.Caption = "ShipName"
			Me.colShipName.FieldName = "ShipName"
			Me.colShipName.Name = "colShipName"
			Me.colShipName.Visible = True
			Me.colShipName.VisibleIndex = 9
			' 
			' colShippedDate
			' 
			Me.colShippedDate.Caption = "ShippedDate"
			Me.colShippedDate.FieldName = "ShippedDate"
			Me.colShippedDate.Name = "colShippedDate"
			Me.colShippedDate.Visible = True
			Me.colShippedDate.VisibleIndex = 10
			' 
			' colShipPostalCode
			' 
			Me.colShipPostalCode.Caption = "ShipPostalCode"
			Me.colShipPostalCode.FieldName = "ShipPostalCode"
			Me.colShipPostalCode.Name = "colShipPostalCode"
			Me.colShipPostalCode.Visible = True
			Me.colShipPostalCode.VisibleIndex = 11
			' 
			' colShipRegion
			' 
			Me.colShipRegion.Caption = "ShipRegion"
			Me.colShipRegion.FieldName = "ShipRegion"
			Me.colShipRegion.Name = "colShipRegion"
			Me.colShipRegion.Visible = True
			Me.colShipRegion.VisibleIndex = 12
			' 
			' colShipVia
			' 
			Me.colShipVia.Caption = "ShipVia"
			Me.colShipVia.FieldName = "ShipVia"
			Me.colShipVia.Name = "colShipVia"
			Me.colShipVia.Visible = True
			Me.colShipVia.VisibleIndex = 13
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			gridLevelNode1.LevelTemplate = Me.gridView2
			gridLevelNode1.RelationName = "CustomersOrders"
			Me.gridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() { gridLevelNode1})
			Me.gridControl1.Location = New System.Drawing.Point(0, 40)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(875, 510)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1, Me.gridView2})
			' 
			' gridView1
			' 
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsSelection.MultiSelect = True
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(8, 8)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(75, 23)
			Me.simpleButton1.TabIndex = 1
			Me.simpleButton1.Text = "Save"
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' simpleButton2
			' 
			Me.simpleButton2.Location = New System.Drawing.Point(104, 8)
			Me.simpleButton2.Name = "simpleButton2"
			Me.simpleButton2.Size = New System.Drawing.Size(72, 24)
			Me.simpleButton2.TabIndex = 2
			Me.simpleButton2.Text = "Load"
'			Me.simpleButton2.Click += New System.EventHandler(Me.simpleButton2_Click);
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.simpleButton1)
			Me.panel1.Controls.Add(Me.simpleButton2)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel1.Location = New System.Drawing.Point(0, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(875, 40)
			Me.panel1.TabIndex = 3
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(875, 550)
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.panel1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private helper As RefreshHelper

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			helper = New RefreshHelper(gridView1, "ID")

			Dim dataSet11 As New DataSet()
			dataSet11.Tables.Add(GetCustomerDataTable())
			dataSet11.Tables.Add(GetPersonDataTable())
			Dim keyColumn As DataColumn = dataSet11.Tables("Customers").Columns("ID")
			Dim foreignKeyColumn As DataColumn = dataSet11.Tables("Persons").Columns("ID")
			dataSet11.Relations.Add("CustomersPersons", keyColumn, foreignKeyColumn)
			gridControl1.DataSource = dataSet11.Tables("Customers")
			gridControl1.ForceInitialize()
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles simpleButton1.Click
			helper.SaveViewInfo()
		End Sub

		Private Sub simpleButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles simpleButton2.Click
			helper.LoadViewInfo()
		End Sub
		Private Function GetCustomerDataTable() As DataTable
			Dim table As New DataTable()
			table.TableName = "Customers"
			table.Columns.Add(New DataColumn("Items", GetType(String)))
			table.Columns.Add(New DataColumn("Money", GetType(Double)))
			table.Columns.Add(New DataColumn("ID", GetType(Integer)))
			For i As Integer = 0 To 9
				table.Rows.Add("Product " & i, 3000 + i * 298.55D, i)
			Next i
			Return table
		End Function
		Private Function GetPersonDataTable() As DataTable
			Dim table As New DataTable()
			table.TableName = "Persons"
			table.Columns.Add(New DataColumn("FirstName", GetType(String)))
			table.Columns.Add(New DataColumn("SecondName", GetType(String)))
			table.Columns.Add(New DataColumn("Age", GetType(Integer)))
			table.Columns.Add(New DataColumn("ID", GetType(Integer)))
			For i As Integer = 0 To 49
				Dim name As String = "Adam"
				Dim secondName As String = "Smith"
				If i Mod 2 = 0 Then
					name = "Ben"
					secondName = "Black"
				End If
				table.Rows.Add(name, secondName, 20 + i \ 2, i Mod 10)
			Next i
			Return table
		End Function
	End Class
End Namespace
