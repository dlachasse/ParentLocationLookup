Imports System.Text.RegularExpressions
Imports System.Data.SqlClient

Public Class Form1

    Public Property AcceptButton As IButtonControl

    Private Sub LocationDataBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)

        Me.Validate()
        Me.LocationDataBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub


    Private Sub LocationDataBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.LocationDataBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim searchParams As String

        searchParams = "VisrM_8289%"
        Me.LocationDataTableAdapter.GetDataBy(searchParams)
        'TODO: This line of code loads data into the 'DataSet1.LocationData' table. You can move, or remove it, as needed.
        Me.LocationDataTableAdapter.Fill(Me.DataSet1.LocationData)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Dim searchParams As String = TextBox1.Text

        If Regex.IsMatch(TextBox1.Text, "(~{3}\d+/)") Then
            TextBox1.Text = searchParams.Replace("~", "").Replace("/", "")
            TextBox1.Text = barcodeLookup(TextBox1.Text)
            searchParams = TextBox1.Text
        End If

        searchParams = "%" + searchParams + "%"

        Me.LocationDataTableAdapter.FillBy(Me.DataSet1.LocationData, searchParams)

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
End Class
