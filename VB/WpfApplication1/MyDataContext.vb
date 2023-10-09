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
            Dim _r As Random = New Random()
            dt.Columns.Add("Row1", GetType(Integer))
            dt.Columns.Add("Row2", GetType(Integer))
            dt.Columns.Add("Column", GetType(String))
            dt.Columns.Add("Data", GetType(Integer))
            dt.Rows.Add(1, 0, "Column0", _r.Next(10))
            dt.Rows.Add(2, 0, "Column0", _r.Next(10))
            dt.Rows.Add(3, 0, "Column0", _r.Next(10))
            dt.Rows.Add(4, 0, "Column0", _r.Next(10))
            dt.Rows.Add(1, 1, "Column0", _r.Next(10))
            dt.Rows.Add(2, 1, "Column0", _r.Next(10))
            dt.Rows.Add(3, 1, "Column0", _r.Next(10))
            dt.Rows.Add(4, 1, "Column0", _r.Next(10))
            dt.Rows.Add(1, 0, "Column1", _r.Next(10))
            dt.Rows.Add(2, 0, "Column1", _r.Next(10))
            dt.Rows.Add(3, 0, "Column1", _r.Next(10))
            dt.Rows.Add(4, 0, "Column1", _r.Next(10))
            dt.Rows.Add(1, 1, "Column1", _r.Next(10))
            dt.Rows.Add(2, 1, "Column1", _r.Next(10))
            dt.Rows.Add(3, 1, "Column1", _r.Next(10))
            dt.Rows.Add(4, 1, "Column1", _r.Next(10))
            Return dt
        End Function
    End Class
End Namespace
