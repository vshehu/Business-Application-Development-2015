Public Class Form1
    'ProductNames contains information about the id of the product (first column of the array) and the name of the product (second column of the array)
    Dim productNames(,) As String = {{"1", "Coca Cola"}, {"2", "Pepsi"}, {"3", "Bread"}, {"4", "Suggar"}, {"5", "Milk"}}
    'ProductPrices contains information about product price (first column) ammount on stock (second column) and VAT (third column). VAT can be 18% or 5 %
    Dim productPrices(,) As Decimal = {{75, 23, 18}, {70, 103, 18}, {25, 17, 5}, {50, 100, 5}, {55, 45, 5}}

    ''' <summary>
    ''' This function will search the array for a product based on 
    ''' part of the product name
    ''' </summary>
    ''' <param name="productName">The name of the product 
    ''' being searched
    ''' </param>
    ''' <returns>The indexes of all products found or an 
    ''' empty array if nothing is found</returns>
    ''' <remarks></remarks>
    Function SearchProductByName(ByVal productName As String) As Integer()

        Dim lst As New List(Of Integer)

        Dim nrElements As Integer = productNames.GetUpperBound(0)

        For i As Integer = 0 To nrElements
            If productNames(i, 1).Contains(productName) Then
                lst.Add(i)
            End If
        Next

        Return lst.ToArray()

    End Function
    ''' <summary>
    ''' This function will search the array for a product based on 
    ''' the id of the product
    ''' </summary>
    ''' <param name="productId">The id of the product</param>
    ''' <returns>The index of the found element on the product 
    ''' array or -1 if nothing is found</returns>
    ''' <remarks></remarks>
    Function SearchProductById(ByVal productId As String) As Integer
        Dim nrElements As Integer = productNames.GetUpperBound(0)

        For i As Integer = 0 To nrElements
            If productNames(i, 0) = productId Then
                Return i
            End If
        Next
        Return -1
    End Function

    Private Sub btnSearchById_Click(sender As Object, e As EventArgs) Handles btnSearchById.Click
        Dim index As Integer = SearchProductById(txtSearchId.Text)

        If index = -1 Then
            MessageBox.Show("No product found with the given Id!")
            Return
        End If

        txtProductName.Text = productNames(index, 1)
        txtAmountStock.Text = productPrices(index, 1)
        txtPrice.Text = productPrices(index, 0)
        txtVAT.Text = productPrices(index, 2)

    End Sub

    Private Sub btnSearchByName_Click(sender As Object, e As EventArgs) Handles btnSearchByName.Click
        Dim indexes() As Integer = SearchProductByName(txtSearchName.Text)

        lstSearchedProducts.Items.Clear()

        For Each index As Integer In indexes
            Dim lvi As New ListViewItem
            'get the id of the product
            lvi.Text = productNames(index, 0)
            'get the name of the product
            lvi.SubItems.Add(productNames(index, 1))
            'get the price of the product
            lvi.SubItems.Add(productPrices(index, 0))
            'get the VAT of the product
            lvi.SubItems.Add(productPrices(index, 2))
            'get the amount of the product
            lvi.SubItems.Add(productPrices(index, 1))

            'Add this row in the searched product list
            lstSearchedProducts.Items.Add(lvi)
        Next
    End Sub
End Class
