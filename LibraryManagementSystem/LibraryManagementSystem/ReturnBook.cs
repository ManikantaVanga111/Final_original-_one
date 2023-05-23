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
    public  class ReturnBook
    {
        //public  void Return_Book()
        //{
        //    int reg_id = AnsiConsole.Ask<int>("[red]Enter the Student Reg_id :[/]");
        //    int book_id = AnsiConsole.Ask<int>("[red]Enter the Book_Id :[/]");
        //    string query = $"select * from  Issue_book where reg_id ={reg_id} and book_id={book_id} ";
        //    SqlDataAdapter adp = Connectionclass.GetAdapter(query);
        //    DataSet ds = new DataSet();
        //    adp.Fill(ds);
        //    if (ds.Tables[0].Rows.Count > 0)
        //    {
        //        SqlDataAdapter adp1 =Connectionclass.GetAdapter($"select * from Issue_book where reg_id ={reg_id}");
        //        DataSet ds1 = new DataSet();
        //        adp1.Fill(ds1);
        //        ds1.Tables[0].Rows[0].Delete();
        //        SqlCommandBuilder cmdBuilder1 = new SqlCommandBuilder(adp1);
        //        adp1.Update(ds1);
        //        AnsiConsole.MarkupLine("[red] Successfully Deleted Issue Details[/]");
        //        SqlDataAdapter adp2 =Connectionclass.GetAdapter($"select * from Book_details where book_id={book_id}");
        //        DataSet ds2 = new DataSet();
        //        adp2.Fill(ds2);
        //        DataRow quantityRow = ds2.Tables[0].Rows[0];
        //        int quantity = Convert.ToInt32(quantityRow["Quantity"]);
        //        quantityRow["Quantity"] = quantity + 1;
        //        SqlCommandBuilder cmdBuilder2 = new SqlCommandBuilder(adp2);
        //        adp2.Update(ds2);
        //        AnsiConsole.MarkupLine("[blue] Successfully Quantity Updated[/]");
        //    }
        //    else
        //    {

        //        AnsiConsole.MarkupLine("[red] Enter the valid Id To Return the Book From Student[/]");
        //    }
        //}
    }
}
