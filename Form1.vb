Imports System.Text.RegularExpressions
Imports System.Data.SqlClient

Public Class Form1


    Private Sub LocationDataBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)

        Me.Validate()
        Me.LocationDataBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub Form1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

        formatAndSearch()

    End Sub

    Private Sub LocationDataBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.LocationDataBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SearchButton.Click, Button1.Click
        formatAndSearch()
    End Sub

    Public Sub formatAndSearch()
        Dim searchParams As String = TextBox1.Text

        If Regex.IsMatch(TextBox1.Text, "(~{3}\d+/)") Then
            TextBox1.Text = searchParams.Replace("~", "").Replace("/", "")
            TextBox1.Text = barcodeLookup(TextBox1.Text)
            searchParams = TextBox1.Text
        End If

        searchParams = "%" + searchParams + "%"
        Try
            Me.LocationDataTableAdapter.FillBy(Me.DataSet1.LocationData, searchParams)
            System.Windows.Forms.MessageBox.Show("Searching " + searchParams)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Function barcodeLookup(ByVal barcode As String)
        Dim myconn As New SqlConnection("Data Source=FASERV;Initial Catalog='SE Data';Integrated Security=True")
        Dim querystr As String = "SELECT LocalSKU FROM Inventory WHERE Barcode = '" & barcode & "'"
        Dim mycmd As New SqlCommand(querystr, myconn)
        Dim value As Object

        myconn.Open()
        value = mycmd.ExecuteScalar()

        barcodeLookup = value.ToString

    End Function

    Protected Overrides Sub OnKeyPress(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(Keys.Enter) Then MyBase.OnKeyPress(e)
    End Sub

    Private Sub BinLookupActivator_Click(sender As Object, e As EventArgs) Handles BinLookupActivator.Click
        Me.Visible = False
        Form2.Visible = True
    End Sub

End Class
