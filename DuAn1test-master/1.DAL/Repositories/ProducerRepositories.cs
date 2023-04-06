using _1.DAL.Context;
using _1.DAL.Entities;
using _1.DAL.iRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class ProducerRepositories : IProducerRepositories
    {
        private List<Producer> _lstproducer;
        private DatabaseContext _context;
        public ProducerRepositories()
        {
            _lstproducer = new List<Producer>();
            _context = new DatabaseContext();
        }

        public bool AddProducer(Producer producer)
        {
            _context.Add(producer);
            _context.SaveChanges();
            return true;

        }

        public bool DeleteProducer(Producer producer)
        {
            _context.Remove(producer);
            _context.SaveChanges();
            return true;
        }

        public List<Producer> GetProducerFromDB()
        {
            _lstproducer = (from a in _context.Producers select a).ToList();
            return _lstproducer;
        }

        public bool UpdateProducer(Producer producer)
        {
            _context.Update(producer);
            _context.SaveChanges();
            return true;
        }
    }
}
