Public Class Form1


    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Right Or e.KeyCode = Keys.D Then
            move(car, 20, 0)
        End If

        If e.KeyCode = Keys.Left Or e.KeyCode = Keys.A Then
            move(car, -20, 0)
        End If

        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.W Then
            move(car, 0, -20)
        End If

        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.S Then
            move(car, 0, 20)
        End If
        car.Refresh()
        If car.Bounds.IntersectsWith(henny.Bounds) Then
            henny.Visible = False
        End If
    End Sub

    Sub move(p As PictureBox, xdir As Integer, ydir As Integer)
        p.Location += New Point(xdir, ydir)
    End Sub

    Sub follow(e As PictureBox, a As PictureBox, speed As Integer)
        If e.Location.Y < a.Location.Y Then
            move(e, 0, speed)
        Else
            move(e, 0, -speed)
        End If
        If e.Location.X < a.Location.X Then
            move(e, speed, 0)
        Else
            move(e, -speed, 0)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        follow(cop, car, 5)
        follow(cop2, car, 10)

    End Sub

End Class
