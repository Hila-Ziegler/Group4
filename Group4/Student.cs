using System;
using System.Data.SqlClient;

namespace Group4
{
    public class Student
    {
        private string Id;
        private string Name;
        private int Age;
        private Club Club;
        private int YearlyGoal;
        private string Password;
        private bool Archive;
        public System.Collections.Generic.List<BookHistory> History;
        public System.Collections.Generic.List<Request> requests;


        public Student(string id, string name, int age, Club club, int yearlyGoal, string password, bool archive, bool is_new)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.Club = club;
            this.YearlyGoal = yearlyGoal;
            this.Password = Hash.GetHash(password);
            this.Archive = archive;
            this.History = new System.Collections.Generic.List<BookHistory>();
            this.requests = new System.Collections.Generic.List<Request>();

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

        public Club get_club()
        {
            return this.Club;
        }

        public int get_yearlyGoal()
        {
            return this.YearlyGoal;
        }

        public bool get_archive()
        {
            return this.Archive;
        }

        public string get_password()
        {
            return this.Password;
        }

        public void set_ID(string id)
        {
            this.Id = id;
        }

        public void set_name(string name)
        {
            this.Name = name; 
        }

        public void set_age(int age)
        {
            this.Age = age;
        }

        public void set_club(Club club)
        {
            this.Club = club;
        }

        public void set_yearlyGoal(int yearlyGoal)
        {
            this.YearlyGoal = yearlyGoal;
        }

        private void set_password(string password)
        {
            this.Password = Hash.GetHash(password);
        }

        public void set_archive(bool archive)
        {
            this.Archive = archive;
        }

        public void addRequest(Request r)
        {
            if (r == null)
                return;
            if (!this.requests.Contains(r))
            {
                this.requests.Add(r);
            }
        }
        public void removeRequest(Request r)
        {
            if (r == null)
                return;
            if (this.requests != null)
                if (this.requests.Contains(r))
                {
                    this.requests.Remove(r);
                }
        }

        public void removeAllRequests()
        {
            if (this.requests != null)
            {
                this.requests.Clear();
            }
        }

        public void addBookHistory(BookHistory bh)
        {
            if (bh == null)
                return;
            if (!this.History.Contains(bh))
            {
                this.History.Add(bh);
            }
        }
        public void removeBookHistory(BookHistory bh)
        {
            if (bh == null)
                return;
            if (this.History != null)
                if (this.History.Contains(bh))
                {
                    this.History.Remove(bh);
                }
        }

        public void removeAllBookHistories()
        {
            if (History != null)
            {
                History.Clear();
            }
        }



        public void create_student()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_add_Students @id , @name, @age, @club , @yearlyGoal, @password, @archive"; 
            c.Parameters.AddWithValue("@id", this.Id);
            c.Parameters.AddWithValue("@name", this.Name);
            c.Parameters.AddWithValue("@age", this.Age);
            c.Parameters.AddWithValue("@club", this.Club.ToString());
            c.Parameters.AddWithValue("@yearlyGoal", this.YearlyGoal);
            c.Parameters.AddWithValue("@password", this.Password);
            c.Parameters.AddWithValue("@archive", this.Archive);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void update_Student()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_Student @id , @name, @age, @club , @yearlyGoal, @password, @archive";
            c.Parameters.AddWithValue("@id", this.Id);
            c.Parameters.AddWithValue("@name", this.Name);
            c.Parameters.AddWithValue("@age", this.Age);
            c.Parameters.AddWithValue("@club", this.Club.ToString());
            c.Parameters.AddWithValue("@yearlyGoal", this.YearlyGoal);
            c.Parameters.AddWithValue("@password", this.Password);
            c.Parameters.AddWithValue("@archive", this.Archive);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

    }
}