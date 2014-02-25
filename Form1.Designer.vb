<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.LocationDataDataGridView = New System.Windows.Forms.DataGridView()
        Me.LocalSKUDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Location2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Location3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Location4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocationDataBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New ParentLocationLookup.DataSet1()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.LocationDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LocationDataTableAdapter = New ParentLocationLookup.DataSet1TableAdapters.LocationDataTableAdapter()
        Me.TableAdapterManager = New ParentLocationLookup.DataSet1TableAdapters.TableAdapterManager()
        CType(Me.LocationDataDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocationDataBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocationDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LocationDataDataGridView
        '
        Me.LocationDataDataGridView.AutoGenerateColumns = False
        Me.LocationDataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LocationDataDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LocalSKUDataGridViewTextBoxColumn, Me.LocationDataGridViewTextBoxColumn, Me.Location2, Me.Location3, Me.Location4})
        Me.LocationDataDataGridView.DataSource = Me.LocationDataBindingSource1
        Me.LocationDataDataGridView.Location = New System.Drawing.Point(13, 129)
        Me.LocationDataDataGridView.Name = "LocationDataDataGridView"
        Me.LocationDataDataGridView.ReadOnly = True
        Me.LocationDataDataGridView.Size = New System.Drawing.Size(743, 430)
        Me.LocationDataDataGridView.TabIndex = 1
        '
        'LocalSKUDataGridViewTextBoxColumn
        '
        Me.LocalSKUDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.LocalSKUDataGridViewTextBoxColumn.DataPropertyName = "LocalSKU"
        Me.LocalSKUDataGridViewTextBoxColumn.HeaderText = "LocalSKU"
        Me.LocalSKUDataGridViewTextBoxColumn.Name = "LocalSKUDataGridViewTextBoxColumn"
        Me.LocalSKUDataGridViewTextBoxColumn.ReadOnly = True
        Me.LocalSKUDataGridViewTextBoxColumn.Width = 80
        '
        'LocationDataGridViewTextBoxColumn
        '
        Me.LocationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.LocationDataGridViewTextBoxColumn.DataPropertyName = "Location"
        Me.LocationDataGridViewTextBoxColumn.HeaderText = "Location"
        Me.LocationDataGridViewTextBoxColumn.Name = "LocationDataGridViewTextBoxColumn"
        Me.LocationDataGridViewTextBoxColumn.ReadOnly = True
        Me.LocationDataGridViewTextBoxColumn.Width = 73
        '
        'Location2
        '
        Me.Location2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Location2.DataPropertyName = "Location2"
        Me.Location2.HeaderText = "Location2"
        Me.Location2.Name = "Location2"
        Me.Location2.ReadOnly = True
        Me.Location2.Width = 79
        '
        'Location3
        '
        Me.Location3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Location3.DataPropertyName = "Location3"
        Me.Location3.HeaderText = "Location3"
        Me.Location3.Name = "Location3"
        Me.Location3.ReadOnly = True
        Me.Location3.Width = 79
        '
        'Location4
        '
        Me.Location4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Location4.DataPropertyName = "Location4"
        Me.Location4.HeaderText = "Location4"
        Me.Location4.Name = "Location4"
        Me.Location4.ReadOnly = True
        Me.Location4.Width = 79
        '
        'LocationDataBindingSource1
        '
        Me.LocationDataBindingSource1.DataMember = "LocationData"
        Me.LocationDataBindingSource1.DataSource = Me.DataSet1BindingSource
        '
        'DataSet1BindingSource
        '
        Me.DataSet1BindingSource.DataSource = Me.DataSet1
        Me.DataSet1BindingSource.Position = 0
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "LocationDataSet"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox1
        '
        Me.TextBox1.AcceptsReturn = True
        Me.TextBox1.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(13, 18)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(743, 47)
        Me.TextBox1.TabIndex = 2
        '
        'SearchButton
        '
        Me.SearchButton.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchButton.Location = New System.Drawing.Point(12, 71)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(744, 38)
        Me.SearchButton.TabIndex = 3
        Me.SearchButton.Text = "Search products"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'LocationDataBindingSource
        '
        Me.LocationDataBindingSource.DataMember = "LocationData"
        Me.LocationDataBindingSource.DataSource = Me.DataSet1
        '
        'LocationDataTableAdapter
        '
        Me.LocationDataTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.LocationDataTableAdapter = Me.LocationDataTableAdapter
        Me.TableAdapterManager.UpdateOrder = ParentLocationLookup.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 588)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LocationDataDataGridView)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.Text = "Lookup Items"
        CType(Me.LocationDataDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocationDataBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocationDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataSet1 As ParentLocationLookup.DataSet1
    Friend WithEvents LocationDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LocationDataTableAdapter As ParentLocationLookup.DataSet1TableAdapters.LocationDataTableAdapter
    Friend WithEvents TableAdapterManager As ParentLocationLookup.DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents LocationDataDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents SearchButton As System.Windows.Forms.Button
    Friend WithEvents LocationDataBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LocalSKUDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LocationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Location2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Location3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Location4 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
