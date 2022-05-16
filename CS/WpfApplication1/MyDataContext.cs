using System;
using System.Data;

namespace WpfApplication1
{
    public class MyDataContext
    {
        public MyDataContext()
        {
            Data = GetData();
        }

        public DataTable Data { get; private set; }

        DataTable GetData()
        {
            DataTable dt = new DataTable();
            Random rnd = new Random();
            dt.Columns.Add("RowGroup", typeof(string));
            dt.Columns.Add("Row", typeof(string));
            dt.Columns.Add("ColumnGroup", typeof(string));
            dt.Columns.Add("Column", typeof(string));
            dt.Columns.Add("Data", typeof(int));
            for(int rowGroup = 1; rowGroup < 5; rowGroup++)
                for(int row = 1; row < 5; row++)
                    for(int columnGroup = 1; columnGroup < 5; columnGroup++)
                        for(int column = 1; column < 5; column++)
                            dt.Rows.Add(
                                "Row Group" + rowGroup,
                                "Row" + row,
                                "Column Group" + columnGroup,
                                "Column" + column,
                                rnd.Next(100));
                            return dt;
        }

    }
}
