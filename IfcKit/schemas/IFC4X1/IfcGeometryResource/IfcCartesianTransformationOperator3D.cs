// This file was automatically generated from IFCDOC at www.buildingsmart-tech.org.
// IFC content is copyright (C) 1996-2018 BuildingSMART International Ltd.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

using BuildingSmart.IFC.IfcGeometricModelResource;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcPresentationOrganizationResource;
using BuildingSmart.IFC.IfcProfileResource;
using BuildingSmart.IFC.IfcRepresentationResource;
using BuildingSmart.IFC.IfcTopologyResource;

namespace BuildingSmart.IFC.IfcGeometryResource
{
	[Guid("137f3407-b6b9-4752-b668-e9e574a1b3fd")]
	public partial class IfcCartesianTransformationOperator3D : IfcCartesianTransformationOperator
	{
		[DataMember(Order=0)] 
		[XmlElement]
		IfcDirection _Axis3;
	
	
		[Description("The exact direction of U[3], the derived Z axis direction.")]
		public IfcDirection Axis3 { get { return this._Axis3; } set { this._Axis3 = value;} }
	
		public new IList<IfcDirection> U { get { return null; } }
	
	
	}
	
}