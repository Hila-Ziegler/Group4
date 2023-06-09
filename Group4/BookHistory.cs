using System;
using System.Data.SqlClient;

namespace Group4
{
    public class BookHistory
    {
        private int CopyNum;
        private Book Book;
        private Student Student;
        private DateTime StartDate;
        private DateTime EndDate;
        private int Rate;


        public BookHistory(int copyNum, Book Book, Student Student, DateTime startDate, DateTime endDate, bool is_new)
        {
            this.CopyNum = copyNum;
            this.Book = Book;
            this.Student = Student;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Rate = 0;

            if (is_new)
            {
                this.create_BookHistory();
                Program.bookHistories.Add(this);
            }
        }

        public int get_copyNum()
        {
            return this.CopyNum;
        }
        public Book get_book()
        {
            return this.Book;
        }

        public Student get_student()
        {
            return this.Student;
        }

        public DateTime get_StartDate()
        {
            return this.StartDate;
        }

        public DateTime get_EndDate()
        {
            return this.EndDate;
        }

        public int get_rate()
        {
            return this.Rate;
        }

        public void set_copyNum(int copyNum)
        {
            this.CopyNum = copyNum;
        }

        public void set_Book(Book Book)
        {
            this.Book = Book;
        }

        public void set_Student(Student Student)
        {
            this.Student = Student;
        }

        public void set_startDate(DateTime startDate)
        {
            this.StartDate = startDate;
        }

        public void set_endDate(DateTime endDate)
        {
            this.EndDate = endDate;
        }

        public void set_rate(int rate)
        {
            this.Rate = rate;
        }

        public void create_BookHistory()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_add_BookHistory @copyNumber	, @serialNumber, @id, @startDate, @endDate, @rate";
            c.Parameters.AddWithValue("@copyNumber", this.CopyNum);
            c.Parameters.AddWithValue("@serialNumber", this.Book.get_sNumber());
            c.Parameters.AddWithValue("@id", this.Student.get_ID());
            //Issue with making new entry in DateTime
            c.Parameters.AddWithValue("@startDate", this.StartDate.ToString());
            c.Parameters.AddWithValue("@endDate", this.EndDate.ToString());
            c.Parameters.AddWithValue("@rate", this.Rate);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void update_BookHistory()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_BookHistory @copyNumber	, @serialNumber, @id, @startDate, @endDate, @rate";
            c.Parameters.AddWithValue("@copyNumber", this.CopyNum);
            c.Parameters.AddWithValue("@serialNumber", this.Book.get_sNumber());
            c.Parameters.AddWithValue("@id", this.Student.get_ID());
            c.Parameters.AddWithValue("@startDate", this.StartDate.ToString());
            c.Parameters.AddWithValue("@endDate", this.EndDate.ToString());
            c.Parameters.AddWithValue("@rate", this.Rate);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        //public void rateABook()
       // {

       // }

    }
}