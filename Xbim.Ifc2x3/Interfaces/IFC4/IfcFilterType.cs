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

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.HVACDomain
{
	public partial class @IfcFilterType : IIfcFilterType
	{
		Xbim.Ifc4.HvacDomain.IfcFilterTypeEnum IIfcFilterType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case Xbim.Ifc2x3.HVACDomain.IfcFilterTypeEnum.AIRPARTICLEFILTER:
						return Xbim.Ifc4.HvacDomain.IfcFilterTypeEnum.AIRPARTICLEFILTER;
					
					case Xbim.Ifc2x3.HVACDomain.IfcFilterTypeEnum.ODORFILTER:
						return Xbim.Ifc4.HvacDomain.IfcFilterTypeEnum.ODORFILTER;
					
					case Xbim.Ifc2x3.HVACDomain.IfcFilterTypeEnum.OILFILTER:
						return Xbim.Ifc4.HvacDomain.IfcFilterTypeEnum.OILFILTER;
					
					case Xbim.Ifc2x3.HVACDomain.IfcFilterTypeEnum.STRAINER:
						return Xbim.Ifc4.HvacDomain.IfcFilterTypeEnum.STRAINER;
					
					case Xbim.Ifc2x3.HVACDomain.IfcFilterTypeEnum.WATERFILTER:
						return Xbim.Ifc4.HvacDomain.IfcFilterTypeEnum.WATERFILTER;
					
					case Xbim.Ifc2x3.HVACDomain.IfcFilterTypeEnum.USERDEFINED:
						return Xbim.Ifc4.HvacDomain.IfcFilterTypeEnum.USERDEFINED;
					
					case Xbim.Ifc2x3.HVACDomain.IfcFilterTypeEnum.NOTDEFINED:
						return Xbim.Ifc4.HvacDomain.IfcFilterTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
	}
}