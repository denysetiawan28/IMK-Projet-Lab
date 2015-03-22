Public Class UserControl2
    Public Property labelname() As String
        Get
            labelname = Label1.Text

        End Get
        Set(ByVal value As String)
            Label1.Text = value
        End Set
    End Property
    Public Property labelname2() As String
        Get
            labelname2 = Label2.Text
        End Get
        Set(ByVal value As String)
            Label2.Text = value
        End Set
    End Property

    Public Property labelfont() As System.Drawing.Font
        Get
            labelfont = Label1.Font
        End Get
        Set(ByVal value As System.Drawing.Font)
            Label1.Font = value
        End Set
    End Property

    Public Property labelcolor() As System.Drawing.Color
        Get
            labelcolor = Label1.ForeColor

        End Get
        Set(ByVal value As System.Drawing.Color)
            Label1.ForeColor = value
        End Set
    End Property

    Public Property gantiimage() As System.Drawing.Image
        Get
            gantiimage = PictureBox1.Image
        End Get
        Set(ByVal value As System.Drawing.Image)
            PictureBox1.Image = value
        End Set
    End Property

    Public Property gantiimage2() As System.Drawing.Image
        Get
            gantiimage2 = PictureBox2.Image
        End Get
        Set(ByVal value As System.Drawing.Image)
            PictureBox2.Image = value
        End Set
    End Property


    Private Sub UserControl2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If PictureBox1.Top >= 172 Then
            labelcolor = Color.Red
        ElseIf PictureBox1.Top >= 137 Then
            labelcolor = Color.Aqua
        ElseIf PictureBox1.Top >= 103 Then
            labelcolor = Color.Pink
        ElseIf PictureBox1.Top >= 69 Then
            labelcolor = Color.Blue
        ElseIf PictureBox1.Top >= 35 Then
            labelcolor = Color.Black
        ElseIf PictureBox1.Top >= 1 Then
            labelcolor = Color.Beige
        ElseIf PictureBox1.Top >= -1 Then
            labelcolor = Color.LawnGreen
        ElseIf PictureBox1.Top >= -35 Then
            labelcolor = Color.DarkRed
        ElseIf PictureBox1.Top >= -69 Then
            labelcolor = Color.Chartreuse
        ElseIf PictureBox1.Top >= -103 Then
            labelcolor = Color.Cornsilk
        ElseIf PictureBox1.Top >= -137 Then
            labelcolor = Color.Chocolate
        ElseIf PictureBox1.Top >= -172 Then
            labelcolor = Color.Gold




        End If

        If PictureBox1.Top >= 206 Then
            PictureBox1.Top = -206
        End If
        PictureBox1.Top += 10

        If PictureBox2.Top >= 206 Then
            PictureBox2.Top = -206
        End If
        PictureBox2.Top += 10
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub
End Class
