using System;
using System.Data.SqlClient;

namespace Group4
{
    public class Copy
    {
        private int CopyNum;
        private Book book;
        private bool Status;


        public Copy(int copyNum, Book book, bool status, bool is_new)
        {
            this.CopyNum = copyNum;
            this.book = book;
            this.Status = status;
            if (is_new)
            {
                this.create_Copy();
                Program.copies.Add(this);

            }
        }

        public int get_copyNum()
        {
            return this.CopyNum;
        }
        public Book get_book()
        {
            return this.book;
        }

        public bool get_status()
        {
            return this.Status;
        }

        public void set_copyNum(int copyNum)
        {
            this.CopyNum = copyNum;
        }

        public void set_book(Book b)
        {
            this.book = b;
        }

        public void set_status(bool status)
        {
            this.Status = status;
        }


        public void create_Copy()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_add_Copies @copyNumber ,@serialNumber , @status";
            c.Parameters.AddWithValue("@copyNumber", this.CopyNum);
            c.Parameters.AddWithValue("@serialNumber", this.book.get_sNumber());
            c.Parameters.AddWithValue("@status", this.Status);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void update_Copy()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_Copy @copyNumber, @serialNumber, @status";
            c.Parameters.AddWithValue("@copyNumber", this.CopyNum);
            c.Parameters.AddWithValue("@serialNumber", this.book.get_sNumber());
            c.Parameters.AddWithValue("@status", this.Status);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        // שיטת מחיקה?
    }
}