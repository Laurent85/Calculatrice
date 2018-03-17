Public Class Calculatrice

    Dim op As String
    Dim a As Double
    Dim b As Integer
    Dim M1 As Double
    Dim M2 As Double
    Dim M3 As Double

    Private Sub Bouton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bouton1.Click
        If b = 0 Then
            Ecran.Text = Ecran.Text & 1
        Else : b = 0
            Ecran.Text = ""
            Ecran.Text = Ecran.Text & 1
        End If
        Ecran2.Text = Ecran2.Text & 1
    End Sub

    Private Sub Bouton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bouton2.Click
        If b = 0 Then
            Ecran.Text = Ecran.Text & 2
        Else : b = 0
            Ecran.Text = ""
            Ecran.Text = Ecran.Text & 2
        End If
        Ecran2.Text = Ecran2.Text & 2
    End Sub

    Private Sub Bouton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bouton3.Click
        If b = 0 Then
            Ecran.Text = Ecran.Text & 3
        Else : b = 0
            Ecran.Text = ""
            Ecran.Text = Ecran.Text & 3
        End If
        Ecran2.Text = Ecran2.Text & 3
    End Sub

    Private Sub Bouton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bouton4.Click
        If b = 0 Then
            Ecran.Text = Ecran.Text & 4
        Else : b = 0
            Ecran.Text = ""
            Ecran.Text = Ecran.Text & 4
        End If
        Ecran2.Text = Ecran2.Text & 4
    End Sub

    Private Sub Bouton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bouton5.Click
        If b = 0 Then
            Ecran.Text = Ecran.Text & 5
        Else : b = 0
            Ecran.Text = ""
            Ecran.Text = Ecran.Text & 5
        End If
        Ecran2.Text = Ecran2.Text & 5
    End Sub

    Private Sub Bouton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bouton6.Click
        If b = 0 Then
            Ecran.Text = Ecran.Text & 6
        Else : b = 0
            Ecran.Text = ""
            Ecran.Text = Ecran.Text & 6
        End If
        Ecran2.Text = Ecran2.Text & 6
    End Sub

    Private Sub Bouton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bouton7.Click
        If b = 0 Then
            Ecran.Text = Ecran.Text & 7
        Else : b = 0
            Ecran.Text = ""
            Ecran.Text = Ecran.Text & 7
        End If
        Ecran2.Text = Ecran2.Text & 7
    End Sub

    Private Sub Bouton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bouton8.Click
        If b = 0 Then
            Ecran.Text = Ecran.Text & 8
        Else : b = 0
            Ecran.Text = ""
            Ecran.Text = Ecran.Text & 8
        End If
        Ecran2.Text = Ecran2.Text & 8
    End Sub

    Private Sub Bouton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bouton9.Click
        If b = 0 Then
            Ecran.Text = Ecran.Text & 9
        Else : b = 0
            Ecran.Text = ""
            Ecran.Text = Ecran.Text & 9
        End If
        Ecran2.Text = Ecran2.Text & 9
    End Sub

    Private Sub Bouton0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bouton0.Click
        If b = 0 Then
            Ecran.Text = Ecran.Text & 0
        Else : b = 0
            Ecran.Text = ""
            Ecran.Text = Ecran.Text & 0
        End If
        Ecran2.Text = Ecran2.Text & 0
    End Sub

    Private Sub Point_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Point.Click
        Ecran.Text = Ecran.Text & ","
        Ecran2.Text = Ecran2.Text & ","
    End Sub

    Private Sub Plus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Plus.Click
        Select Case op
            Case "+"
                a = a + Ecran.Text
                b = 1
                Ecran.Text = a
            Case "-"
                a = a - Ecran.Text
                b = 1
                Ecran.Text = a
            Case "*"
                a = a * Ecran.Text
                b = 1
                Ecran.Text = a
            Case "/"
                a = a / Ecran.Text
                b = 1
                Ecran.Text = a
            Case "^"
                a = a ^ Ecran.Text
                b = 1
                Ecran.Text = a
            Case "^10"
                a = a * (10 ^ Ecran.Text)
                b = 1
                Ecran.Text = a
            Case Else
                b = 1
                a = Ecran.Text
        End Select
        op = "+"
        Ecran2.Text = Ecran2.Text & "+"
    End Sub

    Private Sub Moins_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Moins.Click
        Select Case op
            Case "+"
                a = a + Ecran.Text
                b = 1
                Ecran.Text = a
            Case "-"
                a = a - Ecran.Text
                b = 1
                Ecran.Text = a
            Case "*"
                a = a * Ecran.Text
                b = 1
                Ecran.Text = a
            Case "/"
                a = a / Ecran.Text
                b = 1
                Ecran.Text = a
            Case "^"
                a = a ^ Ecran.Text
                b = 1
                Ecran.Text = a
            Case "^10"
                a = a * (10 ^ Ecran.Text)
                b = 1
                Ecran.Text = a
            Case Else
                b = 1
                a = Ecran.Text
        End Select
        op = "-"
        Ecran2.Text = Ecran2.Text & "-"
    End Sub

    Private Sub Multiplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Multiplier.Click
        Select Case op
            Case "+"
                a = a + Ecran.Text
                b = 1
                Ecran.Text = a
            Case "-"
                a = a - Ecran.Text
                b = 1
                Ecran.Text = a
            Case "*"
                a = a * Ecran.Text
                b = 1
                Ecran.Text = a
            Case "/"
                a = a / Ecran.Text
                b = 1
                Ecran.Text = a
            Case "^"
                a = a ^ Ecran.Text
                b = 1
                Ecran.Text = a
            Case "^10"
                a = a * (10 ^ Ecran.Text)
                b = 1
                Ecran.Text = a
            Case Else
                b = 1
                a = Ecran.Text
        End Select
        op = "*"
        Ecran2.Text = Ecran2.Text & "x"
    End Sub

    Private Sub Diviser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Diviser.Click
        Select Case op
            Case "+"
                a = a + Ecran.Text
                b = 1
                Ecran.Text = a
            Case "-"
                a = a - Ecran.Text
                b = 1
                Ecran.Text = a
            Case "*"
                a = a * Ecran.Text
                b = 1
                Ecran.Text = a
            Case "/"
                a = a / Ecran.Text
                b = 1
                Ecran.Text = a
            Case "^"
                a = a ^ Ecran.Text
                b = 1
                Ecran.Text = a
            Case "^10"
                a = a * (10 ^ Ecran.Text)
                b = 1
                Ecran.Text = a
            Case Else
                b = 1
                a = Ecran.Text
        End Select
        op = "/"
        Ecran2.Text = Ecran2.Text & "/"
    End Sub

    Private Sub Egal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Egal.Click
        Select op
            Case "+"
                a = a + Ecran.Text
                b = 1
                Ecran.Text = a
            Case "-"
                a = a - Ecran.Text
                b = 1
                Ecran.Text = a
            Case "*"
                a = a * Ecran.Text
                b = 1
                Ecran.Text = a
            Case "/"
                a = a / Ecran.Text
                b = 1
                Ecran.Text = a
            Case "^"
                a = a ^ Ecran.Text
                b = 1
                Ecran.Text = a
            Case "^10"
                a = a * (10 ^ Ecran.Text)
                b = 1
                Ecran.Text = a
            Case Else
                b = 1
                a = Ecran.Text
        End Select
        op = ""
        Ecran2.Text = Ecran2.Text
    End Sub

    Private Sub Puissance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Puissance.Click
        Select Case op
            Case "+"
                a = a + Ecran.Text
                b = 1
                Ecran.Text = a
            Case "-"
                a = a - Ecran.Text
                b = 1
                Ecran.Text = a
            Case "*"
                a = a * Ecran.Text
                b = 1
                Ecran.Text = a
            Case "/"
                a = a / Ecran.Text
                b = 1
                Ecran.Text = a
            Case "^"
                a = a ^ Ecran.Text
                b = 1
                Ecran.Text = a
            Case "^10"
                a = a * (10 ^ Ecran.Text)
                b = 1
                Ecran.Text = a
            Case Else
                b = 1
                a = Ecran.Text
        End Select
        op = "^"
        Ecran2.Text = Ecran2.Text & "^"
    End Sub

    Private Sub puissance10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles puissance10.Click
        Select Case op
            Case "+"
                a = a + Ecran.Text
                b = 1
                Ecran.Text = a
            Case "-"
                a = a - Ecran.Text
                b = 1
                Ecran.Text = a
            Case "*"
                a = a * Ecran.Text
                b = 1
                Ecran.Text = a
            Case "/"
                a = a / Ecran.Text
                b = 1
                Ecran.Text = a
            Case "^"
                a = a ^ Ecran.Text
                b = 1
                Ecran.Text = a
            Case "^10"
                a = a * (10 ^ Ecran.Text)
                b = 1
                Ecran.Text = a
            Case Else
                b = 1
                a = Ecran.Text
        End Select
        op = "^10"
        Ecran2.Text = Ecran2.Text & "x10^"
    End Sub

    Private Sub Pourcent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pourcent.Click
        Select Case op
            Case "+"
                a = a + (a * Ecran.Text / 100)
                b = 1
                Ecran.Text = a
            Case "-"
                a = a - (a * Ecran.Text / 100)
                b = 1
                Ecran.Text = a
            Case "*"
                a = a * (a * Ecran.Text / 100)
                b = 1
                Ecran.Text = a
            Case "/"
                a = a / (a * Ecran.Text / 100)
                b = 1
                Ecran.Text = a
            Case "^"
                a = a ^ Ecran.Text
                b = 1
                Ecran.Text = a
            Case "^10"
                a = a * (10 ^ Ecran.Text)
                b = 1
                Ecran.Text = a
            Case Else
                b = 1
                a = Ecran.Text
        End Select
        op = ""
        Ecran2.Text = Ecran2.Text & "%"
    End Sub

    Private Sub DelEcran_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelEcran.Click
        Ecran.Text = ""
        Ecran2.Text = ""
        a = 0
        op = ""
        Me.ActiveControl = Ecran
    End Sub

    Private Sub Pi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pi.Click
        Ecran.Text = Math.PI
        Ecran2.Text = Ecran2.Text & "∏"
    End Sub

    Private Sub carré_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles carré.Click
        Ecran.Text = (Ecran.Text) ^ 2
        Ecran2.Text = Ecran2.Text & "²"
    End Sub

    Private Sub Racine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Racine.Click
        Ecran.Text = Math.Sqrt(Ecran.Text)
        Ecran2.Text = "√" & Ecran2.Text
    End Sub

    Private Sub Sinus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sinus.Click
        Ecran.Text = Math.Sin(Ecran.Text)
        Ecran2.Text = "Sin " & Ecran2.Text
    End Sub

    Private Sub Cosinus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cosinus.Click
        Ecran.Text = Math.Cos(Ecran.Text)
        Ecran2.Text = "Cos " & Ecran2.Text
    End Sub

    Private Sub Inverse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Inverse.Click
        Ecran.Text = 1 / (Ecran.Text)
        Ecran2.Text = "1/" & Ecran2.Text
    End Sub

    Private Sub Tangeante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tangeante.Click
        Ecran.Text = Math.Tan(Ecran.Text)
        Ecran2.Text = "Tan " & Ecran2.Text
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Ecran.Text = Math.Log10(Ecran.Text)
        Ecran2.Text = "Log " & Ecran2.Text
    End Sub

    Private Sub ln_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ln.Click
        Ecran.Text = Math.Log(Ecran.Text)
        Ecran2.Text = "Ln " & Ecran2.Text
    End Sub

    Private Sub Sin_inv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sin_inv.Click
        Ecran.Text = Math.Asin(Ecran.Text)
        Ecran2.Text = "Asin " & Ecran2.Text
    End Sub

    Private Sub Cos_inv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cos_inv.Click
        Ecran.Text = Math.Acos(Ecran.Text)
        Ecran2.Text = "Acos " & Ecran2.Text
    End Sub

    Private Sub Tan_inv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tan_inv.Click
        Ecran.Text = Math.Atan(Ecran.Text)
        Ecran2.Text = "Atan " & Ecran2.Text
    End Sub

    Private Sub Cube_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cube.Click
        Ecran.Text = (Ecran.Text) ^ 3
        Ecran2.Text = Ecran2.Text & "^3"
    End Sub

    Private Sub Retour_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Retour.Click
        Ecran.Text = Mid(Ecran.Text, 1, Len(Ecran.Text) - 1)
        Ecran2.Text = Mid(Ecran2.Text, 1, Len(Ecran2.Text) - 1)
    End Sub

    Private Sub Mem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mem1.Click
        M1 = Ecran.Text
        EcranM1.Text = M1
    End Sub

    Private Sub MemReceive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M1Receive.Click
        Ecran.Text = M1
        Ecran2.Text = Ecran2.Text & M1
    End Sub

    Private Sub MemClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M1Clear.Click
        M1 = 0
        EcranM1.Text = ""
    End Sub

    Private Sub Mem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mem2.Click
        M2 = Ecran.Text
        EcranM2.Text = M2
    End Sub

    Private Sub M2Receive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M2Receive.Click
        Ecran.Text = M2
        Ecran2.Text = Ecran2.Text & M2
    End Sub

    Private Sub M2Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M2Clear.Click
        M2 = 0
        EcranM2.Text = ""
    End Sub

    Private Sub Mem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mem3.Click
        M3 = Ecran.Text
        EcranM3.Text = M3
    End Sub

    Private Sub M3Receive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M3Receive.Click
        Ecran.Text = M3
        Ecran2.Text = Ecran2.Text & M3
    End Sub

    Private Sub M3Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M3Clear.Click
        M3 = 0
        EcranM3.Text = ""
    End Sub

    Private Sub plusmoins_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles plusmoins.Click
        If b = 0 Then
            Ecran.Text = Ecran.Text & "-"
        Else : b = 0
            Ecran.Text = ""
            Ecran.Text = Ecran.Text & "-"
        End If
        Ecran2.Text = Ecran2.Text & "-"
    End Sub

    Private Sub EcranM1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EcranM1.TextChanged
        If M1 <> 0 Then
            EcranM1.BackColor = Color.LightGreen
        Else
            EcranM1.BackColor = Color.LightBlue
        End If
    End Sub

    Private Sub EcranM2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EcranM2.TextChanged
        If M2 <> 0 Then
            EcranM2.BackColor = Color.LightGreen
        Else
            EcranM2.BackColor = Color.LightBlue
        End If
    End Sub

    Private Sub EcranM3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EcranM3.TextChanged
        If M3 <> 0 Then
            EcranM3.BackColor = Color.LightGreen
        Else
            EcranM3.BackColor = Color.LightBlue
        End If
    End Sub

End Class
