using System;
using System.Data.SqlClient;

namespace Group4
{
    public class Event
    {
        private GuestType GuestType; //enum
        private DateTime Date;
        private float Price;
        private string GuestName;
        private int maxGuests;
        private int currentlyRegistered;
        //public System.Collections.Generic.List<Order> orders;


        public Event(string guestType, DateTime date, float price, string guestName, int maxGuests, int currentlyRegistered, bool is_new)
        {
            this.GuestType = guestType;
            this.Date = date;
            this.Price = price;
            this.GuestName = guestName;
            this.MaxGuests = maxGuests;
            this.currentlyRegistered = currentlyRegistered;

            if (is_new)
            {
                this.create_event();
                Program.events.Add(this);

            }
        }

        public string get_guestType()
        {
            return this.GuestType;
        }
        public DateTime get_date()
        {
            return this.Date;
        }

        public float get_price()
        {
            return this.Price;
        }

        public string get_guestName()
        {
            return this.GuestName;
        }

        public int get_maxGuests()
        {
            return this.maxGuests;
        }

        public int get_currentlyRegistered()
        {
            return this.currentlyRegistered;
        }

        public void set_guestType(string guestType)
        {
            this.GuestType = guestType;
        }

        public void set_date(DateTime date)
        {
            this.Date = date;
        }

        public void set_price(float price)
        {
            this.Price = price;
        }

        public void set_guestName(string guestName)
        {
            this.GuestName = guestName;
        }

        public void set_maxGuests(int maxGuests)
        {
            this.maxGuests = maxGuests;
        }

        public void set_currentlyRegistered(int currentlyRegistered)
        {
            this.currentlyRegistered = currentlyRegistered;
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



        public void create_event()
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