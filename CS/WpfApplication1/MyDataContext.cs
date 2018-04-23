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
            Random _r = new Random();
            dt.Columns.Add("Row1", typeof(int));
            dt.Columns.Add("Row2", typeof(int));
            dt.Columns.Add("Column", typeof(string));
            dt.Columns.Add("Data", typeof(int));
            dt.Rows.Add(1, 0, "Column0", _r.Next(10));
            dt.Rows.Add(2, 0, "Column0", _r.Next(10));
            dt.Rows.Add(3, 0, "Column0", _r.Next(10));
            dt.Rows.Add(4, 0, "Column0", _r.Next(10));
            dt.Rows.Add(1, 1, "Column0", _r.Next(10));
            dt.Rows.Add(2, 1, "Column0", _r.Next(10));
            dt.Rows.Add(3, 1, "Column0", _r.Next(10));
            dt.Rows.Add(4, 1, "Column0", _r.Next(10));
            dt.Rows.Add(1, 0, "Column1", _r.Next(10));
            dt.Rows.Add(2, 0, "Column1", _r.Next(10));
            dt.Rows.Add(3, 0, "Column1", _r.Next(10));
            dt.Rows.Add(4, 0, "Column1", _r.Next(10));
            dt.Rows.Add(1, 1, "Column1", _r.Next(10));
            dt.Rows.Add(2, 1, "Column1", _r.Next(10));
            dt.Rows.Add(3, 1, "Column1", _r.Next(10));
            dt.Rows.Add(4, 1, "Column1", _r.Next(10));
            return dt;
        }

    }
}
