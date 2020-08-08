Public Class BaseDialog
    '允許關閉對話方塊
    Dim FCanClose As Boolean = False

    '取得或設定是否允許關閉對話方塊
    Public Property CanClose() As Boolean
        Get
            Return FCanClose
        End Get
        Set(value As Boolean)
            FCanClose = value
        End Set
    End Property
    Public Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        DialogResult = DialogResult.OK
    End Sub
    Public Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        FCanClose = True
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub fmBaseDialog_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = Not FCanClose
    End Sub
#Region "按鈕處理事件"
    Private Sub BaseDialog_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
            '取得或設定值，指出按鍵事件是否應該傳遞至基礎控制項。
            '如果按鍵事件不應傳送至控制項，則為 true，否則為 false。
            e.SuppressKeyPress = True
        ElseIf e.KeyCode = Keys.Up Then
            SendKeys.Send("+{TAB}")
            '取得或設定值，指出按鍵事件是否應該傳遞至基礎控制項。
            '如果按鍵事件不應傳送至控制項，則為 true，否則為 false。
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub BaseDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
#End Region
End Class