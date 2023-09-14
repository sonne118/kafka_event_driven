// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen, version 1.7.7.5
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace TimeOff.Models
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using global::Avro;
	using global::Avro.Specific;
	
	public partial class LeaveApplicationProcessed : ISpecificRecord
	{
		public static Schema _SCHEMA = Schema.Parse(@"{""type"":""record"",""name"":""LeaveApplicationProcessed"",""namespace"":""TimeOff.Models"",""fields"":[{""name"":""EmpEmail"",""type"":""string""},{""name"":""EmpDepartment"",""type"":""string""},{""name"":""LeaveDurationInHours"",""type"":""int""},{""name"":""LeaveStartDateTicks"",""type"":""long""},{""name"":""ProcessedBy"",""type"":""string""},{""name"":""Result"",""type"":""string""}]}");
		private string _EmpEmail;
		private string _EmpDepartment;
		private int _LeaveDurationInHours;
		private long _LeaveStartDateTicks;
		private string _ProcessedBy;
		private string _Result;
		public virtual Schema Schema
		{
			get
			{
				return LeaveApplicationProcessed._SCHEMA;
			}
		}
		public string EmpEmail
		{
			get
			{
				return this._EmpEmail;
			}
			set
			{
				this._EmpEmail = value;
			}
		}
		public string EmpDepartment
		{
			get
			{
				return this._EmpDepartment;
			}
			set
			{
				this._EmpDepartment = value;
			}
		}
		public int LeaveDurationInHours
		{
			get
			{
				return this._LeaveDurationInHours;
			}
			set
			{
				this._LeaveDurationInHours = value;
			}
		}
		public long LeaveStartDateTicks
		{
			get
			{
				return this._LeaveStartDateTicks;
			}
			set
			{
				this._LeaveStartDateTicks = value;
			}
		}
		public string ProcessedBy
		{
			get
			{
				return this._ProcessedBy;
			}
			set
			{
				this._ProcessedBy = value;
			}
		}
		public string Result
		{
			get
			{
				return this._Result;
			}
			set
			{
				this._Result = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this.EmpEmail;
			case 1: return this.EmpDepartment;
			case 2: return this.LeaveDurationInHours;
			case 3: return this.LeaveStartDateTicks;
			case 4: return this.ProcessedBy;
			case 5: return this.Result;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.EmpEmail = (System.String)fieldValue; break;
			case 1: this.EmpDepartment = (System.String)fieldValue; break;
			case 2: this.LeaveDurationInHours = (System.Int32)fieldValue; break;
			case 3: this.LeaveStartDateTicks = (System.Int64)fieldValue; break;
			case 4: this.ProcessedBy = (System.String)fieldValue; break;
			case 5: this.Result = (System.String)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
