<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128579057/17.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T555636)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [CustomTotalGrandTotalBehavior.cs](./CS/WpfApplication1/CustomTotalGrandTotalBehavior.cs) (VB: [CustomTotalGrandTotalBehavior.vb](./VB/WpfApplication1/CustomTotalGrandTotalBehavior.vb))
* [MainWindow.xaml](./CS/WpfApplication1/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfApplication1/MainWindow.xaml))
* [MyDataContext.cs](./CS/WpfApplication1/MyDataContext.cs) (VB: [MyDataContext.vb](./VB/WpfApplication1/MyDataContext.vb))
<!-- default file list end -->
# WPF PivotGridControl - Providing a custom summary for Total, Grand Total and ordinary cells


<p>This example is made based on the <a href="https://www.devexpress.com/Support/Center/p/E2592">How to provide custom summary values for Total, Grand Total and ordinary cells</a> example and illustrates how a cell type can be checked in the CustomSummary event handler. <br>When the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfPivotGridPivotGridControl_CustomSummarytopic">PivotGridControl.CustomSummary</a> event is used to provide custom values for only Total or Grand Total cells, you can use the ColumnField and RowField properties to determine the kind of a processed cell. You can use the following rules to determine that a cell is being processed:</p>
<p>1. If <strong>ColumnField</strong> or <strong>RowField</strong> is <em>null, </em>it means that this is a Grand Total cell;<br>2. If both ColumnField and RowField are last fields in a corresponding area, this means that this is an ordinary cell.<br>3. In other cases, this is a Total cell.<br><br><strong>NOTE</strong><br>This example demonstrates how to determine the value type. To calculate summary values, you can use one of the following solutions:<br>1. Get calculated summary values using the <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.PivotGrid.PivotCustomSummaryEventArgs.SummaryValue.property">SummaryValue</a> property.<br>2. Calculate the value by iterating through <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.PivotGrid.PivotCustomSummaryEventArgs.CreateDrillDownDataSource.method">DrillDownDataSource</a>. This solution is demonstrated in the <a href="https://www.devexpress.com/Support/Center/p/E2136">E2136: How to: Implement Custom Summary</a> example.<br>3. Calculate the value by summary values calculated for low level cells. This is the most complex approach demonstrated in the <a href="https://www.devexpress.com/Support/Center/p/T158425">T158425: How to calculate Total cell values based on the low level Cell summary values</a> example. In this example ASPxPivotGrid is used, but the approach should be similar. </p>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-pivot-grid-provide-custom-summary-values&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-pivot-grid-provide-custom-summary-values&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
