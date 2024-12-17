// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;

//## Custom using statements
//##

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc4x3.ConstructionMgmtDomain
{
	public partial class @IfcConstructionMaterialResource : IIfcConstructionMaterialResource
	{

		[CrossSchemaAttribute(typeof(IIfcConstructionMaterialResource), 11)]
		Ifc4.Interfaces.IfcConstructionMaterialResourceTypeEnum? IIfcConstructionMaterialResource.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcConstructionMaterialResourceTypeEnum.AGGREGATES:
						return Ifc4.Interfaces.IfcConstructionMaterialResourceTypeEnum.AGGREGATES;
					case IfcConstructionMaterialResourceTypeEnum.CONCRETE:
						return Ifc4.Interfaces.IfcConstructionMaterialResourceTypeEnum.CONCRETE;
					case IfcConstructionMaterialResourceTypeEnum.DRYWALL:
						return Ifc4.Interfaces.IfcConstructionMaterialResourceTypeEnum.DRYWALL;
					case IfcConstructionMaterialResourceTypeEnum.FUEL:
						return Ifc4.Interfaces.IfcConstructionMaterialResourceTypeEnum.FUEL;
					case IfcConstructionMaterialResourceTypeEnum.GYPSUM:
						return Ifc4.Interfaces.IfcConstructionMaterialResourceTypeEnum.GYPSUM;
					case IfcConstructionMaterialResourceTypeEnum.MASONRY:
						return Ifc4.Interfaces.IfcConstructionMaterialResourceTypeEnum.MASONRY;
					case IfcConstructionMaterialResourceTypeEnum.METAL:
						return Ifc4.Interfaces.IfcConstructionMaterialResourceTypeEnum.METAL;
					case IfcConstructionMaterialResourceTypeEnum.PLASTIC:
						return Ifc4.Interfaces.IfcConstructionMaterialResourceTypeEnum.PLASTIC;
					case IfcConstructionMaterialResourceTypeEnum.WOOD:
						return Ifc4.Interfaces.IfcConstructionMaterialResourceTypeEnum.WOOD;
					case IfcConstructionMaterialResourceTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcConstructionMaterialResourceTypeEnum.USERDEFINED;
					case IfcConstructionMaterialResourceTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcConstructionMaterialResourceTypeEnum.NOTDEFINED;
					case null: 
						return null;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of PredefinedType
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcConstructionMaterialResourceTypeEnum.AGGREGATES:
						PredefinedType = IfcConstructionMaterialResourceTypeEnum.AGGREGATES;
						return;
					case Ifc4.Interfaces.IfcConstructionMaterialResourceTypeEnum.CONCRETE:
						PredefinedType = IfcConstructionMaterialResourceTypeEnum.CONCRETE;
						return;
					case Ifc4.Interfaces.IfcConstructionMaterialResourceTypeEnum.DRYWALL:
						PredefinedType = IfcConstructionMaterialResourceTypeEnum.DRYWALL;
						return;
					case Ifc4.Interfaces.IfcConstructionMaterialResourceTypeEnum.FUEL:
						PredefinedType = IfcConstructionMaterialResourceTypeEnum.FUEL;
						return;
					case Ifc4.Interfaces.IfcConstructionMaterialResourceTypeEnum.GYPSUM:
						PredefinedType = IfcConstructionMaterialResourceTypeEnum.GYPSUM;
						return;
					case Ifc4.Interfaces.IfcConstructionMaterialResourceTypeEnum.MASONRY:
						PredefinedType = IfcConstructionMaterialResourceTypeEnum.MASONRY;
						return;
					case Ifc4.Interfaces.IfcConstructionMaterialResourceTypeEnum.METAL:
						PredefinedType = IfcConstructionMaterialResourceTypeEnum.METAL;
						return;
					case Ifc4.Interfaces.IfcConstructionMaterialResourceTypeEnum.PLASTIC:
						PredefinedType = IfcConstructionMaterialResourceTypeEnum.PLASTIC;
						return;
					case Ifc4.Interfaces.IfcConstructionMaterialResourceTypeEnum.WOOD:
						PredefinedType = IfcConstructionMaterialResourceTypeEnum.WOOD;
						return;
					case Ifc4.Interfaces.IfcConstructionMaterialResourceTypeEnum.NOTDEFINED:
						PredefinedType = IfcConstructionMaterialResourceTypeEnum.NOTDEFINED;
						return;
					case Ifc4.Interfaces.IfcConstructionMaterialResourceTypeEnum.USERDEFINED:
						PredefinedType = IfcConstructionMaterialResourceTypeEnum.USERDEFINED;
						return;
					
					case null:
						PredefinedType = null;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}
	//## Custom code
	//##
	}
}