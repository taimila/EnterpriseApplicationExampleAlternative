using System;

namespace Domain.Invoice
{
    public interface IInvoice
    {
        void ChangeDuedate(DateTime newDuedate);
    }
}
