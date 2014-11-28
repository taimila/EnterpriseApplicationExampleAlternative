using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDTOs
{
    public class InvoiceStateDto
    {
        public Guid Id { get; set; }
        public string Number { get; set; }
        public DateTime Duedate { get; set; }
    }
}
