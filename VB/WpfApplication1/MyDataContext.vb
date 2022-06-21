Imports System
Imports System.Data

Namespace WpfApplication1

    Public Class MyDataContext

        Private _Data As DataTable

        Public Sub New()
            Data = GetData()
        End Sub

        Public Property Data As DataTable
            Get
                Return _Data
            End Get

            Private Set(ByVal value As DataTable)
                _Data = value
            End Set
        End Property

        Private Function GetData() As DataTable
            Dim dt As DataTable = New DataTable()
            Dim rnd As Random = New Random()
            dt.Columns.Add("RowGroup", GetType(String))
            dt.Columns.Add("Row", GetType(String))
            dt.Columns.Add("ColumnGroup", GetType(String))
            dt.Columns.Add("Column", GetType(String))
            dt.Columns.Add("Data", GetType(Integer))
            For rowGroup As Integer = 1 To 5 - 1
                For row As Integer = 1 To 5 - 1
                    For columnGroup As Integer = 1 To 5 - 1
                        For column As Integer = 1 To 5 - 1
                            dt.Rows.Add("Row Group" & rowGroup, "Row" & row, "Column Group" & columnGroup, "Column" & column, rnd.Next(100))
                        Next
                    Next
                Next
            Next

            Return dt
        End Function
    End Class
End Namespace
