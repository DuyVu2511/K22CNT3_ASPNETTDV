using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TDVLesson06CF.Models
{
    public class TDVBookStore:DbContext
    {
        public TDVBookStore() : base("TDVBookStoreConnectionString") { }

        //Khai bao cac thuoc tinh tuong ung voi cac  bang trong csdl
        public DbSet<TDVCategory> TDVCategories { get; set; }
        public DbSet<TDVBook> TDVBooks { get; set; }

    }
}