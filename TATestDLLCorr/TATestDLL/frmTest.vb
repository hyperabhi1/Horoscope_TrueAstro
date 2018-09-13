Public Class frmTest

    Private Sub frmTest_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        cmbSgn.SelectedIndex = 0
        FillStar()
        cmbStl.SelectedIndex = 0
        cmbSub.SelectedIndex = 0
        cmbSSL.SelectedIndex = 0
        cmbSuk.SelectedIndex = 0
        cmbPra.SelectedIndex = 0
        cmbsPra.SelectedIndex = 0
        cmbSSP.SelectedIndex = 0
    End Sub

    Private Sub FillStar()
        cmbStl.Items.Clear()
        If cmbSgn.Text = "Ari" Or cmbSgn.Text = "Leo" Or cmbSgn.Text = "Sag" Then
            cmbStl.Items.AddRange({"Ke", "Ve", "Su"})
        ElseIf cmbSgn.Text = "Tau" Or cmbSgn.Text = "Vir" Or cmbSgn.Text = "Cap" Then
            cmbStl.Items.AddRange({"Su", "Mo", "Ma"})
        ElseIf cmbSgn.Text = "Gem" Or cmbSgn.Text = "Lib" Or cmbSgn.Text = "Aqu" Then
            cmbStl.Items.AddRange({"Ma", "Ra", "Ju"})
        ElseIf cmbSgn.Text = "Can" Or cmbSgn.Text = "Sco" Or cmbSgn.Text = "Pis" Then
            cmbStl.Items.AddRange({"Ju", "Sa", "Me"})
        End If
    End Sub

    Private Sub cmbSgn_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cmbSgn.SelectedIndexChanged
        FillStar()
    End Sub

    Private Function getDasaIndexByName(ByVal dName As String) As Integer
        If dName = "Su" Then
            getDasaIndexByName = 2
        ElseIf dName = "Mo" Then
            getDasaIndexByName = 3
        ElseIf dName = "Ma" Then
            getDasaIndexByName = 4
        ElseIf dName = "Ra" Then
            getDasaIndexByName = 5
        ElseIf dName = "Ju" Then
            getDasaIndexByName = 6
        ElseIf dName = "Sa" Then
            getDasaIndexByName = 7
        ElseIf dName = "Me" Then
            getDasaIndexByName = 8
        ElseIf dName = "Ke" Then
            getDasaIndexByName = 0
        ElseIf dName = "Ve" Then
            getDasaIndexByName = 1
        Else
            Return 9
        End If
    End Function

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim StartDeg As Double = getNakNo() * 172800000
        Dim Nak_dur As Double = 172800000
        Dim STL_Index = getDasaIndexByName(cmbStl.Text)
        Dim sub_dur, SSL_Dur, Suk_Dur, Pra_Dur, sPra_Dur, SSP_Dur As Double
        Dim sub_Index, SSL_Index, Suk_Index, Pra_Index, sPra_Index, SSP_Index As Integer
        sub_Index = getDasaIndexByName(cmbSub.Text)
        SSL_Index = getDasaIndexByName(cmbSSL.Text)
        Suk_Index = getDasaIndexByName(cmbSuk.Text)
        Pra_Index = getDasaIndexByName(cmbPra.Text)
        sPra_Index = getDasaIndexByName(cmbsPra.Text)
        SSP_Index = getDasaIndexByName(cmbSSP.Text)
        Dim sli As Integer = sub_Index - STL_Index
        If sli < 0 Then sli += 9
        For i As Integer = 0 To sli
            Dim K As Integer = i + STL_Index
            If K > 8 Then
                K -= 9
            End If
            StartDeg += sub_dur
            sub_dur = Nak_dur * getDasaDur(K) / 120
        Next
        Dim ssli As Integer = SSL_Index - sub_Index
        If ssli < 0 Then ssli += 9
        For i As Integer = 0 To ssli
            Dim K As Integer = i + sub_Index
            If K > 8 Then
                K -= 9
            End If
            StartDeg += SSL_Dur
            SSL_Dur = sub_dur * getDasaDur(K) / 120
        Next
        Dim Suki As Integer = Suk_Index - SSL_Index
        If Suki < 0 Then Suki += 9
        For i As Integer = 0 To Suki
            Dim K As Integer = i + SSL_Index
            If K > 8 Then
                K -= 9
            End If
            StartDeg += Suk_Dur
            Suk_Dur = SSL_Dur * getDasaDur(K) / 120
        Next
        Dim Prai As Integer = Pra_Index - Suk_Index
        If Prai < 0 Then Prai += 9
        For i As Integer = 0 To Prai
            Dim K As Integer = i + Suk_Index
            If K > 8 Then
                K -= 9
            End If
            StartDeg += Pra_Dur
            Pra_Dur = Suk_Dur * getDasaDur(K) / 120
        Next
        Dim sPrai As Integer = sPra_Index - Pra_Index
        If sPrai < 0 Then sPrai += 9
        For i As Integer = 0 To sPrai
            Dim K As Integer = i + Pra_Index
            If K > 8 Then
                K -= 9
            End If
            StartDeg += sPra_Dur
            sPra_Dur = Pra_Dur * getDasaDur(K) / 120
        Next
        Dim ssPi As Integer = SSP_Index - sPra_Index
        If ssPi < 0 Then ssPi += 9
        For i As Integer = 0 To ssPi
            Dim K As Integer = i + sPra_Index
            If K > 8 Then
                K -= 9
            End If
            StartDeg += SSP_Dur
            SSP_Dur = sPra_Dur * getDasaDur(K) / 120
        Next
        Label1.Text = StartDeg / 12960000
    End Sub

    Private Function getDasaDur(ByVal pl As Integer) As Integer
        Dim Dur As Integer
        Dim dasadur() As Integer = New Integer() {7, 20, 6, 10, 7, 18, 16, 19, 17}
        Dur = dasadur(pl)
        Return Dur
    End Function

    Private Function getNakNo() As Double
        Dim i As Integer
        If cmbSgn.SelectedIndex = 0 Then
            If cmbStl.SelectedIndex = 0 Then
                i = 0
            ElseIf cmbStl.SelectedIndex = 1 Then
                i = 1
            ElseIf cmbStl.SelectedIndex = 2 Then
                i = 2
            End If
        ElseIf cmbSgn.SelectedIndex = 1 Then
            If cmbStl.SelectedIndex = 0 Then
                i = 2
            ElseIf cmbStl.SelectedIndex = 1 Then
                i = 3
            ElseIf cmbStl.SelectedIndex = 2 Then
                i = 4
            End If
        ElseIf cmbSgn.SelectedIndex = 2 Then
            If cmbStl.SelectedIndex = 0 Then
                i = 4
            ElseIf cmbStl.SelectedIndex = 1 Then
                i = 5
            ElseIf cmbStl.SelectedIndex = 2 Then
                i = 6
            End If
        ElseIf cmbSgn.SelectedIndex = 3 Then
            If cmbStl.SelectedIndex = 0 Then
                i = 6
            ElseIf cmbStl.SelectedIndex = 1 Then
                i = 7
            ElseIf cmbStl.SelectedIndex = 2 Then
                i = 8
            End If
        ElseIf cmbSgn.SelectedIndex = 4 Then
            If cmbStl.SelectedIndex = 0 Then
                i = 9
            ElseIf cmbStl.SelectedIndex = 1 Then
                i = 10
            ElseIf cmbStl.SelectedIndex = 2 Then
                i = 11
            End If
        ElseIf cmbSgn.SelectedIndex = 5 Then
            If cmbStl.SelectedIndex = 0 Then
                i = 11
            ElseIf cmbStl.SelectedIndex = 1 Then
                i = 12
            ElseIf cmbStl.SelectedIndex = 2 Then
                i = 13
            End If
        ElseIf cmbSgn.SelectedIndex = 6 Then
            If cmbStl.SelectedIndex = 0 Then
                i = 13
            ElseIf cmbStl.SelectedIndex = 1 Then
                i = 14
            ElseIf cmbStl.SelectedIndex = 2 Then
                i = 15
            End If
        ElseIf cmbSgn.SelectedIndex = 7 Then
            If cmbStl.SelectedIndex = 0 Then
                i = 15
            ElseIf cmbStl.SelectedIndex = 1 Then
                i = 16
            ElseIf cmbStl.SelectedIndex = 2 Then
                i = 17
            End If
        ElseIf cmbSgn.SelectedIndex = 8 Then
            If cmbStl.SelectedIndex = 0 Then
                i = 18
            ElseIf cmbStl.SelectedIndex = 1 Then
                i = 19
            ElseIf cmbStl.SelectedIndex = 2 Then
                i = 20
            End If
        ElseIf cmbSgn.SelectedIndex = 9 Then
            If cmbStl.SelectedIndex = 0 Then
                i = 20
            ElseIf cmbStl.SelectedIndex = 1 Then
                i = 21
            ElseIf cmbStl.SelectedIndex = 2 Then
                i = 22
            End If
        ElseIf cmbSgn.SelectedIndex = 10 Then
            If cmbStl.SelectedIndex = 0 Then
                i = 22
            ElseIf cmbStl.SelectedIndex = 1 Then
                i = 23
            ElseIf cmbStl.SelectedIndex = 2 Then
                i = 24
            End If
        ElseIf cmbSgn.SelectedIndex = 11 Then
            If cmbStl.SelectedIndex = 0 Then
                i = 24
            ElseIf cmbStl.SelectedIndex = 1 Then
                i = 25
            ElseIf cmbStl.SelectedIndex = 2 Then
                i = 26
            End If
        End If
        Return i
    End Function
End Class