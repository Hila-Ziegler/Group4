using System;
using System.Data.SqlClient;

namespace Group4
{
    public class Registration
    {
        private Student Student;
        private DateTime EventDate;
        private string GuestName;
        private bool ShowedUp;
        private string Review;
        private int Rating;
        private Event Event;
        private string oldDate;


        public Registration(Student Student, bool showedUp, string review, int rating, Event e, string oldDate, bool is_new)
        {
            this.Student = Student;
            this.ShowedUp = showedUp;
            this.Review = review;
            this.Rating = rating;
            if(oldDate == "\"\"")
            {
                this.oldDate = "";
            }
            else this.oldDate = oldDate;
            this.Event = e;
            this.EventDate = this.Event.get_date();
            this.GuestName = this.Event.get_guestName();
            if (is_new)
            {
                this.create_Registration();
                Program.registrations.Add(this);

            }
        }

        public Student get_student()
        {
            return this.Student;
        }
        public DateTime get_eventDate()
        {
            return this.EventDate;
        }

        public string get_guestName()
        {
            return this.GuestName;
        }

        public bool get_showedUp()
        {
            return this.ShowedUp;
        }

        public string get_review()
        {
            return this.Review;
        }

        public int get_rating()
        {
            return this.Rating;
        }

        public string get_oldDate()
        {
            return this.oldDate;
        }

        public Event GetEvent()
        {
            return this.Event;
        }

        public void set_Student(Student s)
        {
            this.Student = s;
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

        public void set_oldDate(string s)
        {
            this.oldDate = s;
        }

        public void setEvent(Event e)
        {
            this.Event = e;
        }

        public void create_Registration()
        {//
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_add_Registrations @id , @showedUp, @review, @rating, @number, @oldDate";
            c.Parameters.AddWithValue("@id", this.Student.get_ID());
            c.Parameters.AddWithValue("@showedUp", this.ShowedUp);
            c.Parameters.AddWithValue("@review", this.Review);
            c.Parameters.AddWithValue("@rating", this.Rating);
            c.Parameters.AddWithValue("@number", this.Event.getNum());
            c.Parameters.AddWithValue("@oldDate", this.oldDate);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void update_Registration()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_Registration @id , @showedUp, @review, @rating, @number, @oldDate";
            c.Parameters.AddWithValue("@id", this.Student.get_ID());
            c.Parameters.AddWithValue("@showedUp", this.ShowedUp);
            c.Parameters.AddWithValue("@review", this.Review);
            c.Parameters.AddWithValue("@rating", this.Rating);
            c.Parameters.AddWithValue("@number", this.Event.getNum());
            c.Parameters.AddWithValue("@oldDate", this.oldDate);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

    }
}