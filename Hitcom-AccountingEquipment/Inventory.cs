//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Inventory
    {
        public int id { get; set; }
        public int FK_Room_id { get; set; }
        public int FK_StatusOfInventory_id { get; set; }
        public int FK_Worker_id { get; set; }
        public int FK_EquipmentCard_id { get; set; }
        public System.DateTime InventoryDate { get; set; }
        public string Comment { get; set; }
    
        public virtual EquipmentCard EquipmentCard { get; set; }
        public virtual Room Room { get; set; }
        public virtual StatusOfInventory StatusOfInventory { get; set; }
        public virtual Worker Worker { get; set; }
    }
}