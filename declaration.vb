﻿Module declaration
    Public ds As New DataSet
    Public cmd As New OleDb.OleDbCommand
    Public da As New OleDb.OleDbDataAdapter
    Public con As OleDb.OleDbConnection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Acer\Desktop\project2.mdb")

    Public sdr As OleDb.OleDbDataReader
    Public userlogin As String = ""
End Module
