Public Class BaseForm



    Dim WithEvents FBindingsource As New BindingSource
    '資料狀態
    Public FTBStatus As Byte = 0
    '主索引鍵值
    Public FPrimaryID As String = ""
    '被刪除的主索引鍵值
    Public FDeleteID As String = ""
    '資料表名稱
    Public FTableName As String = ""
    '資料表主索引鍵的欄位名稱
    Public FIDField As String = ""
    ' ''欄位資料是否有變動
    Protected bolChange As Boolean = False

    Dim BOOT As Boolean = False
    Protected pf As PublicFunction

    Private Sub BaseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '建立公用函數類別
        pf = New PublicFunction
        '預設狀態為瀏覽模式
        TBStatus = 0
        SetButtons()
        SetControls()
        FTableName = TableName
        FIDField = IDField
        If FTableName <> "" And FIDField <> "" Then
            '取得主索引鍵最大值
            PrimaryID = pf.GetKey("SELECT ISNULL(MAX(" & FIDField & "),'') AS ID FROM " & FTableName & " ")
            '移至主索引鍵最大值的記錄
            FillData()
        End If

    End Sub

#Region "按鈕處理事件"

    Private Sub FBindingsource_PositionChanged() Handles FBindingsource.PositionChanged
        SetButtons()
    End Sub

    '按下btnMoveFirstItem按鈕
    Public Sub BindingNavigatorMoveFirstItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveFirstItem.Click
        Dim mKey As String
        mKey = pf.GetKey(String.Format("SELECT ISNULL(MIN({0}),'') FROM {1} ", FIDField, FTableName))
        If mKey <> "" Then
            PrimaryID = mKey
            FillData()
        End If

        TBStatus = 0
    End Sub

    '按下btnMovePreviousItem按鈕
    Private Sub BindingNavigatorMovePreviousItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMovePreviousItem.Click
        Dim mKey As String
        mKey = pf.GetKey(String.Format("SELECT ISNULL(MAX({0}),'') FROM {1} WHERE {0} < '{2}' ", FIDField, FTableName, FPrimaryID))
        If mKey <> "" Then
            PrimaryID = mKey
            FillData()
        End If

        TBStatus = 0
    End Sub

    '按下btnMoveNextItem按鈕
    Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveNextItem.Click
        Dim mKey As String
        mKey = pf.GetKey(String.Format("SELECT ISNULL(MIN({0}),'') FROM {1} WHERE {0} > '{2}' ", FIDField, FTableName, FPrimaryID))
        If mKey <> "" Then
            PrimaryID = mKey
            FillData()
        End If
        TBStatus = 0
    End Sub

    '按下btnMoveLastItem按鈕
    Private Sub BindingNavigatorMoveLastItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveLastItem.Click
        Dim mKey As String
        mKey = pf.GetKey(String.Format("SELECT ISNULL(MAX({0}),'') FROM {1} ", FIDField, FTableName))
        If mKey <> "" Then
            PrimaryID = mKey
            FillData()
        End If
        TBStatus = 0
    End Sub

    '新增
    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        If BeforeAddNew() Then
            BS.AddNew()
            TBStatus = 1
            SetControls()
            SetButtons()
            AfterAddNew()
        End If
    End Sub

    '修改
    Private Sub BindingNavigatorModifyItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorModifyItem.Click
        If BeforeEdit() And (Not PrimaryID Is Nothing) Then
            TBStatus = 2
            SetControls()
            SetButtons()
            AfterEdit()
        End If
    End Sub

    '刪除
    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click
        '按下btnDelete按鈕
        If BeforeDelete() Then
            If DeleteData() Then
                If Not PrimaryID Is Nothing Then
                    Dim dt As New DataTable()
                    Dim IsFind As Boolean = False
                    Dim SQL As String
                    '找出指定資料表的目前被刪除的記錄的下一筆記錄
                    SQL = "SELECT TOP 1 " + FIDField + " AS ID " +
                          "FROM " + FTableName + " " +
                          "WHERE " + FIDField + " > '" + FDeleteID + "' " +
                          "ORDER BY " + FIDField
                    dt = pf.GetDataTable(SQL)
                    If dt.Rows.Count > 0 Then
                        If Not IsDBNull(dt.Rows(0).Item("ID")) Then
                            IsFind = True
                            PrimaryID = CStr(dt.Rows(0).Item("ID"))
                        End If
                    End If
                    If Not IsFind Then
                        '找出指定資料表的的目前記錄的上一筆記錄
                        SQL = "SELECT TOP 1 " + FIDField + " AS ID " +
                              "FROM " + FTableName + " " +
                              "WHERE " + FIDField + " < '" + FDeleteID + "' " +
                              "ORDER BY " + FIDField + " DESC "
                        dt = pf.GetDataTable(SQL)
                        If dt.Rows.Count > 0 Then
                            If Not IsDBNull(dt.Rows(0).Item("ID")) Then
                                IsFind = True
                                PrimaryID = CStr(dt.Rows(0).Item("ID"))
                            End If
                        End If
                    End If
                    If Not IsFind Then
                        PrimaryID = ""
                    End If

                    FillData()
                    SetControls()
                End If

            End If
            SetButtons()
            AfterDelete()
        End If
    End Sub

    '列印
    Private Sub BindingNavigatorPrintItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorPrintItem.Click
        '按下btnPrint按鈕
        DoPrint()
    End Sub

    Private Sub BindingNavigatorCancelItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorCancelItem.Click
        If BeforeCancelEdit() Then
            BS.CancelEdit()
            TBStatus = 0
            SetControls()
            FillData()
            SetButtons()
            AfterCancelEdit()
        End If
    End Sub
    '儲存
    Private Sub BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorSaveItem.Click
        '按btnSaveChange按鈕
        If BeforeEndEdit() Then
            BS.EndEdit()
            Dim PrevTBStatus As Byte = TBStatus
            Try
                If UpdateData() Then
                    TBStatus = 0
                    SetControls()
                    '重新自資料庫讀入資料
                    FillData()
                    MsgBox("儲存完成!")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                TBStatus = PrevTBStatus
            End Try
            SetButtons()
            AfterEndEdit()

        End If
    End Sub

    '查詢
    Private Sub BindingNavigatorSearchItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorSearchItem.Click
        '按下btnSearch按鈕
        PrimaryID = SearchTextBox.Text
        If PrimaryID IsNot Nothing Then
            Dim IsFind As Boolean = False
            Dim SQL As String
            SQL = "SELECT " + FIDField + " AS ID " +
                  "FROM " + FTableName + " " +
                  "WHERE " + FIDField + " = '" + PrimaryID + "' "
            Dim dt As DataTable = pf.GetDataTable(SQL)
            If dt.Rows.Count > 0 Then
                If Not IsDBNull(dt.Rows(0)("ID")) Then
                    IsFind = True
                    PrimaryID = CStr(dt.Rows(0)("ID"))
                    FillData()
                End If
            End If
            If Not IsFind Then
                MsgBox("找不到指定的記錄。")
            End If
            TBStatus = 0
        End If
    End Sub

    '結束
    Private Sub BindingNavigatorExit_Click(sender As Object, e As EventArgs) Handles BindingNavigatorExit.Click
        If MsgBox("是否要結束本作業？", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2) = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub
#End Region

#Region "介面"

    Private Sub SetButtons()
        Try
            'FStatus:
            ' 0:瀏覽模式
            ' 1:新增模式
            ' 2:修改模式
            BindingNavigatorMoveFirstItem.Enabled = (FTBStatus = 0)
            BindingNavigatorMovePreviousItem.Enabled = (FTBStatus = 0)
            BindingNavigatorMoveNextItem.Enabled = (FTBStatus = 0)
            BindingNavigatorMoveLastItem.Enabled = (FTBStatus = 0)
            BindingNavigatorExit.Enabled = (FTBStatus = 0)
            BindingNavigatorAddNewItem.Enabled = (FTBStatus = 0) 'And (AllowAddNew)
            BindingNavigatorModifyItem.Enabled = (FTBStatus = 0) 'And (FPrimaryID <> "") 'And (FAllowEdit)
            BindingNavigatorDeleteItem.Enabled = (FTBStatus = 0) 'And (FPrimaryID <> "") 'And (FAllowDelete)
            BindingNavigatorSaveItem.Enabled = ((FTBStatus = 1) Or (FTBStatus = 2))
            BindingNavigatorCancelItem.Enabled = ((FTBStatus = 1) Or (FTBStatus = 2))
            BindingNavigatorSearchItem.Enabled = (FTBStatus = 0) And (SearchTextBox.Text <> "")
            SearchTextBox.ReadOnly = (FTBStatus <> 0)
            BindingNavigatorPrintItem.Enabled = (FTBStatus = 0) 'And (FPrimaryID <> String.Empty)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SearchTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SearchTextBox.Validating
        If Me.Text <> "" Then
            SetButtons()
        End If
    End Sub
#End Region

#Region "屬性"
    '取得或設定資料表狀態的屬性
    Public Property TBStatus() As Byte
        Get
            Return FTBStatus
        End Get
        Set(value As Byte)
            FTBStatus = value
        End Set
    End Property

    '取得或設定BindingSource物件的屬性
    Public Property BS() As BindingSource
        Get
            Return FBindingsource
        End Get
        Set(value As BindingSource)
            FBindingsource = value
            BaseBindingNavigator.BindingSource = value
        End Set
    End Property

    '取得或設定主索引鍵值的屬性
    Public Property PrimaryID() As String
        Get
            Return FPrimaryID
        End Get
        Set(value As String)
            FPrimaryID = value
        End Set
    End Property

    '取得或設定被刪除的主索引鍵的值
    Public Property DeleteID() As String
        Get
            Return FDeleteID
        End Get
        Set(value As String)
            FDeleteID = value
        End Set
    End Property

    '取得或設定資料表的名稱
    Public Property TableName() As String
        Get
            Return FTableName
        End Get
        Set(value As String)
            FTableName = value
        End Set
    End Property

    '取得或設定主索引鍵的欄位名稱
    Public Property IDField() As String
        Get
            Return FIDField
        End Get
        Set(value As String)
            FIDField = value
        End Set
    End Property

#End Region

#Region "支援函數"

    Public Overridable Function BeforeAddNew() As Boolean
        '虛擬方法，供繼承者實作，預設值為True
        '按下btnAddNew按鈕新增記錄之前
        Return True
    End Function

    Public Overridable Sub AfterAddNew()
        '虛擬方法，供繼承者實作
        '按下btnAddNew按鈕來新增記錄之後
    End Sub

    Public Overridable Function BeforeEdit() As Boolean
        '虛擬方法，供繼承者實作，預設值為True
        '按下btnEdit按鈕編輯記錄之前
        Return True
    End Function

    Public Overridable Sub AfterEdit()
        '虛擬方法，供繼承者實作
        '按下btnEdit按鈕編輯記錄之後
    End Sub

    Public Overridable Function BeforeEndEdit() As Boolean
        '虛擬方法，供繼承者實作，預設值為true
        '儲存資料之後(執行EndEdit方法之前)
        Return True
    End Function

    Public Overridable Sub AfterEndEdit()
        '虛擬方法，供繼承者實作
        '儲存資料之後(執行EndEdit方法之後)
    End Sub

    Public Overridable Function BeforeCancelEdit() As Boolean
        '虛擬方法，供繼承者實作，預設值為True
        '執行BS物件的CancelEdit方法之前
        If MsgBox("是否放棄存檔？(y/n)", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2) = MsgBoxResult.No Then
            Return False
        End If
        '放棄存檔
        Return True
    End Function

    Public Overridable Sub AfterCancelEdit()
        '虛擬方法，供繼承者實作
        '執行BS物件的CancelEdit()方法之後
    End Sub

    Public Overridable Function BeforeDelete() As Boolean
        '虛擬方法，供繼承者實作，預設值為True
        '刪除記錄前要處理的事情
        Return True
    End Function

    Public Overridable Sub AfterDelete()
        '虛擬方法，供繼承者實作
        '刪除記錄後要處理的事情
    End Sub


    Public Overridable Sub FillData()
        '虛擬方法，供繼承者實作
        '載入資料
    End Sub

    Public Overridable Function UpdateData() As Boolean
        '虛擬方法，供繼承者實作，預設值為True
        '用來執行更新的記錄至資料庫
        Return True
    End Function

    Public Overridable Function DeleteData() As Boolean
        '虛擬方法，供繼承者實作，預設值為True
        '用來執行刪除資料庫記錄
        Return True
    End Function

    Public Overridable Sub SetControls()
        '虛擬方法，供繼承者實作
        '設定所有控制項的ReadOnly或Enabled屬性
    End Sub

    Public Overridable Sub SetDefaultValue()
        '虛擬方法，供繼承者實作
        '設定新增記錄時的預設值，觸發於狀態為新增時
    End Sub

    Public Overridable Sub DoPrint()
        '虛擬方法，供繼承者實作
        '用於執行列印表單的任務
    End Sub

#End Region

End Class

