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
   public class Count
    {
        //public  void Count_The_Students_Who_Have_Books()
        //{
        //    string query = $"select * from Issue_book ";
        //    SqlDataAdapter adp = Connectionclass.GetAdapter(query);
        //    DataSet ds = new DataSet();
        //    adp.Fill(ds);
        //    Table table;
        //    if(ds.Tables[0].Rows.Count>0)
        //    {
        //        table=new Table();
        //        table.AddColumn("Book_Id");
        //        table.AddColumn("Reg_Id");
        //        table.AddColumn("Issue_Date");
        //        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        //        {

        //            table.AddRow(ds.Tables[0].Rows[i][0].ToString(), ds.Tables[0].Rows[i][1].ToString(), ds.Tables[0].Rows[i][2].ToString());
        //        }
        //        AnsiConsole.Write(table);
        //        Console.WriteLine("");
        //        AnsiConsole.MarkupLine($"[blue] Students Who Have Book = {ds.Tables[0].Rows.Count} [/] ");
        //    }else
        //    {
        //        AnsiConsole.MarkupLine("[blue] Table Contain Zero Data[/]");
        //    }
        //}
    }
}
