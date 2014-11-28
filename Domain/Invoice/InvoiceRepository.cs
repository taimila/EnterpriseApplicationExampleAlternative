using StateDTOs;
using System;

namespace Domain.Invoice
{
    public class InvoiceRepository : IInvoiceRepository
    {
        InvoiceStateMapper mapper;
        IInvoiceStatePersistenceAdapter adapter;

        public InvoiceRepository(InvoiceStateMapper mapper,  IInvoiceStatePersistenceAdapter adapter)
        {
            this.mapper = mapper;
            this.adapter = adapter;
        }

        public IInvoice GetById(Guid id)
        {
            var dto = adapter.GetById(id);
            return mapper.FromStateDto(dto);
        }

        public IInvoice GetByNumber(string invoiceNumber)
        {
            var dto = adapter.GetByNumber(invoiceNumber);
            return mapper.FromStateDto(dto);
        }

        public void Save(IInvoice invoice)
        {
            var dto = mapper.ToStateDto(invoice);
        }
    }
}
