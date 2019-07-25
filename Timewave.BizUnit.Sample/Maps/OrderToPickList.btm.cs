namespace Timewave.BizUnit.Sample.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Timewave.BizTalkUnit.Sample.Schemas.SourceSchema", typeof(global::Timewave.BizTalkUnit.Sample.Schemas.SourceSchema))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Timewave.BizTalkUnit.Sample.Schemas.PickListSchema", typeof(global::Timewave.BizTalkUnit.Sample.Schemas.PickListSchema))]
    public sealed class OrderToPickList : global::Microsoft.BizTalk.TestTools.Mapper.TestableMapBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://Timewave.BizTalkUnit.Sample.PickListSchema"" xmlns:s0=""http://Timewave.BizTalkUnit.Sample.SourceSchema"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:CustomerOrder"" />
  </xsl:template>
  <xsl:template match=""/s0:CustomerOrder"">
    <ns0:PickList>
      <CustomerId>
        <xsl:value-of select=""CustomerId/text()"" />
      </CustomerId>
      <xsl:for-each select=""OrderLines/Line"">
        <Items>
          <Item>
            <xsl:value-of select=""ItemId/text()"" />
          </Item>
          <Quantity>
            <xsl:value-of select=""ItemQty/text()"" />
          </Quantity>
        </Items>
      </xsl:for-each>
    </ns0:PickList>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Timewave.BizTalkUnit.Sample.Schemas.SourceSchema";
        
        private const global::Timewave.BizTalkUnit.Sample.Schemas.SourceSchema _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Timewave.BizTalkUnit.Sample.Schemas.PickListSchema";
        
        private const global::Timewave.BizTalkUnit.Sample.Schemas.PickListSchema _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"Timewave.BizTalkUnit.Sample.Schemas.PickListSchema";
                return _TrgSchemas;
            }
        }
    }
}
