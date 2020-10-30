// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.PropertyResource;
using Xbim.Ifc4.ExternalReferenceResource;
using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.ActorResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcPerson
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcPerson : IPersistEntity, IfcActorSelect, IfcObjectReferenceSelect, IfcResourceObjectSelect
	{
		IfcIdentifier? @Identification { get;  set; }
		IfcLabel? @FamilyName { get;  set; }
		IfcLabel? @GivenName { get;  set; }
		IItemSet<IfcLabel> @MiddleNames { get; }
		IItemSet<IfcLabel> @PrefixTitles { get; }
		IItemSet<IfcLabel> @SuffixTitles { get; }
		IItemSet<IIfcActorRole> @Roles { get; }
		IItemSet<IIfcAddress> @Addresses { get; }
		IEnumerable<IIfcPersonAndOrganization> @EngagedIn {  get; }
	
	}
}

namespace Xbim.Ifc4.ActorResource
{
	[ExpressType("IfcPerson", 198)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPerson : PersistEntity, IInstantiableEntity, IIfcPerson, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcPerson>
	{
		#region IIfcPerson explicit implementation
		IfcIdentifier? IIfcPerson.Identification { 
 
			get { return @Identification; } 
			set { Identification = value;}
		}	
		IfcLabel? IIfcPerson.FamilyName { 
 
			get { return @FamilyName; } 
			set { FamilyName = value;}
		}	
		IfcLabel? IIfcPerson.GivenName { 
 
			get { return @GivenName; } 
			set { GivenName = value;}
		}	
		IItemSet<IfcLabel> IIfcPerson.MiddleNames { 
			get { return @MiddleNames; } 
		}	
		IItemSet<IfcLabel> IIfcPerson.PrefixTitles { 
			get { return @PrefixTitles; } 
		}	
		IItemSet<IfcLabel> IIfcPerson.SuffixTitles { 
			get { return @SuffixTitles; } 
		}	
		IItemSet<IIfcActorRole> IIfcPerson.Roles { 
			get { return new Common.Collections.ProxyItemSet<IfcActorRole, IIfcActorRole>( @Roles); } 
		}	
		IItemSet<IIfcAddress> IIfcPerson.Addresses { 
			get { return new Common.Collections.ProxyItemSet<IfcAddress, IIfcAddress>( @Addresses); } 
		}	
		IEnumerable<IIfcPersonAndOrganization> IIfcPerson.EngagedIn {  get { return @EngagedIn; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPerson(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_middleNames = new OptionalItemSet<IfcLabel>( this, 0,  4);
			_prefixTitles = new OptionalItemSet<IfcLabel>( this, 0,  5);
			_suffixTitles = new OptionalItemSet<IfcLabel>( this, 0,  6);
			_roles = new OptionalItemSet<IfcActorRole>( this, 0,  7);
			_addresses = new OptionalItemSet<IfcAddress>( this, 0,  8);
		}

		#region Explicit attribute fields
		private IfcIdentifier? _identification;
		private IfcLabel? _familyName;
		private IfcLabel? _givenName;
		private readonly OptionalItemSet<IfcLabel> _middleNames;
		private readonly OptionalItemSet<IfcLabel> _prefixTitles;
		private readonly OptionalItemSet<IfcLabel> _suffixTitles;
		private readonly OptionalItemSet<IfcActorRole> _roles;
		private readonly OptionalItemSet<IfcAddress> _addresses;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 1)]
		public IfcIdentifier? @Identification 
		{ 
			get 
			{
				if(_activated) return _identification;
				Activate();
				return _identification;
			} 
			set
			{
				SetValue( v =>  _identification = v, _identification, value,  "Identification", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 2)]
		public IfcLabel? @FamilyName 
		{ 
			get 
			{
				if(_activated) return _familyName;
				Activate();
				return _familyName;
			} 
			set
			{
				SetValue( v =>  _familyName = v, _familyName, value,  "FamilyName", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 3)]
		public IfcLabel? @GivenName 
		{ 
			get 
			{
				if(_activated) return _givenName;
				Activate();
				return _givenName;
			} 
			set
			{
				SetValue( v =>  _givenName = v, _givenName, value,  "GivenName", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.None, new int [] { 1 }, new int [] { -1 }, 4)]
		public IOptionalItemSet<IfcLabel> @MiddleNames 
		{ 
			get 
			{
				if(_activated) return _middleNames;
				Activate();
				return _middleNames;
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.None, new int [] { 1 }, new int [] { -1 }, 5)]
		public IOptionalItemSet<IfcLabel> @PrefixTitles 
		{ 
			get 
			{
				if(_activated) return _prefixTitles;
				Activate();
				return _prefixTitles;
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.None, new int [] { 1 }, new int [] { -1 }, 6)]
		public IOptionalItemSet<IfcLabel> @SuffixTitles 
		{ 
			get 
			{
				if(_activated) return _suffixTitles;
				Activate();
				return _suffixTitles;
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 7)]
		public IOptionalItemSet<IfcActorRole> @Roles 
		{ 
			get 
			{
				if(_activated) return _roles;
				Activate();
				return _roles;
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 8)]
		public IOptionalItemSet<IfcAddress> @Addresses 
		{ 
			get 
			{
				if(_activated) return _addresses;
				Activate();
				return _addresses;
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("ThePerson")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { -1 }, 9)]
		public IEnumerable<IfcPersonAndOrganization> @EngagedIn 
		{ 
			get 
			{
				return Model.Instances.Where<IfcPersonAndOrganization>(e => Equals(e.ThePerson), "ThePerson", this);
			} 
		}
		#endregion

		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_identification = value.StringVal;
					return;
				case 1: 
					_familyName = value.StringVal;
					return;
				case 2: 
					_givenName = value.StringVal;
					return;
				case 3: 
					_middleNames.InternalAdd(value.StringVal);
					return;
				case 4: 
					_prefixTitles.InternalAdd(value.StringVal);
					return;
				case 5: 
					_suffixTitles.InternalAdd(value.StringVal);
					return;
				case 6: 
					_roles.InternalAdd((IfcActorRole)value.EntityVal);
					return;
				case 7: 
					_addresses.InternalAdd((IfcAddress)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcPerson other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				foreach(var entity in @Roles)
					yield return entity;
				foreach(var entity in @Addresses)
					yield return entity;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				foreach(var entity in @Addresses)
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