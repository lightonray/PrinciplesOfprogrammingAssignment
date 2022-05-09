using System;
using System.Collections.Generic;
using System.Text;

namespace POPA1
{
    class Address
    {
            public string address
            {
                get { return Street + ". " + City + ". " + Country; }
            }
            public string Street { get; set; }
            public string City { get; set; }
            public string Country { get; set; }
            public Address()
            {

            }
        }
}
