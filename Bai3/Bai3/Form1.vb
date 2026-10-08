Public Class Form1

    Private NotInheritable Class MaterialItem
        Public Property Code As String
        Public Property Name As String
        Public Property Unit As String
        Public Property Price As Decimal
    End Class

    Private ReadOnly materials As New List(Of MaterialItem)()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetEditingState(False)
    End Sub

    Private Sub AddMaterial(sender As Object, e As EventArgs) Handles addButton.Click
        Dim code = codeTextBox.Text.Trim()
        If String.IsNullOrWhiteSpace(code) OrElse String.IsNullOrWhiteSpace(nameTextBox.Text.Trim()) OrElse unitComboBox.SelectedIndex < 0 Then
            MessageBox.Show("Vui lòng nhập đầy đủ mã, tên và đơn vị tính.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If materials.Any(Function(material) String.Equals(material.Code, code, StringComparison.OrdinalIgnoreCase)) Then
            MessageBox.Show("Mã vật tư đã tồn tại.", "Mã bị trùng", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            codeTextBox.Focus()
            Return
        End If

        Dim price As Decimal
        If Not TryGetPrice(price) Then Return

        materials.Add(New MaterialItem With {
            .Code = code,
            .Name = nameTextBox.Text.Trim(),
            .Unit = CStr(unitComboBox.SelectedItem),
            .Price = price
        })
        RefreshMaterialList()
        ClearInputs()
    End Sub

    Private Sub UpdateMaterial(sender As Object, e As EventArgs) Handles updateButton.Click
        If materialListView.SelectedIndices.Count = 0 Then Return

        Dim selectedIndex = materialListView.SelectedIndices(0)
        Dim code = codeTextBox.Text.Trim()
        If String.IsNullOrWhiteSpace(code) OrElse String.IsNullOrWhiteSpace(nameTextBox.Text.Trim()) OrElse unitComboBox.SelectedIndex < 0 Then
            MessageBox.Show("Vui lòng nhập đầy đủ mã, tên và đơn vị tính.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If materials.Where(Function(material, index) index <> selectedIndex).Any(Function(material) String.Equals(material.Code, code, StringComparison.OrdinalIgnoreCase)) Then
            MessageBox.Show("Mã vật tư đã tồn tại.", "Mã bị trùng", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            codeTextBox.Focus()
            Return
        End If

        Dim price As Decimal
        If Not TryGetPrice(price) Then Return

        materials(selectedIndex).Code = code
        materials(selectedIndex).Name = nameTextBox.Text.Trim()
        materials(selectedIndex).Unit = CStr(unitComboBox.SelectedItem)
        materials(selectedIndex).Price = price
        RefreshMaterialList()
        ClearInputs()
    End Sub

    Private Sub DeleteMaterial(sender As Object, e As EventArgs) Handles deleteButton.Click
        If materialListView.SelectedIndices.Count = 0 Then
            MessageBox.Show("Vui lòng chọn vật tư cần xóa.", "Chưa chọn dòng", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If MessageBox.Show("Bạn có chắc chắn muốn xóa dòng đang chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return

        materials.RemoveAt(materialListView.SelectedIndices(0))
        RefreshMaterialList()
        ClearInputs()
    End Sub

    Private Sub ClearAllMaterials(sender As Object, e As EventArgs) Handles clearAllButton.Click
        If materials.Count = 0 Then Return
        If MessageBox.Show("Bạn có chắc chắn muốn xóa toàn bộ danh sách?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return

        materials.Clear()
        RefreshMaterialList()
        ClearInputs()
    End Sub

    Private Sub MaterialSelectionChanged(sender As Object, e As EventArgs) Handles materialListView.SelectedIndexChanged
        If materialListView.SelectedIndices.Count = 0 Then
            SetEditingState(False)
            Return
        End If

        Dim material = materials(materialListView.SelectedIndices(0))
        codeTextBox.Text = material.Code
        nameTextBox.Text = material.Name
        unitComboBox.SelectedItem = material.Unit
        priceTextBox.Text = material.Price.ToString("0.##")
        SetEditingState(True)
    End Sub

    Private Function TryGetPrice(ByRef price As Decimal) As Boolean
        If Decimal.TryParse(priceTextBox.Text.Trim(), price) AndAlso price >= 0D Then Return True

        MessageBox.Show("Đơn giá phải là số không âm.", "Đơn giá không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        priceTextBox.Focus()
        Return False
    End Function

    Private Sub RefreshMaterialList()
        materialListView.BeginUpdate()
        materialListView.Items.Clear()
        For Each material In materials
            Dim row As New ListViewItem(material.Code)
            row.SubItems.Add(material.Name)
            row.SubItems.Add(material.Unit)
            row.SubItems.Add(material.Price.ToString("N0"))
            materialListView.Items.Add(row)
        Next
        materialListView.EndUpdate()
    End Sub

    Private Sub ClearInputs()
        materialListView.SelectedItems.Clear()
        codeTextBox.Clear()
        nameTextBox.Clear()
        unitComboBox.SelectedIndex = -1
        priceTextBox.Clear()
        SetEditingState(False)
        codeTextBox.Focus()
    End Sub

    Private Sub SetEditingState(isEditing As Boolean)
        addButton.Enabled = Not isEditing
        updateButton.Enabled = isEditing
        deleteButton.Enabled = isEditing
    End Sub

    Private Sub priceLabel_Click(sender As Object, e As EventArgs) Handles priceLabel.Click

    End Sub

    Private Sub inputGroupBox_Enter(sender As Object, e As EventArgs) Handles inputGroupBox.Enter

    End Sub
End Class
