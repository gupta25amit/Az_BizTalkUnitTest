
#pragma warning disable 162

namespace Timewave.BizUnit.Sample
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(Timewave.BizUnit.Sample.__messagetype_Timewave_BizTalkUnit_Sample_Schemas_SourceSchema)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class OrderPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public OrderPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public OrderPortType(OrderPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            OrderPortType p = new OrderPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(OrderPortType),
            typeof(__messagetype_Timewave_BizTalkUnit_Sample_Schemas_SourceSchema),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(Timewave.BizUnit.Sample.__messagetype_Timewave_BizTalkUnit_Sample_Schemas_SummarySchema)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class SummaryPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public SummaryPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public SummaryPortType(SummaryPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            SummaryPortType p = new SummaryPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(SummaryPortType),
            typeof(__messagetype_Timewave_BizTalkUnit_Sample_Schemas_SummarySchema),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(Timewave.BizUnit.Sample.__messagetype_Timewave_BizTalkUnit_Sample_Schemas_PickListSchema)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PickListPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PickListPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PickListPortType(PickListPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PickListPortType p = new PickListPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PickListPortType),
            typeof(__messagetype_Timewave_BizTalkUnit_Sample_Schemas_PickListSchema),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }
    //#line 258 "C:\Users\amigupta7\Desktop\Amit\Project\GitRepo\Az_BizTalkUnitTest\Timewave.BizUnit.Sample\Orchestrations\ProcessOrder.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "OrderPort", "Operation_1", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(Timewave.BizUnit.Sample.OrderPortType),
            typeof(Timewave.BizUnit.Sample.SummaryPortType),
            typeof(Timewave.BizUnit.Sample.PickListPortType)
        },
        new System.String[] {
            "OrderPort",
            "SummaryPort",
            "PickListPort"
        },
        new System.Type[] {
            null,
            null,
            null
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceCallTreeAttribute(
        new System.Type[] {
        },
        new System.Type[] {
        },
        new System.Type[] {
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eNone
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class ProcessOrder : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eNone,
            new System.String[] {
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy()
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(ProcessOrder));
        private static volatile System.Guid[] _activationSubIds;

        private static new object _lockIdentity = new object();

        public static System.Guid UUID { get { return _serviceId; } }
        public override System.Guid ServiceId { get { return UUID; } }

        protected override System.Guid[] ActivationSubGuids
        {
            get { return _activationSubIds; }
            set { _activationSubIds = value; }
        }

        protected override object StaleStateLock
        {
            get { return _lockIdentity; }
        }

        protected override bool HasActivation { get { return true; } }

        internal bool IsExeced = false;

        static ProcessOrder()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1)
            };

            _Locks = 0;
            _rootContext = new __ProcessOrder_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public ProcessOrder(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "ProcessOrder", tracker)
        {
            ConstructorHelper();
        }

        public ProcessOrder(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "ProcessOrder")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>10c8da40-1454-439c-b97e-a69411ac55a4</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>83d63f0c-4082-42f6-8f8d-52c267057aa5</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>40d6c86b-5544-4ff9-ad43-55e568d6aaf1</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>CreateOrderSummaryMessage</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>9795d98a-ea81-4e78-ab5f-fc8960def2bf</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>a5dcb26d-f826-4a61-98ef-dc89a972cc34</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>9bb5be11-c75f-4113-8f90-dadfe2cc492e</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>4c526a31-062b-448e-b1d7-27fffb235ae6</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>65f082fa-965f-4bc3-90eb-e8d3e28b68f3</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>db5e40a6-e949-4060-8461-8dae7e3f40a5</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>CreaePickListMessage</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>82adfc92-4bee-4688-be98-523dd0692487</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_2</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>5cd709d6-0ab2-4b29-928e-967ac9c8d412</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>dc82f378-84d1-489a-b4c6-64b33af0cd52</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_4</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>d1fb9d3c-5e8f-431c-95aa-23cb140397d3</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>d48d807a-71e6-4aa6-8b35-d0ba7022914e</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'ProcessOrder'</ActionName><IsAtomic>0</IsAtomic><Line>258</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>272</Line><Position>22</Position><ShapeID>'83d63f0c-4082-42f6-8f8d-52c267057aa5'</ShapeID>
<Messages>
	<MsgInfo><name>OrderMessage</name><part>part</part><schema>Timewave.BizTalkUnit.Sample.Schemas.SourceSchema</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>274</Line><Position>13</Position><ShapeID>'40d6c86b-5544-4ff9-ad43-55e568d6aaf1'</ShapeID>
<Messages>
	<MsgInfo><name>OrderSummaryMessage</name><part>part</part><schema>Timewave.BizTalkUnit.Sample.Schemas.SummarySchema</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>OrderMessage</name><part>part</part><schema>Timewave.BizTalkUnit.Sample.Schemas.SourceSchema</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>280</Line><Position>13</Position><ShapeID>'65f082fa-965f-4bc3-90eb-e8d3e28b68f3'</ShapeID>
<Messages>
	<MsgInfo><name>OrderSummaryMessage</name><part>part</part><schema>Timewave.BizTalkUnit.Sample.Schemas.SummarySchema</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>282</Line><Position>13</Position><ShapeID>'db5e40a6-e949-4060-8461-8dae7e3f40a5'</ShapeID>
<Messages>
	<MsgInfo><name>PickListMessage</name><part>part</part><schema>Timewave.BizTalkUnit.Sample.Schemas.PickListSchema</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>OrderMessage</name><part>part</part><schema>Timewave.BizTalkUnit.Sample.Schemas.SourceSchema</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>288</Line><Position>13</Position><ShapeID>'d48d807a-71e6-4aa6-8b35-d0ba7022914e'</ShapeID>
<Messages>
	<MsgInfo><name>PickListMessage</name><part>part</part><schema>Timewave.BizTalkUnit.Sample.Schemas.PickListSchema</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='a0984ff9-2543-4890-ae6a-2d6bc59dc535' LowerBound='1.1' HigherBound='60.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='Timewave.BizUnit.Sample' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='16951878-bebc-4f61-aeaa-c710e86042c0' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='OrderPortType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='OperationDeclaration' OID='a23098c1-e165-4e8c-be7c-001fcfc28a7e' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='abc13a53-5632-4845-bbee-832c0f8e6a1f' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.61'>
                    <om:Property Name='Ref' Value='Timewave.BizTalkUnit.Sample.Schemas.SourceSchema' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='7b9762af-4982-4321-8306-a893edacf741' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SummaryPortType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='OperationDeclaration' OID='5d572e0e-db24-4b9d-8e6e-3f5afe33ca66' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='8d6a087d-78d8-4978-8157-c40a6ef81f1c' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.62'>
                    <om:Property Name='Ref' Value='Timewave.BizTalkUnit.Sample.Schemas.SummarySchema' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='fcd4a372-38e1-4f31-9583-8e4862acd098' ParentLink='Module_PortType' LowerBound='18.1' HigherBound='25.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PickListPortType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='OperationDeclaration' OID='2b7dc75c-477e-4920-873e-19d6b65275a4' ParentLink='PortType_OperationDeclaration' LowerBound='20.1' HigherBound='24.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='b78d5fbc-431a-4946-ba09-82faa97eafa7' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='22.13' HigherBound='22.63'>
                    <om:Property Name='Ref' Value='Timewave.BizTalkUnit.Sample.Schemas.PickListSchema' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='5bd10d22-c4b9-4594-9ca9-29effb1c9f74' ParentLink='Module_ServiceDeclaration' LowerBound='25.1' HigherBound='59.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='ProcessOrder' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='ServiceBody' OID='10c8da40-1454-439c-b97e-a69411ac55a4' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='83d63f0c-4082-42f6-8f8d-52c267057aa5' ParentLink='ServiceBody_Statement' LowerBound='39.1' HigherBound='41.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='OrderPort' />
                    <om:Property Name='MessageName' Value='OrderMessage' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='40d6c86b-5544-4ff9-ad43-55e568d6aaf1' ParentLink='ServiceBody_Statement' LowerBound='41.1' HigherBound='47.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='CreateOrderSummaryMessage' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Transform' OID='9795d98a-ea81-4e78-ab5f-fc8960def2bf' ParentLink='ComplexStatement_Statement' LowerBound='44.1' HigherBound='46.1'>
                        <om:Property Name='ClassName' Value='Timewave.BizUnit.Sample.Maps.OrderToSummary' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Transform_1' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='MessagePartRef' OID='a5dcb26d-f826-4a61-98ef-dc89a972cc34' ParentLink='Transform_InputMessagePartRef' LowerBound='45.96' HigherBound='45.108'>
                            <om:Property Name='MessageRef' Value='OrderMessage' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_1' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessagePartRef' OID='9bb5be11-c75f-4113-8f90-dadfe2cc492e' ParentLink='Transform_OutputMessagePartRef' LowerBound='45.28' HigherBound='45.47'>
                            <om:Property Name='MessageRef' Value='OrderSummaryMessage' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_2' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='MessageRef' OID='4c526a31-062b-448e-b1d7-27fffb235ae6' ParentLink='Construct_MessageRef' LowerBound='42.23' HigherBound='42.42'>
                        <om:Property Name='Ref' Value='OrderSummaryMessage' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='65f082fa-965f-4bc3-90eb-e8d3e28b68f3' ParentLink='ServiceBody_Statement' LowerBound='47.1' HigherBound='49.1'>
                    <om:Property Name='PortName' Value='SummaryPort' />
                    <om:Property Name='MessageName' Value='OrderSummaryMessage' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='db5e40a6-e949-4060-8461-8dae7e3f40a5' ParentLink='ServiceBody_Statement' LowerBound='49.1' HigherBound='55.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='CreaePickListMessage' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Transform' OID='82adfc92-4bee-4688-be98-523dd0692487' ParentLink='ComplexStatement_Statement' LowerBound='52.1' HigherBound='54.1'>
                        <om:Property Name='ClassName' Value='Timewave.BizUnit.Sample.Maps.OrderToPickList' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Transform_2' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='MessagePartRef' OID='5cd709d6-0ab2-4b29-928e-967ac9c8d412' ParentLink='Transform_InputMessagePartRef' LowerBound='53.93' HigherBound='53.105'>
                            <om:Property Name='MessageRef' Value='OrderMessage' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_3' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessagePartRef' OID='dc82f378-84d1-489a-b4c6-64b33af0cd52' ParentLink='Transform_OutputMessagePartRef' LowerBound='53.28' HigherBound='53.43'>
                            <om:Property Name='MessageRef' Value='PickListMessage' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_4' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='MessageRef' OID='d1fb9d3c-5e8f-431c-95aa-23cb140397d3' ParentLink='Construct_MessageRef' LowerBound='50.23' HigherBound='50.38'>
                        <om:Property Name='Ref' Value='PickListMessage' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='d48d807a-71e6-4aa6-8b35-d0ba7022914e' ParentLink='ServiceBody_Statement' LowerBound='55.1' HigherBound='57.1'>
                    <om:Property Name='PortName' Value='PickListPort' />
                    <om:Property Name='MessageName' Value='PickListMessage' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send_2' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='36eb16e0-ffd3-4b81-a5d9-a05e3cc4c95b' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='28.1' HigherBound='30.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Timewave.BizUnit.Sample.OrderPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='OrderPort' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='LogicalBindingAttribute' OID='891ebb7f-dfab-44f5-af54-a3a54706a46d' ParentLink='PortDeclaration_CLRAttribute' LowerBound='28.1' HigherBound='29.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='5ded34e7-cf02-4259-a6db-905960953741' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='30.1' HigherBound='32.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Timewave.BizUnit.Sample.SummaryPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SummaryPort' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='LogicalBindingAttribute' OID='4597902a-a06c-46c5-91ef-486f934c2bce' ParentLink='PortDeclaration_CLRAttribute' LowerBound='30.1' HigherBound='31.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='4f8503dc-feec-47b1-9ee6-ad632a5f011f' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='32.1' HigherBound='34.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Timewave.BizUnit.Sample.PickListPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='PickListPort' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='LogicalBindingAttribute' OID='c181314a-ec16-4db2-812c-ad6f72ca18cb' ParentLink='PortDeclaration_CLRAttribute' LowerBound='32.1' HigherBound='33.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='7f259437-4c1c-4506-8444-3fce20701a0f' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='34.1' HigherBound='35.1'>
                <om:Property Name='Type' Value='Timewave.BizTalkUnit.Sample.Schemas.SourceSchema' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='OrderMessage' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='d165e34d-56c1-4c3c-b52f-7b3fc11f9777' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='35.1' HigherBound='36.1'>
                <om:Property Name='Type' Value='Timewave.BizTalkUnit.Sample.Schemas.SummarySchema' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='OrderSummaryMessage' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='f060e831-5a4a-486d-b9bd-122f02c6aea0' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='36.1' HigherBound='37.1'>
                <om:Property Name='Type' Value='Timewave.BizTalkUnit.Sample.Schemas.PickListSchema' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='PickListMessage' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __ProcessOrder_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __ProcessOrder_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "ProcessOrder")
            {
            }

            public override int Index { get { return 0; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[0]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[0]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                ProcessOrder __svc__ = (ProcessOrder)_service;
                __ProcessOrder_root_0 __ctx0__ = (__ProcessOrder_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.OrderPort != null)
                {
                    __svc__.OrderPort.Close(this, null);
                    __svc__.OrderPort = null;
                }
                if (__svc__.SummaryPort != null)
                {
                    __svc__.SummaryPort.Close(this, null);
                    __svc__.SummaryPort = null;
                }
                if (__svc__.PickListPort != null)
                {
                    __svc__.PickListPort.Close(this, null);
                    __svc__.PickListPort = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __ProcessOrder_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __ProcessOrder_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "ProcessOrder")
            {
            }

            public override int Index { get { return 1; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[1]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[1]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                ProcessOrder __svc__ = (ProcessOrder)_service;
                __ProcessOrder_1 __ctx1__ = (__ProcessOrder_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__OrderMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__OrderMessage);
                    __ctx1__.__OrderMessage = null;
                }
                if (__ctx1__ != null && __ctx1__.__OrderSummaryMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__OrderSummaryMessage);
                    __ctx1__.__OrderSummaryMessage = null;
                }
                if (__ctx1__ != null && __ctx1__.__PickListMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__PickListMessage);
                    __ctx1__.__PickListMessage = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("OrderMessage")]
            public __messagetype_Timewave_BizTalkUnit_Sample_Schemas_SourceSchema __OrderMessage;
            [Microsoft.XLANGs.Core.UserVariableAttribute("OrderSummaryMessage")]
            public __messagetype_Timewave_BizTalkUnit_Sample_Schemas_SummarySchema __OrderSummaryMessage;
            [Microsoft.XLANGs.Core.UserVariableAttribute("PickListMessage")]
            public __messagetype_Timewave_BizTalkUnit_Sample_Schemas_PickListSchema __PickListMessage;
        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = null;
        public override Microsoft.XLANGs.Core.CorrelationType[] CorrelationTypes { get { return _correlationTypes; } }

        private static System.Guid[] _convoySetIds;

        public override System.Guid[] ConvoySetGuids
        {
            get { return _convoySetIds; }
            set { _convoySetIds = value; }
        }

        public static object[] StaticConvoySetInformation
        {
            get {
                return null;
            }
        }

        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("OrderPort")]
        internal OrderPortType OrderPort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("SummaryPort")]
        internal SummaryPortType SummaryPort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("PickListPort")]
        internal PickListPortType PickListPort;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {OrderPortType.Operation_1},
                                               typeof(ProcessOrder).GetField("OrderPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(ProcessOrder), "OrderPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {SummaryPortType.Operation_1},
                                               typeof(ProcessOrder).GetField("SummaryPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(ProcessOrder), "SummaryPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PickListPortType.Operation_1},
                                               typeof(ProcessOrder).GetField("PickListPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(ProcessOrder), "PickListPort"),
                                               null)
        };

        public override Microsoft.XLANGs.Core.PortInfo[] PortInformation
        {
            get { return _portInfo; }
        }

        static public System.Collections.Hashtable PortsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[_portInfo[0].Name] = _portInfo[0];
                h[_portInfo[1].Name] = _portInfo[1];
                h[_portInfo[2].Name] = _portInfo[2];
                return h;
            }
        }

        public static System.Type[] InvokedServicesTypes
        {
            get
            {
                return new System.Type[] {
                    // type of each service invoked by this service
                };
            }
        }

        public static System.Type[] CalledServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static System.Type[] ExecedServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static object[] StaticSubscriptionsInformation {
            get {
                return new object[1]{
                     new object[5] { _portInfo[0], 0, null , -1, true }
                };
            }
        }

        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "83d63f0c-4082-42f6-8f8d-52c267057aa5", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "83d63f0c-4082-42f6-8f8d-52c267057aa5", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "40d6c86b-5544-4ff9-ad43-55e568d6aaf1", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "40d6c86b-5544-4ff9-ad43-55e568d6aaf1", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "65f082fa-965f-4bc3-90eb-e8d3e28b68f3", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "65f082fa-965f-4bc3-90eb-e8d3e28b68f3", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "db5e40a6-e949-4060-8461-8dae7e3f40a5", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "db5e40a6-e949-4060-8461-8dae7e3f40a5", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "d48d807a-71e6-4aa6-8b35-d0ba7022914e", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "d48d807a-71e6-4aa6-8b35-d0ba7022914e", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "00000000-0000-0000-0000-000000000000", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,11,11,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,3,3,4,5,5,5,6,7,7,8,9,9,9,10,11,11,11,11,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __ProcessOrder_root_0 __ctx0__ = (__ProcessOrder_root_0)_stateMgrs[0];
            __ProcessOrder_1 __ctx1__ = (__ProcessOrder_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                OrderPort = new OrderPortType(0, this);
                SummaryPort = new SummaryPortType(1, this);
                PickListPort = new PickListPortType(2, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], OrderPort, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __ProcessOrder_1(this);
                _stateMgrs[1] = __ctx1__;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                __ctx0__.StartContext(__seg__, __ctx1__);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 3:
                if (!__ctx0__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.Finally();
                ServiceDone(__seg__, (Microsoft.XLANGs.Core.Context)_stateMgrs[0]);
                __ctx0__.OnCommit();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment1(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __ProcessOrder_root_0 __ctx0__ = (__ProcessOrder_root_0)_stateMgrs[0];
            __ProcessOrder_1 __ctx1__ = (__ProcessOrder_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[0],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                if (!OrderPort.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__OrderMessage != null)
                    __ctx1__.UnrefMessage(__ctx1__.__OrderMessage);
                __ctx1__.__OrderMessage = new __messagetype_Timewave_BizTalkUnit_Sample_Schemas_SourceSchema("OrderMessage", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__OrderMessage);
                OrderPort.ReceiveMessage(0, __msgEnv__, __ctx1__.__OrderMessage, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (OrderPort != null)
                {
                    OrderPort.Close(__ctx1__, __seg__);
                    OrderPort = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__OrderMessage);
                    __edata.PortName = @"OrderPort";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                {
                    __messagetype_Timewave_BizTalkUnit_Sample_Schemas_SummarySchema __OrderSummaryMessage = new __messagetype_Timewave_BizTalkUnit_Sample_Schemas_SummarySchema("OrderSummaryMessage", __ctx1__);

                    ApplyTransform(typeof(Timewave.BizUnit.Sample.Maps.OrderToSummary), new object[] {__OrderSummaryMessage.part}, new object[] {__ctx1__.__OrderMessage.part});

                    if (__ctx1__.__OrderSummaryMessage != null)
                        __ctx1__.UnrefMessage(__ctx1__.__OrderSummaryMessage);
                    __ctx1__.__OrderSummaryMessage = __OrderSummaryMessage;
                    __ctx1__.RefMessage(__ctx1__.__OrderSummaryMessage);
                }
                __ctx1__.__OrderSummaryMessage.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__OrderSummaryMessage);
                    __edata.Messages.Add(__ctx1__.__OrderMessage);
                    Tracker.FireEvent(__eventLocations[4],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                SummaryPort.SendMessage(0, __ctx1__.__OrderSummaryMessage, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if (SummaryPort != null)
                {
                    SummaryPort.Close(__ctx1__, __seg__);
                    SummaryPort = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__OrderSummaryMessage);
                    __edata.PortName = @"SummaryPort";
                    Tracker.FireEvent(__eventLocations[6],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__OrderSummaryMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__OrderSummaryMessage);
                    __ctx1__.__OrderSummaryMessage = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                {
                    __messagetype_Timewave_BizTalkUnit_Sample_Schemas_PickListSchema __PickListMessage = new __messagetype_Timewave_BizTalkUnit_Sample_Schemas_PickListSchema("PickListMessage", __ctx1__);

                    ApplyTransform(typeof(Timewave.BizUnit.Sample.Maps.OrderToPickList), new object[] {__PickListMessage.part}, new object[] {__ctx1__.__OrderMessage.part});

                    if (__ctx1__.__PickListMessage != null)
                        __ctx1__.UnrefMessage(__ctx1__.__PickListMessage);
                    __ctx1__.__PickListMessage = __PickListMessage;
                    __ctx1__.RefMessage(__ctx1__.__PickListMessage);
                }
                __ctx1__.__PickListMessage.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__PickListMessage);
                    __edata.Messages.Add(__ctx1__.__OrderMessage);
                    Tracker.FireEvent(__eventLocations[8],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__OrderMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__OrderMessage);
                    __ctx1__.__OrderMessage = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                PickListPort.SendMessage(0, __ctx1__.__PickListMessage, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if (PickListPort != null)
                {
                    PickListPort.Close(__ctx1__, __seg__);
                    PickListPort = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__PickListMessage);
                    __edata.PortName = @"PickListPort";
                    Tracker.FireEvent(__eventLocations[10],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__PickListMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__PickListMessage);
                    __ctx1__.__PickListMessage = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                if ( !PreProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[11],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 20;
            case 20:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 21;
            case 21:
                if ( !PreProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 22;
            case 22:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }

    [System.SerializableAttribute]
    sealed public class __Timewave_BizTalkUnit_Sample_Schemas_SourceSchema__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Timewave.BizTalkUnit.Sample.Schemas.SourceSchema _schema = new Timewave.BizTalkUnit.Sample.Schemas.SourceSchema();

        public __Timewave_BizTalkUnit_Sample_Schemas_SourceSchema__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Timewave.BizTalkUnit.Sample.Schemas.SourceSchema",
        new System.Type[]{
            typeof(Timewave.BizTalkUnit.Sample.Schemas.SourceSchema)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Timewave_BizTalkUnit_Sample_Schemas_SourceSchema__)
        },
        0,
        @"http://Timewave.BizTalkUnit.Sample.SourceSchema#CustomerOrder"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Timewave_BizTalkUnit_Sample_Schemas_SourceSchema : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Timewave_BizTalkUnit_Sample_Schemas_SourceSchema__ part;

        private void __CreatePartWrappers()
        {
            part = new __Timewave_BizTalkUnit_Sample_Schemas_SourceSchema__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Timewave_BizTalkUnit_Sample_Schemas_SourceSchema(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Timewave_BizTalkUnit_Sample_Schemas_SummarySchema__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Timewave.BizTalkUnit.Sample.Schemas.SummarySchema _schema = new Timewave.BizTalkUnit.Sample.Schemas.SummarySchema();

        public __Timewave_BizTalkUnit_Sample_Schemas_SummarySchema__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Timewave.BizTalkUnit.Sample.Schemas.SummarySchema",
        new System.Type[]{
            typeof(Timewave.BizTalkUnit.Sample.Schemas.SummarySchema)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Timewave_BizTalkUnit_Sample_Schemas_SummarySchema__)
        },
        0,
        @"http://Timewave.BizTalkUnit.Sample.DestinationSchema#CustomerSummary"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Timewave_BizTalkUnit_Sample_Schemas_SummarySchema : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Timewave_BizTalkUnit_Sample_Schemas_SummarySchema__ part;

        private void __CreatePartWrappers()
        {
            part = new __Timewave_BizTalkUnit_Sample_Schemas_SummarySchema__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Timewave_BizTalkUnit_Sample_Schemas_SummarySchema(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Timewave_BizTalkUnit_Sample_Schemas_PickListSchema__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Timewave.BizTalkUnit.Sample.Schemas.PickListSchema _schema = new Timewave.BizTalkUnit.Sample.Schemas.PickListSchema();

        public __Timewave_BizTalkUnit_Sample_Schemas_PickListSchema__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Timewave.BizTalkUnit.Sample.Schemas.PickListSchema",
        new System.Type[]{
            typeof(Timewave.BizTalkUnit.Sample.Schemas.PickListSchema)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Timewave_BizTalkUnit_Sample_Schemas_PickListSchema__)
        },
        0,
        @"http://Timewave.BizTalkUnit.Sample.PickListSchema#PickList"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Timewave_BizTalkUnit_Sample_Schemas_PickListSchema : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Timewave_BizTalkUnit_Sample_Schemas_PickListSchema__ part;

        private void __CreatePartWrappers()
        {
            part = new __Timewave_BizTalkUnit_Sample_Schemas_PickListSchema__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Timewave_BizTalkUnit_Sample_Schemas_PickListSchema(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
