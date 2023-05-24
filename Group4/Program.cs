using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Group4
{

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static System.Collections.Generic.List<Librarian> Librarins;
        public static System.Collections.Generic.List<Book> Books;
        public static System.Collections.Generic.List<Copy> Copies;
        public static System.Collections.Generic.List<Teacher> Teachers;
        public static System.Collections.Generic.List<Student> Students;
        public static System.Collections.Generic.List<BookHistory> BookHistories;
        public static System.Collections.Generic.List<Registration> Registrations;
        public static System.Collections.Generic.List<Request> Requests;
        public static System.Collections.Generic.List<BookInWaitlist> BookInWaitlists;
        public static System.Collections.Generic.List<BookInWaitlist> BooksInWaitlist;
        [STAThread]

        //שיטה שמחפשת עובד ברשימה לפי תעודת זהות
        public static Book seekbook(string serialNumber)
        {
            foreach (Book b in Books)
            {
                if (b.get_sNumber() == serialNumber)
                    return b;
            }
            return null;
        }

        public static Teacher seekTeacher(string id)
        {
            foreach (Teacher t in Teachers)
            {
                if (t.getID() == id)
                    return t;
            }
            return null;
        }

        public static Student seekStudent(string id)
        {
            foreach (Student s in Students)
            {
                if (s.getID() == id)
                    return s;
            }
            return null;
        }

        public static Librarian seekLibrarian(string id)
        {
            foreach (Librarian l in Librarians)
            {
                if (l.getID() == id)
                    return l;
            }
            return null;
        }




        public static void initLists()//מילוי הרשימות מתוך בסיס הנתונים
        {
            init_Books();
            init_Librarians();
            init_Students();
            init_Teachers();
            init_Copies();
            init_Events();
            init_BooksInWaitlist();
            init_Registrations();
            init_BookHistories();
            init_Requests();
            // init_workers();//אתחול הרשימה של העובדים
            //init_orders();//אתחול הרשימה של ההזמנות
        }


        public static void init_Books()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Books";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Books = new List<Book>();

            while (rdr.Read())
            {
                Language l = (Language)Enum.Parse(typeof(Language), rdr.GetValue(4).ToString())
                Book b = new Book(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), int.Parse(rdr.GetValue(3).ToString()), l, float.Parse(rdr.GetValue(5).ToString()), bool.Parse(rdr.GetValue(6).ToString()), false);
                Books.Add(b);
            }
        }

        public static void init_Librarians()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Librarians";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            Librarins = new List<Order>();
            while (rdr.Read())
            {
                //Librarin l = new Librarin(seekWorker(rdr.GetValue(0).ToString(), int.Parse(rdr.GetValue(1).ToString()), DateTime.Parse((rdr.GetValue(2).ToString())), int.Parse(rdr.GetValue(3).ToString()), false);
                Librarian l = new Librarian(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), bool.Parse(rdr.GetValue(3).ToString(), false);
                Librarins.Add(l);
                //seekWorker(rdr.GetValue(0).ToString()).AddOrders(o);
            }
        }
        //come back later
        public static void init_Copies()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Books";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Books = new List<Book>();

            while (rdr.Read())
            {
                Language l = (Language)Enum.Parse(typeof(Language), rdr.GetValue(4).ToString())
                Book b = new Book(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), int.Parse(rdr.GetValue(3).ToString()), l, float.Parse(rdr.GetValue(5).ToString()), bool.Parse(rdr.GetValue(6).ToString()), false);
                Books.Add(b);
            }
        }

        public static void init_Teachers()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Books";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Teachers = new List<Teacher>();

            while (rdr.Read())
            {
                Teacher t = new Teacher(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), bool.Parse(rdr.GetValue(3).ToString()), false);
                Teachers.Add(t);
            }
        }

        public static void init_Students()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Books";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Students = new List<Student>();

            while (rdr.Read())
            {
                Student s = new Student(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), int.Parse(rdr.GetValue(2).ToString()), rdr.GetValue(3).ToString(), int.Parse(rdr.GetValue(4).ToString()), rdr.GetValue(5).ToString(), bool.Parse(rdr.GetValue(6).ToString()), false);
                Students.Add(s);
            }
        }

        public static void init_BookHistories()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Books";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Books = new List<Book>();

            while (rdr.Read())
            {
                Language l = (Language)Enum.Parse(typeof(Language), rdr.GetValue(4).ToString())
                Book b = new Book(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), int.Parse(rdr.GetValue(3).ToString()), l, float.Parse(rdr.GetValue(5).ToString()), bool.Parse(rdr.GetValue(6).ToString()), false);
                Books.Add(b);
            }
        }

        public static void init_Events()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Books";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Books = new List<Book>();

            while (rdr.Read())
            {
                Language l = (Language)Enum.Parse(typeof(Language), rdr.GetValue(4).ToString())
                Book b = new Book(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), int.Parse(rdr.GetValue(3).ToString()), l, float.Parse(rdr.GetValue(5).ToString()), bool.Parse(rdr.GetValue(6).ToString()), false);
                Books.Add(b);
            }
        }

        public static void init_Registrations()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Books";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Books = new List<Book>();

            while (rdr.Read())
            {
                Language l = (Language)Enum.Parse(typeof(Language), rdr.GetValue(4).ToString())
                Book b = new Book(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), int.Parse(rdr.GetValue(3).ToString()), l, float.Parse(rdr.GetValue(5).ToString()), bool.Parse(rdr.GetValue(6).ToString()), false);
                Books.Add(b);
            }
        }

        public static void init_Requests()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Books";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Books = new List<Book>();

            while (rdr.Read())
            {
                Language l = (Language)Enum.Parse(typeof(Language), rdr.GetValue(4).ToString())
                Book b = new Book(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), int.Parse(rdr.GetValue(3).ToString()), l, float.Parse(rdr.GetValue(5).ToString()), bool.Parse(rdr.GetValue(6).ToString()), false);
                Books.Add(b);
            }
        }

        public static void init_BooksInWaitlist()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Books";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Books = new List<Book>();

            while (rdr.Read())
            {
                Language l = (Language)Enum.Parse(typeof(Language), rdr.GetValue(4).ToString())
                Book b = new Book(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), int.Parse(rdr.GetValue(3).ToString()), l, float.Parse(rdr.GetValue(5).ToString()), bool.Parse(rdr.GetValue(6).ToString()), false);
                Books.Add(b);
            }
        }

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            initLists()
            Application.Run(new Form1());

        }
    }
}
