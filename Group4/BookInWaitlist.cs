using System;
using System.Data.SqlClient;

namespace Group4
{
    public class BookInWaitlist
    {
        private DateTime StartDT;
        private Student student;
        private Book book;


        public BookInWaitlist(DateTime startDT, Student s, Book book, bool is_new)
        {
            this.StartDT = startDT;
            this.student = s;
            this.book = book;

            if (is_new)
            {
                this.create_BookInWaitlist();
                Program.booksInWaitlist.Add(this);

            }
        }

        public DateTime get_startDT()
        {
            return this.StartDT;
        }
        public Student get_Student()
        {
            return this.student;
        }

        public Book get_Book()
        {
            return this.book;
        }

        public void set_startDT(DateTime startDT)
        {
            this.StartDT = startDT;
        }

        public void set_student(Student s)
        {
            this.student = s;
        }

        public void set_book(Book b)
        {
            this.book = b;
        }




        public void create_BookInWaitlist()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_add_BookInWaitlist @startDate ,@id , @serialNumber";
            c.Parameters.AddWithValue("@startDate", this.StartDT);
            c.Parameters.AddWithValue("@id", this.student.get_ID());
            c.Parameters.AddWithValue("@serialNumber", this.book.get_sNumber());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }


    }
}