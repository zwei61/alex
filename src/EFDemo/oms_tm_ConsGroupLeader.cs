//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFDemo
{
    using System;
    using System.Collections.Generic;
    
    public partial class oms_tm_ConsGroupLeader
    {
        public System.Guid ConsGroupLeaderID { get; set; }
        public System.Guid CompanyID { get; set; }
        public System.Guid ConsTeamID { get; set; }
        public string ConsTeamGroupLeaderName { get; set; }
        public Nullable<int> Sex { get; set; }
        public string Phone { get; set; }
        public string IDCard { get; set; }
        public string Address { get; set; }
        public string Level { get; set; }
        public string Status { get; set; }
        public Nullable<int> WorkerNum { get; set; }
        public Nullable<int> WorkingNum { get; set; }
        public Nullable<int> StandbyNum { get; set; }
        public Nullable<int> WorkingSite { get; set; }
        public Nullable<int> MinWorkSite { get; set; }
        public Nullable<int> MaxWorkSite { get; set; }
        public Nullable<int> MinOrderNum { get; set; }
        public Nullable<int> MaxOrderNum { get; set; }
        public Nullable<int> LaborContract { get; set; }
        public Nullable<System.DateTime> JoinDate { get; set; }
        public Nullable<System.DateTime> LeaveDate { get; set; }
        public Nullable<int> CustomerSatisfaction { get; set; }
        public string EmergencyContact { get; set; }
        public string EmergencyPhone { get; set; }
        public string EmergencyAddress { get; set; }
        public string Memo { get; set; }
        public Nullable<System.Guid> CreateBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.Guid> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<bool> IsObsoleted { get; set; }
    }
}
