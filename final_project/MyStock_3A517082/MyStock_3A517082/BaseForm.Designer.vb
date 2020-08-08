<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BaseForm
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BaseForm))
        Me.BaseBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorModifyItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorPrintItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCancelItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSearchItem = New System.Windows.Forms.ToolStripButton()
        Me.SearchTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorExit = New System.Windows.Forms.ToolStripButton()
        CType(Me.BaseBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BaseBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'BaseBindingNavigator
        '
        Me.BaseBindingNavigator.AddNewItem = Nothing
        Me.BaseBindingNavigator.CountItem = Nothing
        Me.BaseBindingNavigator.DeleteItem = Nothing
        Me.BaseBindingNavigator.ImageScalingSize = New System.Drawing.Size(50, 50)
        Me.BaseBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.ToolStripSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorModifyItem, Me.BindingNavigatorDeleteItem, Me.BindingNavigatorPrintItem, Me.BindingNavigatorCancelItem, Me.BindingNavigatorSaveItem, Me.BindingNavigatorSearchItem, Me.SearchTextBox, Me.BindingNavigatorExit})
        Me.BaseBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BaseBindingNavigator.MoveFirstItem = Nothing
        Me.BaseBindingNavigator.MoveLastItem = Nothing
        Me.BaseBindingNavigator.MoveNextItem = Nothing
        Me.BaseBindingNavigator.MovePreviousItem = Nothing
        Me.BaseBindingNavigator.Name = "BaseBindingNavigator"
        Me.BaseBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.BaseBindingNavigator.PositionItem = Nothing
        Me.BaseBindingNavigator.Size = New System.Drawing.Size(800, 57)
        Me.BaseBindingNavigator.TabIndex = 4
        Me.BaseBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(52, 54)
        Me.BindingNavigatorMoveFirstItem.Text = "移到最前面"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(52, 54)
        Me.BindingNavigatorMovePreviousItem.Text = "移到上一個"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 57)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(52, 54)
        Me.BindingNavigatorMoveNextItem.Text = "移到下一個"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(52, 54)
        Me.BindingNavigatorMoveLastItem.Text = "移到最後面"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 57)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(52, 54)
        Me.BindingNavigatorAddNewItem.Text = "新增"
        '
        'BindingNavigatorModifyItem
        '
        Me.BindingNavigatorModifyItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorModifyItem.Image = CType(resources.GetObject("BindingNavigatorModifyItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorModifyItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BindingNavigatorModifyItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BindingNavigatorModifyItem.Name = "BindingNavigatorModifyItem"
        Me.BindingNavigatorModifyItem.Size = New System.Drawing.Size(52, 54)
        Me.BindingNavigatorModifyItem.Text = "修改"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(52, 54)
        Me.BindingNavigatorDeleteItem.Text = "刪除"
        '
        'BindingNavigatorPrintItem
        '
        Me.BindingNavigatorPrintItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorPrintItem.Image = CType(resources.GetObject("BindingNavigatorPrintItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorPrintItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BindingNavigatorPrintItem.Name = "BindingNavigatorPrintItem"
        Me.BindingNavigatorPrintItem.Size = New System.Drawing.Size(54, 54)
        Me.BindingNavigatorPrintItem.Text = "列印"
        '
        'BindingNavigatorCancelItem
        '
        Me.BindingNavigatorCancelItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorCancelItem.Image = CType(resources.GetObject("BindingNavigatorCancelItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorCancelItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BindingNavigatorCancelItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BindingNavigatorCancelItem.Name = "BindingNavigatorCancelItem"
        Me.BindingNavigatorCancelItem.Size = New System.Drawing.Size(52, 54)
        Me.BindingNavigatorCancelItem.Text = "放棄儲存"
        '
        'BindingNavigatorSaveItem
        '
        Me.BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorSaveItem.Image = CType(resources.GetObject("BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorSaveItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BindingNavigatorSaveItem.Name = "BindingNavigatorSaveItem"
        Me.BindingNavigatorSaveItem.Size = New System.Drawing.Size(52, 54)
        Me.BindingNavigatorSaveItem.Text = "儲存"
        '
        'BindingNavigatorSearchItem
        '
        Me.BindingNavigatorSearchItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorSearchItem.Image = CType(resources.GetObject("BindingNavigatorSearchItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorSearchItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BindingNavigatorSearchItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BindingNavigatorSearchItem.Name = "BindingNavigatorSearchItem"
        Me.BindingNavigatorSearchItem.Size = New System.Drawing.Size(52, 54)
        Me.BindingNavigatorSearchItem.Text = "搜尋"
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(100, 57)
        '
        'BindingNavigatorExit
        '
        Me.BindingNavigatorExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorExit.Image = CType(resources.GetObject("BindingNavigatorExit.Image"), System.Drawing.Image)
        Me.BindingNavigatorExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BindingNavigatorExit.Name = "BindingNavigatorExit"
        Me.BindingNavigatorExit.Size = New System.Drawing.Size(54, 54)
        Me.BindingNavigatorExit.Text = "結束"
        '
        'BaseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BaseBindingNavigator)
        Me.Name = "BaseForm"
        Me.Text = "BaseForm"
        CType(Me.BaseBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BaseBindingNavigator.ResumeLayout(False)
        Me.BaseBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BaseBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorModifyItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorPrintItem As ToolStripButton
    Friend WithEvents BindingNavigatorCancelItem As ToolStripButton
    Friend WithEvents BindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents BindingNavigatorSearchItem As ToolStripButton
    Friend WithEvents SearchTextBox As ToolStripTextBox
    Friend WithEvents BindingNavigatorExit As ToolStripButton
End Class
