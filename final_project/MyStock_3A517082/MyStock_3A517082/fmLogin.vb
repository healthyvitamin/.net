Imports System.Data
Imports System.Data.SqlClient
Public Class fmLogin
    '認證次數
    Dim iCheckTimes As Integer
    '建立公用函數類別
    Dim pf As New PublicFunction()

    Private Sub fmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '認證次數預設值為0
        iCheckTimes = 0
        Me.txtUserID.Focus()
    End Sub

    Public Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click



        '宣告引用ADO.NET元件
        Dim CN As New SqlConnection(My.Settings.ORDERConnectionString)
        Dim RD As SqlDataReader
        Dim CMD As SqlCommand
        Dim SQLCMD As String = "SELECT ID, PASSWORD " +
                             "FROM 帳號密碼 " +  '查詢帳號密碼資料庫
                             "WHERE ID = @ID " +
                             "AND Password = @PASSWORD "
        ' MsgBox(SQLCMD)

        Try
            CN.Open()
            CMD = New SqlCommand(SQLCMD, CN)
            '具參數型命令
            CMD.Parameters.AddWithValue("@ID", Me.txtUserID.Text)  '根據輸入的帳號去查詢資料庫ID

            CMD.Parameters.AddWithValue("@PASSWORD", Me.txtPasswordCode.Text)
            RD = CMD.ExecuteReader()
            If RD.HasRows Then  '如果有查詢到 設定FmMain主畫面的各種參數
                RD.Read()
                FmMain.FPowerCheck = True
                FmMain.LblUserName.Text = "使用者:(" + CStr(RD.Item("ID")) + ")" + "系統管理員"
                CanClose = True  'CanClose參數來自於繼承的BaseDialog 當她=true
            Else '沒有則顯示失敗
                FmMain.FPowerCheck = False
                MsgBox("使用者代碼或密碼錯誤!")
                iCheckTimes = iCheckTimes + 1
                If (iCheckTimes = 3) Then
                    MsgBox("認證失敗已達3次，系統將結束！")
                    CanClose = True
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            CN.Close()
        End Try


    End Sub

    Private Sub fmLogin_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        '游標置於帳號欄位上
        Me.txtUserID.Focus()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtUserID.TextChanged

    End Sub
End Class
