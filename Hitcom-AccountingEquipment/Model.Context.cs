﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hitcom_AccountingEquipment
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AccountingEquipmentEntities : DbContext
    {
        public static AccountingEquipmentEntities _context;
        public AccountingEquipmentEntities()
            : base("name=AccountingEquipmentEntities")
        {
        }
        public static AccountingEquipmentEntities GetContext() {
            if (_context == null)
                _context = new AccountingEquipmentEntities();
            return _context;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Breakdown> Breakdown { get; set; }
        public virtual DbSet<Equipment> Equipment { get; set; }
        public virtual DbSet<EquipmentCard> EquipmentCard { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<Manufacturer> Manufacturer { get; set; }
        public virtual DbSet<Nomenclature> Nomenclature { get; set; }
        public virtual DbSet<OperationHystory> OperationHystory { get; set; }
        public virtual DbSet<Position> Position { get; set; }
        public virtual DbSet<Repair> Repair { get; set; }
        public virtual DbSet<Room> Room { get; set; }
        public virtual DbSet<ServiceOrganization> ServiceOrganization { get; set; }
        public virtual DbSet<StatusEquipInRepair> StatusEquipInRepair { get; set; }
        public virtual DbSet<StatusOfEquipment> StatusOfEquipment { get; set; }
        public virtual DbSet<StatusOfInventory> StatusOfInventory { get; set; }
        public virtual DbSet<StatusOfWorker> StatusOfWorker { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TypeOfNomenclature> TypeOfNomenclature { get; set; }
        public virtual DbSet<TypeOfRoom> TypeOfRoom { get; set; }
        public virtual DbSet<Worker> Worker { get; set; }
    }
}
