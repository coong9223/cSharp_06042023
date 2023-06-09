﻿using _1.DAL.DomainClass;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2.BUS.IServices
{
    public interface ICuaHangService
    {
        string Add(CuaHangView obj);
        string Update(CuaHangView obj);
        string Delete(CuaHangView obj);
        List<CuaHangView> GetAll();
        List<CuaHangView> GetAll(string input);

        List<string> GetThanhPhos();
        CuaHang GetById(Guid id);
        Guid GetIdByName(string name);
    }
}
