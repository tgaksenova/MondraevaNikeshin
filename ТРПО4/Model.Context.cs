﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ТРПО4
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }

        private static Entities _context;
        public static Entities GetContext()
        {
            if (_context == null)
                _context = new Entities();
            return _context;
        }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Abiturient> Abiturient { get; set; }
        public virtual DbSet<Nas_pynkt2> Nas_pynkt2 { get; set; }
        public virtual DbSet<Nationality2> Nationality2 { get; set; }
        public virtual DbSet<Oblast_2> Oblast_2 { get; set; }
        public virtual DbSet<Shkola2> Shkola2 { get; set; }
        public virtual DbSet<Specilnost2> Specilnost2 { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Ylitsa2> Ylitsa2 { get; set; }
    }
}
