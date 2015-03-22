Public Class MDIForm

    Public Sub isenable()
        LogOutToolStripMenuItem.Enabled = True
        LogInStripMenuItem1.Enabled = False
        TransactionToolStripMenuItem.Visible = True
        MasterToolStripMenuItem.Visible = True
        GaleryToolStripMenuItem.Visible = True
        AboutUsToolStripMenuItem.Visible = True


    End Sub

    Public Sub isdisable()
        LogOutToolStripMenuItem.Enabled = False
        LogInStripMenuItem1.Enabled = True
        TransactionToolStripMenuItem.Visible = False
        MasterToolStripMenuItem.Visible = False
        GaleryToolStripMenuItem.Visible = False
        AboutUsToolStripMenuItem.Visible = False
    End Sub

    Private Sub PaymentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Galery.MdiParent = Me
        Galery.Show()

    End Sub

    Private Sub RerservationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        reservation.MdiParent = Me
        reservation.Show()
    End Sub

    Private Sub MDIForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        isdisable()
        If Form1.TextBoxUser.Text <> "admin" Or Form1.TextBoxPassword.Text <> "admin" Then
            isdisable()
        Else
            isenable()
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GaleryToolStripMenuItem.Click
        Galery.MdiParent = Me
        Galery.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogInStripMenuItem1.Click
        If Form1.cancel = False Then
            isdisable()

        End If

        Form1.Show()
        Me.Close()


    End Sub

    Private Sub TransactionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasterToolStripMenuItem.Click
        donutanddrink.MdiParent = Me
        donutanddrink.Show()

    End Sub

    Private Sub MasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransactionToolStripMenuItem.Click
        Buydonuanddrink.MdiParent = Me
        Buydonuanddrink.Show()
    End Sub

    Private Sub AboutUsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutUsToolStripMenuItem.Click
        AboutUs.MdiParent = Me
        AboutUs.Show()
    End Sub

    Private Sub FileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub LogOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem.Click
        isdisable()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class