using System;
using System.ComponentModel;

namespace Group4
{
    public enum Status
    {
        approved,
        submitted,
        [Description("in process")]
        inProcess,
        [Description("waiting for librarian response")]
        waitingForLibrarianResponse,
        declined
    }
}