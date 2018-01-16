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

using BuildingSmart.IFC.IfcActorResource;
using BuildingSmart.IFC.IfcDateTimeResource;
using BuildingSmart.IFC.IfcMeasureResource;

namespace BuildingSmart.IFC.IfcExternalReferenceResource
{
	[Guid("dbc80bb9-c76e-4129-8977-ff211bb10350")]
	public abstract partial class IfcExternalReference :
		BuildingSmart.IFC.IfcPresentationOrganizationResource.IfcLightDistributionDataSourceSelect,
		BuildingSmart.IFC.IfcPropertyResource.IfcObjectReferenceSelect
	{
		[DataMember(Order=0)] 
		[XmlAttribute]
		IfcLabel? _Location;
	
		[DataMember(Order=1)] 
		[XmlAttribute]
		IfcIdentifier? _ItemReference;
	
		[DataMember(Order=2)] 
		[XmlAttribute]
		IfcLabel? _Name;
	
	
		[Description(@"Location, where the external source (classification, document or library). This can be either human readable or computer interpretable. For electronic location normally given as an URL location string, however other ways of accessing external references may be established in an application scenario.
	")]
		public IfcLabel? Location { get { return this._Location; } set { this._Location = value;} }
	
		[Description("Identifier for the referenced item in the external source (classification, docume" +
	    "nt or library). The internal reference can provide a computer interpretable poin" +
	    "ter into electronic source.")]
		public IfcIdentifier? ItemReference { get { return this._ItemReference; } set { this._ItemReference = value;} }
	
		[Description("Optional name to further specify the reference. It can provide a human readable i" +
	    "dentifier (which does not necessarily need to have a counterpart in the internal" +
	    " structure of the document).")]
		public IfcLabel? Name { get { return this._Name; } set { this._Name = value;} }
	
	
	}
	
}