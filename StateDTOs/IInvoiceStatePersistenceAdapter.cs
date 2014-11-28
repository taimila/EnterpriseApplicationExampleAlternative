using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDTOs
{
    public interface IInvoiceStatePersistenceAdapter
    {
        InvoiceStateDto GetById(Guid id);
        InvoiceStateDto GetByNumber(string invoiceNumber);

        void Save(InvoiceStateDto invoice);
    }
}
