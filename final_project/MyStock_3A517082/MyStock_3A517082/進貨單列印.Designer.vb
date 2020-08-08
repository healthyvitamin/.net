<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 進貨單列印
    Inherits MyStock_3A517082.BaseDialog

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
        Me.TxtSID = New System.Windows.Forms.TextBox()
        Me.TxtEID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtSID
        '
        Me.TxtSID.Location = New System.Drawing.Point(190, 157)
        Me.TxtSID.Name = "TxtSID"
        Me.TxtSID.Size = New System.Drawing.Size(100, 25)
        Me.TxtSID.TabIndex = 14
        '
        'TxtEID
        '
        Me.TxtEID.Location = New System.Drawing.Point(317, 157)
        Me.TxtEID.Name = "TxtEID"
        Me.TxtEID.Size = New System.Drawing.Size(100, 25)
        Me.TxtEID.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(296, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 15)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "~"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(117, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "進貨單號"
        '
        '進貨單列印
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.ClientSize = New System.Drawing.Size(572, 369)
        Me.Controls.Add(Me.TxtSID)
        Me.Controls.Add(Me.TxtEID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "進貨單列印"
        Me.Text = "進貨單列印"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtEID, 0)
        Me.Controls.SetChildIndex(Me.TxtSID, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtSID As TextBox
    Friend WithEvents TxtEID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
