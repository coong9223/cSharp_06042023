﻿using _1.DAL.DomainClass;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _2.BUS.IServices
{
    public interface IQLNsxService
    {
        string Add(NsxView obj);
        string Update(NsxView obj);
        string Delete(NsxView obj);
        List<NsxView> GetAll();
        List<NsxView> GetAll(string input);

        Nsx GetById(Guid id);
        Guid GetIdByName(string name);
    }
}
