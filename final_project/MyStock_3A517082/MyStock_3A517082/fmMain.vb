Imports System.Windows.Forms

Public Class FmMain
    Dim pf As New PublicFunction
    '是否已經通過認證
    Public FPowerCheck As Boolean = False

    Private Sub FmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblUserName.Text = ""
        '檢查使用者代碼資料表是否有ADMIN的使用者
        SyncAdminUsers()

        '開啟認證登入表單對話方塊
        Dim frmLogin As New fmLogin()
        frmLogin.ShowDialog()
        '如果未通過認證，就結束系統
        If (Not FPowerCheck) Then
            Close()
        End If

    End Sub

    Private Sub 出貨資料管理AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 出貨資料管理ToolStripMenuItem.Click
        OpenForm(New 出貨資料管理)
    End Sub
    Private Sub 進貨資料管理AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 進貨資料管理ToolStripMenuItem.Click
        OpenForm(New 進貨資料管理)
    End Sub


    Private Sub 結束0ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 結束ToolStripMenuItem.Click
        If MsgBox("是否結束本系統?(y/n)", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation) = MsgBoxResult.Yes Then
            End
        End If
    End Sub

#Region "自訂函數"

    ''' <summary>
    ''' 檢查使用者代碼資料表是否有ADMIN的使用者
    ''' </summary>
    ''' <remarks>若是ADMIN的使用者且無使用者資料時;則新增使用者資料與帳號密碼(default:ID='ADMIN';PASSWORD='ADMIN')</remarks>
    Private Sub SyncAdminUsers()
        '檢查使用者代碼資料表是否有ADMIN的使用者
        Dim dt As DataTable
        dt = pf.GetDataTable("SELECT ID " +
                             "FROM 帳號密碼 " +
                             "WHERE ID = 'ADMIN' ")
        If dt.Rows.Count = 0 Then
            '新增ADMIN使用者''系統管理員'
            pf.ExecSQL("INSERT INTO 員工 " +
                      "(員工編號, 姓名) " +
                      "VALUES " +
                      "('ADMIN','系統管理員') ")
            pf.ExecSQL("INSERT INTO 帳號密碼 " +
                       "(ID, Password) " +
                       "VALUES " +
                       "('ADMIN','ADMIN') ")
        End If
    End Sub

    ''' <summary>
    ''' 顯示執行表單
    ''' </summary>
    ''' <param name="mForm">要執行表單的名稱</param>
    ''' <remarks></remarks>
    Private Sub OpenForm(ByVal mForm As Form)
        For Each fm In My.Application.OpenForms
            If fm.name = mForm.Name Then
                fm.focus()
                fm.windowstate = FormWindowState.Normal
                Exit Sub
            End If
        Next
        mForm.Show()
        mForm.MdiParent = Me
        mForm.TopMost = True
        mForm.StartPosition = FormStartPosition.CenterParent
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
#End Region

End Class