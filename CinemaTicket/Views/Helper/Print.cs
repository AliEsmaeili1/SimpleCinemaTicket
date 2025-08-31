using System.Data;

namespace CinemaTicket.Views.Helper
{
    internal static class Print
    {
        public static void PrintTable(DataTable table)
        {
            Console.WriteLine("\n\n");
            //print columns
            foreach (DataColumn col in table.Columns)
            {
                Console.Write("\t\t");
                Console.Write(col.ColumnName);
            }
            Console.WriteLine();
            //print Rows
            foreach (DataRow row in table.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write("\t\t");
                    Console.Write(item);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\n\n");
        }
    }
}
