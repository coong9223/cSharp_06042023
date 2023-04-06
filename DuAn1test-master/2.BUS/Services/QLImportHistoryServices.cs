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
    public class QLImportHistoryServices : IQLImportHistoryServices
    {
        private IImportHistoryRepositories _iQLImportHistory; //gọi tầng 1 xuống để làm việc với data
        private List<ImportHistory> _lstimportHistories;
        public QLImportHistoryServices()
        {
            _iQLImportHistory = new ImportHistoryRepositories();
            _lstimportHistories = new List<ImportHistory>();
        }
        public bool AddImportHistory(ImportHistory importHistory)
        {
            _iQLImportHistory.AddImportHistory(importHistory);
            return true;
        }

        public bool DeleteImportHistory(ImportHistory importHistory)
        {
            _iQLImportHistory.DeleteImportHistory(importHistory);
            return true;
        }

        public List<ImportHistory> GetImportHistoryFromDB()
        {
            _lstimportHistories = _iQLImportHistory.GetImportHistoryFromDB();
            return _lstimportHistories;
        }

        public bool UpdateImportHistory(ImportHistory importHistory)
        {
            _iQLImportHistory.UpdateImportHistory(importHistory);
            return true;
        }
    }
}
