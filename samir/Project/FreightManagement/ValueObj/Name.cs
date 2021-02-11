using System;
using System.Diagnostics;

namespace FreightManagement.ValueObj
{
    [DebuggerDisplay("{First,nq} {Last,nq}")]
    public class Name
    {
        public string First { get; }

        public string Last { get; }

        public Name(string first, string last)
        {
            if (string.IsNullOrWhiteSpace(first)) throw new Exception("First name is invalid");
            if (string.IsNullOrWhiteSpace(last)) throw new Exception("Last name is invalid");

            First = first;
            Last = last;
        }
    }
}
