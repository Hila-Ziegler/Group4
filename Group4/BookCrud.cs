using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group4
{
    public partial class BookCrud : Form
    {
        private Book b = null;
        private string sn = "";
        public System.Collections.Generic.List<Copy> copies = null;
        private  int serialNumLength= 8;
        Librarian librarian;
        public BookCrud(string s, Librarian libr)
        {
            librarian = libr;
            System.Collections.Generic.List<Copy> allCopies = Program.copies;
            this.copies = Program.copies;
            this.sn = s;
            this.copies = this.filterCopyList(allCopies, s);

            InitializeComponent();
        }

        public BookCrud(String s, Book b, Librarian libr)
        {
            librarian = libr;
            System.Collections.Generic.List<Copy> allCopies = Program.copies;
            this.copies = Program.copies;
            this.b = b;
            this.sn = s;
            this.copies = this.filterCopyList(allCopies, b.get_sNumber());

            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void BookCrudHomePage_Click(object sender, EventArgs e)
        {
            LibrarianChooseAction form8 = new LibrarianChooseAction(librarian);
            form8.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["CopyNum"].Index)
            {
                int i = e.RowIndex;
                int copyNum = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                Copy c = null;
                foreach (Copy co in copies)
                {
                    if (co.get_copyNum() == copyNum){
                        c = co;
                    }
                }
                CopyCrud form11 = new CopyCrud(c, librarian);
                form11.Show();
                this.Hide();
            }
        }


        private System.Collections.Generic.List<Copy> filterCopyList(System.Collections.Generic.List<Copy> li,String sn)
        {
            System.Collections.Generic.List<Copy> ans = new System.Collections.Generic.List<Copy>();
            foreach (Copy c in li)
            {
            if (c.get_book().get_sNumber() == sn){
                    ans.Add(c);
                }
            }
            return ans;
        }

        private void update_CopyList()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = this.copies;
            int i = 0;
            foreach (Copy c in this.copies)
            {
                if (c.get_book().get_sNumber() == sn && c.get_deleted() == false)
                {
                    if (i < dataGridView1.Rows.Count)
                    {
                    this.dataGridView1.Rows[i].Cells[0].Value = c.get_copyNum();
                    this.dataGridView1.Rows[i].Cells[1].Value = c.get_status();
                    this.dataGridView1.Rows[i].Cells[2].Value = "Delete";
                    }
                    else
                    {
                    dataGridView1.Rows.Add(c.get_copyNum(), c.get_status());
                    }
                    i++;  
                }
            }
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void Load_Enum()
        {
            List<KeyValuePair<string, string>> lstLng = new List<KeyValuePair<string, string>>();
            Array Languages = Enum.GetValues(typeof(Language));
            foreach (Language Language in Languages)
            {
                lstLng.Add(new KeyValuePair<string, string>(Language.ToString(), ((int)Language).ToString()));
            }
            LngCombo.DataSource = lstLng;
            LngCombo.DisplayMember = "Key";
            LngCombo.ValueMember = "Value";
        }

        private void BookCrud_Load(object sender, EventArgs e)
        {

            if (sn != "update" && sn != null)
            {
                ManageWaitlist1.Hide();
                if (this.librarian != null)
                {
                    ManageWaitlist1.Show();
                }
                if (Program.seekBook(sn).isAvailable())
                {
                    Avilabletxt.Text = "Available";
                    Avilabletxt.ForeColor = Color.Green;
                }
                else
                {
                    Avilabletxt.Text = "Unavailable";
                    Avilabletxt.ForeColor = Color.Red;
                }
                BringBackFromArchieve.Hide();
                ISBNTextBox.Hide();
                AuthorTextBox.Hide();
                PublishYearTextBox.Hide();
                CreateNewBook.Hide();
                Titlelbl.Hide();
                TitleTextBox.Hide();
                btnUpdateBook.Hide();
                LngCombo.Hide();

                this.b = Program.seekBook(sn);
                lb_ISBN_value.Text = sn;
                lb_AuthorValue.Text = b.get_author();
                lb_PublishYearValue.Text = b.get_PYear().ToString();
                lb_LangueageValue.Text = b.get_lang().ToString();
                lb_RatingValue.Text = b.get_rating().ToString();
                BookCrudTitle.Text = b.get_title();

                this.update_CopyList();
                if (b.get_archive())
                {
                    dataGridView1.Hide();
                    bookCrudAddNewCopy.Hide();
                    BringBackFromArchieve.Show();
                }
            }
            else if (sn == "update")
            {
                Load_Enum();
                BringBackFromArchieve.Hide();
                Titlelbl.Hide();
                ISBNTextBox.Hide();
                TitleTextBox.Hide();
                lb_AuthorValue.Hide();
                lb_PublishYearValue.Hide();
                lb_LangueageValue.Hide();
                CreateNewBook.Hide();
                BookCrudUpdateBTN.Hide();
                BookCrudDeleteBTN.Hide();
                bookCrudAddNewCopy.Hide();
                dataGridView1.Hide();
                BookCrudTitle.Text = b.get_title();
                AuthorTextBox.Text = b.get_author();
                PublishYearTextBox.Text = b.get_PYear().ToString();
                LngCombo.Text = b.get_lang().ToString();
                updateScreenratinglbl.Text = b.get_rating().ToString();
                ISBNUpdateScreen.Text = b.get_sNumber();
                
        }
            else
            {
                BringBackFromArchieve.Hide();
                BookCrudUpdateBTN.Hide();
                BookCrudDeleteBTN.Hide();
                bookCrudAddNewCopy.Hide();
                dataGridView1.Hide();
                BookCrudTitle.Hide();
                Ratinglbl.Hide();
                btnUpdateBook.Hide();
                Load_Enum();
            }





        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bookCrudAddNewCopy_Click(object sender, EventArgs e)
        {
            if (this.b != null)
            {
                    Func<Copy, int> fieldSelector = copy => copy.get_copyNum();
                    int maxFieldValue = this.copies.Max(fieldSelector);
                    Copy c = new Copy(maxFieldValue + 1, b, false, false, true);
                    b.addCopy(c);
                    this.copies.Add(c);
                    this.update_CopyList();
             

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.checkIfValid())
            {
                Language l = (Language)Enum.Parse(typeof(Language), LngCombo.Text);
                Book b = new Book(ISBNTextBox.Text, TitleTextBox.Text, AuthorTextBox.Text, int.Parse(PublishYearTextBox.Text), l, 0, false, true);
                Copy c = new Copy(1, b, false, true, false);
                b.Copies.Add(c);

                BookCrud form12 = new BookCrud(b.get_sNumber(), librarian);
                form12.Show();
                this.Hide();
            }
        }

        private bool checkIfValid()
        {
            BookCrudErrorWindow bc;
            if (ISBNTextBox.Text == "" || PublishYearTextBox.Text == "" || TitleTextBox.Text == "" || AuthorTextBox.Text == "")
            {
                String s = $"Not all required information entered, \nPlease try again";
                bc = new BookCrudErrorWindow(s, this, librarian);
                bc.Show();
                return false;
            }


            if (ISBNTextBox.Text.Length > serialNumLength)
            {
                // Error Window
                String s = $"Serial number is longer than expected, \nPlease enter a valid number of characters,\nmax allowed length is: {serialNumLength}";
                bc = new BookCrudErrorWindow(s,this, librarian);
                bc.Show();
                return false;
            }
            else if (int.Parse(PublishYearTextBox.Text) > DateTime.Now.Year)
            {
                //Error Window
                String s = $"Publish year cannot exceed current year, \nPlease enter a valid year";
                bc = new BookCrudErrorWindow(s,this,librarian);
                bc.Show();
                return false;
            }
            return true;
        }

        private void BookCrudUpdateBTN_Click(object sender, EventArgs e)
        {
            BookCrud update = new BookCrud("update", b, librarian);
            update.Show();
            this.Hide();
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            this.b.set_author(AuthorTextBox.Text);
            this.b.set_PYear(int.Parse(PublishYearTextBox.Text));
            this.b.set_lang((Language)Enum.Parse(typeof (Language), LngCombo.Text));
            this.b.update_Book();
            BookCrud updated = new BookCrud(b.get_sNumber(), librarian);
            updated.Show();
            this.Hide();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void BookCrudDeleteBTN_Click(object sender, EventArgs e)
        {
            AreYouSure form14 = new AreYouSure(b,this, librarian);
            form14.Show();
        }

        private void BringBackFromArchieve_Click(object sender, EventArgs e)
        {
            this.b.set_archive(false);
            this.b.update_Book();
            this.Hide();
            ManageBooks form16 = new ManageBooks(librarian);
            form16.Show();

        }

        private void languageTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Language v = (Language)this.LngCombo.SelectedValue;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e) // change this dahof
        {
            if (e.ColumnIndex == dataGridView1.Columns["Actions"].Index)
            {
                int i = e.RowIndex;
                int cNum = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                Copy c = Program.seekCopy(this.b, cNum);
                if (this.b.countCopies() == 1)
                {
                    c.set_deleted(true);
                    c.update_Copy();
                    this.b.set_archive(true);
                    this.b.update_Book();
                    this.Hide();
                    ManageBooks form16 = new ManageBooks(librarian);
                    form16.Show();
                }
                else
                {
                    c.set_deleted(true);
                    c.update_Copy();
                    this.BookCrud_Load(sender, e);
                }
            }
        }

        private void ManageWaitlist_Click(object sender, EventArgs e)
        {
            ManageWaitList mwl = new ManageWaitList(this.b);
            mwl.Show();

        }
    }
}
