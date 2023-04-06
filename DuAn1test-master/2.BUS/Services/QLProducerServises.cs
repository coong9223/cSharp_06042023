
using _1.DAL.Entities;
using _1.DAL.iRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class QLProducerServises : IQLProducerServices
    {
        private IProducerRepositories _iqlProducer;
        private List<Producer> _lstProducer;
        public QLProducerServises()
        {
            _iqlProducer = new ProducerRepositories() ;
            _lstProducer = new List<Producer>() ;
        }
    
        public bool AddProducer(Producer producer)
        {
            _iqlProducer.AddProducer(producer);
            return true;
        }

        public bool DeleteProducer(Producer producer)
        {
            _iqlProducer.DeleteProducer(producer);
            return true;
        }

        public List<Producer> GetProducerFromDB()
        {
            _lstProducer = _iqlProducer.GetProducerFromDB();
            return _lstProducer;
        }

        public bool UpdateProducer(Producer producer)
        {
            _iqlProducer.UpdateProducer(producer);
            return true;
        }
    }
}
