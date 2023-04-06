﻿using _1.DAL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface INsxService
    {
        string Add(Nsx obj);
        string Update(Nsx obj);
        string Delete(Nsx obj);
        List<Nsx> GetAll();
        List<Nsx> GetAll(string input);
        Nsx GetById(Guid id);
        Guid GetIdFromTen(string ten);
    }
}
