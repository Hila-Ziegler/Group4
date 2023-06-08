using System;
using System.ComponentModel;

namespace Group4
{
    public enum Club
    {
        [Description("The Bookies")]
        TheBookies,
        [Description("The Book Marks")]
        TheBookMarks,
        [Description("Book Besties")]
        BookBesties,
        [Description("Sequel Chasers")]
        SequelChasers,
        None
        /*        TheBookies,
                TheBookMarks,
                BookBesties,
                SequelChasers*/

    }
}