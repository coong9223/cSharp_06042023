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
    public class ImportHistoryRepositories : IImportHistoryRepositories
    {
        private List<ImportHistory> _lstImportHistory;
        private DatabaseContext _context;
        public ImportHistoryRepositories()
        {
            _lstImportHistory = new List<ImportHistory>();

            _context = new DatabaseContext();
        }

        public bool AddImportHistory(ImportHistory importHistory)
        {
            _context.Add(importHistory);
            _context.SaveChanges();
            return true;
        }


        public bool DeleteImportHistory(ImportHistory importHistory)
        {
            _context.Remove(importHistory);
            _context.SaveChanges();
            return true;
        }


        public List<ImportHistory> GetImportHistoryFromDB()
        {
            _lstImportHistory = (from a in _context.ImportHistories
                                 select a).ToList();
            return _lstImportHistory;
        }

        public bool UpdateImportHistory(ImportHistory importHistory)
        {
            _context.Update(importHistory);
            _context.SaveChanges();
            return true;
        }
    }
}
