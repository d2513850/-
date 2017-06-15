Public Class frmGhtlag
    Dim s, t As String
    Dim x, y As Integer
    Private Sub txtCnt_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCnt.GotFocus
        txtCnt.ForeColor = Color.FromArgb(0, 0, 0, 0)
    End Sub

    Private Sub txtCnt_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCnt.LostFocus
        If IsNumeric(txtCnt.Text) = False Then
            txtCnt.ForeColor = Color.FromArgb(0, 255, 0, 0)
        ElseIf Val(txtCnt.Text) < 2 Then
            txtCnt.ForeColor = Color.FromArgb(0, 255, 0, 0)
        ElseIf Math.Ceiling(Val(txtCnt.Text)) <> Math.Floor(Val(txtCnt.Text)) Then
            txtCnt.ForeColor = Color.FromArgb(0, 255, 0, 0)
        Else
            txtCnt.ForeColor = Color.FromArgb(0, 0, 0, 0)
        End If
    End Sub

    Private Sub txtTil_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTil.GotFocus
        txtTil.ForeColor = Color.FromArgb(0, 0, 0, 0)
    End Sub

    Private Sub txtTil_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTil.LostFocus
        If IsNumeric(txtTil.Text) = False Then
            txtTil.ForeColor = Color.FromArgb(0, 255, 0, 0)
        ElseIf Val(txtTil.Text) < 1 Then
            txtTil.ForeColor = Color.FromArgb(0, 255, 0, 0)
        ElseIf Math.Ceiling(Val(txtTil.Text)) <> Math.Floor(Val(txtTil.Text)) Then
            txtTil.ForeColor = Color.FromArgb(0, 255, 0, 0)
        Else
            txtTil.ForeColor = Color.FromArgb(0, 0, 0, 0)
        End If
    End Sub
    Private Sub btnOutput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOutput.Click
        s = ""
        t = ""
        txtRes.Text = ""
        Randomize()
        If IsNumeric(txtCnt.Text) = False Then
            txtRes.Text = "參與人數必須是正整數"
        ElseIf IsNumeric(txtTil.Text) = False Then
            txtRes.Text = "階數必須是正整數"
        ElseIf IsNumeric(txtCvp.Text) = False Then
            txtRes.Text = "轉彎機率必須是實數"
        ElseIf Val(txtCvp.Text) < 0 Or Val(txtCvp.Text) > 1 Then
            txtRes.Text = "轉彎機率不得小於0或大於1"
        ElseIf Val(txtTil.Text) < 1 Then
            txtRes.Text = "階數不得小於1"
        ElseIf Math.Ceiling(Val(txtTil.Text)) <> Math.Floor(Val(txtTil.Text)) Then
            txtRes.Text = "階數必須是正整數"
        Else
            If cmbDict.Text = "上下" Then
                For y = 1 To Val(txtTil.Text)
                    s = ""
                    If Rnd() < Val(txtCvp.Text) Then
                        s = "├"
                    Else
                        s = "│"
                    End If
                    If Val(txtCnt.Text) < 2 Then
                        s = ""
                        txtRes.Text = "參與人數不得小於2"
                    ElseIf Math.Ceiling(Val(txtCnt.Text)) <> Math.Floor(Val(txtCnt.Text)) Then
                        txtRes.Text = "參與人數必須是正整數"
                    Else
                        For x = 2 To Val(txtCnt.Text) - 1
                            If Microsoft.VisualBasic.Right(s, 1) = "├" Then
                                s &= "┤"
                            Else
                                If Rnd() < Val(txtCvp.Text) Then
                                    s &= "├"
                                Else
                                    s &= "│"
                                End If
                            End If
                        Next x
                        If Microsoft.VisualBasic.Right(s, 1) = "├" Then
                            s &= "┤"
                        Else
                            s &= "│"
                        End If
                        txtRes.Text &= s & vbNewLine
                    End If
                Next y
            ElseIf cmbDict.Text = "左右" Then
                s = ""
                If Val(txtCnt.Text) < 2 Then
                    txtRes.Text = "參與人數不得小於2"
                ElseIf Math.Ceiling(Val(txtCnt.Text)) <> Math.Floor(Val(txtCnt.Text)) Then
                    txtRes.Text = "參與人數必須是正整數"
                Else
                    For y = 1 To Val(txtTil.Text)
                        If Rnd() < Val(txtCvp.Text) Then
                            s &= "┬"
                        Else
                            s &= "─"
                        End If
                    Next y
                    txtRes.Text = s & vbNewLine
                    For x = 2 To Val(txtCnt.Text) - 1
                        t = ""
                        For y = 1 To Val(txtTil.Text)
                            If Mid(s, y, 1) = "┬" Then
                                t &= "┴"
                            Else
                                If Rnd() < Val(txtCvp.Text) Then
                                    t &= "┬"
                                Else
                                    t &= "─"
                                End If
                            End If
                        Next y
                        txtRes.Text &= t & vbNewLine
                        s = t
                    Next x
                    t = ""
                    For y = 1 To Val(txtTil.Text)
                        If Mid(s, y, 1) = "┬" Then
                            t &= "┴"
                        Else
                            t &= "─"
                        End If
                    Next y
                    txtRes.Text &= t & vbNewLine
                End If
                Else
                    txtRes.Text = "請決定鬼腳圖的方向"
                End If
        End If
    End Sub

    Private Sub txtCvp_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCvp.GotFocus
        txtCvp.ForeColor = Color.FromArgb(0, 0, 0, 0)
    End Sub

    Private Sub txtCvp_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCvp.LostFocus
        If IsNumeric(txtCvp.Text) = False Then
            txtCvp.ForeColor = Color.FromArgb(0, 255, 0, 0)
        ElseIf Val(txtCvp.Text) < 0 Or Val(txtCvp.Text) > 1 Then
            txtCvp.ForeColor = Color.FromArgb(0, 255, 0, 0)
        Else
            txtCvp.ForeColor = Color.FromArgb(0, 0, 0, 0)
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
