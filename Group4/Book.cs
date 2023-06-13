

using System;
using System.Data.SqlClient;
using System.Linq;

namespace Group4
{
    public class Book
    {
        private string SerialNumber;
        private string Title;
        private string author;
        private int PublishYear;
        private Language Language; //enum
        private float Rating;
        private bool Archive;
        public System.Collections.Generic.List<Copy> Copies;
        public System.Collections.Generic.List<BookHistory> History;


        public Book(string serialNumber, string title, string author, int publishYear, Language language, float rating, bool archive, bool is_new)
        {
            this.SerialNumber = serialNumber;
            this.Title = title;
            this.author = author;
            this.PublishYear = publishYear;
            this.Language = language;
            this.Rating = rating;
            this.Archive = archive;
            this.Copies = new System.Collections.Generic.List<Copy>();
            this.History = new System.Collections.Generic.List<BookHistory>();
            if (is_new)
            {
                this.create_Book();
                Program.books.Add(this);

            }
        }

        //getters

        public string get_sNumber()
        {
            return this.SerialNumber;
        }
        public string get_author()
        {
            return this.author;
        }

        public string get_title()
        {
            return this.Title;
        }

        public int get_PYear()
        {
            return this.PublishYear;
        }

        public Language get_lang()
        {
            return this.Language;
        }

        public float get_rating()
        {
            return this.Rating;
        }

        public bool get_archive()
        {
            return this.Archive;
        }
        //setters


        public void set_sNumber(string serialNumber)
        {
            this.SerialNumber = serialNumber;
        }
        public void set_author(string author)
        {
            this.author = author;
        }

        public void set_title(string title)
        {
            this.Title = title;
        }

        public void set_PYear(int publishYear)
        {
            this.PublishYear = publishYear;
        }

        public void set_lang(Language language)
        {
            this.Language = language;
        }

        public void set_rating(float rating)
        {
            this.Rating = rating;
        }

        public void set_archive(bool archive)
        {
            this.Archive = archive;
        }


        public void addCopy(Copy c)
        {
            if (c == null)
                return;
            if (!this.Copies.Contains(c))
            {
                this.Copies.Add(c);
            }
        }
        public void removeCopy(Copy c)
        {
            if (c == null)
                return;
            if (this.Copies != null)
                if (this.Copies.Contains(c))
                {
                    this.Copies.Remove(c);
                }
        }

        public void removeAllCopies()
        {
            if (Copies != null)
            {
                Copies.Clear();
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





        public void create_Book()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_add_Books @serialNumber, @title, @author, @publishYear, @language, @rating, @arcive";
            c.Parameters.AddWithValue("@serialNumber", this.SerialNumber);
            c.Parameters.AddWithValue("@title", this.Title);
            c.Parameters.AddWithValue("@author", this.author);
            c.Parameters.AddWithValue("@publishYear", this.PublishYear);
            c.Parameters.AddWithValue("@language", this.Language.ToString());
            c.Parameters.AddWithValue("@rating", this.Rating);
            c.Parameters.AddWithValue("@arcive", this.Archive);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void update_Book()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_Book @serialNumber, @title , @author, @publishYear , @language, @rating, @arcive";
            c.Parameters.AddWithValue("@serialNumber", this.SerialNumber);
            c.Parameters.AddWithValue("@title", this.Title);
            c.Parameters.AddWithValue("@author", this.author);
            c.Parameters.AddWithValue("@publishYear", this.PublishYear);
            c.Parameters.AddWithValue("@language", this.Language.ToString());
            c.Parameters.AddWithValue("@rating", this.Rating);
            c.Parameters.AddWithValue("@arcive", this.Archive);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public int countCopies()
        {
            return this.Copies.Count();
        }

        public int countCopiesNotDeleted()
        {
            int count = 0;
            foreach(Copy c in this.Copies)
            {
                if (!c.get_deleted())
                {
                    count++;
                }
            }
            return count;
        }

        public void calculateAverageRating()
        {
            float count=0;
            float ratingSum=0;
            foreach (BookHistory bh in this.History)
            {
                if (bh.get_EndDate() != new DateTime())
                {
                    count+=1;
                    ratingSum += bh.get_rate();

                }
            }

            float a = ratingSum / count;
            this.set_rating(a) ;
        }

        public bool isAvailable()
        {
            foreach (Copy c in this.Copies)
            {
                if (!c.get_status())
                {
                    return true;
                }
            }
            return false;
        }


    }
}