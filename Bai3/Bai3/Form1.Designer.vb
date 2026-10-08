<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        splitContainer1 = New SplitContainer()
        inputGroupBox = New GroupBox()
        clearAllButton = New Button()
        deleteButton = New Button()
        updateButton = New Button()
        addButton = New Button()
        priceTextBox = New TextBox()
        priceLabel = New Label()
        unitComboBox = New ComboBox()
        unitLabel = New Label()
        nameTextBox = New TextBox()
        nameLabel = New Label()
        codeTextBox = New TextBox()
        codeLabel = New Label()
        listGroupBox = New GroupBox()
        materialListView = New ListView()
        codeColumnHeader = New ColumnHeader()
        nameColumnHeader = New ColumnHeader()
        unitColumnHeader = New ColumnHeader()
        priceColumnHeader = New ColumnHeader()
        CType(splitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        splitContainer1.Panel1.SuspendLayout()
        splitContainer1.Panel2.SuspendLayout()
        splitContainer1.SuspendLayout()
        inputGroupBox.SuspendLayout()
        listGroupBox.SuspendLayout()
        SuspendLayout()
        ' 
        ' splitContainer1
        ' 
        splitContainer1.Dock = DockStyle.Fill
        splitContainer1.FixedPanel = FixedPanel.Panel1
        splitContainer1.Location = New Point(0, 0)
        splitContainer1.Name = "splitContainer1"
        ' 
        ' splitContainer1.Panel1
        ' 
        splitContainer1.Panel1.Controls.Add(inputGroupBox)
        splitContainer1.Panel1MinSize = 310
        ' 
        ' splitContainer1.Panel2
        ' 
        splitContainer1.Panel2.Controls.Add(listGroupBox)
        splitContainer1.Panel2MinSize = 400
        splitContainer1.Size = New Size(1084, 611)
        splitContainer1.SplitterDistance = 330
        splitContainer1.TabIndex = 0
        ' 
        ' inputGroupBox
        ' 
        inputGroupBox.Controls.Add(clearAllButton)
        inputGroupBox.Controls.Add(deleteButton)
        inputGroupBox.Controls.Add(updateButton)
        inputGroupBox.Controls.Add(addButton)
        inputGroupBox.Controls.Add(priceTextBox)
        inputGroupBox.Controls.Add(priceLabel)
        inputGroupBox.Controls.Add(unitComboBox)
        inputGroupBox.Controls.Add(unitLabel)
        inputGroupBox.Controls.Add(nameTextBox)
        inputGroupBox.Controls.Add(nameLabel)
        inputGroupBox.Controls.Add(codeTextBox)
        inputGroupBox.Controls.Add(codeLabel)
        inputGroupBox.Dock = DockStyle.Fill
        inputGroupBox.Location = New Point(0, 0)
        inputGroupBox.Name = "inputGroupBox"
        inputGroupBox.Padding = New Padding(10)
        inputGroupBox.Size = New Size(330, 611)
        inputGroupBox.TabIndex = 0
        inputGroupBox.TabStop = False
        inputGroupBox.Text = "Thông tin vật tư"
        ' 
        ' clearAllButton
        ' 
        clearAllButton.Location = New Point(165, 439)
        clearAllButton.Name = "clearAllButton"
        clearAllButton.Size = New Size(145, 38)
        clearAllButton.TabIndex = 11
        clearAllButton.Text = "Xóa toàn bộ"
        clearAllButton.UseVisualStyleBackColor = True
        ' 
        ' deleteButton
        ' 
        deleteButton.Location = New Point(13, 439)
        deleteButton.Name = "deleteButton"
        deleteButton.Size = New Size(145, 38)
        deleteButton.TabIndex = 10
        deleteButton.Text = "Xóa dòng"
        deleteButton.UseVisualStyleBackColor = True
        ' 
        ' updateButton
        ' 
        updateButton.Location = New Point(165, 388)
        updateButton.Name = "updateButton"
        updateButton.Size = New Size(145, 38)
        updateButton.TabIndex = 9
        updateButton.Text = "Cập nhật"
        updateButton.UseVisualStyleBackColor = True
        ' 
        ' addButton
        ' 
        addButton.Location = New Point(13, 388)
        addButton.Name = "addButton"
        addButton.Size = New Size(145, 38)
        addButton.TabIndex = 8
        addButton.Text = "Thêm mới"
        addButton.UseVisualStyleBackColor = True
        ' 
        ' priceTextBox
        ' 
        priceTextBox.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        priceTextBox.Location = New Point(15, 327)
        priceTextBox.Name = "priceTextBox"
        priceTextBox.Size = New Size(285, 39)
        priceTextBox.TabIndex = 7
        ' 
        ' priceLabel
        ' 
        priceLabel.AutoSize = True
        priceLabel.Location = New Point(12, 292)
        priceLabel.Name = "priceLabel"
        priceLabel.Size = New Size(159, 32)
        priceLabel.TabIndex = 6
        priceLabel.Text = "Đơn giá nhập"
        ' 
        ' unitComboBox
        ' 
        unitComboBox.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        unitComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        unitComboBox.FormattingEnabled = True
        unitComboBox.Items.AddRange(New Object() {"Cái", "Bộ", "Kg", "Mết"})
        unitComboBox.Location = New Point(15, 238)
        unitComboBox.Name = "unitComboBox"
        unitComboBox.Size = New Size(285, 40)
        unitComboBox.TabIndex = 5
        ' 
        ' unitLabel
        ' 
        unitLabel.AutoSize = True
        unitLabel.Location = New Point(12, 203)
        unitLabel.Name = "unitLabel"
        unitLabel.Size = New Size(133, 32)
        unitLabel.TabIndex = 4
        unitLabel.Text = "Đơn vị tính"
        ' 
        ' nameTextBox
        ' 
        nameTextBox.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        nameTextBox.Location = New Point(15, 148)
        nameTextBox.Name = "nameTextBox"
        nameTextBox.Size = New Size(285, 39)
        nameTextBox.TabIndex = 3
        ' 
        ' nameLabel
        ' 
        nameLabel.AutoSize = True
        nameLabel.Location = New Point(13, 113)
        nameLabel.Name = "nameLabel"
        nameLabel.Size = New Size(120, 32)
        nameLabel.TabIndex = 2
        nameLabel.Text = "Tên vật tư"
        ' 
        ' codeTextBox
        ' 
        codeTextBox.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        codeTextBox.Location = New Point(15, 63)
        codeTextBox.Name = "codeTextBox"
        codeTextBox.Size = New Size(285, 39)
        codeTextBox.TabIndex = 1
        ' 
        ' codeLabel
        ' 
        codeLabel.AutoSize = True
        codeLabel.Location = New Point(15, 30)
        codeLabel.Name = "codeLabel"
        codeLabel.Size = New Size(116, 32)
        codeLabel.TabIndex = 0
        codeLabel.Text = "Mã vật tư"
        ' 
        ' listGroupBox
        ' 
        listGroupBox.Controls.Add(materialListView)
        listGroupBox.Dock = DockStyle.Fill
        listGroupBox.Location = New Point(0, 0)
        listGroupBox.Name = "listGroupBox"
        listGroupBox.Padding = New Padding(10)
        listGroupBox.Size = New Size(750, 611)
        listGroupBox.TabIndex = 0
        listGroupBox.TabStop = False
        listGroupBox.Text = "Danh sách vật tư"
        ' 
        ' materialListView
        ' 
        materialListView.Columns.AddRange(New ColumnHeader() {codeColumnHeader, nameColumnHeader, unitColumnHeader, priceColumnHeader})
        materialListView.Dock = DockStyle.Fill
        materialListView.FullRowSelect = True
        materialListView.GridLines = True
        materialListView.Location = New Point(10, 42)
        materialListView.MultiSelect = False
        materialListView.Name = "materialListView"
        materialListView.Size = New Size(730, 559)
        materialListView.TabIndex = 0
        materialListView.UseCompatibleStateImageBehavior = False
        materialListView.View = View.Details
        ' 
        ' codeColumnHeader
        ' 
        codeColumnHeader.Text = "Mã VT"
        codeColumnHeader.Width = 100
        ' 
        ' nameColumnHeader
        ' 
        nameColumnHeader.Text = "Tên VT"
        nameColumnHeader.Width = 260
        ' 
        ' unitColumnHeader
        ' 
        unitColumnHeader.Text = "Đơn vị tính"
        unitColumnHeader.Width = 130
        ' 
        ' priceColumnHeader
        ' 
        priceColumnHeader.Text = "Đơn giá"
        priceColumnHeader.TextAlign = HorizontalAlignment.Right
        priceColumnHeader.Width = 140
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13.0F, 32.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1084, 611)
        Controls.Add(splitContainer1)
        MinimumSize = New Size(850, 500)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Quản lý danh mục Vật tư / Linh kiện"
        splitContainer1.Panel1.ResumeLayout(False)
        splitContainer1.Panel2.ResumeLayout(False)
        CType(splitContainer1, ComponentModel.ISupportInitialize).EndInit()
        splitContainer1.ResumeLayout(False)
        inputGroupBox.ResumeLayout(False)
        inputGroupBox.PerformLayout()
        listGroupBox.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents splitContainer1 As SplitContainer
    Friend WithEvents inputGroupBox As GroupBox
    Friend WithEvents codeLabel As Label
    Friend WithEvents nameLabel As Label
    Friend WithEvents unitLabel As Label
    Friend WithEvents priceLabel As Label
    Friend WithEvents codeTextBox As TextBox
    Friend WithEvents nameTextBox As TextBox
    Friend WithEvents unitComboBox As ComboBox
    Friend WithEvents priceTextBox As TextBox
    Friend WithEvents addButton As Button
    Friend WithEvents updateButton As Button
    Friend WithEvents deleteButton As Button
    Friend WithEvents clearAllButton As Button
    Friend WithEvents listGroupBox As GroupBox
    Friend WithEvents materialListView As ListView
    Friend WithEvents codeColumnHeader As ColumnHeader
    Friend WithEvents nameColumnHeader As ColumnHeader
    Friend WithEvents unitColumnHeader As ColumnHeader
    Friend WithEvents priceColumnHeader As ColumnHeader

End Class
