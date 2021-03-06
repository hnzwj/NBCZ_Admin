//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由T4模板自动生成
//	   生成时间 2018-07-05 10:16:48
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失
//     作者：Harbour CTS
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using DapperExtensions.Mapper;
using Newtonsoft.Json;
namespace NBCZ.Model
{	
    [JsonObject(MemberSerialization.OptIn)]
    public partial class Pub_Department:BaseEntity<Pub_Department>
    {
        public Pub_Department()
        {
          //varchar主键 报错At least one Key column must be defined.
          Map(x => x.DeptCode).Key(KeyType.Assigned);
          AutoMap();
        }
    		 /// <summary>
     	/// 部门编号
     	/// </summary>
        [JsonProperty]	
		public string DeptCode { get; set; }

		 /// <summary>
     	/// 部门名称
     	/// </summary>
        [JsonProperty]	
		public string DeptName { get; set; }

		 /// <summary>
     	/// 备注
     	/// </summary>
        [JsonProperty]	
		public string Remark { get; set; }

		 /// <summary>
     	/// 上级部门编号
     	/// </summary>
        [JsonProperty]	
		public string ParentCode { get; set; }

		 /// <summary>
     	/// 部门级别
     	/// </summary>
        [JsonProperty]	
		public int DeptLevel { get; set; }

		 /// <summary>
     	/// 最后编辑人
     	/// </summary>
        [JsonProperty]	
		public string Lmid { get; set; }

		 /// <summary>
     	/// 最后编辑时间
     	/// </summary>
        [JsonProperty]	
		public DateTime? Lmdt { get; set; }

		 /// <summary>
     	/// 停用状态 默认0 未停用 1 停用
     	/// </summary>
        [JsonProperty]	
		public bool? StopFlag { get; set; }

		   
    }
}

