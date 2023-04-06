using _1.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.iRepositories
{
    public interface IProducerRepositories
    {
        bool AddProducer(Producer producer);
        bool UpdateProducer(Producer producer);
        bool DeleteProducer(Producer producer);
        List<Producer> GetProducerFromDB();
    }
}
