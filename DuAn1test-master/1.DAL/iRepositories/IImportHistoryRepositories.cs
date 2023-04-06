using _1.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.iRepositories
{
    public interface IImportHistoryRepositories
    {
        bool AddImportHistory(ImportHistory importHistory);
        bool UpdateImportHistory(ImportHistory importHistory);
        bool DeleteImportHistory(ImportHistory importHistory);
        List<ImportHistory> GetImportHistoryFromDB();
    }
}
