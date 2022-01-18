using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public class ReferanceBook : IBook
    {
        public string Author { get; set; }
        public string LibraryId { get; set; }
        public int Pages { get; set; }
        public string Title { get; set; }

    }
}
