﻿using _1.DAL.DomainClass;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2.BUS.IServices
{
    public interface IKhachHangService
    {
        string Add(KhachHangView obj);
        string Update(KhachHangView obj);
        string Delete(KhachHangView obj);
        List<KhachHangView> GetAll();
        List<KhachHangView> GetAll(string input);

        KhachHang GetById(Guid id);
        Guid GetIdByName(string name);
    }
}

