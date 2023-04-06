using ASM_AspC4.Models;

namespace ASM_AspC4.iServices
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
