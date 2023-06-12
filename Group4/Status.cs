using System;
using System.ComponentModel;

namespace Group4
{
    public enum Status
    {
        [Description ("Approved")]
        Approved,
        [Description("Declined")]
        Declined,
        [Description ("Open")]
        Open,
        [Description ("Closed")]
        Closed
    }
}