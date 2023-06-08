using System;
using System.ComponentModel;

namespace Group4
{
    public enum Status
    {
        [Description ("Approved")]
        Approved,
        [Description ("Submitted")]
        Submitted,
        [Description("In process")]
        InProcess,
        [Description("Waiting for librarian response")]
        WaitingForLibrarianResponse,
        [Description("Declined")]
        Declined,
        [Description ("Open")]
        Open,
        [Description ("Closed")]
        Closed
    }
}