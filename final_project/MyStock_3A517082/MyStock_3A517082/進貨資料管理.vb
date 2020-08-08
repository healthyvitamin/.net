'專案屬性->參考->加入->組件->System.transactions
'依序點選「開始」 → 「系統管理工具」 → 「服務」 → 「Distributed Transaction Coordinator」，開啟「Distributed Transaction Coordinator」視窗。
Imports System.Transactions
Imports System.Data.SqlClient
Public Class 進貨資料管理



    Private Sub 進貨資料管理_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            'TODO: 這行程式碼會將資料載入 'ORDERDataSet.產品資料' 資料表。您可以視需要進行移動或移除。
            Me.產品資料TableAdapter.Fill(Me.ORDERDataSet.產品資料)
            'TODO: 這行程式碼會將資料載入 'ORDERDataSet.客戶' 資料表。您可以視需要進行移動或移除。
            Me.供應商TableAdapter.Fill(Me.ORDERDataSet.供應商)
            BS = 進貨主檔BindingSource
            '指定資料表名稱
            TableName = "進貨主檔"
            '指定主索引鍵的欄位名稱
            IDField = "進貨單號"




            If FTableName <> "" And FIDField <> "" Then
                '取得主索引鍵最大值
                PrimaryID = pf.GetKey("SELECT ISNULL(MAX(" & FIDField & "),'') AS ID FROM " & FTableName & " ")
                '移至主索引鍵最大值的記錄
                FillData()
            End If


            '----------------------------------------------------------
            '設定DataGridView顯示格式與顏色
            pf.SetDGV(進貨明細DataGridView)

            '設定DataGridView 項次 欄位整數且置中靠右
            Me.項次.DefaultCellStyle.Format = "N0"
            Me.項次.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            '設定DataGridView 數量 欄位整數且置中靠右
            Me.數量.DefaultCellStyle.Format = "N0"
            Me.數量.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            '設定DataGridView 單價 欄位數值小數2位且置中靠右
            Me.單價.DefaultCellStyle.Format = "N2"
            Me.單價.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            '設定DataGridView 小計 欄位數值小數1位且置中靠右
            Me.小計.DefaultCellStyle.Format = "N1"
            Me.小計.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            '取消進貨明細DataGridVie允許使用者自行新增資料列
            Me.進貨明細DataGridView.AllowUserToAddRows = False
            '-----------------------------------------------------------


            TBStatus = 0
            SetControls()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

#Region "介面"
    '客戶編號ComboBox選取值有改變時重新載入連絡人、地址
    Private Sub 廠商編號ComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles 廠商編號ComboBox.SelectedValueChanged
        If TBStatus = 0 Then Exit Sub



        Try
            Dim SQLCMD As String = String.Format("SELECT 連絡人  FROM 供應商 WHERE 供應商編號 = '{0}'", Me.廠商編號ComboBox.SelectedValue)
            Dim DT As DataTable
            DT = pf.GetDataTable(SQLCMD)
            If DT.Rows.Count > 0 Then
                Me.連絡人TextBox.Text = DT.Rows(0).Item(0)

            Else
                Me.連絡人TextBox.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
#End Region
#Region "DGV"
    '儲存格在編輯模式時
    Private Sub 進貨明細DataGridView_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles 進貨明細DataGridView.CellBeginEdit
        If TBStatus = 0 Then Exit Sub
        '進貨主檔EndEdit()

        Me.進貨主檔BindingSource.EndEdit()
        '進貨明細DataGridView允許使用者新增資料列
        Me.進貨明細DataGridView.AllowUserToAddRows = True

    End Sub

    '新增資料預設值
    Private Sub 進貨明細DataGridView_DefaultValuesNeeded(sender As Object, e As DataGridViewRowEventArgs) Handles 進貨明細DataGridView.DefaultValuesNeeded
        e.Row.Cells("進貨單號").Value = Me.進貨單號TextBox.Text
        e.Row.Cells("項次").Value = Me.進貨明細DataGridView.RowCount 'e.Row.Index + 1
        e.Row.Cells("產品編號").Value = ""
        e.Row.Cells("單價").Value = 0
        e.Row.Cells("數量").Value = 1
        e.Row.Cells("小計").Value = 0

    End Sub

    '進貨明細DataGridView刪除資料列時重新定義項次順序
    Private Sub 進貨明細DataGridView_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles 進貨明細DataGridView.RowsRemoved
        If 進貨明細DataGridView.RowCount <= 0 Then Exit Sub
        For i As Integer = 0 To 進貨明細DataGridView.RowCount - 1
            Me.進貨明細DataGridView.Rows(i).Cells("項次").Value = i + 1
        Next
        '計算小計、合計、總計
        CalTotal()
    End Sub

    '判斷產品編號、單價、數量是否有異動:有異動-> bolChange = True
    Private Sub 進貨明細DataGridView_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles 進貨明細DataGridView.CellValueChanged
        If TBStatus = 0 Then Exit Sub
        If e.ColumnIndex = 1 Or e.ColumnIndex = 2 Or e.ColumnIndex = 3 Then
            bolChange = True
        End If

    End Sub

    Private Sub 進貨明細DataGridView_CellValidated(sender As Object, e As DataGridViewCellEventArgs) Handles 進貨明細DataGridView.CellValidated

        '若為瀏覽模式或產品編號、單價、數量没有異動則跳離
        If TBStatus = 0 Or bolChange = False Then Exit Sub

        '將異動旗標設為False
        bolChange = False
        'MsgBox(e.ColumnIndex)
        '產品編號資料有異動;則重新取得產品資料
        If e.ColumnIndex = 1 Then
            Dim ID As String = IIf(IsDBNull(Me.進貨明細DataGridView.CurrentRow.Cells("產品編號").Value), "", Me.進貨明細DataGridView.CurrentRow.Cells("產品編號").Value)

            If ID <> "" Then
                Dim SQLCMD As String = String.Format("SELECT 單價, 不再銷售 FROM 產品資料 WHERE 產品編號 = '{0}'", ID)
                Dim DT As DataTable
                DT = pf.GetDataTable(SQLCMD)

                '找到產品資料則帶入產品單價與是否不再銷售
                If DT.Rows.Count > 0 Then
                    '若產品不再銷售;則發出警告
                    If DT.Rows(0).Item(1) = True Then
                        MsgBox("此產品已不再銷售!")
                    End If
                    '帶入產品單價
                    Me.進貨明細DataGridView.CurrentRow.Cells("單價").Value = DT.Rows(0).Item(0)
                Else
                    '若找不到產品資料則單價歸0
                    Me.進貨明細DataGridView.CurrentRow.Cells("單價").Value = 0
                End If
            End If

            '再啟用進貨明細DataGridView使用者新增資料列
            Me.進貨明細DataGridView.AllowUserToAddRows = True

        End If

        If Me.進貨明細DataGridView.CurrentRow.Cells("產品編號").Value = "" Then
            Me.進貨明細DataGridView.CurrentCell = Me.進貨明細DataGridView.CurrentRow.Cells("項次")
            If 進貨明細DataGridView.RowCount > 0 Then
                Me.進貨明細DataGridView.AllowUserToAddRows = False
            End If
        End If

        '計算小計、合計、總計
        CalTotal()
    End Sub
#End Region


#Region "支援函數"

    ''' <summary>
    ''' 設定所有控制項的ReadOnly或Enabled屬性
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub SetControls()
        Try
            '-------------------------------------------
            Me.進貨單號TextBox.ReadOnly = (TBStatus <> 1 And TBStatus <> 2)
            Me.連絡人TextBox.ReadOnly = (TBStatus <> 1 And TBStatus <> 2)
            Me.進貨別TextBox.ReadOnly = (TBStatus <> 1 And TBStatus <> 2)
            Me.備註TextBox.ReadOnly = (TBStatus <> 1 And TBStatus <> 2)
            Me.發票號碼TextBox.ReadOnly = (TBStatus <> 1 And TBStatus <> 2)
            Me.廠商編號ComboBox.Enabled = (TBStatus = 1 Or TBStatus = 2)
            Me.進貨日期DateTimePicker.Enabled = (TBStatus = 1 Or TBStatus = 2)
            Me.進貨金額TextBox.ReadOnly = True
            Me.營業稅TextBox.ReadOnly = True
            Me.總計金額TextBox.ReadOnly = True
            '-------------------------------------------
            Me.進貨明細DataGridView.ReadOnly = (TBStatus <> 1 And TBStatus <> 2)
            Me.進貨明細DataGridView.AllowUserToAddRows = (TBStatus = 1 Or TBStatus = 2)
            Me.項次.ReadOnly = True
            Me.小計.ReadOnly = True



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    '載入資料
    Public Overrides Sub FillData()
        Try
            ORDERDataSet.EnforceConstraints = False
            '  MsgBox(PrimaryID)
            Me.進貨主檔TableAdapter.Fill(Me.ORDERDataSet.進貨主檔, PrimaryID)
            Me.進貨明細TableAdapter.Fill(Me.ORDERDataSet.進貨明細, PrimaryID)
            ORDERDataSet.EnforceConstraints = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    '按下btnAddNew按鈕來新增記錄之後
    Public Overrides Sub AfterAddNew()
        Me.進貨日期DateTimePicker.Value = Today
        Me.進貨單號TextBox.Text = GetDeliverID(Me.進貨日期DateTimePicker.Value)
        Me.進貨別TextBox.Text = "1"
        Me.廠商編號ComboBox.Focus()

        '進貨金額設定 因為資料庫不能NULL
        Me.進貨金額TextBox.Text = 0

    End Sub

    '按下btnEdit按鈕編輯記錄之後
    Public Overrides Sub AfterEdit()
        Me.廠商編號ComboBox.Focus()
    End Sub

    '刪除記錄前要處理的事情
    Public Overrides Function BeforeDelete() As Boolean
        If MsgBox(String.Format("刪除本筆資料？" + vbCrLf + vbCrLf + "單據號碼：{0}", 進貨單號TextBox.Text), MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2) = MsgBoxResult.No Then
            '放棄刪除，跳離刪除記錄的程序
            Return False
        End If
        '進行刪除記錄的程序
        DeleteID = 進貨單號TextBox.Text
        Return True
    End Function

    '用來執行刪除資料庫記錄
    Public Overrides Function DeleteData() As Boolean
        Try

            'Using Scope As New TransactionScope
            For i As Integer = 0 To Me.進貨明細DataGridView.RowCount - 1
                With Me.進貨明細DataGridView.Rows(i)
                    '進貨明細-刪除部分:需還原原始產品編號的庫存數量
                    pf.StockQty(.Cells("產品編號").Value, IIf(Me.進貨別TextBox.Text = "1", -1, 1) * .Cells("數量").Value)
                End With
            Next
            pf.ExecSQL(String.Format("DELETE FROM 進貨主檔 WHERE 進貨單號 = '{0}' ", 進貨單號TextBox.Text))
            PrimaryID = 進貨單號TextBox.Text
            'Scope.Complete()
            'End Using
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    '用來執行更新的記錄至資料庫
    Public Overrides Function UpdateData() As Boolean
        Try
            Me.Validate()
            '結束編輯
            BS.EndEdit()
            Me.進貨明細BindingSource.EndEdit()

            '刪除產品編號空白資料列
            For i As Integer = 0 To ORDERDataSet.進貨明細.Rows.Count - 1
                If Not ORDERDataSet.進貨明細.Rows(i).RowState = DataRowState.Deleted Then

                    If IsDBNull(ORDERDataSet.進貨明細.Rows(i).Item("產品編號")) Or ORDERDataSet.進貨明細.Rows(i).Item("產品編號") = "" Then
                        ORDERDataSet.進貨明細.Rows(i).Delete()
                    End If
                End If
            Next

            'Using scope As New TransactionScope


            '記錄原單別
            Dim OldType, NewType As String
            OldType = ""    '原始單別
            NewType = ""    '目前單別
            '取得進貨主檔-修改部分
            Dim modType As ORDERDataSet.進貨主檔DataTable = ORDERDataSet.進貨主檔.GetChanges(DataRowState.Modified)

            OldType = Me.進貨別TextBox.Text
            NewType = Me.進貨別TextBox.Text
            If modType IsNot Nothing Then
                For Each dr As DataRow In modType
                    OldType = dr("進貨別", DataRowVersion.Original)
                    NewType = dr("進貨別", DataRowVersion.Current)
                Next
            End If

            '有更改單別才執行
            If OldType <> NewType Then
                Dim uncItem As ORDERDataSet.進貨明細DataTable = ORDERDataSet.進貨明細.GetChanges(DataRowState.Unchanged)
                If uncItem IsNot Nothing Then
                    For Each dr As DataRow In uncItem
                        '進貨明細-未修改部分: 先還原原始產品編號的庫存數量量(還原)
                        pf.StockQty(dr("產品編號", DataRowVersion.Original), IIf(OldType = "1", -1, 1) * dr("數量", DataRowVersion.Original))
                        '進貨明細-未修改部分: 再異動目前產品編號的庫存數量
                        pf.StockQty(dr("產品編號", DataRowVersion.Current), IIf(NewType = "1", 1, -1) * dr("數量", DataRowVersion.Current))
                    Next
                End If
            End If

            '取得進貨明細-新增部分
            Dim addItem As ORDERDataSet.進貨明細DataTable = ORDERDataSet.進貨明細.GetChanges(DataRowState.Added)
            '取得訂貨明細-修改部分
            Dim modItem As ORDERDataSet.進貨明細DataTable = ORDERDataSet.進貨明細.GetChanges(DataRowState.Modified)
            '取得訂貨明細-刪除部分
            Dim delItem As ORDERDataSet.進貨明細DataTable = ORDERDataSet.進貨明細.GetChanges(DataRowState.Deleted)

            If delItem IsNot Nothing Then
                For Each dr As DataRow In delItem.Rows
                    '進貨明細-刪除部分:需還原原始產品編號的庫存數量
                    pf.StockQty(dr("產品編號", DataRowVersion.Original), IIf(OldType = "1", -1, 1) * dr("數量", DataRowVersion.Original))
                Next
            End If

            If modItem IsNot Nothing Then
                For Each dr As DataRow In modItem.Rows
                    '  MsgBox(dr("數量", DataRowVersion.Original))
                    '  MsgBox(dr("數量", DataRowVersion.Current))
                    'MsgBox(IIf(OldType = "1", -1, 1) * dr("數量", DataRowVersion.Original))
                    'MsgBox(IIf(NewType = "1", 1, -1) * dr("數量", DataRowVersion.Current))

                    '進貨明細-修改部分:需先還原原始產品編號的庫存數量量(還原)

                    pf.StockQty(dr("產品編號", DataRowVersion.Original), IIf(OldType = "1", -1, 1) * dr("數量", DataRowVersion.Original))
                    '進貨明細-修改部分:再異動目前產品編號的庫存數量
                    pf.StockQty(dr("產品編號", DataRowVersion.Current), IIf(NewType = "1", 1, -1) * dr("數量", DataRowVersion.Current))
                Next
            End If

            If addItem IsNot Nothing Then
                For Each dr As DataRow In addItem.Rows
                    'MsgBox(dr("id", DataRowVersion.Current))
                    '進貨明細-新增部分:異動目前產品編號的庫存數量
                    pf.StockQty(dr("產品編號", DataRowVersion.Current), IIf(NewType = "1", 1, -1) * dr("數量", DataRowVersion.Current))
                Next
            End If

            '更新資料
            進貨主檔TableAdapter.Update(ORDERDataSet.進貨主檔)
            進貨明細TableAdapter.Update(ORDERDataSet.進貨明細)
            PrimaryID = 進貨單號TextBox.Text
            'scope.Complete()
            'End Using
            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function

    '執行BS物件的CancelEdit方法之前
    Public Overrides Function BeforeCancelEdit() As Boolean
        MyBase.BeforeCancelEdit()
        Me.進貨明細BindingSource.CancelEdit()
        Me.進貨主檔BindingSource.CancelEdit()
        Return True
    End Function

    '用於執行列印表單的任務
    Public Overrides Sub DoPrint()
        Dim PT As New 進貨單列印
        PT.ShowDialog()
    End Sub



    ''' <summary>
    ''' 取得當月最後進貨單號
    ''' </summary>
    ''' <param name="D">進貨日期</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetDeliverID(ByVal D As Date) As String
        Dim SQLCMD As String = String.Format("SELECT MAX(進貨單號) AS ID FROM 進貨主檔 WHERE 進貨單號 LIKE '{0}%'", D.Year.ToString.PadLeft(4, "0") & D.Month.ToString.PadLeft(2, "0"))
        Dim DT As DataTable
        DT = pf.GetDataTable(SQLCMD)
        If IsDBNull(DT.Rows(0).Item("ID")) Then
            GetDeliverID = D.Year.ToString.PadLeft(4, "0") & D.Month.ToString.PadLeft(2, "0") & "001"
        Else
            Dim ID1, ID2 As String
            ID1 = DT.Rows(0).Item("ID")
            ID2 = CStr(CInt(ID1.Substring(6, 3)) + 1).PadLeft(3, "0")
            GetDeliverID = D.Year.ToString.PadLeft(4, "0") & D.Month.ToString.PadLeft(2, "0") & ID2
        End If
    End Function

    '計算小計、合計、總計金額
    Private Sub CalTotal()
        '先記錄當時進貨明細DataGridView.AllowUserToAddRows狀態
        Dim bolAdd As Boolean = Me.進貨明細DataGridView.AllowUserToAddRows
        '先關閉進貨明細DataGridView新增列;避免計算時發生錯誤
        Me.進貨明細DataGridView.AllowUserToAddRows = False
        '小計
        Dim dubAmount As Double = 0
        '合計
        Dim dubTotAmount As Double = 0
        '
        If Me.進貨明細DataGridView.RowCount > 0 Then
            For i As Integer = 0 To 進貨明細DataGridView.RowCount - 1
                '小計=單價*數量
                'Math.Round四捨五入函數
                dubAmount = Math.Round((Val(Me.進貨明細DataGridView.Rows(i).Cells("單價").Value) * Val(Me.進貨明細DataGridView.Rows(i).Cells("數量").Value)), 1, MidpointRounding.AwayFromZero)
                '合計=各明細列的小計總合
                dubTotAmount += dubAmount
                '更新各明細列的小計值
                Me.進貨明細DataGridView.Rows(i).Cells("小計").Value = dubAmount
            Next
        End If
        '銷售金額=dubTotAmount
        Me.進貨金額TextBox.Text = dubTotAmount.ToString("#,##0.#")
        '營業稅=dubTotAmount*5%
        Me.營業稅TextBox.Text = (dubTotAmount * 5 / 100).ToString("#,##0.#")
        '總計金額=銷售金額+營業稅-->(銷售金額*1.05)
        Me.總計金額TextBox.Text = (dubTotAmount * 1.05).ToString("#,##0.#")  '(Val(Me.銷售金額TextBox.Text) + Val(Me.營業稅TextBox.Text)).ToString("#,##0")
        '再還原進貨明細DataGridView.AllowUserToAddRows當時狀態
        Me.進貨明細DataGridView.AllowUserToAddRows = bolAdd
    End Sub









#End Region

End Class