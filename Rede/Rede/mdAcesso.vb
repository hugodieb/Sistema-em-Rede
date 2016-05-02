Imports System.Data.OleDb

Module mdAcesso

    Public Function getConnection() As OleDbConnection

        Dim sql As String

        sql = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\projetos_vb\Sistema_rede\Rede\pessoa.accdb"

        Return New OleDbConnection(sql)
    End Function

End Module
