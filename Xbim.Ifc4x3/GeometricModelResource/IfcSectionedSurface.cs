// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4x3.GeometryResource;
using Xbim.Ifc4x3.ProfileResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4x3.GeometricModelResource;
//## Custom using statements
//##


namespace Xbim.Ifc4x3.GeometricModelResource
{
	[ExpressType("IfcSectionedSurface", 1484)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSectionedSurface : IfcSurface, IInstantiableEntity, IContainsEntityReferences, IEquatable<@IfcSectionedSurface>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSectionedSurface(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_crossSectionPositions = new ItemSet<IfcAxis2PlacementLinear>( this, 0,  2);
			_crossSections = new ItemSet<IfcProfileDef>( this, 0,  3);
		}

		#region Explicit attribute fields
		private IfcCurve _directrix;
		private readonly ItemSet<IfcAxis2PlacementLinear> _crossSectionPositions;
		private readonly ItemSet<IfcProfileDef> _crossSections;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 3)]
		public IfcCurve @Directrix 
		{ 
			get 
			{
				if(_activated) return _directrix;
				Activate();
				return _directrix;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _directrix = v, _directrix, value,  "Directrix", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, new int [] { 2 }, new int [] { -1 }, 4)]
		public IItemSet<IfcAxis2PlacementLinear> @CrossSectionPositions 
		{ 
			get 
			{
				if(_activated) return _crossSectionPositions;
				Activate();
				return _crossSectionPositions;
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, new int [] { 2 }, new int [] { -1 }, 5)]
		public IItemSet<IfcProfileDef> @CrossSections 
		{ 
			get 
			{
				if(_activated) return _crossSections;
				Activate();
				return _crossSections;
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_directrix = (IfcCurve)(value.EntityVal);
					return;
				case 1: 
					_crossSectionPositions.InternalAdd((IfcAxis2PlacementLinear)value.EntityVal);
					return;
				case 2: 
					_crossSections.InternalAdd((IfcProfileDef)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcSectionedSurface other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Directrix != null)
					yield return @Directrix;
				foreach(var entity in @CrossSectionPositions)
					yield return entity;
				foreach(var entity in @CrossSections)
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