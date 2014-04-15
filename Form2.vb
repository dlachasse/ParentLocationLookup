Public Class Form2

    Private Sub BinLookupActivator_Click(sender As Object, e As EventArgs) Handles BinLookupActivator.Click
        Me.Visible = False
        Form1.Visible = True
    End Sub

    Private Sub BinLookup_Click(sender As Object, e As EventArgs) Handles BinLookup.Click
        Dim bin As String = BinLookupText.Text

        Try
            Me.InventoryTableAdapter.GetDataBy(bin)
            Me.InventoryTableAdapter.FillBy(Me.BinItems.Inventory, bin)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub OnKeyPress(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(Keys.Enter) Then MyBase.OnKeyPress(e)
    End Sub
End Class