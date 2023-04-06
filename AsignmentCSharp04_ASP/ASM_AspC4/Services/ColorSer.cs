﻿using ASM_AspC4.Models;
using ASM_AspC4.iServices;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Razor.Infrastructure;
using Microsoft.AspNetCore.Mvc.TagHelpers;

namespace ASM_AspC4.Services
{
    public class ColorSer : iColor
    {
        ShopDbContext dbContext;
        public ColorSer()
        {
            dbContext = new ShopDbContext();
        }

        public bool createColor(Color c)
        {
            try
            {
                dbContext.Colors.Add(c);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool deleteColor(Guid id)
        {
            try
            {
                var color=dbContext.Colors.Find(id);
                dbContext.Colors.Remove(color);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Color> getAllColor()
        {
            return dbContext.Colors.ToList();
        }

        public Color getById(Guid idColor)
        {
            return dbContext.Colors.FirstOrDefault(v => v.idColor == idColor);
        }

        public List<Color> getByName(string name)
        {
            return dbContext.Colors.Where(v=>v.nameColor.Contains(name)).ToList();  
        }

        public bool updateColor(Color c)
        {
            try
            {
                var color = dbContext.Colors.Find(c.idColor);
                color.nameColor = c.nameColor;
                color.statusColor = c.statusColor;
                dbContext.Colors.Update(color);
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
