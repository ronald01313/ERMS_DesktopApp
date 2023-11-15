Public Class dashBoard




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Panel_main.Visible = True
        Panel_events.Visible = False
        Panel_bookings.Visible = False




    End Sub


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_events.Click

        Panel_events.Visible = True





    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_bookings.Click

        Panel_bookings.Visible = True

    End Sub


    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click

    End Sub

    Private Sub btn_main_Click(sender As Object, e As EventArgs) Handles btn_main.Click

        Panel_main.Visible = True
        Panel_bookings.Visible = False
        Panel_events.Visible = False

    End Sub
End Class
