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
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Abiturient> Abiturient { get; set; }
        public virtual DbSet<Nas_pynkt> Nas_pynkt { get; set; }
        public virtual DbSet<Nationality> Nationality { get; set; }
        public virtual DbSet<Oblast_> Oblast_ { get; set; }
        public virtual DbSet<Shkola> Shkola { get; set; }
        public virtual DbSet<Special_nost_> Special_nost_ { get; set; }
        public virtual DbSet<Ylitsa> Ylitsa { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}
