Imports System.Data
Imports System.Data.SqlClient
Public Class PublicFunction
    Public xCompany As String = "勤益資訊有限公司"

    ''' <summary>
    ''' 取得SQLCMD欄位值
    ''' </summary>
    ''' <param name="SQLCMD">SQLCMD</param>
    ''' <param name="INDEX">取第index欄位值</param>
    ''' <returns>回傳欄位值</returns>
    ''' <remarks></remarks>
    Public Function GetKey(ByVal SQLCMD As String, Optional ByRef INDEX As Integer = 0) As String
        Dim CN As New SqlConnection(My.Settings.ORDERConnectionString)
        Dim DR As SqlDataReader
        Dim CMD As SqlCommand
        Try
            GetKey = ""
            CN.Open()
            CMD = New SqlCommand(SQLCMD, CN)
            DR = CMD.ExecuteReader
            If DR.HasRows Then
                DR.Read()
                GetKey = DR(INDEX)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            CN.Close()
        End Try
    End Function


    '經由SQL指令將查詢資料存成DataTable
    ''' <summary>
    ''' 經由SQL指令將查詢資料存成DataTable
    ''' </summary>
    ''' <param name="SQL">SQL指令</param>
    ''' <returns>DataTable</returns>
    ''' <remarks></remarks>
    Public Function GetDataTable(SQL As String) As DataTable
        '建立連接物件
        Dim cn As New SqlConnection(My.Settings.ORDERConnectionString)
        '定義資料表物件
        Dim dt As DataTable
        Try
            '開啟連接物件
            cn.Open()
            '建立新的SqlCommand
            Dim cmd As New SqlCommand(SQL, cn)
            '接收命令物件讀取到的資料
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            '建立新的DataTable
            dt = New DataTable()
            '載入SqlDataReader的資料
            dt.Load(dr)
            '關閉SqlDataReader
            dr.Close()
            '釋放SqlCommand所占用的資源
            cmd.Dispose()
        Finally
            '關閉連接物件
            cn.Close()
        End Try
        '傳回DataTable
        Return dt
    End Function

    '執行SQL指令，並傳回影響筆數
    ''' <summary>
    ''' 執行SQL指令，並傳回影響筆數
    ''' </summary>
    ''' <param name="SQL">SQL指令</param>
    ''' <returns>傳回影響筆數</returns>
    ''' <remarks></remarks>
    Public Function ExecSQL(SQL As String) As Integer
        '定義變數，用來接收更新資料後的影響筆數
        Dim iRowAffected As Integer = 0
        '建立連接物件
        Dim cn As New SqlConnection(My.Settings.ORDERConnectionString)
        Try
            '開啟連接物件
            cn.Open()
            '建立新的SqlCommand
            Dim cmd As New SqlCommand(SQL, cn)
            '執行SQL命令
            iRowAffected = cmd.ExecuteNonQuery()
            '釋放SqlCommand所占用的資源
            cmd.Dispose()
        Finally
            '關閉連接物件
            cn.Close()
        End Try
        '傳回影響筆數
        Return iRowAffected
    End Function

    ''' <summary>
    ''' 依照傳入的 SQL 語法載入資料給 DataTable
    ''' </summary>
    ''' <param name="SQL_String"></param>
    ''' <param name="gTables"></param>
    ''' <remarks>依照傳入的 SQL 語法載入資料給 DataTable</remarks>
    Public Sub ReQuery(ByVal SQL_String As String, ByRef gTables As DataTable)
        Dim TmpCmd As SqlCommand
        Dim TmpAdp As SqlDataAdapter
        Dim cn As New SqlConnection(My.Settings.ORDERConnectionString)
        Try
            cn.Open()
            TmpCmd = New SqlCommand(SQL_String, cn)
            TmpAdp = New SqlDataAdapter(TmpCmd)
            gTables.Clear()

            TmpAdp.Fill(gTables)
        Catch ex As Exception
            '關閉連接物件
            cn.Close()
        End Try

    End Sub



    '多載(Overload) ：
    '　　「多載」必定發生在同一類別(Class)，宣告成多載的函數的參數個數與資料型態不可以完全相同。
    ''' <summary>
    ''' 回傳WHERE條件字串
    ''' </summary>
    ''' <param name="strFieldName">WHERE條件欄位名稱</param>
    ''' <param name="strID1">條件起始值</param>
    ''' <param name="strID2">條件終止值</param>
    ''' <returns>回傳WHERE條件字串</returns>
    ''' <remarks></remarks>
    Function SQLWhere(ByVal strFieldName As String, ByVal strID1 As String, ByVal strID2 As String) As String
        SQLWhere = ""
        If strID1 <> "" And strID2 = "" Then '如果起始值不是空的，終止值是空的 就列印從起始值開始以後的
            SQLWhere = " AND " + strFieldName + " >= '" + strID1 + "' "
        ElseIf strID1 = "" And strID2 <> "" Then '同上 反過來 列印小於終止值的
            SQLWhere = " AND " + strFieldName + " <= '" + strID2 + "' "
        ElseIf strID1 <> "" And strID2 <> "" Then '兩個都有值 則拿取他們之間的
            SQLWhere = " AND " + strFieldName + " >= '" + strID1 + "' AND " + strFieldName + " <= '" + strID2 + "' "

        End If
    End Function


    ''' <summary>
    ''' 回傳WHERE條件字串
    ''' </summary>
    ''' <param name="strFieldName">WHERE條件欄位名稱</param>
    ''' <param name="strID1">條件值</param>
    ''' <returns>回傳WHERE條件字串</returns>
    ''' <remarks></remarks>
    Function SQLWhere(ByVal strFieldName As String, ByVal strID1 As String) As String
        SQLWhere = ""
        If strID1 <> "" Then
            SQLWhere = " AND " + strFieldName + " = '" + strID1 + "' "
        End If
    End Function

    '
    ''' <summary>
    ''' 異動產品庫存量
    ''' </summary>
    ''' <param name="ID">產品編號</param>
    ''' <param name="Qty">異動庫存量</param>
    ''' <remarks></remarks>
    Public Sub StockQty(ID As String, Qty As Integer)
        If ID = "" Or ID = Nothing Then Exit Sub

        '定義影響的資料列數
        Dim rowsAffected As Integer
        'SQL陳述式
        Dim SQL As String
        SQL = String.Format("UPDATE 產品資料 SET 庫存量 = 庫存量 + {0} " +
                            "WHERE 產品編號 = '{1}' ",
                            Qty, ID)
        '執行SQL命令
        rowsAffected = ExecSQL(SQL)
        '檢查影響的資料列數
        If rowsAffected = 0 Then
            '修改失敗，舉發例外
            Dim ex As New Exception("異動庫存量發生不可預期的錯誤！")
            ex.Source = "庫存量"
            Throw ex
        End If
    End Sub

    ''' <summary>
    ''' 設定DataGridView顯示格格與顏色
    ''' </summary>
    ''' <param name="dgv">要設定的DataGridView名稱</param>
    ''' <remarks></remarks>
    Public Sub SetDGV(ByRef dgv As DataGridView)
        With dgv
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(162, 255, 162) 'Color.GreenYellow
            .BackgroundColor = System.Drawing.Color.FromArgb(250, 255, 250)
            .DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(230, 255, 230)
            .ForeColor = Color.DarkBlue
        End With
    End Sub
End Class
