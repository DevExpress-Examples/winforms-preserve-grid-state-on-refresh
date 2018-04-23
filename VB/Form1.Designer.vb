Imports Microsoft.VisualBasic
Imports System
Namespace WindowsFormsApplication97
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
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
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.nwindDataSet = New WindowsFormsApplication97.nwindDataSet()
			Me.ordersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.ordersTableAdapter = New WindowsFormsApplication97.nwindDataSetTableAdapters.OrdersTableAdapter()
			Me.colOrderID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCustomerID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colEmployeeID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colOrderDate = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colRequiredDate = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colShippedDate = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colShipVia = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colFreight = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colShipName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colShipAddress = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colShipCity = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colShipRegion = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colShipPostalCode = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colShipCountry = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.order_DetailsTableAdapter1 = New WindowsFormsApplication97.nwindDataSetTableAdapters.Order_DetailsTableAdapter()
			Me.button1 = New System.Windows.Forms.Button()
			Me.button2 = New System.Windows.Forms.Button()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ordersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.ordersBindingSource
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(738, 426)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colOrderID, Me.colCustomerID, Me.colEmployeeID, Me.colOrderDate, Me.colRequiredDate, Me.colShippedDate, Me.colShipVia, Me.colFreight, Me.colShipName, Me.colShipAddress, Me.colShipCity, Me.colShipRegion, Me.colShipPostalCode, Me.colShipCountry})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' ordersBindingSource
			' 
			Me.ordersBindingSource.DataMember = "Orders"
			Me.ordersBindingSource.DataSource = Me.nwindDataSet
			' 
			' ordersTableAdapter
			' 
			Me.ordersTableAdapter.ClearBeforeFill = True
			' 
			' colOrderID
			' 
			Me.colOrderID.FieldName = "OrderID"
			Me.colOrderID.Name = "colOrderID"
			Me.colOrderID.Visible = True
			Me.colOrderID.VisibleIndex = 0
			' 
			' colCustomerID
			' 
			Me.colCustomerID.FieldName = "CustomerID"
			Me.colCustomerID.Name = "colCustomerID"
			Me.colCustomerID.Visible = True
			Me.colCustomerID.VisibleIndex = 1
			' 
			' colEmployeeID
			' 
			Me.colEmployeeID.FieldName = "EmployeeID"
			Me.colEmployeeID.Name = "colEmployeeID"
			Me.colEmployeeID.Visible = True
			Me.colEmployeeID.VisibleIndex = 2
			' 
			' colOrderDate
			' 
			Me.colOrderDate.FieldName = "OrderDate"
			Me.colOrderDate.Name = "colOrderDate"
			Me.colOrderDate.Visible = True
			Me.colOrderDate.VisibleIndex = 3
			' 
			' colRequiredDate
			' 
			Me.colRequiredDate.FieldName = "RequiredDate"
			Me.colRequiredDate.Name = "colRequiredDate"
			Me.colRequiredDate.Visible = True
			Me.colRequiredDate.VisibleIndex = 4
			' 
			' colShippedDate
			' 
			Me.colShippedDate.FieldName = "ShippedDate"
			Me.colShippedDate.Name = "colShippedDate"
			Me.colShippedDate.Visible = True
			Me.colShippedDate.VisibleIndex = 5
			' 
			' colShipVia
			' 
			Me.colShipVia.FieldName = "ShipVia"
			Me.colShipVia.Name = "colShipVia"
			Me.colShipVia.Visible = True
			Me.colShipVia.VisibleIndex = 6
			' 
			' colFreight
			' 
			Me.colFreight.FieldName = "Freight"
			Me.colFreight.Name = "colFreight"
			Me.colFreight.Visible = True
			Me.colFreight.VisibleIndex = 7
			' 
			' colShipName
			' 
			Me.colShipName.FieldName = "ShipName"
			Me.colShipName.Name = "colShipName"
			Me.colShipName.Visible = True
			Me.colShipName.VisibleIndex = 8
			' 
			' colShipAddress
			' 
			Me.colShipAddress.FieldName = "ShipAddress"
			Me.colShipAddress.Name = "colShipAddress"
			Me.colShipAddress.Visible = True
			Me.colShipAddress.VisibleIndex = 9
			' 
			' colShipCity
			' 
			Me.colShipCity.FieldName = "ShipCity"
			Me.colShipCity.Name = "colShipCity"
			Me.colShipCity.Visible = True
			Me.colShipCity.VisibleIndex = 10
			' 
			' colShipRegion
			' 
			Me.colShipRegion.FieldName = "ShipRegion"
			Me.colShipRegion.Name = "colShipRegion"
			Me.colShipRegion.Visible = True
			Me.colShipRegion.VisibleIndex = 11
			' 
			' colShipPostalCode
			' 
			Me.colShipPostalCode.FieldName = "ShipPostalCode"
			Me.colShipPostalCode.Name = "colShipPostalCode"
			Me.colShipPostalCode.Visible = True
			Me.colShipPostalCode.VisibleIndex = 12
			' 
			' colShipCountry
			' 
			Me.colShipCountry.FieldName = "ShipCountry"
			Me.colShipCountry.Name = "colShipCountry"
			Me.colShipCountry.Visible = True
			Me.colShipCountry.VisibleIndex = 13
			' 
			' order_DetailsTableAdapter1
			' 
			Me.order_DetailsTableAdapter1.ClearBeforeFill = True
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(110, 469)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(75, 23)
			Me.button1.TabIndex = 1
			Me.button1.Text = "button1"
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click);
			' 
			' button2
			' 
			Me.button2.Location = New System.Drawing.Point(283, 468)
			Me.button2.Name = "button2"
			Me.button2.Size = New System.Drawing.Size(75, 23)
			Me.button2.TabIndex = 2
			Me.button2.Text = "button2"
			Me.button2.UseVisualStyleBackColor = True
'			Me.button2.Click += New System.EventHandler(Me.button2_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(898, 550)
			Me.Controls.Add(Me.button2)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ordersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private nwindDataSet As nwindDataSet
		Private ordersBindingSource As System.Windows.Forms.BindingSource
		Private ordersTableAdapter As nwindDataSetTableAdapters.OrdersTableAdapter
		Private colOrderID As DevExpress.XtraGrid.Columns.GridColumn
		Private colCustomerID As DevExpress.XtraGrid.Columns.GridColumn
		Private colEmployeeID As DevExpress.XtraGrid.Columns.GridColumn
		Private colOrderDate As DevExpress.XtraGrid.Columns.GridColumn
		Private colRequiredDate As DevExpress.XtraGrid.Columns.GridColumn
		Private colShippedDate As DevExpress.XtraGrid.Columns.GridColumn
		Private colShipVia As DevExpress.XtraGrid.Columns.GridColumn
		Private colFreight As DevExpress.XtraGrid.Columns.GridColumn
		Private colShipName As DevExpress.XtraGrid.Columns.GridColumn
		Private colShipAddress As DevExpress.XtraGrid.Columns.GridColumn
		Private colShipCity As DevExpress.XtraGrid.Columns.GridColumn
		Private colShipRegion As DevExpress.XtraGrid.Columns.GridColumn
		Private colShipPostalCode As DevExpress.XtraGrid.Columns.GridColumn
		Private colShipCountry As DevExpress.XtraGrid.Columns.GridColumn
		Private order_DetailsTableAdapter1 As nwindDataSetTableAdapters.Order_DetailsTableAdapter
		Private WithEvents button1 As System.Windows.Forms.Button
		Private WithEvents button2 As System.Windows.Forms.Button
	End Class
End Namespace

