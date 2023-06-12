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
        private Copy Copy;
       

        public Request(RequestType type, DateTime startDT, Student stud, Librarian lib, DateTime endDT, Status status,Copy c, bool is_new)
        {
            this.Type = type;
            this.StartDT = startDT;
            this.Student = stud;
            this.Librarian = lib;
            this.EndDT = endDT;
            this.Status = status;
            this.Copy = c;
            

            if (is_new)
            {
                this.create_Request();
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

        public Student get_Student()
        {
            return this.Student;
        }

        public Librarian get_Librarian()
        {
            return this.Librarian;
        }

        public DateTime get_endDT()
        {
            return this.EndDT;
        }

        public Status get_status()
        {
            return this.Status;
        }


        public Copy get_copy()
        {
            return this.Copy;
        }

        public void set_type(RequestType type)
        {
            this.Type = type;
        }

        public void set_startDT(DateTime startDT)
        {
            this.StartDT = startDT;
        }

        public void set_Student(Student s)
        {
            this.Student = s;
        }

        public void set_Librarian(Librarian l)
        {
            this.Librarian = l;
        }

        public void set_endDT(DateTime endDT)
        {
            this.EndDT = endDT;
        }

        public void set_status(Status status)
        {
            this.Status = status;
        }


        public void set_copy(Copy copy)
        {
            this.Copy = copy;
        }


        public void create_Request()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_add_Requests @type, @startDT, @sid, @lib, @endDT, @status, @serialNum, @copyNum";
            c.Parameters.AddWithValue("@type", this.Type.ToString());
            c.Parameters.AddWithValue("@startDT", this.StartDT.ToString("yyyy/MM/dd HH:mm:ss"));
            c.Parameters.AddWithValue("@sid", this.Student.get_ID());
            c.Parameters.AddWithValue("@lib", this.Librarian.get_ID());
            c.Parameters.AddWithValue("@endDT", this.EndDT.ToString("yyyy/MM/dd HH:mm:ss"));
            c.Parameters.AddWithValue("@status", this.Status.ToString());
            c.Parameters.AddWithValue("@serialNum", this.Copy.get_book().get_sNumber());
            c.Parameters.AddWithValue("@copyNum", this.Copy.get_copyNum());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void update_Request()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_Request @type, @startDT, @sid, @lib, @endDT, @status, @serialNum, @copyNum";
            c.Parameters.AddWithValue("@type", this.Type.ToString());
            c.Parameters.AddWithValue("@startDT", this.StartDT.ToString("yyyy/MM/dd HH:mm:ss"));
            c.Parameters.AddWithValue("@sid", this.Student.get_ID());
            c.Parameters.AddWithValue("@lib", this.Librarian.get_ID());
            c.Parameters.AddWithValue("@endDT", this.EndDT.ToString("yyyy/MM/dd HH:mm:ss"));
            c.Parameters.AddWithValue("@status", this.Status.ToString());
            c.Parameters.AddWithValue("@serialNum", this.Copy.get_book().get_sNumber());
            c.Parameters.AddWithValue("@copyNum", this.Copy.get_copyNum());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

    }
}