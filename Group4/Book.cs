

using System;
using System.Data.SqlClient;

namespace Group4
{
    public class Book
    {
        private string SerialNumber;
        private string Title;
        private string author;
        private int PublishYear;
        private Language Language; //enum
        private float Rating;
        private bool Archive;
        public System.Collections.Generic.List<Copy> Copies;
        public System.Collections.Generic.List<BookHistory> History;


        public Book(string serialNumber, string title, string author, int publishYear, string language, float rating, bool archive, bool is_new)
        {
            this.SerialNumber = serialNumber;
            this.Title = title;
            this.author = author;
            this.PublishYear = publishYear;
            this.Language = (Language)Enum.Parse(typeof(Language), language);
            this.Rating = rating;
            this.Archive = archive;
            this.Copies = new System.Collections.Generic.List<Copy>();
            this.History = new System.Collections.Generic.List<BookHistory>();
            if (is_new)
            {
                this.create_Book();
                Program.books.Add(this);

            }
        }

        //getters

        public string get_sNumber()
        {
            return this.SerialNumber;
        }
        public string get_author()
        {
            return this.author;
        }

        public string get_title()
        {
            return this.Title;
        }

        public int get_PYear()
        {
            return this.PublishYear;
        }

        public string get_lang()
        {
            return this.Language;
        }

        public float get_rating()
        {
            return this.Rating;
        }

        public bool get_archive()
        {
            return this.Archive;
        }
        //setters


        public void set_name(string name)
        {
            this.WorkerName = name;
        }

        public string set_sNumber(string serialNumber)
        {
            this.SerialNumber = serialNumber;
        }
        public string set_author(string author)
        {
            this.author = author;
        }

        public string set_title(string title)
        {
            this.Title = title;
        }

        public int set_PYear(int publishYear)
        {
            this.PublishYear = publishYear;
        }

        public string set_lang(string language)
        {
            this.Language = language;
        }

        public float set_rating(float rating)
        {
            this.Rating = rating;
        }

        public bool set_archive(bool archive)
        {
            this.Archive = archive;
        }

        /// <summary>
        /// later on
        /// </summary>


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



        public void create_Book()
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