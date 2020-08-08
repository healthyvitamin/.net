<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 出貨資料管理
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
        Dim 出貨單號Label As System.Windows.Forms.Label
        Dim 出貨日期Label As System.Windows.Forms.Label
        Dim 連絡人Label As System.Windows.Forms.Label
        Dim 出貨地址Label As System.Windows.Forms.Label
        Dim 客戶編號Label As System.Windows.Forms.Label
        Dim 出貨別Label As System.Windows.Forms.Label
        Dim 發票號碼Label As System.Windows.Forms.Label
        Dim 備註Label As System.Windows.Forms.Label
        Dim 銷售金額Label As System.Windows.Forms.Label
        Dim 營業稅Label As System.Windows.Forms.Label
        Dim 總計金額Label As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.客戶編號ComboBox = New System.Windows.Forms.ComboBox()
        Me.出貨主檔BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ORDERDataSet = New MyStock_3A517082.ORDERDataSet()
        Me.客戶BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.出貨地址TextBox = New System.Windows.Forms.TextBox()
        Me.連絡人TextBox = New System.Windows.Forms.TextBox()
        Me.出貨單號TextBox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.發票號碼TextBox = New System.Windows.Forms.TextBox()
        Me.出貨別TextBox = New System.Windows.Forms.TextBox()
        Me.出貨日期DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.出貨明細DataGridView = New System.Windows.Forms.DataGridView()
        Me.出貨單號 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.產品編號 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.產品資料BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.數量 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.單價 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.小計 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.項次 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.出貨明細BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.備註TextBox = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.總計金額TextBox = New System.Windows.Forms.TextBox()
        Me.營業稅TextBox = New System.Windows.Forms.TextBox()
        Me.銷售金額TextBox = New System.Windows.Forms.TextBox()
        Me.出貨主檔TableAdapter = New MyStock_3A517082.ORDERDataSetTableAdapters.出貨主檔TableAdapter()
        Me.TableAdapterManager = New MyStock_3A517082.ORDERDataSetTableAdapters.TableAdapterManager()
        Me.出貨明細TableAdapter = New MyStock_3A517082.ORDERDataSetTableAdapters.出貨明細TableAdapter()
        Me.客戶TableAdapter = New MyStock_3A517082.ORDERDataSetTableAdapters.客戶TableAdapter()
        Me.產品資料TableAdapter = New MyStock_3A517082.ORDERDataSetTableAdapters.產品資料TableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        出貨單號Label = New System.Windows.Forms.Label()
        出貨日期Label = New System.Windows.Forms.Label()
        連絡人Label = New System.Windows.Forms.Label()
        出貨地址Label = New System.Windows.Forms.Label()
        客戶編號Label = New System.Windows.Forms.Label()
        出貨別Label = New System.Windows.Forms.Label()
        發票號碼Label = New System.Windows.Forms.Label()
        備註Label = New System.Windows.Forms.Label()
        銷售金額Label = New System.Windows.Forms.Label()
        營業稅Label = New System.Windows.Forms.Label()
        總計金額Label = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.出貨主檔BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ORDERDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.客戶BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.出貨明細DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.產品資料BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.出貨明細BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        '出貨單號Label
        '
        出貨單號Label.AutoSize = True
        出貨單號Label.Location = New System.Drawing.Point(57, 20)
        出貨單號Label.Name = "出貨單號Label"
        出貨單號Label.Size = New System.Drawing.Size(71, 15)
        出貨單號Label.TabIndex = 0
        出貨單號Label.Text = "出貨單號:"
        '
        '出貨日期Label
        '
        出貨日期Label.AutoSize = True
        出貨日期Label.Location = New System.Drawing.Point(52, 20)
        出貨日期Label.Name = "出貨日期Label"
        出貨日期Label.Size = New System.Drawing.Size(71, 15)
        出貨日期Label.TabIndex = 0
        出貨日期Label.Text = "出貨日期:"
        '
        '連絡人Label
        '
        連絡人Label.AutoSize = True
        連絡人Label.Location = New System.Drawing.Point(261, 57)
        連絡人Label.Name = "連絡人Label"
        連絡人Label.Size = New System.Drawing.Size(56, 15)
        連絡人Label.TabIndex = 4
        連絡人Label.Text = "連絡人:"
        '
        '出貨地址Label
        '
        出貨地址Label.AutoSize = True
        出貨地址Label.Location = New System.Drawing.Point(57, 96)
        出貨地址Label.Name = "出貨地址Label"
        出貨地址Label.Size = New System.Drawing.Size(71, 15)
        出貨地址Label.TabIndex = 6
        出貨地址Label.Text = "出貨地址:"
        '
        '客戶編號Label
        '
        客戶編號Label.AutoSize = True
        客戶編號Label.Location = New System.Drawing.Point(57, 57)
        客戶編號Label.Name = "客戶編號Label"
        客戶編號Label.Size = New System.Drawing.Size(71, 15)
        客戶編號Label.TabIndex = 7
        客戶編號Label.Text = "客戶編號:"
        '
        '出貨別Label
        '
        出貨別Label.AutoSize = True
        出貨別Label.Location = New System.Drawing.Point(67, 60)
        出貨別Label.Name = "出貨別Label"
        出貨別Label.Size = New System.Drawing.Size(56, 15)
        出貨別Label.TabIndex = 2
        出貨別Label.Text = "出貨別:"
        '
        '發票號碼Label
        '
        發票號碼Label.AutoSize = True
        發票號碼Label.Location = New System.Drawing.Point(52, 96)
        發票號碼Label.Name = "發票號碼Label"
        發票號碼Label.Size = New System.Drawing.Size(71, 15)
        發票號碼Label.TabIndex = 4
        發票號碼Label.Text = "發票號碼:"
        '
        '備註Label
        '
        備註Label.AutoSize = True
        備註Label.Location = New System.Drawing.Point(71, 19)
        備註Label.Name = "備註Label"
        備註Label.Size = New System.Drawing.Size(41, 15)
        備註Label.TabIndex = 0
        備註Label.Text = "備註:"
        '
        '銷售金額Label
        '
        銷售金額Label.AutoSize = True
        銷售金額Label.Location = New System.Drawing.Point(104, 22)
        銷售金額Label.Name = "銷售金額Label"
        銷售金額Label.Size = New System.Drawing.Size(71, 15)
        銷售金額Label.TabIndex = 0
        銷售金額Label.Text = "銷售金額:"
        '
        '營業稅Label
        '
        營業稅Label.AutoSize = True
        營業稅Label.Location = New System.Drawing.Point(119, 56)
        營業稅Label.Name = "營業稅Label"
        營業稅Label.Size = New System.Drawing.Size(56, 15)
        營業稅Label.TabIndex = 2
        營業稅Label.Text = "營業稅:"
        '
        '總計金額Label
        '
        總計金額Label.AutoSize = True
        總計金額Label.Location = New System.Drawing.Point(104, 92)
        總計金額Label.Name = "總計金額Label"
        總計金額Label.Size = New System.Drawing.Size(71, 15)
        總計金額Label.TabIndex = 4
        總計金額Label.Text = "總計金額:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(客戶編號Label)
        Me.Panel1.Controls.Add(Me.客戶編號ComboBox)
        Me.Panel1.Controls.Add(出貨地址Label)
        Me.Panel1.Controls.Add(Me.出貨地址TextBox)
        Me.Panel1.Controls.Add(連絡人Label)
        Me.Panel1.Controls.Add(Me.連絡人TextBox)
        Me.Panel1.Controls.Add(出貨單號Label)
        Me.Panel1.Controls.Add(Me.出貨單號TextBox)
        Me.Panel1.Location = New System.Drawing.Point(0, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(474, 143)
        Me.Panel1.TabIndex = 5
        '
        '客戶編號ComboBox
        '
        Me.客戶編號ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.出貨主檔BindingSource, "客戶編號", True))
        Me.客戶編號ComboBox.DataSource = Me.客戶BindingSource
        Me.客戶編號ComboBox.DisplayMember = "公司名稱"
        Me.客戶編號ComboBox.FormattingEnabled = True
        Me.客戶編號ComboBox.Location = New System.Drawing.Point(134, 54)
        Me.客戶編號ComboBox.Name = "客戶編號ComboBox"
        Me.客戶編號ComboBox.Size = New System.Drawing.Size(121, 23)
        Me.客戶編號ComboBox.TabIndex = 8
        Me.客戶編號ComboBox.ValueMember = "客戶編號"
        '
        '出貨主檔BindingSource
        '
        Me.出貨主檔BindingSource.DataMember = "出貨主檔"
        Me.出貨主檔BindingSource.DataSource = Me.ORDERDataSet
        '
        'ORDERDataSet
        '
        Me.ORDERDataSet.DataSetName = "ORDERDataSet"
        Me.ORDERDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '客戶BindingSource
        '
        Me.客戶BindingSource.DataMember = "客戶"
        Me.客戶BindingSource.DataSource = Me.ORDERDataSet
        '
        '出貨地址TextBox
        '
        Me.出貨地址TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.出貨主檔BindingSource, "出貨地址", True))
        Me.出貨地址TextBox.Location = New System.Drawing.Point(134, 93)
        Me.出貨地址TextBox.Name = "出貨地址TextBox"
        Me.出貨地址TextBox.Size = New System.Drawing.Size(289, 25)
        Me.出貨地址TextBox.TabIndex = 7
        '
        '連絡人TextBox
        '
        Me.連絡人TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.出貨主檔BindingSource, "連絡人", True))
        Me.連絡人TextBox.Location = New System.Drawing.Point(323, 54)
        Me.連絡人TextBox.Name = "連絡人TextBox"
        Me.連絡人TextBox.Size = New System.Drawing.Size(100, 25)
        Me.連絡人TextBox.TabIndex = 5
        '
        '出貨單號TextBox
        '
        Me.出貨單號TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.出貨主檔BindingSource, "出貨單號", True))
        Me.出貨單號TextBox.Location = New System.Drawing.Point(134, 17)
        Me.出貨單號TextBox.Name = "出貨單號TextBox"
        Me.出貨單號TextBox.Size = New System.Drawing.Size(100, 25)
        Me.出貨單號TextBox.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(發票號碼Label)
        Me.Panel2.Controls.Add(Me.發票號碼TextBox)
        Me.Panel2.Controls.Add(出貨別Label)
        Me.Panel2.Controls.Add(Me.出貨別TextBox)
        Me.Panel2.Controls.Add(出貨日期Label)
        Me.Panel2.Controls.Add(Me.出貨日期DateTimePicker)
        Me.Panel2.Location = New System.Drawing.Point(480, 60)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(475, 143)
        Me.Panel2.TabIndex = 6
        '
        '發票號碼TextBox
        '
        Me.發票號碼TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.出貨主檔BindingSource, "發票號碼", True))
        Me.發票號碼TextBox.Location = New System.Drawing.Point(129, 93)
        Me.發票號碼TextBox.Name = "發票號碼TextBox"
        Me.發票號碼TextBox.Size = New System.Drawing.Size(100, 25)
        Me.發票號碼TextBox.TabIndex = 5
        '
        '出貨別TextBox
        '
        Me.出貨別TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.出貨主檔BindingSource, "出貨別", True))
        Me.出貨別TextBox.Location = New System.Drawing.Point(129, 57)
        Me.出貨別TextBox.Name = "出貨別TextBox"
        Me.出貨別TextBox.Size = New System.Drawing.Size(100, 25)
        Me.出貨別TextBox.TabIndex = 3
        '
        '出貨日期DateTimePicker
        '
        Me.出貨日期DateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.出貨主檔BindingSource, "出貨日期", True))
        Me.出貨日期DateTimePicker.Location = New System.Drawing.Point(129, 16)
        Me.出貨日期DateTimePicker.Name = "出貨日期DateTimePicker"
        Me.出貨日期DateTimePicker.Size = New System.Drawing.Size(200, 25)
        Me.出貨日期DateTimePicker.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.出貨明細DataGridView)
        Me.Panel3.Location = New System.Drawing.Point(0, 209)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(955, 153)
        Me.Panel3.TabIndex = 6
        '
        '出貨明細DataGridView
        '
        Me.出貨明細DataGridView.AutoGenerateColumns = False
        Me.出貨明細DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.出貨明細DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.出貨單號, Me.產品編號, Me.數量, Me.單價, Me.小計, Me.項次, Me.id})
        Me.出貨明細DataGridView.DataSource = Me.出貨明細BindingSource
        Me.出貨明細DataGridView.Location = New System.Drawing.Point(3, 3)
        Me.出貨明細DataGridView.Name = "出貨明細DataGridView"
        Me.出貨明細DataGridView.RowTemplate.Height = 27
        Me.出貨明細DataGridView.Size = New System.Drawing.Size(952, 147)
        Me.出貨明細DataGridView.TabIndex = 0
        '
        '出貨單號
        '
        Me.出貨單號.DataPropertyName = "出貨單號"
        Me.出貨單號.HeaderText = "出貨單號"
        Me.出貨單號.Name = "出貨單號"
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
        '出貨明細BindingSource
        '
        Me.出貨明細BindingSource.DataMember = "FK_出貨明細_出貨主檔"
        Me.出貨明細BindingSource.DataSource = Me.出貨主檔BindingSource
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(備註Label)
        Me.Panel4.Controls.Add(Me.備註TextBox)
        Me.Panel4.Location = New System.Drawing.Point(0, 368)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(474, 150)
        Me.Panel4.TabIndex = 6
        '
        '備註TextBox
        '
        Me.備註TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.出貨主檔BindingSource, "備註", True))
        Me.備註TextBox.Location = New System.Drawing.Point(118, 16)
        Me.備註TextBox.Multiline = True
        Me.備註TextBox.Name = "備註TextBox"
        Me.備註TextBox.Size = New System.Drawing.Size(353, 125)
        Me.備註TextBox.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(總計金額Label)
        Me.Panel5.Controls.Add(Me.總計金額TextBox)
        Me.Panel5.Controls.Add(營業稅Label)
        Me.Panel5.Controls.Add(Me.營業稅TextBox)
        Me.Panel5.Controls.Add(銷售金額Label)
        Me.Panel5.Controls.Add(Me.銷售金額TextBox)
        Me.Panel5.Location = New System.Drawing.Point(480, 368)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(475, 150)
        Me.Panel5.TabIndex = 6
        '
        '總計金額TextBox
        '
        Me.總計金額TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.出貨主檔BindingSource, "總計金額", True))
        Me.總計金額TextBox.Location = New System.Drawing.Point(181, 89)
        Me.總計金額TextBox.Name = "總計金額TextBox"
        Me.總計金額TextBox.Size = New System.Drawing.Size(100, 25)
        Me.總計金額TextBox.TabIndex = 5
        '
        '營業稅TextBox
        '
        Me.營業稅TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.出貨主檔BindingSource, "營業稅", True))
        Me.營業稅TextBox.Location = New System.Drawing.Point(181, 53)
        Me.營業稅TextBox.Name = "營業稅TextBox"
        Me.營業稅TextBox.Size = New System.Drawing.Size(100, 25)
        Me.營業稅TextBox.TabIndex = 3
        '
        '銷售金額TextBox
        '
        Me.銷售金額TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.出貨主檔BindingSource, "銷售金額", True))
        Me.銷售金額TextBox.Location = New System.Drawing.Point(181, 19)
        Me.銷售金額TextBox.Name = "銷售金額TextBox"
        Me.銷售金額TextBox.Size = New System.Drawing.Size(100, 25)
        Me.銷售金額TextBox.TabIndex = 1
        '
        '出貨主檔TableAdapter
        '
        Me.出貨主檔TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.employeeTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MyStock_3A517082.ORDERDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.供應商TableAdapter = Nothing
        Me.TableAdapterManager.出貨主檔TableAdapter = Me.出貨主檔TableAdapter
        Me.TableAdapterManager.出貨明細TableAdapter = Nothing
        Me.TableAdapterManager.員工TableAdapter = Nothing
        Me.TableAdapterManager.客戶TableAdapter = Nothing
        Me.TableAdapterManager.帳號密碼TableAdapter = Nothing
        Me.TableAdapterManager.產品資料TableAdapter = Nothing
        Me.TableAdapterManager.產品類別TableAdapter = Nothing
        Me.TableAdapterManager.訂貨主檔TableAdapter = Nothing
        Me.TableAdapterManager.訂貨明細TableAdapter = Nothing
        Me.TableAdapterManager.貨運公司TableAdapter = Nothing
        Me.TableAdapterManager.進貨主檔TableAdapter = Nothing
        Me.TableAdapterManager.進貨明細TableAdapter = Nothing
        '
        '出貨明細TableAdapter
        '
        Me.出貨明細TableAdapter.ClearBeforeFill = True
        '
        '客戶TableAdapter
        '
        Me.客戶TableAdapter.ClearBeforeFill = True
        '
        '產品資料TableAdapter
        '
        Me.產品資料TableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(235, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 15)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "(1 出貨 2退回)"
        '
        '出貨資料管理
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.ClientSize = New System.Drawing.Size(955, 521)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "出貨資料管理"
        Me.Text = "出貨資料管理"
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.Panel3, 0)
        Me.Controls.SetChildIndex(Me.Panel4, 0)
        Me.Controls.SetChildIndex(Me.Panel5, 0)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.出貨主檔BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ORDERDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.客戶BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.出貨明細DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.產品資料BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.出貨明細BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents 出貨主檔BindingSource As BindingSource
    Friend WithEvents 出貨主檔TableAdapter As ORDERDataSetTableAdapters.出貨主檔TableAdapter
    Friend WithEvents TableAdapterManager As ORDERDataSetTableAdapters.TableAdapterManager
    Friend WithEvents 出貨單號TextBox As TextBox
    Friend WithEvents 客戶編號ComboBox As ComboBox
    Friend WithEvents 出貨地址TextBox As TextBox
    Friend WithEvents 連絡人TextBox As TextBox
    Friend WithEvents 出貨日期DateTimePicker As DateTimePicker
    Friend WithEvents 發票號碼TextBox As TextBox
    Friend WithEvents 出貨別TextBox As TextBox
    Friend WithEvents 出貨明細BindingSource As BindingSource
    Friend WithEvents 出貨明細TableAdapter As ORDERDataSetTableAdapters.出貨明細TableAdapter
    Friend WithEvents 出貨明細DataGridView As DataGridView
    Friend WithEvents 備註TextBox As TextBox
    Friend WithEvents 總計金額TextBox As TextBox
    Friend WithEvents 營業稅TextBox As TextBox
    Friend WithEvents 銷售金額TextBox As TextBox
    Friend WithEvents 客戶BindingSource As BindingSource
    Friend WithEvents 客戶TableAdapter As ORDERDataSetTableAdapters.客戶TableAdapter
    Friend WithEvents 產品資料BindingSource As BindingSource
    Friend WithEvents 產品資料TableAdapter As ORDERDataSetTableAdapters.產品資料TableAdapter
    Friend WithEvents 出貨單號 As DataGridViewTextBoxColumn
    Friend WithEvents 產品編號 As DataGridViewComboBoxColumn
    Friend WithEvents 數量 As DataGridViewTextBoxColumn
    Friend WithEvents 單價 As DataGridViewTextBoxColumn
    Friend WithEvents 小計 As DataGridViewTextBoxColumn
    Friend WithEvents 項次 As DataGridViewTextBoxColumn
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
End Class
