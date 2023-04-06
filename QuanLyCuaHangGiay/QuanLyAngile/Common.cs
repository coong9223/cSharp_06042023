using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyAngile
{
   public static class Common
    {
       public static QuanliAngileEntities db = new QuanliAngileEntities();
      public static string Connectionstring = @"Data Source=DESKTOP-H0KQCAN;Initial Catalog=QuanliAngile;Integrated Security=True";
    }
}
