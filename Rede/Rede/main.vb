Imports System.Data.OleDb

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub loadGridView()
        Using con As OleDbConnection = getConnection()

            Dim cmd As OleDbCommand
            Dim dt As OleDbDataAdapter
            Dim da As DataTable

            Try
                con.Open()

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try


        End Using

    End Sub

End Class
