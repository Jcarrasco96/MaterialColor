Public Class FormMain

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btn10.Click, btn11.Click, btn12.Click, btn13.Click, btn14.Click, btn15.Click, btn16.Click, btn17.Click, btn18.Click, btn19.Click, btn20.Click, btn21.Click, btn22.Click, btn23.Click, btn24.Click, btn25.Click, btn26.Click, btn27.Click, btn28.Click, btn29.Click, btn30.Click, btn31.Click, btn32.Click, btn33.Click, btn34.Click, btn35.Click, btn36.Click, btn37.Click, btn38.Click, btn39.Click, btn40.Click, btn41.Click, btn42.Click, btn43.Click, btn44.Click, btn45.Click, btn46.Click, btn47.Click, btn48.Click, btn49.Click, btn50.Click, btn51.Click, btn52.Click, btn53.Click, btn54.Click, btn55.Click, btn56.Click, btn57.Click, btn58.Click, btn59.Click, btn60.Click, btn61.Click, btn62.Click, btn63.Click, btn64.Click, btn65.Click, btn66.Click, btn67.Click, btn68.Click, btn69.Click, btn70.Click, btn71.Click, btn72.Click, btn73.Click, btn74.Click, btn75.Click, btn76.Click, btn77.Click, btn78.Click, btn79.Click, btn80.Click, btn81.Click, btn82.Click, btn83.Click, btn84.Click, btn85.Click, btn86.Click, btn87.Click, btn88.Click, btn89.Click, btn90.Click, btn91.Click, btn92.Click, btn93.Click, btn94.Click, btn95.Click, btn96.Click, btn97.Click, btn98.Click, btn99.Click, btn100.Click, btn101.Click, btn102.Click, btn103.Click, btn104.Click, btn105.Click, btn106.Click, btn107.Click, btn108.Click, btn109.Click, btn110.Click, btn111.Click, btn112.Click, btn113.Click, btn114.Click, btn115.Click, btn116.Click, btn117.Click, btn118.Click, btn119.Click, btn120.Click, btn121.Click, btn122.Click, btn123.Click, btn124.Click, btn125.Click, btn126.Click, btn127.Click, btn128.Click, btn129.Click, btn130.Click, btn131.Click, btn132.Click, btn133.Click, btn134.Click, btn135.Click, btn136.Click, btn137.Click, btn138.Click, btn139.Click, btn140.Click, btn141.Click, btn142.Click, btn143.Click, btn144.Click, btn145.Click, btn146.Click, btn147.Click, btn148.Click, btn149.Click, btn150.Click, btn151.Click, btn152.Click, btn153.Click, btn154.Click, btn155.Click, btn156.Click, btn157.Click, btn158.Click, btn159.Click, btn160.Click, btn161.Click, btn162.Click, btn163.Click, btn164.Click, btn165.Click, btn166.Click, btn167.Click, btn168.Click, btn169.Click, btn170.Click, btn171.Click, btn172.Click, btn173.Click, btn174.Click, btn175.Click, btn176.Click, btn177.Click, btn178.Click, btn179.Click, btn180.Click, btn181.Click, btn182.Click, btn183.Click, btn184.Click, btn185.Click, btn186.Click, btn187.Click, btn188.Click, btn189.Click, btn190.Click, btn191.Click, btn192.Click, btn193.Click, btn194.Click, btn195.Click, btn196.Click, btn197.Click, btn198.Click, btn199.Click, btn200.Click, btn201.Click, btn202.Click, btn203.Click, btn204.Click, btn205.Click, btn206.Click, btn207.Click, btn208.Click, btn209.Click, btn210.Click, btn211.Click, btn212.Click, btn213.Click, btn214.Click, btn215.Click, btn216.Click, btn217.Click, btn218.Click, btn219.Click, btn220.Click, btn221.Click, btn222.Click, btn223.Click, btn224.Click, btn225.Click, btn226.Click, btn227.Click, btn228.Click, btn229.Click, btn230.Click, btn231.Click, btn232.Click, btn233.Click, btn234.Click, btn235.Click, btn236.Click, btn237.Click, btn238.Click, btn239.Click, btn240.Click, btn241.Click, btn242.Click, btn243.Click, btn244.Click, btn245.Click, btn246.Click, btn247.Click, btn248.Click, btn249.Click, btn250.Click, btn251.Click, btn252.Click, btn253.Click, btn254.Click, btn255.Click, btn256.Click, btn257.Click, btn258.Click, btn259.Click, btn260.Click, btn261.Click, btn262.Click, btn263.Click, btn264.Click, btn265.Click
        Dim obj As Button = sender

        GetColor(obj.BackColor)
    End Sub

    Sub GetColor(color As Color)
        If radioBack.Checked Then
            lblTest.BackColor = color
            lblBackColor.Text = ByteToColor(color) & vbCrLf & color.R & ", " & color.G & ", " & color.B
            My.Settings.BackColor = color
        End If
        If radioFore.Checked Then
            lblTest.ForeColor = color
            lblForeColor.Text = ByteToColor(color) & vbCrLf & color.R & ", " & color.G & ", " & color.B
            My.Settings.ForeColor = color
        End If

        txtColor.Text = ByteToColor(color)

        Clipboard.SetText(ByteToColor(color))
    End Sub

    Function ByteToColor(c As Color) As String
        Return c.R.ToString("x2").ToUpper & c.G.ToString("x2").ToUpper & c.B.ToString("x2").ToUpper
    End Function

    Private Sub txtColor_TextChanged(sender As Object, e As EventArgs) Handles txtColor.TextChanged
        If txtColor.Text.Length = 6 Then
            Try
                Dim r = Byte.Parse(txtColor.Text.Substring(0, 2), Globalization.NumberStyles.HexNumber)
                Dim g = Byte.Parse(txtColor.Text.Substring(2, 2), Globalization.NumberStyles.HexNumber)
                Dim b = Byte.Parse(txtColor.Text.Substring(4, 2), Globalization.NumberStyles.HexNumber)

                GetColor(Color.FromArgb(r, g, b))
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTest.BackColor = My.Settings.BackColor
        lblBackColor.Text = ByteToColor(My.Settings.BackColor) & vbCrLf & My.Settings.BackColor.R & ", " & My.Settings.BackColor.G & ", " & My.Settings.BackColor.B

        lblTest.ForeColor = My.Settings.ForeColor
        lblForeColor.Text = ByteToColor(My.Settings.ForeColor) & vbCrLf & My.Settings.ForeColor.R & ", " & My.Settings.ForeColor.G & ", " & My.Settings.ForeColor.B

        txtColor.Text = ByteToColor(My.Settings.ForeColor)
    End Sub

End Class
