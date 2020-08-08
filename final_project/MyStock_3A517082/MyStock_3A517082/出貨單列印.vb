Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class 出貨單列印


    Dim FCanClose As Boolean = False





    Dim pf As New PublicFunction
    Dim ds As New DataSet
    Private Sub 出貨單列印_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        DialogResult = DialogResult.OK
        ds.Tables.Add(New DataTable)
        '注意要與Crystal Reports 所建立的資料表名稱一致
        ds.Tables(0).TableName = "DataTable1"
        Dim SQLCMD As String

        'SQLCMD = "SELECT 客戶編號, 公司名稱, 連絡人, 地址, 電話, 傳真電話,地址 FROM 客戶 WHERE 客戶編號 IS NOT NULL "
        'SQLCMD += pf.SQLWhere("客戶編號", TxtSID.Text, TxtEID.Text)
        'SQLCMD += " ORDER BY 客戶編號"

        SQLCMD = " SELECT  出貨主檔.出貨單號, 出貨主檔.客戶編號, 出貨主檔.連絡人, 出貨主檔.出貨別, 出貨主檔.總計金額, 出貨主檔.營業稅, 
                   出貨主檔.銷售金額, 出貨主檔.出貨地址, 出貨主檔.出貨日期, 出貨明細.項次, 出貨明細.產品編號, 出貨明細.數量, 
                   出貨明細.單價, 出貨明細.小計, 產品資料.產品, 出貨主檔.發票號碼 
FROM      出貨主檔 INNER JOIN
                   出貨明細 ON 出貨主檔.出貨單號 = 出貨明細.出貨單號 INNER JOIN
                   客戶 ON 出貨主檔.客戶編號 = 客戶.客戶編號 INNER JOIN
                   產品資料 ON 出貨明細.產品編號 = 產品資料.產品編號 "

        SQLCMD += pf.SQLWhere("出貨主檔.出貨單號", TxtSID.Text, TxtEID.Text)
        SQLCMD += " Order By 出貨主檔.出貨單號 "
        '  MsgBox(SQLCMD)
        '   MsgBox(SQLCMD)
        '執行SQLCMD命令;將資料載入ds.Tables("命令")
        pf.ReQuery(SQLCMD, ds.Tables("DataTable1"))

        '宣告Rpt為"客戶資料明細表" ReportClass
        Dim Rpt As ReportClass = New 出貨單
        '指定 Rpt 所用的 DataSource
        Rpt.SetDataSource(ds)

        '實作ReportPreview
        Dim RptForm As New reportpreview
        '傳送Company參數給報表
        Rpt.SetParameterValue("Company", pf.xCompany)
        '   Rpt.SetParameterValue("客戶編號", "123")
        '指定ReportSource=客戶資料明細表
        RptForm.CrystalReportViewer1.ReportSource = Rpt
        '最大畫面
        RptForm.WindowState = FormWindowState.Maximized
        '顯示
        RptForm.Show()


    End Sub

    Public Property CanClose() As Boolean
        Get
            Return FCanClose
        End Get
        Set(value As Boolean)
            FCanClose = value
        End Set
    End Property


    Public Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        FCanClose = True
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub fmBaseDialog_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = Not FCanClose
    End Sub



End Class