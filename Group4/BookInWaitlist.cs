using System;
using System.Data.SqlClient;

namespace Group4
{
    public class BookInWaitlist
    {
        private DateTime StartDT;
        private string ID;
        private string SerialNum;
        //public System.Collections.Generic.List<Order> orders;


        public BookInWaitlist(DateTime startDT, string id, string serialNum, bool is_new)
        {
            this.StartDT = startDT;
            this.ID = id;
            this.SerialNum = serialNum;

            if (is_new)
            {
                this.create_bookInWaitlist();
                Program.booksInWaitlist.Add(this);

            }
        }

        public DateTime get_startDT()
        {
            return this.StartDT;
        }
        public string get_id()
        {
            return this.ID;
        }

        public string get_serialNum()
        {
            return this.SerialNum;
        }

        public void set_startDT(DateTime startDT)
        {
            this.StartDT = startDT;
        }

        public void set_id(string id)
        {
            this.ID = id;
        }

        public void set_serialNum(string serialNum)
        {
            this.SerialNum = serialNum;
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



        public void create_bookInWaitlist()
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