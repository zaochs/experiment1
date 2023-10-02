//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.910.0 using the following command:
// xscgen ../NeTEx-light/NeTEx_publication_reduced.xsd -o .
namespace Gml
{
    
    
    /// <summary>
    /// <para>gml:ReferenceType is intended to be used in application schemas directly, if a property element shall use a "by-reference only" encoding.</para>
    /// <para>The value of this property is a remote text description of the object. The xlink:href attribute of the gml:descriptionReference property references the external description.</para>
    /// </summary>
    [System.ComponentModel.DescriptionAttribute("gml:ReferenceType is intended to be used in application schemas directly, if a pr" +
        "operty element shall use a \"by-reference only\" encoding.")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.910.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ReferenceType", Namespace="http://www.opengis.net/gml/3.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("descriptionReference", Namespace="http://www.opengis.net/gml/3.2")]
    public partial class ReferenceType : IOwnershipAttributeGroup, IAssociationAttributeGroup
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _owns = false;
        
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("owns")]
        public bool Owns
        {
            get
            {
                return _owns;
            }
            set
            {
                _owns = value;
            }
        }
        
        /// <summary>
        /// <para>gml:NilReasonType defines a content model that allows recording of an explanation for a void value or other exception.
        ///gml:NilReasonType is a union of the following enumerated values:
        ///-	inapplicable there is no value
        ///-	missing the correct value is not readily available to the sender of this data. Furthermore, a correct value may not exist
        ///-	template the value will be available later
        ///-	unknown the correct value is not known to, and not computable by, the sender of this data. However, a correct value probably exists
        ///-	withheld the value is not divulged
        ///-	other:text other brief explanation, where text is a string of two or more characters with no included spaces
        ///and
        ///-	anyURI which should refer to a resource which describes the reason for the exception
        ///A particular community may choose to assign more detailed semantics to the standard values provided. Alternatively, the URI method enables a specific or more complete explanation for the absence of a value to be provided elsewhere and indicated by-reference in an instance document.
        ///gml:NilReasonType is used as a member of a union in a number of simple content types where it is necessary to permit a value from the NilReasonType union as an alternative to the primary type.</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("nilReason")]
        public string NilReason { get; set; }
    }
    
    /// <summary>
    /// <para>Encoding a GML property inline vs. by-reference shall not imply anything about the "ownership" of the contained or referenced GML Object, i.e. the encoding style shall not imply any "deep-copy" or "deep-delete" semantics. To express ownership over the contained or referenced GML Object, the gml:OwnershipAttributeGroup attribute group may be added to object-valued property elements. If the attribute group is not part of the content model of such a property element, then the value may not be "owned".
    ///When the value of the owns attribute is "true", the existence of inline or referenced object(s) depends upon the existence of the parent object.</para>
    /// </summary>
    [System.ComponentModel.DescriptionAttribute(@"Encoding a GML property inline vs. by-reference shall not imply anything about the ""ownership"" of the contained or referenced GML Object, i.e. the encoding style shall not imply any ""deep-copy"" or ""deep-delete"" semantics. To express ownership over the contained or referenced GML Object, the gml:OwnershipAttributeGroup attribute group may be added to object-valued property elements. If the attribute group is not part of the content model of such a property element, then the value may not be ""owned"". When the value of the owns attribute is ""true"", the existence of inline or referenced object(s) depends upon the existence of the parent object.")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.910.0")]
    public partial interface IOwnershipAttributeGroup
    {
        
        [System.ComponentModel.DefaultValueAttribute(false)]
        bool Owns
        {
            get;
            set;
        }
    }
    
    /// <summary>
    /// <para>XLink components are the standard method to support hypertext referencing in XML. An XML Schema attribute group, gml:AssociationAttributeGroup, is provided to support the use of Xlinks as the method for indicating the value of a property by reference in a uniform manner in GML.</para>
    /// </summary>
    [System.ComponentModel.DescriptionAttribute(@"XLink components are the standard method to support hypertext referencing in XML. An XML Schema attribute group, gml:AssociationAttributeGroup, is provided to support the use of Xlinks as the method for indicating the value of a property by reference in a uniform manner in GML.")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.910.0")]
    public partial interface IAssociationAttributeGroup
    {
        
        /// <summary>
        /// <para>gml:NilReasonType defines a content model that allows recording of an explanation for a void value or other exception.
        ///gml:NilReasonType is a union of the following enumerated values:
        ///-	inapplicable there is no value
        ///-	missing the correct value is not readily available to the sender of this data. Furthermore, a correct value may not exist
        ///-	template the value will be available later
        ///-	unknown the correct value is not known to, and not computable by, the sender of this data. However, a correct value probably exists
        ///-	withheld the value is not divulged
        ///-	other:text other brief explanation, where text is a string of two or more characters with no included spaces
        ///and
        ///-	anyURI which should refer to a resource which describes the reason for the exception
        ///A particular community may choose to assign more detailed semantics to the standard values provided. Alternatively, the URI method enables a specific or more complete explanation for the absence of a value to be provided elsewhere and indicated by-reference in an instance document.
        ///gml:NilReasonType is used as a member of a union in a number of simple content types where it is necessary to permit a value from the NilReasonType union as an alternative to the primary type.</para>
        /// </summary>
        string NilReason
        {
            get;
            set;
        }
    }
    
    /// <summary>
    /// <para>gml:CodeType is a generalized type to be used for a term, keyword or name.
    ///It adds a XML attribute codeSpace to a term, where the value of the codeSpace attribute (if present) shall indicate a dictionary, thesaurus, classification scheme, authority, or pattern for the term.</para>
    /// <para>The gml:name property provides a label or identifier for the object, commonly a descriptive name. An object may have several names, typically assigned by different authorities. gml:name uses the gml:CodeType content model.  The authority for a name is indicated by the value of its (optional) codeSpace attribute.  The name may or may not be unique, as determined by the rules of the organization responsible for the codeSpace.  In common usage there will be one name per authority, so a processing application may select the name from its preferred codeSpace.</para>
    /// </summary>
    [System.ComponentModel.DescriptionAttribute(@"gml:CodeType is a generalized type to be used for a term, keyword or name. It adds a XML attribute codeSpace to a term, where the value of the codeSpace attribute (if present) shall indicate a dictionary, thesaurus, classification scheme, authority, or pattern for the term.")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.910.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("CodeType", Namespace="http://www.opengis.net/gml/3.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("name", Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CodeWithAuthorityType))]
    public partial class CodeType
    {
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets the text value.</para>
        /// </summary>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value { get; set; }
        
        [System.Xml.Serialization.XmlAttributeAttribute("codeSpace")]
        public string CodeSpace { get; set; }
    }
    
    /// <summary>
    /// <para>gml:CodeWithAuthorityType requires that the codeSpace attribute is provided in an instance.</para>
    /// <para>Often, a special identifier is assigned to an object by the maintaining authority with the intention that it is used in references to the object For such cases, the codeSpace shall be provided. That identifier is usually unique either globally or within an application domain. gml:identifier is a pre-defined property for such identifiers.</para>
    /// </summary>
    [System.ComponentModel.DescriptionAttribute("gml:CodeWithAuthorityType requires that the codeSpace attribute is provided in an" +
        " instance.")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.910.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("CodeWithAuthorityType", Namespace="http://www.opengis.net/gml/3.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("identifier", Namespace="http://www.opengis.net/gml/3.2")]
    public partial class CodeWithAuthorityType : CodeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.910.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("T_LineString", Namespace="http://www.opengis.net/gml/3.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("LineString", Namespace="http://www.opengis.net/gml/3.2")]
    public partial class TLineString : IStandardObjectProperties, IBaseAttributesGroup
    {
        
        [System.Xml.Serialization.XmlElementAttribute("descriptionReference")]
        public ReferenceType DescriptionReference { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("identifier")]
        public CodeWithAuthorityType Identifier { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<CodeType> _name;
        
        [System.Xml.Serialization.XmlElementAttribute("name")]
        public System.Collections.ObjectModel.Collection<CodeType> Name
        {
            get
            {
                return _name;
            }
            private set
            {
                _name = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Name collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NameSpecified
        {
            get
            {
                return (this.Name.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="TLineString" /> class.</para>
        /// </summary>
        public TLineString()
        {
            this._name = new System.Collections.ObjectModel.Collection<CodeType>();
            this._pos = new System.Collections.ObjectModel.Collection<TPos>();
            this._pointProperty = new System.Collections.ObjectModel.Collection<TPointProperty>();
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TPos> _pos;
        
        [System.Xml.Serialization.XmlElementAttribute("pos")]
        public System.Collections.ObjectModel.Collection<TPos> Pos
        {
            get
            {
                return _pos;
            }
            private set
            {
                _pos = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Pos collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PosSpecified
        {
            get
            {
                return (this.Pos.Count != 0);
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TPointProperty> _pointProperty;
        
        [System.Xml.Serialization.XmlElementAttribute("pointProperty")]
        public System.Collections.ObjectModel.Collection<TPointProperty> PointProperty
        {
            get
            {
                return _pointProperty;
            }
            private set
            {
                _pointProperty = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the PointProperty collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PointPropertySpecified
        {
            get
            {
                return (this.PointProperty.Count != 0);
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("posList")]
        public TPosList PosList { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("id", Namespace="http://www.opengis.net/gml/3.2", Form=System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string Id { get; set; }
        
        [System.Xml.Serialization.XmlAttributeAttribute("srsName")]
        public string SrsName { get; set; }
        
        [System.Xml.Serialization.XmlAttributeAttribute("srsDimension")]
        public string SrsDimension { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.910.0")]
    public partial interface IStandardObjectProperties
    {
        
        ReferenceType DescriptionReference
        {
            get;
            set;
        }
        
        CodeWithAuthorityType Identifier
        {
            get;
            set;
        }
        
        System.Collections.ObjectModel.Collection<CodeType> Name
        {
            get;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.910.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("T_pos", Namespace="http://www.opengis.net/gml/3.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("pos", Namespace="http://www.opengis.net/gml/3.2")]
    public partial class TPos
    {
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets the text value.</para>
        /// </summary>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value { get; set; }
        
        [System.Xml.Serialization.XmlAttributeAttribute("srsName")]
        public string SrsName { get; set; }
        
        [System.Xml.Serialization.XmlAttributeAttribute("srsDimension")]
        public string SrsDimension { get; set; }
    }
    
    /// <summary>
    /// <para>This property element either references a point via the XLink-attributes or contains the point element. pointProperty is the predefined property which may be used by GML Application Schemas whenever a GML feature has a property with a value that is substitutable for Point.</para>
    /// </summary>
    [System.ComponentModel.DescriptionAttribute(@"This property element either references a point via the XLink-attributes or contains the point element. pointProperty is the predefined property which may be used by GML Application Schemas whenever a GML feature has a property with a value that is substitutable for Point.")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.910.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("T_pointProperty", Namespace="http://www.opengis.net/gml/3.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("pointProperty", Namespace="http://www.opengis.net/gml/3.2")]
    public partial class TPointProperty
    {
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Point")]
        public TPoint Point { get; set; }
        
        /// <summary>
        /// <para>gml:NilReasonType defines a content model that allows recording of an explanation for a void value or other exception.
        ///gml:NilReasonType is a union of the following enumerated values:
        ///-	inapplicable there is no value
        ///-	missing the correct value is not readily available to the sender of this data. Furthermore, a correct value may not exist
        ///-	template the value will be available later
        ///-	unknown the correct value is not known to, and not computable by, the sender of this data. However, a correct value probably exists
        ///-	withheld the value is not divulged
        ///-	other:text other brief explanation, where text is a string of two or more characters with no included spaces
        ///and
        ///-	anyURI which should refer to a resource which describes the reason for the exception
        ///A particular community may choose to assign more detailed semantics to the standard values provided. Alternatively, the URI method enables a specific or more complete explanation for the absence of a value to be provided elsewhere and indicated by-reference in an instance document.
        ///gml:NilReasonType is used as a member of a union in a number of simple content types where it is necessary to permit a value from the NilReasonType union as an alternative to the primary type.</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("nilReason")]
        public string NilReason { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _owns = false;
        
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("owns")]
        public bool Owns
        {
            get
            {
                return _owns;
            }
            set
            {
                _owns = value;
            }
        }
    }
    
    /// <summary>
    /// <para>A Point is defined by a single coordinate tuple. The direct position of a point is specified by the pos element which is of type DirectPositionType.</para>
    /// </summary>
    [System.ComponentModel.DescriptionAttribute("A Point is defined by a single coordinate tuple. The direct position of a point i" +
        "s specified by the pos element which is of type DirectPositionType.")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.910.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("T_Point", Namespace="http://www.opengis.net/gml/3.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("Point", Namespace="http://www.opengis.net/gml/3.2")]
    public partial class TPoint : IStandardObjectProperties, IBaseAttributesGroup
    {
        
        [System.Xml.Serialization.XmlElementAttribute("descriptionReference")]
        public ReferenceType DescriptionReference { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("identifier")]
        public CodeWithAuthorityType Identifier { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<CodeType> _name;
        
        [System.Xml.Serialization.XmlElementAttribute("name")]
        public System.Collections.ObjectModel.Collection<CodeType> Name
        {
            get
            {
                return _name;
            }
            private set
            {
                _name = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Name collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NameSpecified
        {
            get
            {
                return (this.Name.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="TPoint" /> class.</para>
        /// </summary>
        public TPoint()
        {
            this._name = new System.Collections.ObjectModel.Collection<CodeType>();
        }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("pos")]
        public TPos Pos { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("id", Namespace="http://www.opengis.net/gml/3.2", Form=System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string Id { get; set; }
        
        [System.Xml.Serialization.XmlAttributeAttribute("srsName")]
        public string SrsName { get; set; }
        
        [System.Xml.Serialization.XmlAttributeAttribute("srsDimension")]
        public string SrsDimension { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.910.0")]
    public partial interface IBaseAttributesGroup
    {
        
        string Id
        {
            get;
            set;
        }
        
        string SrsName
        {
            get;
            set;
        }
        
        string SrsDimension
        {
            get;
            set;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.910.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("T_posList", Namespace="http://www.opengis.net/gml/3.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("posList", Namespace="http://www.opengis.net/gml/3.2")]
    public partial class TPosList
    {
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets the text value.</para>
        /// </summary>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value { get; set; }
        
        [System.Xml.Serialization.XmlAttributeAttribute("srsName")]
        public string SrsName { get; set; }
        
        [System.Xml.Serialization.XmlAttributeAttribute("srsDimension")]
        public string SrsDimension { get; set; }
        
        [System.Xml.Serialization.XmlAttributeAttribute("count")]
        public string Count { get; set; }
    }
    
    /// <summary>
    /// <para>A LinearRing is defined by four or more coordinate tuples, with linear interpolation between them; the first and last coordinates shall be coincident. The number of direct positions in the list shall be at least four.</para>
    /// </summary>
    [System.ComponentModel.DescriptionAttribute("A LinearRing is defined by four or more coordinate tuples, with linear interpolat" +
        "ion between them; the first and last coordinates shall be coincident. The number" +
        " of direct positions in the list shall be at least four.")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.910.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("T_LinearRing", Namespace="http://www.opengis.net/gml/3.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("LinearRing", Namespace="http://www.opengis.net/gml/3.2")]
    public partial class TLinearRing
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TPos> _pos;
        
        [System.Xml.Serialization.XmlElementAttribute("pos")]
        public System.Collections.ObjectModel.Collection<TPos> Pos
        {
            get
            {
                return _pos;
            }
            private set
            {
                _pos = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Pos collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PosSpecified
        {
            get
            {
                return (this.Pos.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="TLinearRing" /> class.</para>
        /// </summary>
        public TLinearRing()
        {
            this._pos = new System.Collections.ObjectModel.Collection<TPos>();
            this._pointProperty = new System.Collections.ObjectModel.Collection<TPointProperty>();
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TPointProperty> _pointProperty;
        
        [System.Xml.Serialization.XmlElementAttribute("pointProperty")]
        public System.Collections.ObjectModel.Collection<TPointProperty> PointProperty
        {
            get
            {
                return _pointProperty;
            }
            private set
            {
                _pointProperty = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the PointProperty collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PointPropertySpecified
        {
            get
            {
                return (this.PointProperty.Count != 0);
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("posList")]
        public TPosList PosList { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.910.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("T_descriptionReference", Namespace="http://www.opengis.net/gml/3.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TDescriptionReference
    {
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("owns")]
        public bool Owns { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("nilReason")]
        public string NilReason { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.910.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("T_identifier", Namespace="http://www.opengis.net/gml/3.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TIdentifier
    {
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets the text value.</para>
        /// </summary>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("codeSpace")]
        public string CodeSpace { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.910.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("T_name", Namespace="http://www.opengis.net/gml/3.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TName
    {
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets the text value.</para>
        /// </summary>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("codeSpace")]
        public string CodeSpace { get; set; }
    }
    
    /// <summary>
    /// <para>A Polygon is a special surface that is defined by a single surface patch (see D.3.6). The boundary of this patch is coplanar and the polygon uses planar interpolation in its interior. 
    ///The elements exterior and interior describe the surface boundary of the polygon.</para>
    /// </summary>
    [System.ComponentModel.DescriptionAttribute(@"A Polygon is a special surface that is defined by a single surface patch (see D.3.6). The boundary of this patch is coplanar and the polygon uses planar interpolation in its interior. The elements exterior and interior describe the surface boundary of the polygon.")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.910.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("T_Polygon", Namespace="http://www.opengis.net/gml/3.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("Polygon", Namespace="http://www.opengis.net/gml/3.2")]
    public partial class TPolygon : IStandardObjectProperties, IBaseAttributesGroup
    {
        
        [System.Xml.Serialization.XmlElementAttribute("descriptionReference")]
        public ReferenceType DescriptionReference { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("identifier")]
        public CodeWithAuthorityType Identifier { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<CodeType> _name;
        
        [System.Xml.Serialization.XmlElementAttribute("name")]
        public System.Collections.ObjectModel.Collection<CodeType> Name
        {
            get
            {
                return _name;
            }
            private set
            {
                _name = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Name collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NameSpecified
        {
            get
            {
                return (this.Name.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="TPolygon" /> class.</para>
        /// </summary>
        public TPolygon()
        {
            this._name = new System.Collections.ObjectModel.Collection<CodeType>();
            this._interior = new System.Collections.ObjectModel.Collection<TInterior>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("exterior")]
        public TExterior Exterior { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TInterior> _interior;
        
        [System.Xml.Serialization.XmlElementAttribute("interior")]
        public System.Collections.ObjectModel.Collection<TInterior> Interior
        {
            get
            {
                return _interior;
            }
            private set
            {
                _interior = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Interior collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InteriorSpecified
        {
            get
            {
                return (this.Interior.Count != 0);
            }
        }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("id", Namespace="http://www.opengis.net/gml/3.2", Form=System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string Id { get; set; }
        
        [System.Xml.Serialization.XmlAttributeAttribute("srsName")]
        public string SrsName { get; set; }
        
        [System.Xml.Serialization.XmlAttributeAttribute("srsDimension")]
        public string SrsDimension { get; set; }
    }
    
    /// <summary>
    /// <para>A boundary of a surface consists of a number of rings. In the normal 2D case, one of these rings is distinguished as being the exterior boundary. In a general manifold this is not always possible, in which case all boundaries shall be listed as interior boundaries, and the exterior will be empty.</para>
    /// </summary>
    [System.ComponentModel.DescriptionAttribute(@"A boundary of a surface consists of a number of rings. In the normal 2D case, one of these rings is distinguished as being the exterior boundary. In a general manifold this is not always possible, in which case all boundaries shall be listed as interior boundaries, and the exterior will be empty.")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.910.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("T_exterior", Namespace="http://www.opengis.net/gml/3.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("exterior", Namespace="http://www.opengis.net/gml/3.2")]
    public partial class TExterior
    {
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("LinearRing")]
        public TLinearRing LinearRing { get; set; }
    }
    
    /// <summary>
    /// <para>A boundary of a surface consists of a number of rings. The "interior" rings separate the surface / surface patch from the area enclosed by the rings.</para>
    /// </summary>
    [System.ComponentModel.DescriptionAttribute("A boundary of a surface consists of a number of rings. The \"interior\" rings separ" +
        "ate the surface / surface patch from the area enclosed by the rings.")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.910.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("T_interior", Namespace="http://www.opengis.net/gml/3.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("interior", Namespace="http://www.opengis.net/gml/3.2")]
    public partial class TInterior
    {
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("LinearRing")]
        public TLinearRing LinearRing { get; set; }
    }
}
