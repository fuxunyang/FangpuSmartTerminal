﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace fangpu_terminal
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FangpuDatacenterModelEntities : DbContext
    {
        public FangpuDatacenterModelEntities()
            : base("name=FangpuDatacenterModelEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<deviceinfo> deviceinfo { get; set; }
        public virtual DbSet<operationlog> operationlog { get; set; }
        public virtual DbSet<bandchecklist> bandchecklist { get; set; }
        public virtual DbSet<dailychecklist> dailychecklist { get; set; }
        public virtual DbSet<fieldchecklist> fieldchecklist { get; set; }
        public virtual DbSet<historydata> historydata { get; set; }
        public virtual DbSet<userinfo> userinfo { get; set; }
        public virtual DbSet<proceduretechnologybase_work> proceduretechnologybase_work { get; set; }
        public virtual DbSet<proceduretechnologybase> proceduretechnologybase { get; set; }
        public virtual DbSet<historydata_1200> historydata_1200 { get; set; }
        public virtual DbSet<warn_info> warn_info { get; set; }
        public virtual DbSet<haltinfo> haltinfo { get; set; }
        public virtual DbSet<historydata_jsoncopy> historydata_jsoncopy { get; set; }
        public virtual DbSet<realtimedata> realtimedata { get; set; }
    }
}