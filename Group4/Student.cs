using System;
using System.Data.SqlClient;

namespace Group4
{
    public class Student
    {
        private string Id;
        private string Name;
        private int Age;
        private string Club;
        private int YearlyGoal;
        private string Password;
        private bool Archive;
        //public System.Collections.Generic.List<Order> orders;


        public Student(string id, string name, int age, string club, int yearlyGoal, string password, bool archive, bool is_new)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.Club = club;
            this.YearlyGoal = yearlyGoal;
            this.Password = password;
            this.Archive = archive;

            if (is_new)
            {
                this.create_student();
                Program.students.Add(this);

            }
        }

        public string get_name()
        {
            return this.Name;
        }
        public string get_ID()
        {
            return this.Id;
        }

        public int get_age()
        {
            return this.Age;
        }

        public string get_club()
        {
            return this.Club;
        }

        public int get_yearlyGoal()
        {
            return this.YearlyGoal;
        }

        public string get_archive()
        {
            return this.Archive;
        }

        private string get_password()
        {
            return this.Password;
        }

        public void set_ID(string id)
        {
            this.ID = id;
        }

        public void set_name(string name)
        {
            this.Name = name; 
        }

        public void set_age(int age)
        {
            this.Age = age;
        }

        public void set_club(string club)
        {
            this.Club = club;
        }

        public void set_yearlyGoal(int yearlyGoal)
        {
            this.YearlyGoal = yearlyGoal;
        }

        private void set_password(string password)
        {
            this.Password = password;
        }

        public void set_archive(bool archive)
        {
            this.Archive = archive;
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



        public void create_student()
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