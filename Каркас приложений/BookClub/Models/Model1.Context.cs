﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookClub.Models
{
    using System;
    using System.Collections;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class bookclubEntities : DbContext
    {

        private static bookclubEntities _context;
        public bookclubEntities()
            : base("name=bookclubEntities")
        {
        }

        public static bookclubEntities GetContext()
        {
            if (_context == null)
                _context = new bookclubEntities();
            return _context;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        

        public virtual DbSet<merch> merch { get; set; }
        public virtual DbSet<orders> orders { get; set; }
        public virtual DbSet<point> point { get; set; }
        public virtual DbSet<sostav> sostav { get; set; }
        public virtual DbSet<status> status { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<type_user> type_user { get; set; }
        public virtual DbSet<users> users { get; set; }
    }
}
