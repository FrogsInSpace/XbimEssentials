// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4x3.GeometricConstraintResource;
//## Custom using statements
//##


namespace Xbim.Ifc4x3.GeometricConstraintResource
{
	[ExpressType("IfcAlignmentCantSegment", 1403)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcAlignmentCantSegment : IfcAlignmentParameterSegment, IInstantiableEntity, IEquatable<@IfcAlignmentCantSegment>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcAlignmentCantSegment(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcLengthMeasure _startDistAlong;
		private IfcNonNegativeLengthMeasure _horizontalLength;
		private IfcLengthMeasure _startCantLeft;
		private IfcLengthMeasure? _endCantLeft;
		private IfcLengthMeasure _startCantRight;
		private IfcLengthMeasure? _endCantRight;
		private IfcAlignmentCantSegmentTypeEnum _predefinedType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 3)]
		public IfcLengthMeasure @StartDistAlong 
		{ 
			get 
			{
				if(_activated) return _startDistAlong;
				Activate();
				return _startDistAlong;
			} 
			set
			{
				SetValue( v =>  _startDistAlong = v, _startDistAlong, value,  "StartDistAlong", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 4)]
		public IfcNonNegativeLengthMeasure @HorizontalLength 
		{ 
			get 
			{
				if(_activated) return _horizontalLength;
				Activate();
				return _horizontalLength;
			} 
			set
			{
				SetValue( v =>  _horizontalLength = v, _horizontalLength, value,  "HorizontalLength", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 5)]
		public IfcLengthMeasure @StartCantLeft 
		{ 
			get 
			{
				if(_activated) return _startCantLeft;
				Activate();
				return _startCantLeft;
			} 
			set
			{
				SetValue( v =>  _startCantLeft = v, _startCantLeft, value,  "StartCantLeft", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 6)]
		public IfcLengthMeasure? @EndCantLeft 
		{ 
			get 
			{
				if(_activated) return _endCantLeft;
				Activate();
				return _endCantLeft;
			} 
			set
			{
				SetValue( v =>  _endCantLeft = v, _endCantLeft, value,  "EndCantLeft", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 7)]
		public IfcLengthMeasure @StartCantRight 
		{ 
			get 
			{
				if(_activated) return _startCantRight;
				Activate();
				return _startCantRight;
			} 
			set
			{
				SetValue( v =>  _startCantRight = v, _startCantRight, value,  "StartCantRight", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 8)]
		public IfcLengthMeasure? @EndCantRight 
		{ 
			get 
			{
				if(_activated) return _endCantRight;
				Activate();
				return _endCantRight;
			} 
			set
			{
				SetValue( v =>  _endCantRight = v, _endCantRight, value,  "EndCantRight", 8);
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 9)]
		public IfcAlignmentCantSegmentTypeEnum @PredefinedType 
		{ 
			get 
			{
				if(_activated) return _predefinedType;
				Activate();
				return _predefinedType;
			} 
			set
			{
				SetValue( v =>  _predefinedType = v, _predefinedType, value,  "PredefinedType", 9);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 2: 
					_startDistAlong = value.RealVal;
					return;
				case 3: 
					_horizontalLength = value.RealVal;
					return;
				case 4: 
					_startCantLeft = value.RealVal;
					return;
				case 5: 
					_endCantLeft = value.RealVal;
					return;
				case 6: 
					_startCantRight = value.RealVal;
					return;
				case 7: 
					_endCantRight = value.RealVal;
					return;
				case 8: 
                    _predefinedType = (IfcAlignmentCantSegmentTypeEnum) System.Enum.Parse(typeof (IfcAlignmentCantSegmentTypeEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcAlignmentCantSegment other)
	    {
	        return this == other;
	    }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}