using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;

namespace LibraryManagementSystem
{
    //public class IssueBook
    //{
    //    public  void Issue_Book()
    //    {
    //        int book_id = AnsiConsole.Ask<int>("[red]Enter the Book_Id :[/]");
    //        int reg_id =AnsiConsole.Ask<int>("[red]Enter the Student Reg_id :[/]");
    //        string query = $"select * from  Book_details where book_id={book_id}";
    //        SqlDataAdapter adp = Connectionclass.GetAdapter(query);
    //        DataSet ds = new DataSet();
    //        adp.Fill(ds);
    //        if (ds.Tables[0].Rows.Count != 0)
    //        {
    //            DataRow quantityRow = ds.Tables[0].Rows[0];
    //            int quantity = Convert.ToInt32(quantityRow["Quantity"]);
    //            if (quantity != 0)
    //            {
    //                SqlDataAdapter adp1 = Connectionclass.GetAdapter($"select * from Issue_book");
    //                DataSet ds1 = new DataSet();
    //                adp1.Fill(ds1);
    //                var row = ds1.Tables[0].NewRow();
    //                row["book_id"] = book_id;
    //                row["reg_id"] = reg_id;
    //                row["IssueDate"] =DateTime.Now;
    //                ds1.Tables[0].Rows.Add(row);
    //                SqlCommandBuilder cmd = new SqlCommandBuilder(adp1);
    //                adp1.Update(ds1);
    //                AnsiConsole.MarkupLine("[blue]successfully Issued book for student[/]");
    //                SqlDataAdapter adp2 = Connectionclass.GetAdapter($"select * from  Book_details where book_id={book_id}");
    //                DataSet ds2 = new DataSet();
    //                adp2.Fill(ds2);
    //                var row1 = ds2.Tables[0].Rows[0];
    //                row1["Quantity"] = quantity - 1;
    //                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adp2);
    //                adp2.Update(ds2);
    //                AnsiConsole.MarkupLine("[blue] Successfully Quantity Updated[/]");
    //            } else
    //            {
    //                AnsiConsole.MarkupLine("[blue] Quantity Is Zero[/]");
    //            }

    //        }
    //        else
    //        {
    //            AnsiConsole.MarkupLine("[red] Enter the valid Id To Issue the Book For Student[/]");
    //        }
    //    }
    //}
}
