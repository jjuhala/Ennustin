Public Class Form1

    Private Sub tx_i_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tx_i.TextChanged

        Try
            Dim i As Integer = CInt(tx_i.Text)
            lb_i.Items.Add(tx_i.Text)
            predict(CInt(tx_i.Text))
            lb_i.TopIndex = lb_i.Items.Count - 1
            lb_p.TopIndex = lb_p.Items.Count - 1
        Catch ex As Exception

        End Try
        tx_i.Clear()
    End Sub



    Sub predict(ByVal lastval)
        ' Build array

        Dim inputs(9999) As Integer
        Dim predict(9) As Integer

        Dim ci = 0
        Dim addnext = False

        For Each itm As String In lb_i.Items

            If addnext Then
                predict(CInt(itm)) += 1
                addnext = False
            End If
            If (CInt(itm) = lastval) Then
                addnext = True
            End If


            ci += 1
            'inputs(ci) = CInt(itm)

        Next

        lb_p.Items.Add(getmax(predict))


        getresult()

    End Sub
    Sub getresult()
        Dim ok = 0
        Dim fail = 0
        Dim cn = 0
        For Each itm As String In lb_i.Items
            If cn > 9 Then
                If itm = lb_p.Items(cn).ToString Then
                    ok += 1
                Else
                    fail += 1
                End If
            End If
           

            cn += 1
        Next
        lb_perc.Text = (Math.Round(ok / (ok + fail) * 100)).ToString + "%"
    End Sub
    Function getnext(ByVal arr, ByVal cur)

        Dim max = 0
        Dim maxpos = 0
        Dim curpos = 0
        For Each nro In arr
            If nro > max Then
                max = nro
                maxpos = curpos
            End If
            curpos += 1
        Next
        Return maxpos
    End Function
    Function getmax(ByVal arr)
        Dim max = 0
        Dim maxpos = 0
        Dim curpos = 0
        For Each nro In arr
            If nro > max Then
                max = nro
                maxpos = curpos
            End If
            curpos += 1
        Next
        Return maxpos
    End Function
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lb_p.Items.Add("-")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        lb_i.Items.Clear()
        lb_p.Items.Clear()
        lb_perc.Text = "--%"
        lb_p.Items.Add("-")
    End Sub
End Class


