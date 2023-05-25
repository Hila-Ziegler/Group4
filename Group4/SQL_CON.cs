﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;//חשוב!
using System.Windows.Forms;//עבור ההודעות!
using System.Data;

namespace Group4
{
    class SQL_CON
    {
         SqlConnection conn;
        string Username = "ofirwij"


        public SQL_CON(){
            conn = new SqlConnection("Data Source=dbcourse.database.windows.net;Initial Catalog=SADM_4;Persist Security Info=True;User ID="+Username+"@bgufbm.onmicrosoft.com;Authentication=ActiveDirectoryPassword");//update this!!
        }

        public void execute_non_query(SqlCommand cmd){
           
            try
         {
             // open a connection object
             this.conn.Open();
             cmd.Connection = conn;
             cmd.ExecuteNonQuery();
             MessageBox.Show(" השאילתה בוצעה בהצלחה", "המשך", MessageBoxButtons.OK);
         }
            catch (Exception ex) {
                MessageBox.Show("שגיאה בביצוע השאילתה", "המשך", MessageBoxButtons.OK);
            }
           finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        public SqlDataReader execute_query(SqlCommand cmd){
            try
               {
                   // open a connection object
                     conn.Open();
                     cmd.Connection = conn;
                     SqlDataReader READER =cmd.ExecuteReader(); 
                     return READER;
              }
            catch (Exception ex)
               {
                MessageBox.Show("שגיאה בביצוע השאילתה", "המשך", MessageBoxButtons.OK);
                return null;
              }


        }

    }

}