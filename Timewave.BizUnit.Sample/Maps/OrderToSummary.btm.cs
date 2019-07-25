namespace Timewave.BizUnit.Sample.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Timewave.BizTalkUnit.Sample.Schemas.SourceSchema", typeof(global::Timewave.BizTalkUnit.Sample.Schemas.SourceSchema))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Timewave.BizTalkUnit.Sample.Schemas.SummarySchema", typeof(global::Timewave.BizTalkUnit.Sample.Schemas.SummarySchema))]
    public sealed class OrderToSummary : global::Microsoft.BizTalk.TestTools.Mapper.TestableMapBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://Timewave.BizTalkUnit.Sample.DestinationSchema"" xmlns:s0=""http://Timewave.BizTalkUnit.Sample.SourceSchema"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:CustomerOrder"" />
  </xsl:template>
  <xsl:template match=""/s0:CustomerOrder"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(string(Forename/text()) , &quot; &quot; , string(Surname/text()))"" />
    <xsl:variable name=""var:v2"" select=""count(/s0:CustomerOrder/OrderLines/Line)"" />
    <ns0:CustomerSummary>
      <CustomerId>
        <xsl:value-of select=""CustomerId/text()"" />
      </CustomerId>
      <CustomerName>
        <xsl:value-of select=""$var:v1"" />
      </CustomerName>
      <ItemsOrdered>
        <xsl:value-of select=""$var:v2"" />
      </ItemsOrdered>
      <PaymentStatus>
        <xsl:value-of select=""PaymentStatus/text()"" />
      </PaymentStatus>
    </ns0:CustomerSummary>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0, string param1, string param2)
{
   return param0 + param1 + param2;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Timewave.BizTalkUnit.Sample.Schemas.SourceSchema";
        
        private const global::Timewave.BizTalkUnit.Sample.Schemas.SourceSchema _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Timewave.BizTalkUnit.Sample.Schemas.SummarySchema";
        
        private const global::Timewave.BizTalkUnit.Sample.Schemas.SummarySchema _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"Timewave.BizTalkUnit.Sample.Schemas.SourceSchema";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Timewave.BizTalkUnit.Sample.Schemas.SummarySchema";
                return _TrgSchemas;
            }
        }
    }
}
