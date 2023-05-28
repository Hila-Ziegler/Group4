﻿using System;
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
        //public System.Collections.Generic.List<Order> orders;


        public BookHistory(int copyNum, Book Book, Student Student, DateTime startDate, DateTime endDate, bool is_new)
        {
            this.CopyNum = copyNum;
            this.Book = Book;
            this.Student = Student;
            this.StartDate = startDate;
            this.EndDate = endDate;

            if (is_new)
            {
                this.create_bookHistory();
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

        public System.Collections.Generic.List<Order> Orders // get and set for the whole list
        {
            get
            {
                if (orders == null)
                    orders = new System.Collections.Generic.List<Order>();
                return orders;
            }
            set
            {
                RemoveAllOrders();
                if (value != null)
                {
                    foreach (Order oOrder in value)
                        AddOrders(oOrder);
                }
            }
        }

        public void AddOrders(Order newOrder)
        {
            if (newOrder == null)
                return;
            if (this.orders == null)
                this.orders = new System.Collections.Generic.List<Order>();
            if (!this.orders.Contains(newOrder))
            {
                this.orders.Add(newOrder);
                newOrder.Worker = this;
            }
        }
        public void RemoveOrders(Order oldOrder)
        {
            if (oldOrder == null)
                return;
            if (this.orders != null)
                if (this.orders.Contains(oldOrder))
                {
                    this.orders.Remove(oldOrder);
                    oldOrder.Worker = null;
                }
        }

        public void RemoveAllOrders()
        {
            if (orders != null)
            {
                foreach (Order order in orders)
                    order.Worker = null;
                orders.Clear();
            }
        }



        public void create_bookHistory()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_add_worker @id, @name, @title";
            c.Parameters.AddWithValue("@id", this.WorkerId);
            c.Parameters.AddWithValue("@name", this.WorkerName);
            c.Parameters.AddWithValue("@title", this.workerTitle.ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void Update_worker()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_worker  @id, @name, @title";
            c.Parameters.AddWithValue("@id", this.WorkerId);
            c.Parameters.AddWithValue("@name", this.WorkerName);
            c.Parameters.AddWithValue("@title", this.workerTitle.ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void Delete_worker()
        {
            Program.Workers.Remove(this);
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_delete_worker @id";
            c.Parameters.AddWithValue("@id", this.WorkerId);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

    }
}