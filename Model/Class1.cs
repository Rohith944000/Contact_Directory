using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ulong PhoneNumber { get; set; }

        public override string ToString()
        {
            return string.Format("{0},{1},{2}", this.FirstName, this.LastName, this.PhoneNumber);
        }
    }
}
