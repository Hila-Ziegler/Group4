
using System;
using System.Data.SqlClient;

namespace Group4
{
    public class Librarian
    {
        private string Id;
        private string Name;
        private string Password;
        private bool Archive;
        public System.Collections.Generic.List<Request> requests;


        public Librarian(string id, string name, string password, bool archive, bool is_new)
        {
            this.Id = id;
            this.Name = name;
            this.Password = password;
            this.Archive = archive;
            this.requests = new System.Collections.Generic.List<Request>();
            if (is_new)
            {
                this.Password = Hash.GetHash(password);
                this.create_librarian();
                Program.librarians.Add(this);

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

        public void set_password(string password)
        {
            this.Password = Hash.GetHash(password);
        }

        public void set_archive(bool archive)
        {
            this.Archive = archive;
        }



        public void create_librarian()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_add_Librarians @id, @name, @password, @archive";
            c.Parameters.AddWithValue("@id", this.Id);
            c.Parameters.AddWithValue("@name", this.Name);
            c.Parameters.AddWithValue("@password", this.Password);
            c.Parameters.AddWithValue("@archive", this.Archive);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void update_librarian()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_Librarian  @id, @name, @password, @archive";
            c.Parameters.AddWithValue("@id", this.Id);
            c.Parameters.AddWithValue("@name", this.Name);
            c.Parameters.AddWithValue("@password", this.Password);
            c.Parameters.AddWithValue("@archive", this.Archive);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }



    }


}