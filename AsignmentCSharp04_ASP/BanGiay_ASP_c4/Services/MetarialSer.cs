using BanGiay_ASP_c4.Models;
using BanGiay_ASP_c4.iServices;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Razor.Infrastructure;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.EntityFrameworkCore;

namespace BanGiay_ASP_c4.Services
{
    public class MetarialSer : iMetarial
    {

        ShopGiayDbContext dbContext;
        public MetarialSer()
        {
            dbContext = new ShopGiayDbContext();
        }
        public bool createMetarial(Metarial m)
        {
            try
            {
                dbContext.Metarials.Add(m);
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
                var metarial = dbContext.Metarials.Find(id);
                dbContext.Metarials.Remove(metarial);
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
            return dbContext.Metarials.ToList();
        }

        public Metarial getById(Guid id)
        {
            return dbContext.Metarials.FirstOrDefault(v => v.idMetarial == id);
        }

        public bool updateMetarial(Metarial m)
        {
            try
            {
                var metarial = dbContext.Metarials.Find(m.idMetarial);
                metarial.nameMetarial = m.nameMetarial;
                metarial.statusMetarial = m.statusMetarial;
                dbContext.Metarials.Update(metarial);
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
