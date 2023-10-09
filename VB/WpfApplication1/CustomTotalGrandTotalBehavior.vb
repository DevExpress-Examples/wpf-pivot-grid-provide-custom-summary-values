Imports DevExpress.Xpf.PivotGrid
Imports System.Windows.Interactivity

Namespace WpfApplication1

    Public Class CustomTotalGrandTotalBehavior
        Inherits Behavior(Of PivotGridControl)

        Protected ReadOnly Property PivotGrid As PivotGridControl
            Get
                Return CType(AssociatedObject, PivotGridControl)
            End Get
        End Property

        Protected Overrides Sub OnAttached()
            AddHandler PivotGrid.CustomSummary, AddressOf PivotGrid_CustomSummary
        End Sub

        Public Property Name As String

        Private Sub PivotGrid_CustomSummary(ByVal sender As Object, ByVal e As PivotCustomSummaryEventArgs)
            If Equals(e.DataField.Name, Name) Then
                If e.ColumnField Is Nothing OrElse e.RowField Is Nothing Then
                    'this is Grand Total cell
                    e.CustomValue = "Grand Total"
                    Return
                End If

                Dim lastRowFieldIndex As Integer = PivotGrid.GetFieldsByArea(FieldArea.RowArea).Count() - 1
                Dim lastColumnFieldIndex As Integer = PivotGrid.GetFieldsByArea(FieldArea.ColumnArea).Count() - 1
                If e.RowField.AreaIndex = lastRowFieldIndex AndAlso e.ColumnField.AreaIndex = lastColumnFieldIndex Then
                    'this is Ordinary cell
                    e.CustomValue = e.SummaryValue.Summary
                Else
                    'this is Total cell
                    e.CustomValue = "Total"
                End If
            End If
        End Sub
    End Class
End Namespace
