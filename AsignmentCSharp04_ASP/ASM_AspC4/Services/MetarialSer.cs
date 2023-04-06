using ASM_AspC4.Models;
using ASM_AspC4.iServices;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Razor.Infrastructure;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using System.Xml.Linq;

namespace ASM_AspC4.Services
{
    public class MetarialSer : iMetarial
    {
        ShopDbContext dbContext;
        public MetarialSer()
        {
            dbContext = new ShopDbContext();
        }

        public bool createMetarial(Metarial m)
        {
            try
            {
                dbContext.Metarial.Add(m);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool deleteMetarial(Guid id)
        {
            try
            {
                var metarial = dbContext.Metarial.Find(id);
                dbContext.Metarial.Remove(metarial);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Metarial> getAllMetarial()
        {
            return dbContext.Metarial.ToList();
        }

        public Metarial getById(Guid id)
        {
            return dbContext.Metarial.FirstOrDefault(v => v.idMetarial == id);
        }

        public bool updateMetarial(Metarial m)
        {
            try
            {
                var metarial = dbContext.Metarial.Find(m.idMetarial);
                metarial.nameMetarial = m.nameMetarial;
                metarial.statusMetarial = m.statusMetarial;
                dbContext.Metarial.Update(metarial);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
