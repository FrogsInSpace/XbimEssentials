// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.GeometryResource;
using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.PresentationAppearanceResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcStyledItem
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcStyledItem : IIfcRepresentationItem
	{
		IIfcRepresentationItem @Item { get;  set; }
		IItemSet<IIfcStyleAssignmentSelect> @Styles { get; }
		IfcLabel? @Name { get;  set; }
	
	}
}

namespace Xbim.Ifc4.PresentationAppearanceResource
{
	[ExpressType("IfcStyledItem", 56)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcStyledItem : IfcRepresentationItem, IInstantiableEntity, IIfcStyledItem, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcStyledItem>
	{
		#region IIfcStyledItem explicit implementation
		IIfcRepresentationItem IIfcStyledItem.Item { 
 
 
			get { return @Item; } 
			set { Item = value as IfcRepresentationItem;}
		}	
		IItemSet<IIfcStyleAssignmentSelect> IIfcStyledItem.Styles { 
			get { return new Common.Collections.ProxyItemSet<IfcStyleAssignmentSelect, IIfcStyleAssignmentSelect>( @Styles); } 
		}	
		IfcLabel? IIfcStyledItem.Name { 
 
			get { return @Name; } 
			set { Name = value;}
		}	
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStyledItem(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_styles = new ItemSet<IfcStyleAssignmentSelect>( this, 0,  2);
		}

		#region Explicit attribute fields
		private IfcRepresentationItem _item;
		private readonly ItemSet<IfcStyleAssignmentSelect> _styles;
		private IfcLabel? _name;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 3)]
		public IfcRepresentationItem @Item 
		{ 
			get 
			{
				if(_activated) return _item;
				Activate();
				return _item;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _item = v, _item, value,  "Item", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 4)]
		public IItemSet<IfcStyleAssignmentSelect> @Styles 
		{ 
			get 
			{
				if(_activated) return _styles;
				Activate();
				return _styles;
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 5)]
		public IfcLabel? @Name 
		{ 
			get 
			{
				if(_activated) return _name;
				Activate();
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name", 3);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_item = (IfcRepresentationItem)(value.EntityVal);
					return;
				case 1: 
					_styles.InternalAdd((IfcStyleAssignmentSelect)value.EntityVal);
					return;
				case 2: 
					_name = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcStyledItem other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Item != null)
					yield return @Item;
				foreach(var entity in @Styles)
					yield return entity;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@Item != null)
					yield return @Item;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}