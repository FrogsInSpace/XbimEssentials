// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.ConstructionMgmtDomain;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcCrewResourceType
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcCrewResourceType : IIfcConstructionResourceType
	{
		IfcCrewResourceTypeEnum @PredefinedType { get;  set; }
	
	}
}

namespace Xbim.Ifc4.ConstructionMgmtDomain
{
	[ExpressType("IfcCrewResourceType", 1145)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCrewResourceType : IfcConstructionResourceType, IInstantiableEntity, IIfcCrewResourceType, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcCrewResourceType>
	{
		#region IIfcCrewResourceType explicit implementation
		IfcCrewResourceTypeEnum IIfcCrewResourceType.PredefinedType { 
 
			get { return @PredefinedType; } 
			set { PredefinedType = value;}
		}	
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCrewResourceType(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcCrewResourceTypeEnum _predefinedType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(12, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 21)]
		public IfcCrewResourceTypeEnum @PredefinedType 
		{ 
			get 
			{
				if(_activated) return _predefinedType;
				Activate();
				return _predefinedType;
			} 
			set
			{
				SetValue( v =>  _predefinedType = v, _predefinedType, value,  "PredefinedType", 12);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
				case 4: 
				case 5: 
				case 6: 
				case 7: 
				case 8: 
				case 9: 
				case 10: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 11: 
                    _predefinedType = (IfcCrewResourceTypeEnum) System.Enum.Parse(typeof (IfcCrewResourceTypeEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcCrewResourceType other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@OwnerHistory != null)
					yield return @OwnerHistory;
				foreach(var entity in @HasPropertySets)
					yield return entity;
				foreach(var entity in @BaseCosts)
					yield return entity;
				if (@BaseQuantity != null)
					yield return @BaseQuantity;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				foreach(var entity in @HasPropertySets)
					yield return entity;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}