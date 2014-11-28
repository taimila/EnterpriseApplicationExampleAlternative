using StateDTOs;

namespace Domain.Invoice
{
    public class InvoiceStateMapper
    {
        public IInvoice FromStateDto(InvoiceStateDto dto)
        {
            return new Invoice
            {
                Id = dto.Id,
                Number = dto.Number,
                Duedate = dto.Duedate
            };
        }

        public InvoiceStateDto ToStateDto(IInvoice entity)
        {
            var i = entity as Invoice;

            return new InvoiceStateDto
            {
                Id = i.Id,
                Number = i.Number,
                Duedate = i.Duedate
            };
        }
    }
}
