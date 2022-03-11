Public Class Roulette

    Dim BetRed, BetBlack, BetOdd, BetEven, Odd, Even, Red, Black, NewRoundTimer As Boolean
    Dim SpinNumb, second As Integer
    Public Balance As Integer

    Private Sub RBlack_Click(sender As Object, e As EventArgs) Handles RBlack.Click

        If CheckBal() = True And CoinBalance.Text > BetAmount.Text Then
            BetBlack = True
            CoinBalance.Text -= BetAmount.Text
            BlackBetAmount.Text += BetAmount.Text
            RBlack.Enabled = False
        End If
    End Sub

    Private Sub Deposit_Click(sender As Object, e As EventArgs) Handles Deposit.Click
        DepositScreen.Show()
    End Sub

    Private Sub Roulette_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CoinBalance.Text = Character.PlayerCoinBalance

        EvenBetAmount.ForeColor = Color.Black
        OddBetAmount.ForeColor = Color.Black
        BlackBetAmount.ForeColor = Color.Black
        RedBetAmount.ForeColor = Color.Black
        EvenBetAmount.Text = ""
        OddBetAmount.Text = ""
        BlackBetAmount.Text = ""
        RedBetAmount.Text = ""
        SpinWheel.Enabled = True
        BetAmount.Text = ""
        CollectWinnings.Enabled = False
        BetOdd = False
        BetEven = False
        BetBlack = False
        BetRed = False
    End Sub


    Private Sub REven_Click(sender As Object, e As EventArgs) Handles REven.Click
        If CheckBal() = True And CoinBalance.Text > BetAmount.Text Then
            BetEven = True
            CoinBalance.Text -= BetAmount.Text
            EvenBetAmount.Text += BetAmount.Text
            REven.Enabled = False
        End If
    End Sub

    Private Sub CollectWinnings_Click(sender As Object, e As EventArgs) Handles CollectWinnings.Click
        EvenBetAmount.ForeColor = Color.Black
        OddBetAmount.ForeColor = Color.Black
        BlackBetAmount.ForeColor = Color.Black
        RedBetAmount.ForeColor = Color.Black
        EvenBetAmount.Text = ""
        OddBetAmount.Text = ""
        BlackBetAmount.Text = ""
        RedBetAmount.Text = ""
        SpinWheel.Enabled = True
        BetAmount.Text = ""
        CollectWinnings.Enabled = False
        BetOdd = False
        BetEven = False
        BetBlack = False
        BetRed = False
        RBlack.Enabled = True
        RRed.Enabled = True
        ROdd.Enabled = True
        REven.Enabled = True
        Character.PlayerCoinBalance = CoinBalance.Text
    End Sub

    Private Sub RRed_Click(sender As Object, e As EventArgs) Handles RRed.Click
        If CheckBal() = True And CoinBalance.Text > BetAmount.Text Then
            BetRed = True
            CoinBalance.Text -= BetAmount.Text
            RedBetAmount.Text += BetAmount.Text
            EvenBetAmount.ForeColor = Color.Green
            OddBetAmount.ForeColor = Color.Red
            RRed.Enabled = False
        End If
    End Sub

    Private Sub ROdd_Click(sender As Object, e As EventArgs) Handles ROdd.Click
        If CheckBal() = True And CoinBalance.Text > BetAmount.Text Then
            BetOdd = True
            CoinBalance.Text -= BetAmount.Text
            OddBetAmount.Text += BetAmount.Text
            ROdd.Enabled = False
        End If
    End Sub



    Private Sub SpinWheel_Click_1(sender As Object, e As EventArgs) Handles SpinWheel.Click
        NewRound()
        NewRoundTimer = False
        If BetBlack And Black = True Then
            CoinBalance.Text += BlackBetAmount.Text * 2
            BlackBetAmount.ForeColor = Color.Green
            RedBetAmount.ForeColor = Color.Red
            SpinColour.ForeColor = Color.Black
            SpinNumber.ForeColor = Color.White
        End If
        If BetRed And Red = True Then
            CoinBalance.Text += RedBetAmount.Text * 2
            RedBetAmount.ForeColor = Color.Green
            BlackBetAmount.ForeColor = Color.Red
            SpinColour.ForeColor = Color.Red
            SpinNumber.ForeColor = Color.White
        End If
        If BetOdd And Odd = True Then
            CoinBalance.Text += OddBetAmount.Text * 2
            OddBetAmount.ForeColor = Color.Green
            EvenBetAmount.ForeColor = Color.Red
        End If
        If BetEven And Even = True Then
            CoinBalance.Text += EvenBetAmount.Text * 2
            EvenBetAmount.ForeColor = Color.Green
            OddBetAmount.ForeColor = Color.Red



        Else

        End If
        SpinWheel.Enabled = False
        CollectWinnings.Enabled = True
        If Red = True Then
            SpinNumber.BackColor = Color.Red
        Else
            SpinNumber.BackColor = Color.Black
        End If
    End Sub


    Private Sub NewRound()

        Randomize()
        CheckBal()
        GetRandNum()

    End Sub
    Private Sub GetRandNum()
        Randomize()
        Dim RandNum As Integer = Int((36 * Rnd()) + 1)

        SpinNumb = RandNum
        SpinNumber.Text = RandNum


        Black = False
        Red = False

        If SpinNumb = 1 Or SpinNumb = 3 Or SpinNumb = 5 Or SpinNumb = 7 Or SpinNumb = 9 Or SpinNumb = 11 Or SpinNumb = 13 Or SpinNumb = 15 Or SpinNumb = 17 Or SpinNumb = 19 Or SpinNumb = 21 Or SpinNumb = 23 Or SpinNumb = 25 Or SpinNumb = 27 Or SpinNumb = 29 Or SpinNumb = 31 Then
            Odd = True
            Even = False
        Else
            Even = True
            Odd = False

        End If
        If SpinNumb = 2 Or SpinNumb = 4 Or SpinNumb = 6 Or SpinNumb = 8 Or SpinNumb = 10 Or SpinNumb = 11 Or SpinNumb = 13 Or SpinNumb = 15 Or SpinNumb = 17 Or SpinNumb = 20 Or SpinNumb = 22 Or SpinNumb = 24 Or SpinNumb = 26 Or SpinNumb = 28 Or SpinNumb = 29 Or SpinNumb = 31 Or SpinNumb = 33 Or SpinNumb = 35 Then
            Black = True

            SpinColour.Text = "Black"
        Else
            Red = True
            SpinColour.Text = "Red"
        End If
    End Sub

    Private Sub BetAmount_TextChanged(sender As Object, e As EventArgs)

    End Sub


    Function CheckBal()
        Dim CanBet As Boolean
        If Character.PlayerCoinBalance > 0 Then
            CanBet = True
        Else
            CanBet = False
        End If
        Return CanBet
    End Function
End Class
