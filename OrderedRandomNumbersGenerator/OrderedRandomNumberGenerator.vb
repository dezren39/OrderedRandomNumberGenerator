Option Strict On
Public Class FrmRandNumGen
    Private Sub BtnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim rand As New Random()
        Dim amountOfNumbers = CInt(nmcAmountOfNumbers.Value)
        Dim lowerLimit = CInt(nmcLowerLimit.Value)
        Dim upperLimit = CInt(nmcUpperLimit.Value)
        Dim randomNumbers(amountOfNumbers) As Integer
        Dim sortedNumbers = New List(Of Integer) From {0}

        For index = 0 To amountOfNumbers - 1
            randomNumbers(index) = rand.Next(lowerLimit, upperLimit)
        Next

        For indexOuter = 0 To randomNumbers.GetUpperBound(0)
            For indexInner = 0 To sortedNumbers.Count - 1
                If randomNumbers(indexOuter) > sortedNumbers(indexInner) Then
                    sortedNumbers.Insert(indexInner, randomNumbers(indexOuter))
                    Exit For
                End If
            Next
        Next

        sortedNumbers.RemoveAt(sortedNumbers.Count - 1)
        lvwOutput.Clear()

        For Each element In sortedNumbers
            lvwOutput.Items.Add(element.ToString)
        Next
    End Sub
End Class
