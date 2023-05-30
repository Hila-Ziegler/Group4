using System;
using System.Data.SqlClient;

namespace Group4
{
    public class Event
    {
        private GuestType GuestType; //enum
        private DateTime Date;
        private float Price;
        private string GuestName;
        private Status status; //enum
        private int MaxGuests;
        private int CurrentlyRegistered;
        private Teacher Teacher;
        public System.Collections.Generic.List<Student> Registered;
        //public System.Collections.Generic.List<Order> orders;


        public Event(GuestType guestType, DateTime date, float price, string guestName, Status status, int maxGuests, int currentlyRegistered, bool is_new)
        {
            this.GuestType = guestType;
            this.Date = date;
            this.Price = price;
            this.GuestName = guestName;
            this.MaxGuests = maxGuests;
            this.CurrentlyRegistered = currentlyRegistered;
            this.Registered = new System.Collections.Generic.List<Student>();
            this.status = status;

            if (is_new)
            {
                this.create_Event();
                Program.events.Add(this);

            }
        }

        public GuestType get_guestType()
        {
            return this.GuestType;
        }
        public DateTime get_date()
        {
            return this.Date;
        }

        public float get_price()
        {
            return this.Price;
        }

        public string get_guestName()
        {
            return this.GuestName;
        }

        public int get_maxGuests()
        {
            return this.MaxGuests;
        }

        public int get_currentlyRegistered()
        {
            return this.CurrentlyRegistered;
        }

        public Teacher get_Teacher()
        {
            return this.Teacher;
        }

        public void set_guestType(GuestType guestType)
        {
            this.GuestType = guestType;
        }

        public void set_date(DateTime date)
        {
            this.Date = date;
        }

        public void set_price(float price)
        {
            this.Price = price;
        }

        public void set_guestName(string guestName)
        {
            this.GuestName = guestName;
        }

        public void set_maxGuests(int maxGuests)
        {
            this.MaxGuests = maxGuests;
        }

        public void set_currentlyRegistered(int currentlyRegistered)
        {
            this.CurrentlyRegistered = currentlyRegistered;
        }

        public void set_Teacher(Teacher t)
        {
            this.Teacher = t;
        }

       
        public void create_Event()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_add_Events @guestType,@date,@price,@guestSpeakerName , @status,@maxGuests,@currentlyRegistered";
            c.Parameters.AddWithValue("@guestType", this.GuestType.ToString());
            c.Parameters.AddWithValue("@date", this.Date);
            c.Parameters.AddWithValue("@price", this.Price);
            c.Parameters.AddWithValue("@guestSpeakerName", this.GuestName);
            c.Parameters.AddWithValue("@status", this.status.ToString());
            c.Parameters.AddWithValue("@maxGuests", this.MaxGuests);
            c.Parameters.AddWithValue("@currentlyRegistered", this.CurrentlyRegistered);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void update_Event()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_Event @guestType,@date,@price,@guestSpeakerName , @status,@maxGuests,@currentlyRegistered";
            c.Parameters.AddWithValue("@guestType", this.GuestType.ToString());
            c.Parameters.AddWithValue("@date", this.Date);
            c.Parameters.AddWithValue("@price", this.Price);
            c.Parameters.AddWithValue("@guestSpeakerName", this.GuestName);
            c.Parameters.AddWithValue("@status", this.status.ToString());
            c.Parameters.AddWithValue("@maxGuests", this.MaxGuests);
            c.Parameters.AddWithValue("@currentlyRegistered", this.CurrentlyRegistered);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }


    }
}