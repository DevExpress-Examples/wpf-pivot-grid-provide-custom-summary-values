using DevExpress.Xpf.PivotGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Interactivity;

namespace WpfApplication1
{
    public class CustomTotalGrandTotalBehavior : Behavior<PivotGridControl>
    {
        protected PivotGridControl PivotGrid { get { return (PivotGridControl)AssociatedObject; } }
        protected override void OnAttached()
        {
            PivotGrid.CustomSummary += PivotGrid_CustomSummary;
        }
        public string Name { set; get; }
        private void PivotGrid_CustomSummary(object sender, PivotCustomSummaryEventArgs e)
        {
            if (e.DataField.Name == Name)
            {
                if ((e.ColumnField == null) || (e.RowField == null))
                {
                    //this is Grand Total cell
                    e.CustomValue = "Grand Total";
                    return;
                }
                int lastRowFieldIndex = PivotGrid.GetFieldsByArea(FieldArea.RowArea).Count() - 1;
                int lastColumnFieldIndex = PivotGrid.GetFieldsByArea(FieldArea.ColumnArea).Count() - 1;
                if (e.RowField.AreaIndex == lastRowFieldIndex && e.ColumnField.AreaIndex == lastColumnFieldIndex)
                {
                    //this is Ordinary cell
                    e.CustomValue = e.SummaryValue.Summary;
                }
                else
                {
                    //this is Total cell
                    e.CustomValue = "Total";
                }


            }
        }
    }
}
