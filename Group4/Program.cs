﻿using System;
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
        public static System.Collections.Generic.List<Librarian> librarians;
        public static System.Collections.Generic.List<Book> books;
        public static System.Collections.Generic.List<Copy> copies;
        public static System.Collections.Generic.List<Teacher> teachers;
        public static System.Collections.Generic.List<Student> students;
        public static System.Collections.Generic.List<BookHistory> bookHistories;
        public static System.Collections.Generic.List<Registration> registrations;
        public static System.Collections.Generic.List<Request> requests;
        public static System.Collections.Generic.List<BookInWaitlist> booksInWaitlist;
        public static System.Collections.Generic.List<Event> events;
        [STAThread]

        //שיטה שמחפשת עובד ברשימה לפי תעודת זהות
        public static Book seekBook(string serialNumber)
        {
            foreach (Book b in books)
            {
                if (b.get_sNumber() == serialNumber)
                    return b;
            }
            return null;
        }

        public static Teacher seekTeacher(string id)
        {
            foreach (Teacher t in teachers)
            {
                if (t.get_ID() == id)
                    return t;
            }
            return null;
        }

        public static Student seekStudent(string id)
        {
            foreach (Student s in students)
            {
                if (s.get_ID() == id)
                    return s;
            }
            return null;
        }

        public static Librarian seekLibrarian(string id)
        {
            foreach (Librarian l in librarians)
            {
                if (l.get_ID() == id)
                    return l;
            }
            return null;
        }

        //date, guestSpeakerName
        public static Event seekEvent(DateTime date, string guestName)
        {
            foreach (Event e in events)
            {
                if (e.get_guestName() == guestName && e.get_date() == date)
                    return e;
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
        }


        public static void init_Books()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Books";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            books = new List<Book>();

            while (rdr.Read())
            {
                Language l = (Language)Enum.Parse(typeof(Language), rdr.GetValue(4).ToString());
                Book b = new Book(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), int.Parse(rdr.GetValue(3).ToString()), l, float.Parse(rdr.GetValue(5).ToString()), bool.Parse(rdr.GetValue(6).ToString()), false);
                books.Add(b);
            }
        }

        public static void init_Librarians()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Librarians";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            librarians = new List<Librarian>();
            while (rdr.Read())
            {
                //Librarin l = new Librarin(seekWorker(rdr.GetValue(0).ToString(), int.Parse(rdr.GetValue(1).ToString()), DateTime.Parse((rdr.GetValue(2).ToString())), int.Parse(rdr.GetValue(3).ToString()), false);
                Librarian l = new Librarian(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), bool.Parse(rdr.GetValue(3).ToString()), false);
                librarians.Add(l);
                //seekWorker(rdr.GetValue(0).ToString()).AddOrders(o);
            }
        }
        public static void init_Copies()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Copies";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            books = new List<Book>();

            while (rdr.Read())
            {
                Language l = (Language)Enum.Parse(typeof(Language), rdr.GetValue(4).ToString());
                Copy co = new Copy(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), bool.Parse(rdr.GetValue(2).ToString()),  false);
                copies.Add(co);
                Book b = seekBook(co.get_serialNum());
                b.Copies.Add(co);
            }
        }

        public static void init_Teachers()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Teachers";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            teachers = new List<Teacher>();

            while (rdr.Read())
            {
                Teacher t = new Teacher(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), bool.Parse(rdr.GetValue(3).ToString()), false);
                teachers.Add(t);
            }
        }

        public static void init_Students()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Books";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            students = new List<Student>();

            while (rdr.Read())
            {
                Student s = new Student(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), int.Parse(rdr.GetValue(2).ToString()), rdr.GetValue(3).ToString(), int.Parse(rdr.GetValue(4).ToString()), rdr.GetValue(5).ToString(), bool.Parse(rdr.GetValue(6).ToString()), false);
                students.Add(s);
            }
        }
        
        public static void init_BookHistories()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_BookHistories";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            books = new List<Book>();

            while (rdr.Read())
            {
                Book b = seekBook(rdr.GetValue(1).ToString());
                Student s = seekStudent(rdr.GetValue(2).ToString());
                BookHistory bh = new BookHistory(int.Parse(rdr.GetValue(0).ToString()), b, s, DateTime.Parse(rdr.GetValue(3).ToString()), DateTime.Parse(rdr.GetValue(4).ToString()), false);
                b.History.Add(bh);
                s.History.Add(bh);
            }
        }

        public static void init_Events()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Events";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            events = new List<Event>();

            while (rdr.Read())
            {
                Language l = (Language)Enum.Parse(typeof(Language), rdr.GetValue(4).ToString());
                Event e = new Event(rdr.GetValue(0).ToString(),DateTime.Parse(rdr.GetValue(1).ToString()),float.Parse(rdr.GetValue(2).ToString()),rdr.GetValue(3).ToString(), int.Parse(rdr.GetValue(4).ToString()),int.Parse(rdr.GetValue(5).ToString()), false);
                events.Add(e);
            }
        }

        public static void init_Registrations()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Registrations";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            books = new List<Book>();

            while (rdr.Read())
            {
                Student s = seekStudent(rdr.GetValue(0).ToString());
                Registration r = new Registration(s, DateTime.Parse(rdr.GetValue(1).ToString()),rdr.GetValue(2).ToString(),bool.Parse(rdr.GetValue(3).ToString()),rdr.GetValue(4).ToString(), int.Parse(rdr.GetValue(5).ToString()), false);
                Event e = seekEvent(DateTime.Parse(rdr.GetValue(1).ToString()), rdr.GetValue(2).ToString());
                e.Registered.Add(s);
            }
        }



        public static void init_Requests()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Requests";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            requests = new List<Request>();

            while (rdr.Read())
            {
                Student s = seekStudent(rdr.GetValue(2).ToString());
                Librarian l = seekLibrarian(rdr.GetValue(6).ToString());
                Request r = new Request(rdr.GetValue(0).ToString(), DateTime.Parse(rdr.GetValue(1).ToString()), s, DateTime.Parse(rdr.GetValue(3).ToString()), rdr.GetValue(4).ToString(), rdr.GetValue(5).ToString(), l, false);
                l.requests.Add(r);
                s.requests.Add(r);
            }
        }
        //come back later
        public static void init_BooksInWaitlist()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_BookInWaitlist";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            booksInWaitlist = new List<BookInWaitlist>();

            while (rdr.Read())
            {
                Student s = seekStudent(rdr.GetValue(1).ToString());
                Book bo = seekBook(rdr.GetValue(2).ToString());
                BookInWaitlist b = new BookInWaitlist(DateTime.Parse(rdr.GetValue(0).ToString()), s, bo, false);
                booksInWaitlist.Add(b);
            }
        }

        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            init_Books();
            Console.WriteLine("Books made successfully");
            //initLists();
           // Console.WriteLine("lists made successfully");
            //Application.Run(new Form1());

        }
    }
}
