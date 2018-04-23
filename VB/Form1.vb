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
	  Private oleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
	  Private oleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
	  Private oleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
	  Private oleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
	  Private oleDbConnection1 As System.Data.OleDb.OleDbConnection
	  Private oleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
	  Private dataSet11 As WindowsApplication649.DataSet1
	  Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
	  Private WithEvents simpleButton2 As DevExpress.XtraEditors.SimpleButton
	  Private oleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
	  Private oleDbInsertCommand2 As System.Data.OleDb.OleDbCommand
	  Private oleDbUpdateCommand2 As System.Data.OleDb.OleDbCommand
	  Private oleDbDeleteCommand2 As System.Data.OleDb.OleDbCommand
	  Private oleDbDataAdapter2 As System.Data.OleDb.OleDbDataAdapter
	  Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
	  Private colAddress As DevExpress.XtraGrid.Columns.GridColumn
	  Private colCity As DevExpress.XtraGrid.Columns.GridColumn
	  Private colCompanyName As DevExpress.XtraGrid.Columns.GridColumn
	  Private colContactName As DevExpress.XtraGrid.Columns.GridColumn
	  Private colContactTitle As DevExpress.XtraGrid.Columns.GridColumn
	  Private colCountry As DevExpress.XtraGrid.Columns.GridColumn
	  Private colCustomerID As DevExpress.XtraGrid.Columns.GridColumn
	  Private colFax As DevExpress.XtraGrid.Columns.GridColumn
	  Private colPhone As DevExpress.XtraGrid.Columns.GridColumn
	  Private colPostalCode As DevExpress.XtraGrid.Columns.GridColumn
	  Private colRegion As DevExpress.XtraGrid.Columns.GridColumn
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
		Private bindingSource1 As BindingSource
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
			Me.components = New System.ComponentModel.Container()
			Dim gridLevelNode1 As New DevExpress.XtraGrid.GridLevelNode()
			Dim configurationAppSettings As New System.Configuration.AppSettingsReader()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
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
			Me.dataSet11 = New WindowsApplication649.DataSet1()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colAddress = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCity = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCompanyName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colContactName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colContactTitle = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCountry = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCustomerID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colFax = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colPhone = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colPostalCode = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colRegion = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.oleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
			Me.oleDbConnection1 = New System.Data.OleDb.OleDbConnection()
			Me.oleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
			Me.oleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
			Me.oleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
			Me.oleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton2 = New DevExpress.XtraEditors.SimpleButton()
			Me.oleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand()
			Me.oleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand()
			Me.oleDbUpdateCommand2 = New System.Data.OleDb.OleDbCommand()
			Me.oleDbDeleteCommand2 = New System.Data.OleDb.OleDbCommand()
			Me.oleDbDataAdapter2 = New System.Data.OleDb.OleDbDataAdapter()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.bindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel1.SuspendLayout()
			CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
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
			Me.gridControl1.DataSource = Me.dataSet11.Customers
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
			' dataSet11
			' 
			Me.dataSet11.DataSetName = "DataSet1"
			Me.dataSet11.Locale = New System.Globalization.CultureInfo("en-US")
			Me.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colAddress, Me.colCity, Me.colCompanyName, Me.colContactName, Me.colContactTitle, Me.colCountry, Me.colCustomerID, Me.colFax, Me.colPhone, Me.colPostalCode, Me.colRegion})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsSelection.MultiSelect = True
			' 
			' colAddress
			' 
			Me.colAddress.Caption = "Address"
			Me.colAddress.FieldName = "Address"
			Me.colAddress.Name = "colAddress"
			Me.colAddress.Visible = True
			Me.colAddress.VisibleIndex = 0
			' 
			' colCity
			' 
			Me.colCity.Caption = "City"
			Me.colCity.FieldName = "City"
			Me.colCity.Name = "colCity"
			Me.colCity.Visible = True
			Me.colCity.VisibleIndex = 1
			' 
			' colCompanyName
			' 
			Me.colCompanyName.Caption = "CompanyName"
			Me.colCompanyName.FieldName = "CompanyName"
			Me.colCompanyName.Name = "colCompanyName"
			Me.colCompanyName.Visible = True
			Me.colCompanyName.VisibleIndex = 2
			' 
			' colContactName
			' 
			Me.colContactName.Caption = "ContactName"
			Me.colContactName.FieldName = "ContactName"
			Me.colContactName.Name = "colContactName"
			Me.colContactName.Visible = True
			Me.colContactName.VisibleIndex = 3
			' 
			' colContactTitle
			' 
			Me.colContactTitle.Caption = "ContactTitle"
			Me.colContactTitle.FieldName = "ContactTitle"
			Me.colContactTitle.Name = "colContactTitle"
			Me.colContactTitle.Visible = True
			Me.colContactTitle.VisibleIndex = 4
			' 
			' colCountry
			' 
			Me.colCountry.Caption = "Country"
			Me.colCountry.FieldName = "Country"
			Me.colCountry.Name = "colCountry"
			Me.colCountry.Visible = True
			Me.colCountry.VisibleIndex = 5
			' 
			' colCustomerID
			' 
			Me.colCustomerID.Caption = "CustomerID"
			Me.colCustomerID.FieldName = "CustomerID"
			Me.colCustomerID.Name = "colCustomerID"
			Me.colCustomerID.Visible = True
			Me.colCustomerID.VisibleIndex = 6
			' 
			' colFax
			' 
			Me.colFax.Caption = "Fax"
			Me.colFax.FieldName = "Fax"
			Me.colFax.Name = "colFax"
			Me.colFax.Visible = True
			Me.colFax.VisibleIndex = 7
			' 
			' colPhone
			' 
			Me.colPhone.Caption = "Phone"
			Me.colPhone.FieldName = "Phone"
			Me.colPhone.Name = "colPhone"
			Me.colPhone.Visible = True
			Me.colPhone.VisibleIndex = 8
			' 
			' colPostalCode
			' 
			Me.colPostalCode.Caption = "PostalCode"
			Me.colPostalCode.FieldName = "PostalCode"
			Me.colPostalCode.Name = "colPostalCode"
			Me.colPostalCode.Visible = True
			Me.colPostalCode.VisibleIndex = 9
			' 
			' colRegion
			' 
			Me.colRegion.Caption = "Region"
			Me.colRegion.FieldName = "Region"
			Me.colRegion.Name = "colRegion"
			Me.colRegion.Visible = True
			Me.colRegion.VisibleIndex = 10
			' 
			' oleDbSelectCommand1
			' 
			Me.oleDbSelectCommand1.CommandText = "SELECT CustomerID, EmployeeID, Freight, OrderDate, OrderID, RequiredDate, ShipAdd" & "ress, ShipCity, ShipCountry, ShipName, ShippedDate, ShipPostalCode, ShipRegion, " & "ShipVia FROM Orders"
			Me.oleDbSelectCommand1.Connection = Me.oleDbConnection1
			' 
			' oleDbConnection1
			' 
			Me.oleDbConnection1.ConnectionString = (CStr(configurationAppSettings.GetValue("oleDbConnection1.ConnectionString", GetType(String))))
			' 
			' oleDbInsertCommand1
			' 
			Me.oleDbInsertCommand1.CommandText = resources.GetString("oleDbInsertCommand1.CommandText")
			Me.oleDbInsertCommand1.Connection = Me.oleDbConnection1
			Me.oleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() { New System.Data.OleDb.OleDbParameter("CustomerID", System.Data.OleDb.OleDbType.VarWChar, 5, "CustomerID"), New System.Data.OleDb.OleDbParameter("EmployeeID", System.Data.OleDb.OleDbType.Integer, 0, "EmployeeID"), New System.Data.OleDb.OleDbParameter("Freight", System.Data.OleDb.OleDbType.Currency, 0, "Freight"), New System.Data.OleDb.OleDbParameter("OrderDate", System.Data.OleDb.OleDbType.DBDate, 0, "OrderDate"), New System.Data.OleDb.OleDbParameter("RequiredDate", System.Data.OleDb.OleDbType.DBDate, 0, "RequiredDate"), New System.Data.OleDb.OleDbParameter("ShipAddress", System.Data.OleDb.OleDbType.VarWChar, 60, "ShipAddress"), New System.Data.OleDb.OleDbParameter("ShipCity", System.Data.OleDb.OleDbType.VarWChar, 15, "ShipCity"), New System.Data.OleDb.OleDbParameter("ShipCountry", System.Data.OleDb.OleDbType.VarWChar, 15, "ShipCountry"), New System.Data.OleDb.OleDbParameter("ShipName", System.Data.OleDb.OleDbType.VarWChar, 40, "ShipName"), New System.Data.OleDb.OleDbParameter("ShippedDate", System.Data.OleDb.OleDbType.DBDate, 0, "ShippedDate"), New System.Data.OleDb.OleDbParameter("ShipPostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, "ShipPostalCode"), New System.Data.OleDb.OleDbParameter("ShipRegion", System.Data.OleDb.OleDbType.VarWChar, 15, "ShipRegion"), New System.Data.OleDb.OleDbParameter("ShipVia", System.Data.OleDb.OleDbType.Integer, 0, "ShipVia")})
			' 
			' oleDbUpdateCommand1
			' 
			Me.oleDbUpdateCommand1.CommandText = resources.GetString("oleDbUpdateCommand1.CommandText")
			Me.oleDbUpdateCommand1.Connection = Me.oleDbConnection1
			Me.oleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() { New System.Data.OleDb.OleDbParameter("CustomerID", System.Data.OleDb.OleDbType.VarWChar, 5, "CustomerID"), New System.Data.OleDb.OleDbParameter("EmployeeID", System.Data.OleDb.OleDbType.Integer, 0, "EmployeeID"), New System.Data.OleDb.OleDbParameter("Freight", System.Data.OleDb.OleDbType.Currency, 0, "Freight"), New System.Data.OleDb.OleDbParameter("OrderDate", System.Data.OleDb.OleDbType.DBDate, 0, "OrderDate"), New System.Data.OleDb.OleDbParameter("RequiredDate", System.Data.OleDb.OleDbType.DBDate, 0, "RequiredDate"), New System.Data.OleDb.OleDbParameter("ShipAddress", System.Data.OleDb.OleDbType.VarWChar, 60, "ShipAddress"), New System.Data.OleDb.OleDbParameter("ShipCity", System.Data.OleDb.OleDbType.VarWChar, 15, "ShipCity"), New System.Data.OleDb.OleDbParameter("ShipCountry", System.Data.OleDb.OleDbType.VarWChar, 15, "ShipCountry"), New System.Data.OleDb.OleDbParameter("ShipName", System.Data.OleDb.OleDbType.VarWChar, 40, "ShipName"), New System.Data.OleDb.OleDbParameter("ShippedDate", System.Data.OleDb.OleDbType.DBDate, 0, "ShippedDate"), New System.Data.OleDb.OleDbParameter("ShipPostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, "ShipPostalCode"), New System.Data.OleDb.OleDbParameter("ShipRegion", System.Data.OleDb.OleDbType.VarWChar, 15, "ShipRegion"), New System.Data.OleDb.OleDbParameter("ShipVia", System.Data.OleDb.OleDbType.Integer, 0, "ShipVia"), New System.Data.OleDb.OleDbParameter("Original_OrderID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "OrderID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_CustomerID", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "CustomerID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_CustomerID1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "CustomerID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_EmployeeID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "EmployeeID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_EmployeeID1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "EmployeeID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Freight", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Freight", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Freight1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Freight", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_OrderDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "OrderDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_OrderDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "OrderDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_RequiredDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "RequiredDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_RequiredDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "RequiredDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ShipAddress", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipAddress", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ShipAddress1", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipAddress", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ShipCity", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipCity", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ShipCity1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipCity", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ShipCountry", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipCountry", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ShipCountry1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipCountry", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ShipName", System.Data.OleDb.OleDbType.VarWChar, 40, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ShipName1", System.Data.OleDb.OleDbType.VarWChar, 40, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ShipPostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipPostalCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ShipPostalCode1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipPostalCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ShipRegion", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipRegion", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ShipRegion1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipRegion", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ShipVia", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipVia", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ShipVia1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipVia", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ShippedDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShippedDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ShippedDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShippedDate", System.Data.DataRowVersion.Original, Nothing)})
			' 
			' oleDbDeleteCommand1
			' 
			Me.oleDbDeleteCommand1.CommandText = resources.GetString("oleDbDeleteCommand1.CommandText")
			Me.oleDbDeleteCommand1.Connection = Me.oleDbConnection1
			Me.oleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() { New System.Data.OleDb.OleDbParameter("Original_OrderID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "OrderID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_CustomerID", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "CustomerID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_CustomerID1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "CustomerID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_EmployeeID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "EmployeeID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_EmployeeID1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "EmployeeID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Freight", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Freight", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Freight1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Freight", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_OrderDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "OrderDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_OrderDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "OrderDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_RequiredDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "RequiredDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_RequiredDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "RequiredDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ShipAddress", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipAddress", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ShipAddress1", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipAddress", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ShipCity", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipCity", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ShipCity1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipCity", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ShipCountry", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipCountry", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ShipCountry1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipCountry", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ShipName", System.Data.OleDb.OleDbType.VarWChar, 40, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ShipName1", System.Data.OleDb.OleDbType.VarWChar, 40, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ShipPostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipPostalCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ShipPostalCode1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipPostalCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ShipRegion", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipRegion", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ShipRegion1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipRegion", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ShipVia", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipVia", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ShipVia1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipVia", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ShippedDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShippedDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ShippedDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShippedDate", System.Data.DataRowVersion.Original, Nothing)})
			' 
			' oleDbDataAdapter1
			' 
			Me.oleDbDataAdapter1.DeleteCommand = Me.oleDbDeleteCommand1
			Me.oleDbDataAdapter1.InsertCommand = Me.oleDbInsertCommand1
			Me.oleDbDataAdapter1.SelectCommand = Me.oleDbSelectCommand1
			Me.oleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() { New System.Data.Common.DataTableMapping("Table", "Orders", New System.Data.Common.DataColumnMapping() { New System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"), New System.Data.Common.DataColumnMapping("EmployeeID", "EmployeeID"), New System.Data.Common.DataColumnMapping("Freight", "Freight"), New System.Data.Common.DataColumnMapping("OrderDate", "OrderDate"), New System.Data.Common.DataColumnMapping("OrderID", "OrderID"), New System.Data.Common.DataColumnMapping("RequiredDate", "RequiredDate"), New System.Data.Common.DataColumnMapping("ShipAddress", "ShipAddress"), New System.Data.Common.DataColumnMapping("ShipCity", "ShipCity"), New System.Data.Common.DataColumnMapping("ShipCountry", "ShipCountry"), New System.Data.Common.DataColumnMapping("ShipName", "ShipName"), New System.Data.Common.DataColumnMapping("ShippedDate", "ShippedDate"), New System.Data.Common.DataColumnMapping("ShipPostalCode", "ShipPostalCode"), New System.Data.Common.DataColumnMapping("ShipRegion", "ShipRegion"), New System.Data.Common.DataColumnMapping("ShipVia", "ShipVia")})})
			Me.oleDbDataAdapter1.UpdateCommand = Me.oleDbUpdateCommand1
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
			' oleDbSelectCommand2
			' 
			Me.oleDbSelectCommand2.CommandText = "SELECT Address, City, CompanyName, ContactName, ContactTitle, Country, CustomerID" & ", Fax, Phone, PostalCode, Region FROM Customers"
			Me.oleDbSelectCommand2.Connection = Me.oleDbConnection1
			' 
			' oleDbInsertCommand2
			' 
			Me.oleDbInsertCommand2.CommandText = "INSERT INTO Customers(Address, City, CompanyName, ContactName, ContactTitle, Coun" & "try, CustomerID, Fax, Phone, PostalCode, Region) VALUES (?, ?, ?, ?, ?, ?, ?, ?," & " ?, ?, ?)"
			Me.oleDbInsertCommand2.Connection = Me.oleDbConnection1
			Me.oleDbInsertCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() { New System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 60, "Address"), New System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 15, "City"), New System.Data.OleDb.OleDbParameter("CompanyName", System.Data.OleDb.OleDbType.VarWChar, 40, "CompanyName"), New System.Data.OleDb.OleDbParameter("ContactName", System.Data.OleDb.OleDbType.VarWChar, 30, "ContactName"), New System.Data.OleDb.OleDbParameter("ContactTitle", System.Data.OleDb.OleDbType.VarWChar, 30, "ContactTitle"), New System.Data.OleDb.OleDbParameter("Country", System.Data.OleDb.OleDbType.VarWChar, 15, "Country"), New System.Data.OleDb.OleDbParameter("CustomerID", System.Data.OleDb.OleDbType.VarWChar, 5, "CustomerID"), New System.Data.OleDb.OleDbParameter("Fax", System.Data.OleDb.OleDbType.VarWChar, 24, "Fax"), New System.Data.OleDb.OleDbParameter("Phone", System.Data.OleDb.OleDbType.VarWChar, 24, "Phone"), New System.Data.OleDb.OleDbParameter("PostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, "PostalCode"), New System.Data.OleDb.OleDbParameter("Region", System.Data.OleDb.OleDbType.VarWChar, 15, "Region")})
			' 
			' oleDbUpdateCommand2
			' 
			Me.oleDbUpdateCommand2.CommandText = resources.GetString("oleDbUpdateCommand2.CommandText")
			Me.oleDbUpdateCommand2.Connection = Me.oleDbConnection1
			Me.oleDbUpdateCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() { New System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 60, "Address"), New System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 15, "City"), New System.Data.OleDb.OleDbParameter("CompanyName", System.Data.OleDb.OleDbType.VarWChar, 40, "CompanyName"), New System.Data.OleDb.OleDbParameter("ContactName", System.Data.OleDb.OleDbType.VarWChar, 30, "ContactName"), New System.Data.OleDb.OleDbParameter("ContactTitle", System.Data.OleDb.OleDbType.VarWChar, 30, "ContactTitle"), New System.Data.OleDb.OleDbParameter("Country", System.Data.OleDb.OleDbType.VarWChar, 15, "Country"), New System.Data.OleDb.OleDbParameter("CustomerID", System.Data.OleDb.OleDbType.VarWChar, 5, "CustomerID"), New System.Data.OleDb.OleDbParameter("Fax", System.Data.OleDb.OleDbType.VarWChar, 24, "Fax"), New System.Data.OleDb.OleDbParameter("Phone", System.Data.OleDb.OleDbType.VarWChar, 24, "Phone"), New System.Data.OleDb.OleDbParameter("PostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, "PostalCode"), New System.Data.OleDb.OleDbParameter("Region", System.Data.OleDb.OleDbType.VarWChar, 15, "Region"), New System.Data.OleDb.OleDbParameter("Original_CustomerID", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "CustomerID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Address", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Address", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "City", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_City1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "City", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_CompanyName", System.Data.OleDb.OleDbType.VarWChar, 40, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "CompanyName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ContactName", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ContactName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ContactName1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ContactName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ContactTitle", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ContactTitle", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ContactTitle1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ContactTitle", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Country", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Country", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Country1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Country", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Fax", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Fax", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Fax1", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Fax", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Phone", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Phone", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Phone1", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Phone", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_PostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "PostalCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_PostalCode1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "PostalCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Region", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Region", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Region1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Region", System.Data.DataRowVersion.Original, Nothing)})
			' 
			' oleDbDeleteCommand2
			' 
			Me.oleDbDeleteCommand2.CommandText = resources.GetString("oleDbDeleteCommand2.CommandText")
			Me.oleDbDeleteCommand2.Connection = Me.oleDbConnection1
			Me.oleDbDeleteCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() { New System.Data.OleDb.OleDbParameter("Original_CustomerID", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "CustomerID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Address", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Address", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "City", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_City1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "City", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_CompanyName", System.Data.OleDb.OleDbType.VarWChar, 40, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "CompanyName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ContactName", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ContactName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ContactName1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ContactName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ContactTitle", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ContactTitle", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ContactTitle1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ContactTitle", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Country", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Country", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Country1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Country", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Fax", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Fax", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Fax1", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Fax", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Phone", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Phone", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Phone1", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Phone", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_PostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "PostalCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_PostalCode1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "PostalCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Region", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Region", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Region1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Region", System.Data.DataRowVersion.Original, Nothing)})
			' 
			' oleDbDataAdapter2
			' 
			Me.oleDbDataAdapter2.DeleteCommand = Me.oleDbDeleteCommand2
			Me.oleDbDataAdapter2.InsertCommand = Me.oleDbInsertCommand2
			Me.oleDbDataAdapter2.SelectCommand = Me.oleDbSelectCommand2
			Me.oleDbDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() { New System.Data.Common.DataTableMapping("Table", "Customers", New System.Data.Common.DataColumnMapping() { New System.Data.Common.DataColumnMapping("Address", "Address"), New System.Data.Common.DataColumnMapping("City", "City"), New System.Data.Common.DataColumnMapping("CompanyName", "CompanyName"), New System.Data.Common.DataColumnMapping("ContactName", "ContactName"), New System.Data.Common.DataColumnMapping("ContactTitle", "ContactTitle"), New System.Data.Common.DataColumnMapping("Country", "Country"), New System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"), New System.Data.Common.DataColumnMapping("Fax", "Fax"), New System.Data.Common.DataColumnMapping("Phone", "Phone"), New System.Data.Common.DataColumnMapping("PostalCode", "PostalCode"), New System.Data.Common.DataColumnMapping("Region", "Region")})})
			Me.oleDbDataAdapter2.UpdateCommand = Me.oleDbUpdateCommand2
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
			' bindingSource1
			' 
			Me.bindingSource1.DataMember = "Customers"
			Me.bindingSource1.DataSource = Me.dataSet11
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
			CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel1.ResumeLayout(False)
			CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
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
		 oleDbDataAdapter2.Fill(dataSet11)
		 oleDbDataAdapter1.Fill(dataSet11)
		 helper = New RefreshHelper(gridView1, "CustomerID")
	  End Sub

	  Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles simpleButton1.Click
		 helper.SaveViewInfo()
	  End Sub

	  Private Sub simpleButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles simpleButton2.Click
		 helper.LoadViewInfo()
	  End Sub
	End Class
End Namespace
