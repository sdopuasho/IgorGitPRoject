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
    
    public partial class OperationHystory
    {
        public int id { get; set; }
        public int FK_Worker_id { get; set; }
        public string Operation { get; set; }
        public System.DateTime DateTimeOfOperation { get; set; }
    
        public virtual Worker Worker { get; set; }
    }
}
