using System;
using System.ComponentModel;

namespace Group4
{
    public enum Status
    {
        Approved,
        Submitted,
        [Description("In process")]
        InProcess,
        [Description("Waiting for librarian response")]
        WaitingForLibrarianResponse,
        Declined,
        Open
    }
}