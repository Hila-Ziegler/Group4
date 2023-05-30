using System;
using System.Data.SqlClient;

namespace Group4
{
    public class Request
    {
        private RequestType Type;
        private DateTime StartDT;
        private Student Student;
        private Librarian Librarian;
        private DateTime EndDT;
        private Status Status;
        private string PhotoAddress;
        
        //public System.Collections.Generic.List<Order> orders;

        //Update to have librarian id
        public Request(RequestType type, DateTime startDT, Student stud, Librarian lib, DateTime endDT, Status status, string photoAddress , bool is_new)
        {
            this.Type = type;
            this.StartDT = startDT;
            this.Student = stud;
            this.Librarian = lib;
            this.EndDT = endDT;
            this.Status = status;
            this.PhotoAddress = photoAddress;
            

            if (is_new)
            {
                this.create_request();
                Program.requests.Add(this);

            }
        }

        public RequestType get_type()
        {
            return this.Type;
        }
        public DateTime get_startDT()
        {
            return this.StartDT;
        }

        public string get_id()
        {
            return this.ID;
        }

        public DateTime get_endDT()
        {
            return this.EndDT;
        }

        public Status get_status()
        {
            return this.Status;
        }

        public string get_photoAddress()
        {
            return this.PhotoAddress;
        }

        public void set_type(string type)
        {
            this.Type = type;
        }

        public void set_startDT(DateTime startDT)
        {
            this.StartDT = startDT;
        }

        public void set_id(string id)
        {
            this.ID = id;
        }

        public void set_endDT(DateTime endDT)
        {
            this.EndDT = endDT;
        }

        public void set_status(string status)
        {
            this.Status = status;
        }

        public void set_photoAddress(string photoAddress)
        {
            this.PhotoAddress = photoAddress;
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



        public void create_request()
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