<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.BinLookupText = New System.Windows.Forms.TextBox()
        Me.BinLookup = New System.Windows.Forms.Button()
        Me.InventoryDataGridView = New System.Windows.Forms.DataGridView()
        Me.BinLookupActivator = New System.Windows.Forms.Button()
        Me.InventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BinItems = New ParentLocationLookup.BinItems()
        Me.InventoryTableAdapter = New ParentLocationLookup.BinItemsTableAdapters.InventoryTableAdapter()
        Me.TableAdapterManager = New ParentLocationLookup.BinItemsTableAdapters.TableAdapterManager()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.InventoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BinItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BinLookupText
        '
        Me.BinLookupText.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold)
        Me.BinLookupText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BinLookupText.Location = New System.Drawing.Point(13, 61)
        Me.BinLookupText.Name = "BinLookupText"
        Me.BinLookupText.Size = New System.Drawing.Size(743, 47)
        Me.BinLookupText.TabIndex = 0
        '
        'BinLookup
        '
        Me.BinLookup.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold)
        Me.BinLookup.Location = New System.Drawing.Point(12, 114)
        Me.BinLookup.Name = "BinLookup"
        Me.BinLookup.Size = New System.Drawing.Size(744, 42)
        Me.BinLookup.TabIndex = 1
        Me.BinLookup.Text = "View Bin Contents"
        Me.BinLookup.UseVisualStyleBackColor = True
        '
        'InventoryDataGridView
        '
        Me.InventoryDataGridView.AutoGenerateColumns = False
        Me.InventoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InventoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.InventoryDataGridView.DataSource = Me.InventoryBindingSource
        Me.InventoryDataGridView.Location = New System.Drawing.Point(13, 172)
        Me.InventoryDataGridView.Name = "InventoryDataGridView"
        Me.InventoryDataGridView.Size = New System.Drawing.Size(743, 434)
        Me.InventoryDataGridView.TabIndex = 4
        '
        'BinLookupActivator
        '
        Me.BinLookupActivator.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.BinLookupActivator.Location = New System.Drawing.Point(13, 12)
        Me.BinLookupActivator.Name = "BinLookupActivator"
        Me.BinLookupActivator.Size = New System.Drawing.Size(120, 34)
        Me.BinLookupActivator.TabIndex = 5
        Me.BinLookupActivator.Text = "Location Lookup"
        Me.BinLookupActivator.UseVisualStyleBackColor = False
        '
        'InventoryBindingSource
        '
        Me.InventoryBindingSource.DataMember = "Inventory"
        Me.InventoryBindingSource.DataSource = Me.BinItems
        '
        'BinItems
        '
        Me.BinItems.DataSetName = "BinItems"
        Me.BinItems.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InventoryTableAdapter
        '
        Me.InventoryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = ParentLocationLookup.BinItemsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "LocalSKU"
        Me.DataGridViewTextBoxColumn1.HeaderText = "LocalSKU"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "L1QTY"
        Me.DataGridViewTextBoxColumn5.HeaderText = "L1QTY"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "L2QTY"
        Me.DataGridViewTextBoxColumn2.HeaderText = "L2QTY"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "L3QTY"
        Me.DataGridViewTextBoxColumn3.HeaderText = "L3QTY"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "L4QTY"
        Me.DataGridViewTextBoxColumn4.HeaderText = "L4QTY"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 622)
        Me.Controls.Add(Me.BinLookupActivator)
        Me.Controls.Add(Me.InventoryDataGridView)
        Me.Controls.Add(Me.BinLookup)
        Me.Controls.Add(Me.BinLookupText)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "Bin Lookup"
        CType(Me.InventoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BinItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BinLookupText As System.Windows.Forms.TextBox
    Friend WithEvents BinLookup As System.Windows.Forms.Button
    Friend WithEvents BinItems As ParentLocationLookup.BinItems
    Friend WithEvents InventoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InventoryTableAdapter As ParentLocationLookup.BinItemsTableAdapters.InventoryTableAdapter
    Friend WithEvents TableAdapterManager As ParentLocationLookup.BinItemsTableAdapters.TableAdapterManager
    Friend WithEvents InventoryDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents BinLookupActivator As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
