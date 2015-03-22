Public Class Galery

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub payment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load




    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        If TreeView1.SelectedNode.Text = "Donut" Then
            PictureBox1.Image = ImageList1.Images(0)
            TextBox1.Text = "-"
            Label2.Text = "-"

        ElseIf TreeView1.SelectedNode.Text = "Chocolate Blend Donut" Then
            PictureBox1.Image = ImageList1.Images(0)
            TextBox1.Text = "Chocolate Blend Donut"
            Label2.Text = "Rp. 12.000,00"

        ElseIf TreeView1.SelectedNode.Text = "Chocolate Freeze Donut" Then
            PictureBox1.Image = ImageList1.Images(1)
            TextBox1.Text = "Chocolate Freeze Donut"
            Label2.Text = "Rp. 12.000,00"

        ElseIf TreeView1.SelectedNode.Text = "Half glow Donut" Then
            PictureBox1.Image = ImageList1.Images(2)
            TextBox1.Text = "Half Glow Donut"
            Label2.Text = "Rp. 12.000,00"

        ElseIf TreeView1.SelectedNode.Text = "Holiday Donut" Then
            PictureBox1.Image = ImageList1.Images(3)
            TextBox1.Text = "Holiday Donut"
            Label2.Text = "Rp. 12.000,00"

        ElseIf TreeView1.SelectedNode.Text = "Love Donut" Then
            PictureBox1.Image = ImageList1.Images(4)
            TextBox1.Text = "Love Donut"
            Label2.Text = "Rp. 12.000,00"

        ElseIf TreeView1.SelectedNode.Text = "Pink Frost Donut" Then
            PictureBox1.Image = ImageList1.Images(5)
            TextBox1.Text = "Pink Frost Donut"
            Label2.Text = "Rp. 12.000,00"

        ElseIf TreeView1.SelectedNode.Text = "Pink Sprinkled Donut" Then
            PictureBox1.Image = ImageList1.Images(6)
            TextBox1.Text = "Pink Sprinkled Donut"
            Label2.Text = "Rp. 12.000,00"


        End If

        If TreeView1.SelectedNode.Text = "Drink" Then
            PictureBox1.Image = ImageList1.Images(7)
            TextBox1.Text = "-"
            Label2.Text = "-"

        ElseIf TreeView1.SelectedNode.Text = "Frozen Caramel" Then
            PictureBox1.Image = ImageList1.Images(7)
            TextBox1.Text = "Frozen Caramel Coffe"
            Label2.Text = "Rp. 15.000,00"

        ElseIf TreeView1.SelectedNode.Text = "Frozen Coffe" Then
            PictureBox1.Image = ImageList1.Images(8)
            TextBox1.Text = "Frozen Coffe"
            Label2.Text = "Rp. 15.000,00"

        ElseIf TreeView1.SelectedNode.Text = "Frozen Mocha Freeze" Then
            PictureBox1.Image = ImageList1.Images(9)
            TextBox1.Text = "Frozen Mocha Freeze"
            Label2.Text = "Rp. 15.000,00"

        ElseIf TreeView1.SelectedNode.Text = "Hot Chocolate Dark" Then
            PictureBox1.Image = ImageList1.Images(10)
            TextBox1.Text = "Hot Chocolate Dark"
            Label2.Text = "Rp. 13.000,00"

        ElseIf TreeView1.SelectedNode.Text = "Hot Chocolate Mint" Then
            PictureBox1.Image = ImageList1.Images(11)
            TextBox1.Text = "Hot Chocolate Mint"
            Label2.Text = "Rp. 13.000,00"

        ElseIf TreeView1.SelectedNode.Text = "Hot Chocolate" Then
            PictureBox1.Image = ImageList1.Images(12)
            TextBox1.Text = "Hot Chocolate"
            Label2.Text = "Rp. 13.000,00"

        ElseIf TreeView1.SelectedNode.Text = "Ice Tea Original" Then
            PictureBox1.Image = ImageList1.Images(13)
            TextBox1.Text = "Ice Tea Original"
            Label2.Text = "Rp. 10.000,00"


        End If
    End Sub
End Class