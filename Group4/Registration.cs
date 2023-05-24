using System;
using System.Data.SqlClient;

namespace Group4
{
    public class Registration
    {
        private string ID;
        private DateTime EventDate;
        private string GuestName;
        private bool ShowedUp;
        private string Review;
        private int Rating;
        //public System.Collections.Generic.List<Order> orders;


        public Registration(string id, DateTime eventDate, string guestName, bool showedUp, string review, int rating, bool is_new)
        {
            this.ID = id;
            this.EventDate = eventDate;
            this.GuestName = guestName;
            this.ShowedUp = showedUp;
            this.Review = review;
            this.Rating = rating;

            if (is_new)
            {
                this.create_registration();
                Program.registrations.Add(this);

            }
        }

        public string get_id()
        {
            return this.ID;
        }
        public DateTime get_eventDate()
        {
            return this.EventDate;
        }

        public float get_guestName()
        {
            return this.GuestName;
        }

        public string get_showedUp()
        {
            return this.ShowedUp;
        }

        public int get_review()
        {
            return this.Review;
        }

        public int get_rating()
        {
            return this.Rating;
        }

        public void set_id(string id)
        {
            this.ID = id;
        }

        public void set_eventDate(DateTime eventDate)
        {
            this.EventDate = eventDate;
        }

        public void set_guestName(string guestName)
        {
            this.GuestName = guestName;
        }

        public void set_showedUp(bool showedUp)
        {
            this.ShowedUp = showedUp;
        }

        public void set_review(string review)
        {
            this.Review = review;
        }

        public void set_rating(int rating)
        {
            this.Rating = rating;
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



        public void create_registration()
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