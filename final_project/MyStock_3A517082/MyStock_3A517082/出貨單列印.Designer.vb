<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 出貨單列印
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtEID = New System.Windows.Forms.TextBox()
        Me.TxtSID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(94, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "出貨單號"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(273, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "~"
        '
        'TxtEID
        '
        Me.TxtEID.Location = New System.Drawing.Point(294, 121)
        Me.TxtEID.Name = "TxtEID"
        Me.TxtEID.Size = New System.Drawing.Size(100, 25)
        Me.TxtEID.TabIndex = 9
        '
        'TxtSID
        '
        Me.TxtSID.Location = New System.Drawing.Point(167, 121)
        Me.TxtSID.Name = "TxtSID"
        Me.TxtSID.Size = New System.Drawing.Size(100, 25)
        Me.TxtSID.TabIndex = 10
        '
        '出貨單列印
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.ClientSize = New System.Drawing.Size(572, 369)
        Me.Controls.Add(Me.TxtSID)
        Me.Controls.Add(Me.TxtEID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "出貨單列印"
        Me.Text = "出貨單列印"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtEID, 0)
        Me.Controls.SetChildIndex(Me.TxtSID, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtEID As TextBox
    Friend WithEvents TxtSID As TextBox
End Class
