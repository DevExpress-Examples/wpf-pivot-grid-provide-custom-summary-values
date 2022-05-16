Imports System
Imports System.Data

Namespace WpfApplication1
    Public Class MyDataContext
        Public Sub New()
            Data = GetData()
        End Sub

        Private privateData As DataTable
        Public Property Data() As DataTable
            Get
                Return privateData
            End Get
            Private Set(ByVal value As DataTable)
                privateData = value
            End Set
        End Property

		Private Function GetData() As DataTable
			Dim dt As New DataTable()
			Dim rnd As New Random()
			dt.Columns.Add("RowGroup", GetType(String))
			dt.Columns.Add("Row", GetType(String))
			dt.Columns.Add("ColumnGroup", GetType(String))
			dt.Columns.Add("Column", GetType(String))
			dt.Columns.Add("Data", GetType(Integer))
			For rowGroup As Integer = 1 To 4
				For row As Integer = 1 To 4
					For columnGroup As Integer = 1 To 4
						For column As Integer = 1 To 4
							dt.Rows.Add("Row Group" & rowGroup, "Row" & row, "Column Group" & columnGroup, "Column" & column, rnd.Next(100))
						Next column
					Next columnGroup
				Next row
			Next rowGroup
			Return dt
		End Function

	End Class
End Namespace
