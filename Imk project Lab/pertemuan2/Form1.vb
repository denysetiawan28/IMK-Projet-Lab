Public Class Form1

    Public Declare Function CreateRectRgn Lib "gdi32" Alias "CreateRectRgn" (ByVal X1 As Integer, ByVal Y1 As Integer, ByVal X2 As Integer, ByVal Y2 As Integer) As Integer
    Public Declare Function CreateRoundRectRgn Lib "gdi32" Alias "CreateRoundRectRgn" (ByVal X1 As Integer, ByVal Y1 As Integer, ByVal X2 As Integer, ByVal Y2 As Integer, ByVal X3 As Integer, ByVal Y3 As Integer) As Integer
    Public Declare Function CreateEllipticRgn Lib "gdi32" Alias "CreateEllipticRgn" (ByVal X1 As Integer, ByVal Y1 As Integer, ByVal X2 As Integer, ByVal Y2 As Integer) As Integer
    Public Declare Function CreatePolygonRgn Lib "gdi32" Alias "CreatePolygonRgn" (ByRef lpPoint As Koordinat, ByVal nCount As Integer, ByVal nPolyFillMode As Integer) As Integer
    Public Declare Function CombineRgn Lib "gdi32" Alias "CombineRgn" (ByVal hDestRgn As Integer, ByVal hSrcRgn1 As Integer, ByVal hSrcRgn2 As Integer, ByVal nCombineMode As Integer) As Integer
    Public Declare Function SetWindowRgn Lib "user32" Alias "SetWindowRgn" (ByVal hWnd As Integer, ByVal hRgn As Integer, ByVal bRedraw As Boolean) As Integer
    Public Declare Function DeleteObject Lib "gdi32" Alias "DeleteObject" (ByVal hObject As Integer) As Integer


    Public Structure Koordinat
        Dim x As Integer
        Dim y As Integer
    End Structure

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
    Public cancel As Boolean
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLogin.Click
        If TextBoxUser.Text = "" Then
            MessageBox.Show("Username Must Be Filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf TextBoxPassword.Text = "" Then
            MessageBox.Show("Password Must Be Filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If TextBoxUser.Text <> "admin" Or TextBoxPassword.Text <> "admin" Then
                MessageBox.Show("Invalid Username / Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
                MessageBox.Show("Log In Success", "Log In", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                MDIForm.Show()
                Me.Close()
            End If

        End If


    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim bulat = CreateEllipticRgn(30, 30, 550, 550)
        Dim bulat2 = CreateEllipticRgn(120, 120, 460, 460)
        CombineRgn(bulat, bulat, bulat2, 3)

        Dim roundrect2 = CreateRoundRectRgn(160, 180, 360, 380, 60, 60)
        CombineRgn(bulat, bulat, roundrect2, 3)

        Dim bulat3 = CreateEllipticRgn(250, 210, 420, 380)
        CombineRgn(bulat, bulat, bulat3, 2)

        Dim bulat4 = CreateEllipticRgn(290, 250, 370, 340)
        CombineRgn(bulat, bulat, bulat4, 3)
        SetWindowRgn(Me.Handle, bulat, True)
    End Sub

    Private Sub ButtonCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancel.Click
        cancel = False
        MDIForm.Show()
        Me.Close()
    End Sub
End Class
