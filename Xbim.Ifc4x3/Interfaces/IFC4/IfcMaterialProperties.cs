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
namespace Xbim.Ifc4x3.MaterialResource
{
	public partial class @IfcMaterialProperties : IIfcMaterialProperties
	{

		[CrossSchemaAttribute(typeof(IIfcMaterialProperties), 4)]
		IIfcMaterialDefinition IIfcMaterialProperties.Material 
		{ 
			get
			{
				return Material;
			} 
			set
			{
				Material = value as IfcMaterialDefinition;
				
			}
		}
	//## Custom code
	//##
	}
}