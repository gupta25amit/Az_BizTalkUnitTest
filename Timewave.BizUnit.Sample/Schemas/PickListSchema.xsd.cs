namespace Timewave.BizTalkUnit.Sample.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Timewave.BizTalkUnit.Sample.PickListSchema",@"PickList")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"PickList"})]
    public sealed class PickListSchema : Microsoft.BizTalk.TestTools.Schema.TestableSchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://Timewave.BizTalkUnit.Sample.PickListSchema"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://Timewave.BizTalkUnit.Sample.PickListSchema"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""PickList"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""CustomerId"" type=""xs:string"" />
        <xs:element name=""Items"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Item"" type=""xs:string"" />
              <xs:element name=""Quantity"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public PickListSchema() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "PickList";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
