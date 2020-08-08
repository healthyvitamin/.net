<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FmMain
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.進貨資料管理ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.出貨資料管理ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.結束ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.LblUserName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.進貨資料管理ToolStripMenuItem, Me.出貨資料管理ToolStripMenuItem, Me.結束ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(968, 28)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '進貨資料管理ToolStripMenuItem
        '
        Me.進貨資料管理ToolStripMenuItem.Name = "進貨資料管理ToolStripMenuItem"
        Me.進貨資料管理ToolStripMenuItem.Size = New System.Drawing.Size(111, 24)
        Me.進貨資料管理ToolStripMenuItem.Text = "進貨資料管理"
        '
        '出貨資料管理ToolStripMenuItem
        '
        Me.出貨資料管理ToolStripMenuItem.Name = "出貨資料管理ToolStripMenuItem"
        Me.出貨資料管理ToolStripMenuItem.Size = New System.Drawing.Size(111, 24)
        Me.出貨資料管理ToolStripMenuItem.Text = "出貨資料管理"
        '
        '結束ToolStripMenuItem
        '
        Me.結束ToolStripMenuItem.Name = "結束ToolStripMenuItem"
        Me.結束ToolStripMenuItem.Size = New System.Drawing.Size(51, 24)
        Me.結束ToolStripMenuItem.Text = "結束"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LblUserName})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 562)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(968, 24)
        Me.StatusStrip1.TabIndex = 10
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'LblUserName
        '
        Me.LblUserName.Name = "LblUserName"
        Me.LblUserName.Size = New System.Drawing.Size(161, 19)
        Me.LblUserName.Text = "ToolStripStatusLabel1"
        '
        'FmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 586)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FmMain"
        Me.Text = "進銷存管理系統"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 進貨資料管理ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 出貨資料管理ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents 結束ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LblUserName As ToolStripStatusLabel
End Class
