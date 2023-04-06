using BanGiay_ASP_c4.Models;

namespace BanGiay_ASP_c4.iServices
{
    public interface iMetarial
    {
        public bool createMetarial(Metarial m);
        public bool updateMetarial(Metarial m);
        public bool deleteMetarial(Guid id);
        public List<Metarial> getAllMetarial();
        public Metarial getById(Guid id);
    }
}
