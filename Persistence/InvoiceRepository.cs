using MongoDB.Driver;
using MongoDB.Driver.Linq;
using StateDTOs;
using System;
using System.Linq;

namespace Persistence
{
    public class InvoiceRepository : MongoRepository, IInvoiceStatePersistenceAdapter
    {
        public InvoiceRepository(MongoClient mongo) : base(mongo) { }

        public InvoiceStateDto GetById(Guid id)
        {
            return Invoices.AsQueryable<InvoiceStateDto>()
                           .Single(c => c.Id == id);
        }

        public InvoiceStateDto GetByNumber(string invoiceNumber)
        {
            return Invoices.AsQueryable<InvoiceStateDto>()
                           .Single(c => c.Number == invoiceNumber);
        }

        public void Save(InvoiceStateDto invoice)
        {
            Invoices.Save(invoice);
        }

        MongoCollection<InvoiceStateDto> Invoices
        {
            get { return Database.GetCollection<InvoiceStateDto>("invoices"); }
        }
    }
}
