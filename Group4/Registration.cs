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


        public Registration(Student Student, DateTime eventDate, string guestName, bool showedUp, string review, int rating, bool is_new)
        {
            this.Student = Student;
            this.EventDate = eventDate;
            this.GuestName = guestName;
            this.ShowedUp = showedUp;
            this.Review = review;
            this.Rating = rating;

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

        public void create_Registration()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_add_Registrations @id , @eventDate, @guestSpeakerName, @showedUp, @review, @rating";
            c.Parameters.AddWithValue("@id", this.Student.get_ID());
            c.Parameters.AddWithValue("@eventDate", this.EventDate);
            c.Parameters.AddWithValue("@guestSpeakerName", this.GuestName);
            c.Parameters.AddWithValue("@showedUp", this.ShowedUp);
            c.Parameters.AddWithValue("@review", this.Review);
            c.Parameters.AddWithValue("@rating", this.Rating);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void update_Registration()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_Registration @id , @eventDate, @guestSpeakerName, @showedUp, @review, @rating";
            c.Parameters.AddWithValue("@id", this.Student.get_ID());
            c.Parameters.AddWithValue("@eventDate", this.EventDate);
            c.Parameters.AddWithValue("@guestSpeakerName", this.GuestName);
            c.Parameters.AddWithValue("@showedUp", this.ShowedUp);
            c.Parameters.AddWithValue("@review", this.Review);
            c.Parameters.AddWithValue("@rating", this.Rating);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

    }
}