using System;

namespace Domain.Invoice
{
    public interface IInvoiceRepository
    {
        IInvoice GetById(Guid id);
        IInvoice GetByNumber(string invoiceNumber);

        void Save(IInvoice invoice);
    }
}
