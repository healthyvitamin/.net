<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 進貨資料管理
    Inherits MyStock_3A517082.BaseForm

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim 進貨單號Label As System.Windows.Forms.Label
        Dim 廠商編號Label As System.Windows.Forms.Label
        Dim 連絡人Label As System.Windows.Forms.Label
        Dim 進貨日期Label As System.Windows.Forms.Label
        Dim 進貨別Label As System.Windows.Forms.Label
        Dim 發票號碼Label As System.Windows.Forms.Label
        Dim 備註Label As System.Windows.Forms.Label
        Dim 進貨金額Label As System.Windows.Forms.Label
        Dim 營業稅Label As System.Windows.Forms.Label
        Dim 總計金額Label As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.連絡人TextBox = New System.Windows.Forms.TextBox()
        Me.進貨主檔BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ORDERDataSet = New MyStock_3A517082.ORDERDataSet()
        Me.廠商編號ComboBox = New System.Windows.Forms.ComboBox()
        Me.供應商BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.進貨單號TextBox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.發票號碼TextBox = New System.Windows.Forms.TextBox()
        Me.進貨別TextBox = New System.Windows.Forms.TextBox()
        Me.進貨日期DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.進貨明細DataGridView = New System.Windows.Forms.DataGridView()
        Me.進貨單號 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.產品編號 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.產品資料BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.數量 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.單價 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.小計 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.項次 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.進貨明細BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.備註TextBox = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.總計金額TextBox = New System.Windows.Forms.TextBox()
        Me.營業稅TextBox = New System.Windows.Forms.TextBox()
        Me.進貨金額TextBox = New System.Windows.Forms.TextBox()
        Me.進貨主檔TableAdapter = New MyStock_3A517082.ORDERDataSetTableAdapters.進貨主檔TableAdapter()
        Me.TableAdapterManager = New MyStock_3A517082.ORDERDataSetTableAdapters.TableAdapterManager()
        Me.供應商TableAdapter = New MyStock_3A517082.ORDERDataSetTableAdapters.供應商TableAdapter()
        Me.產品資料TableAdapter = New MyStock_3A517082.ORDERDataSetTableAdapters.產品資料TableAdapter()
        Me.進貨明細TableAdapter = New MyStock_3A517082.ORDERDataSetTableAdapters.進貨明細TableAdapter()
        進貨單號Label = New System.Windows.Forms.Label()
        廠商編號Label = New System.Windows.Forms.Label()
        連絡人Label = New System.Windows.Forms.Label()
        進貨日期Label = New System.Windows.Forms.Label()
        進貨別Label = New System.Windows.Forms.Label()
        發票號碼Label = New System.Windows.Forms.Label()
        備註Label = New System.Windows.Forms.Label()
        進貨金額Label = New System.Windows.Forms.Label()
        營業稅Label = New System.Windows.Forms.Label()
        總計金額Label = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.進貨主檔BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ORDERDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.供應商BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.進貨明細DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.產品資料BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.進貨明細BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        '進貨單號Label
        '
        進貨單號Label.AutoSize = True
        進貨單號Label.Location = New System.Drawing.Point(77, 22)
        進貨單號Label.Name = "進貨單號Label"
        進貨單號Label.Size = New System.Drawing.Size(71, 15)
        進貨單號Label.TabIndex = 0
        進貨單號Label.Text = "進貨單號:"
        '
        '廠商編號Label
        '
        廠商編號Label.AutoSize = True
        廠商編號Label.Location = New System.Drawing.Point(77, 58)
        廠商編號Label.Name = "廠商編號Label"
        廠商編號Label.Size = New System.Drawing.Size(71, 15)
        廠商編號Label.TabIndex = 2
        廠商編號Label.Text = "廠商編號:"
        '
        '連絡人Label
        '
        連絡人Label.AutoSize = True
        連絡人Label.Location = New System.Drawing.Point(92, 93)
        連絡人Label.Name = "連絡人Label"
        連絡人Label.Size = New System.Drawing.Size(56, 15)
        連絡人Label.TabIndex = 4
        連絡人Label.Text = "連絡人:"
        '
        '進貨日期Label
        '
        進貨日期Label.AutoSize = True
        進貨日期Label.Location = New System.Drawing.Point(75, 23)
        進貨日期Label.Name = "進貨日期Label"
        進貨日期Label.Size = New System.Drawing.Size(71, 15)
        進貨日期Label.TabIndex = 0
        進貨日期Label.Text = "進貨日期:"
        '
        '進貨別Label
        '
        進貨別Label.AutoSize = True
        進貨別Label.Location = New System.Drawing.Point(90, 63)
        進貨別Label.Name = "進貨別Label"
        進貨別Label.Size = New System.Drawing.Size(56, 15)
        進貨別Label.TabIndex = 2
        進貨別Label.Text = "進貨別:"
        '
        '發票號碼Label
        '
        發票號碼Label.AutoSize = True
        發票號碼Label.Location = New System.Drawing.Point(75, 100)
        發票號碼Label.Name = "發票號碼Label"
        發票號碼Label.Size = New System.Drawing.Size(71, 15)
        發票號碼Label.TabIndex = 4
        發票號碼Label.Text = "發票號碼:"
        '
        '備註Label
        '
        備註Label.AutoSize = True
        備註Label.Location = New System.Drawing.Point(75, 16)
        備註Label.Name = "備註Label"
        備註Label.Size = New System.Drawing.Size(41, 15)
        備註Label.TabIndex = 0
        備註Label.Text = "備註:"
        '
        '進貨金額Label
        '
        進貨金額Label.AutoSize = True
        進貨金額Label.Location = New System.Drawing.Point(75, 32)
        進貨金額Label.Name = "進貨金額Label"
        進貨金額Label.Size = New System.Drawing.Size(71, 15)
        進貨金額Label.TabIndex = 0
        進貨金額Label.Text = "進貨金額:"
        '
        '營業稅Label
        '
        營業稅Label.AutoSize = True
        營業稅Label.Location = New System.Drawing.Point(90, 73)
        營業稅Label.Name = "營業稅Label"
        營業稅Label.Size = New System.Drawing.Size(56, 15)
        營業稅Label.TabIndex = 2
        營業稅Label.Text = "營業稅:"
        '
        '總計金額Label
        '
        總計金額Label.AutoSize = True
        總計金額Label.Location = New System.Drawing.Point(75, 115)
        總計金額Label.Name = "總計金額Label"
        總計金額Label.Size = New System.Drawing.Size(71, 15)
        總計金額Label.TabIndex = 4
        總計金額Label.Text = "總計金額:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(連絡人Label)
        Me.Panel1.Controls.Add(Me.連絡人TextBox)
        Me.Panel1.Controls.Add(廠商編號Label)
        Me.Panel1.Controls.Add(Me.廠商編號ComboBox)
        Me.Panel1.Controls.Add(進貨單號Label)
        Me.Panel1.Controls.Add(Me.進貨單號TextBox)
        Me.Panel1.Location = New System.Drawing.Point(0, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(474, 142)
        Me.Panel1.TabIndex = 5
        '
        '連絡人TextBox
        '
        Me.連絡人TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.進貨主檔BindingSource, "連絡人", True))
        Me.連絡人TextBox.Location = New System.Drawing.Point(154, 90)
        Me.連絡人TextBox.Name = "連絡人TextBox"
        Me.連絡人TextBox.Size = New System.Drawing.Size(100, 25)
        Me.連絡人TextBox.TabIndex = 5
        '
        '進貨主檔BindingSource
        '
        Me.進貨主檔BindingSource.DataMember = "進貨主檔"
        Me.進貨主檔BindingSource.DataSource = Me.ORDERDataSet
        '
        'ORDERDataSet
        '
        Me.ORDERDataSet.DataSetName = "ORDERDataSet"
        Me.ORDERDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '廠商編號ComboBox
        '
        Me.廠商編號ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.進貨主檔BindingSource, "廠商編號", True))
        Me.廠商編號ComboBox.DataSource = Me.供應商BindingSource
        Me.廠商編號ComboBox.DisplayMember = "供應商"
        Me.廠商編號ComboBox.FormattingEnabled = True
        Me.廠商編號ComboBox.Location = New System.Drawing.Point(154, 55)
        Me.廠商編號ComboBox.Name = "廠商編號ComboBox"
        Me.廠商編號ComboBox.Size = New System.Drawing.Size(121, 23)
        Me.廠商編號ComboBox.TabIndex = 3
        Me.廠商編號ComboBox.ValueMember = "供應商編號"
        '
        '供應商BindingSource
        '
        Me.供應商BindingSource.DataMember = "供應商"
        Me.供應商BindingSource.DataSource = Me.ORDERDataSet
        '
        '進貨單號TextBox
        '
        Me.進貨單號TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.進貨主檔BindingSource, "進貨單號", True))
        Me.進貨單號TextBox.Location = New System.Drawing.Point(154, 19)
        Me.進貨單號TextBox.Name = "進貨單號TextBox"
        Me.進貨單號TextBox.Size = New System.Drawing.Size(100, 25)
        Me.進貨單號TextBox.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(發票號碼Label)
        Me.Panel2.Controls.Add(Me.發票號碼TextBox)
        Me.Panel2.Controls.Add(進貨別Label)
        Me.Panel2.Controls.Add(Me.進貨別TextBox)
        Me.Panel2.Controls.Add(進貨日期Label)
        Me.Panel2.Controls.Add(Me.進貨日期DateTimePicker)
        Me.Panel2.Location = New System.Drawing.Point(480, 60)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(480, 142)
        Me.Panel2.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(258, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 15)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "(1 進貨 2退回)"
        '
        '發票號碼TextBox
        '
        Me.發票號碼TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.進貨主檔BindingSource, "發票號碼", True))
        Me.發票號碼TextBox.Location = New System.Drawing.Point(152, 97)
        Me.發票號碼TextBox.Name = "發票號碼TextBox"
        Me.發票號碼TextBox.Size = New System.Drawing.Size(100, 25)
        Me.發票號碼TextBox.TabIndex = 5
        '
        '進貨別TextBox
        '
        Me.進貨別TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.進貨主檔BindingSource, "進貨別", True))
        Me.進貨別TextBox.Location = New System.Drawing.Point(152, 60)
        Me.進貨別TextBox.Name = "進貨別TextBox"
        Me.進貨別TextBox.Size = New System.Drawing.Size(100, 25)
        Me.進貨別TextBox.TabIndex = 3
        '
        '進貨日期DateTimePicker
        '
        Me.進貨日期DateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.進貨主檔BindingSource, "進貨日期", True))
        Me.進貨日期DateTimePicker.Location = New System.Drawing.Point(152, 19)
        Me.進貨日期DateTimePicker.Name = "進貨日期DateTimePicker"
        Me.進貨日期DateTimePicker.Size = New System.Drawing.Size(200, 25)
        Me.進貨日期DateTimePicker.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.進貨明細DataGridView)
        Me.Panel3.Location = New System.Drawing.Point(0, 204)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(960, 171)
        Me.Panel3.TabIndex = 6
        '
        '進貨明細DataGridView
        '
        Me.進貨明細DataGridView.AutoGenerateColumns = False
        Me.進貨明細DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.進貨明細DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.進貨單號, Me.產品編號, Me.數量, Me.單價, Me.小計, Me.項次, Me.id})
        Me.進貨明細DataGridView.DataSource = Me.進貨明細BindingSource
        Me.進貨明細DataGridView.Location = New System.Drawing.Point(3, 4)
        Me.進貨明細DataGridView.Name = "進貨明細DataGridView"
        Me.進貨明細DataGridView.RowTemplate.Height = 27
        Me.進貨明細DataGridView.Size = New System.Drawing.Size(945, 164)
        Me.進貨明細DataGridView.TabIndex = 0
        '
        '進貨單號
        '
        Me.進貨單號.DataPropertyName = "進貨單號"
        Me.進貨單號.HeaderText = "進貨單號"
        Me.進貨單號.Name = "進貨單號"
        '
        '產品編號
        '
        Me.產品編號.DataPropertyName = "產品編號"
        Me.產品編號.DataSource = Me.產品資料BindingSource
        Me.產品編號.DisplayMember = "產品"
        Me.產品編號.HeaderText = "產品編號"
        Me.產品編號.Name = "產品編號"
        Me.產品編號.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.產品編號.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.產品編號.ValueMember = "產品編號"
        '
        '產品資料BindingSource
        '
        Me.產品資料BindingSource.DataMember = "產品資料"
        Me.產品資料BindingSource.DataSource = Me.ORDERDataSet
        '
        '數量
        '
        Me.數量.DataPropertyName = "數量"
        Me.數量.HeaderText = "數量"
        Me.數量.Name = "數量"
        '
        '單價
        '
        Me.單價.DataPropertyName = "單價"
        Me.單價.HeaderText = "單價"
        Me.單價.Name = "單價"
        '
        '小計
        '
        Me.小計.DataPropertyName = "小計"
        Me.小計.HeaderText = "小計"
        Me.小計.Name = "小計"
        '
        '項次
        '
        Me.項次.DataPropertyName = "項次"
        Me.項次.HeaderText = "項次"
        Me.項次.Name = "項次"
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        '進貨明細BindingSource
        '
        Me.進貨明細BindingSource.DataMember = "FK_進貨明細_進貨主檔"
        Me.進貨明細BindingSource.DataSource = Me.進貨主檔BindingSource
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(備註Label)
        Me.Panel4.Controls.Add(Me.備註TextBox)
        Me.Panel4.Location = New System.Drawing.Point(0, 381)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(474, 164)
        Me.Panel4.TabIndex = 6
        '
        '備註TextBox
        '
        Me.備註TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.進貨主檔BindingSource, "備註", True))
        Me.備註TextBox.Location = New System.Drawing.Point(122, 13)
        Me.備註TextBox.Multiline = True
        Me.備註TextBox.Name = "備註TextBox"
        Me.備註TextBox.Size = New System.Drawing.Size(317, 139)
        Me.備註TextBox.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(總計金額Label)
        Me.Panel5.Controls.Add(Me.總計金額TextBox)
        Me.Panel5.Controls.Add(營業稅Label)
        Me.Panel5.Controls.Add(Me.營業稅TextBox)
        Me.Panel5.Controls.Add(進貨金額Label)
        Me.Panel5.Controls.Add(Me.進貨金額TextBox)
        Me.Panel5.Location = New System.Drawing.Point(480, 381)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(480, 164)
        Me.Panel5.TabIndex = 6
        '
        '總計金額TextBox
        '
        Me.總計金額TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.進貨主檔BindingSource, "總計金額", True))
        Me.總計金額TextBox.Location = New System.Drawing.Point(152, 112)
        Me.總計金額TextBox.Name = "總計金額TextBox"
        Me.總計金額TextBox.Size = New System.Drawing.Size(100, 25)
        Me.總計金額TextBox.TabIndex = 5
        '
        '營業稅TextBox
        '
        Me.營業稅TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.進貨主檔BindingSource, "營業稅", True))
        Me.營業稅TextBox.Location = New System.Drawing.Point(152, 70)
        Me.營業稅TextBox.Name = "營業稅TextBox"
        Me.營業稅TextBox.Size = New System.Drawing.Size(100, 25)
        Me.營業稅TextBox.TabIndex = 3
        '
        '進貨金額TextBox
        '
        Me.進貨金額TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.進貨主檔BindingSource, "進貨金額", True))
        Me.進貨金額TextBox.Location = New System.Drawing.Point(152, 29)
        Me.進貨金額TextBox.Name = "進貨金額TextBox"
        Me.進貨金額TextBox.Size = New System.Drawing.Size(100, 25)
        Me.進貨金額TextBox.TabIndex = 1
        '
        '進貨主檔TableAdapter
        '
        Me.進貨主檔TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.employeeTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MyStock_3A517082.ORDERDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.供應商TableAdapter = Me.供應商TableAdapter
        Me.TableAdapterManager.出貨主檔TableAdapter = Nothing
        Me.TableAdapterManager.出貨明細TableAdapter = Nothing
        Me.TableAdapterManager.員工TableAdapter = Nothing
        Me.TableAdapterManager.客戶TableAdapter = Nothing
        Me.TableAdapterManager.帳號密碼TableAdapter = Nothing
        Me.TableAdapterManager.產品資料TableAdapter = Me.產品資料TableAdapter
        Me.TableAdapterManager.產品類別TableAdapter = Nothing
        Me.TableAdapterManager.訂貨主檔TableAdapter = Nothing
        Me.TableAdapterManager.訂貨明細TableAdapter = Nothing
        Me.TableAdapterManager.貨運公司TableAdapter = Nothing
        Me.TableAdapterManager.進貨主檔TableAdapter = Me.進貨主檔TableAdapter
        Me.TableAdapterManager.進貨明細TableAdapter = Me.進貨明細TableAdapter
        '
        '供應商TableAdapter
        '
        Me.供應商TableAdapter.ClearBeforeFill = True
        '
        '產品資料TableAdapter
        '
        Me.產品資料TableAdapter.ClearBeforeFill = True
        '
        '進貨明細TableAdapter
        '
        Me.進貨明細TableAdapter.ClearBeforeFill = True
        '
        '進貨資料管理
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.ClientSize = New System.Drawing.Size(960, 545)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "進貨資料管理"
        Me.Text = "進貨資料管理"
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.Panel3, 0)
        Me.Controls.SetChildIndex(Me.Panel4, 0)
        Me.Controls.SetChildIndex(Me.Panel5, 0)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.進貨主檔BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ORDERDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.供應商BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.進貨明細DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.產品資料BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.進貨明細BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents ORDERDataSet As ORDERDataSet
    Friend WithEvents 進貨主檔BindingSource As BindingSource
    Friend WithEvents 進貨主檔TableAdapter As ORDERDataSetTableAdapters.進貨主檔TableAdapter
    Friend WithEvents TableAdapterManager As ORDERDataSetTableAdapters.TableAdapterManager
    Friend WithEvents 進貨單號TextBox As TextBox
    Friend WithEvents 廠商編號ComboBox As ComboBox
    Friend WithEvents 連絡人TextBox As TextBox
    Friend WithEvents 發票號碼TextBox As TextBox
    Friend WithEvents 進貨別TextBox As TextBox
    Friend WithEvents 進貨日期DateTimePicker As DateTimePicker
    Friend WithEvents 備註TextBox As TextBox
    Friend WithEvents 總計金額TextBox As TextBox
    Friend WithEvents 營業稅TextBox As TextBox
    Friend WithEvents 進貨金額TextBox As TextBox
    Friend WithEvents 進貨明細TableAdapter As ORDERDataSetTableAdapters.進貨明細TableAdapter
    Friend WithEvents 進貨明細BindingSource As BindingSource
    Friend WithEvents 進貨明細DataGridView As DataGridView
    Friend WithEvents 供應商TableAdapter As ORDERDataSetTableAdapters.供應商TableAdapter
    Friend WithEvents 供應商BindingSource As BindingSource
    Friend WithEvents 產品資料TableAdapter As ORDERDataSetTableAdapters.產品資料TableAdapter
    Friend WithEvents 產品資料BindingSource As BindingSource
    Friend WithEvents 進貨單號 As DataGridViewTextBoxColumn
    Friend WithEvents 產品編號 As DataGridViewComboBoxColumn
    Friend WithEvents 數量 As DataGridViewTextBoxColumn
    Friend WithEvents 單價 As DataGridViewTextBoxColumn
    Friend WithEvents 小計 As DataGridViewTextBoxColumn
    Friend WithEvents 項次 As DataGridViewTextBoxColumn
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
End Class
