namespace Timewave.BizTalkUnit.Sample.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Timewave.BizTalkUnit.Sample.DestinationSchema",@"CustomerSummary")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"CustomerSummary"})]
    public sealed class SummarySchema : Microsoft.BizTalk.TestTools.Schema.TestableSchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://Timewave.BizTalkUnit.Sample.DestinationSchema"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://Timewave.BizTalkUnit.Sample.DestinationSchema"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""CustomerSummary"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""CustomerId"" type=""xs:string"" />
        <xs:element name=""CustomerName"" type=""xs:string"" />
        <xs:element name=""ItemsOrdered"" type=""xs:string"" />
        <xs:element name=""PaymentStatus"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public SummarySchema() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "CustomerSummary";
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
