   /* 
    Licensed under the Apache License, Version 2.0
    
    http://www.apache.org/licenses/LICENSE-2.0
    */
using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace Xml2CSharp
{
	[XmlRoot(ElementName="EDI_DC40")]
	public class EDI_DC40 {
		[XmlElement(ElementName="TABNAM")]
		public string TABNAM { get; set; }
		[XmlElement(ElementName="MANDT")]
		public string MANDT { get; set; }
		[XmlElement(ElementName="DOCNUM")]
		public string DOCNUM { get; set; }
		[XmlElement(ElementName="DOCREL")]
		public string DOCREL { get; set; }
		[XmlElement(ElementName="STATUS")]
		public string STATUS { get; set; }
		[XmlElement(ElementName="DIRECT")]
		public string DIRECT { get; set; }
		[XmlElement(ElementName="OUTMOD")]
		public string OUTMOD { get; set; }
		[XmlElement(ElementName="IDOCTYP")]
		public string IDOCTYP { get; set; }
		[XmlElement(ElementName="CIMTYP")]
		public string CIMTYP { get; set; }
		[XmlElement(ElementName="MESTYP")]
		public string MESTYP { get; set; }
		[XmlElement(ElementName="MESCOD")]
		public string MESCOD { get; set; }
		[XmlElement(ElementName="SNDPOR")]
		public string SNDPOR { get; set; }
		[XmlElement(ElementName="SNDPRT")]
		public string SNDPRT { get; set; }
		[XmlElement(ElementName="SNDPRN")]
		public string SNDPRN { get; set; }
		[XmlElement(ElementName="RCVPOR")]
		public string RCVPOR { get; set; }
		[XmlElement(ElementName="RCVPRT")]
		public string RCVPRT { get; set; }
		[XmlElement(ElementName="RCVPFC")]
		public string RCVPFC { get; set; }
		[XmlElement(ElementName="RCVPRN")]
		public string RCVPRN { get; set; }
		[XmlElement(ElementName="CREDAT")]
		public string CREDAT { get; set; }
		[XmlElement(ElementName="CRETIM")]
		public string CRETIM { get; set; }
		[XmlElement(ElementName="SERIAL")]
		public string SERIAL { get; set; }
		[XmlAttribute(AttributeName="SEGMENT")]
		public string SEGMENT { get; set; }
	}

	[XmlRoot(ElementName="Z1EDIDC")]
	public class Z1EDIDC {
		[XmlElement(ElementName="MSGFN")]
		public string MSGFN { get; set; }
		[XmlAttribute(AttributeName="SEGMENT")]
		public string SEGMENT { get; set; }
	}

	[XmlRoot(ElementName="Z1EDT20")]
	public class Z1EDT20 {
		[XmlElement(ElementName="QUALF")]
		public string QUALF { get; set; }
		[XmlElement(ElementName="VALUE")]
		public string VALUE { get; set; }
		[XmlAttribute(AttributeName="SEGMENT")]
		public string SEGMENT { get; set; }
		[XmlElement(ElementName="VALUE2")]
		public string VALUE2 { get; set; }
	}

	[XmlRoot(ElementName="E1EDT22")]
	public class E1EDT22 {
		[XmlElement(ElementName="SHTYP_BEZ")]
		public string SHTYP_BEZ { get; set; }
		[XmlElement(ElementName="BFART_BEZ")]
		public string BFART_BEZ { get; set; }
		[XmlElement(ElementName="VSART_BEZ")]
		public string VSART_BEZ { get; set; }
		[XmlElement(ElementName="LAUFK_BEZ")]
		public string LAUFK_BEZ { get; set; }
		[XmlElement(ElementName="ROUTE_BEZ")]
		public string ROUTE_BEZ { get; set; }
		[XmlElement(ElementName="STTRG_BEZ")]
		public string STTRG_BEZ { get; set; }
		[XmlElement(ElementName="FBGST_BEZ")]
		public string FBGST_BEZ { get; set; }
		[XmlAttribute(AttributeName="SEGMENT")]
		public string SEGMENT { get; set; }
	}

	[XmlRoot(ElementName="E1ADRM4")]
	public class E1ADRM4 {
		[XmlElement(ElementName="PARTNER_Q")]
		public string PARTNER_Q { get; set; }
		[XmlElement(ElementName="PARTNER_ID")]
		public string PARTNER_ID { get; set; }
		[XmlElement(ElementName="LANGUAGE")]
		public string LANGUAGE { get; set; }
		[XmlElement(ElementName="NAME1")]
		public string NAME1 { get; set; }
		[XmlElement(ElementName="STREET1")]
		public string STREET1 { get; set; }
		[XmlElement(ElementName="POSTL_COD1")]
		public string POSTL_COD1 { get; set; }
		[XmlElement(ElementName="CITY1")]
		public string CITY1 { get; set; }
		[XmlElement(ElementName="TELEFAX")]
		public string TELEFAX { get; set; }
		[XmlElement(ElementName="E_MAIL")]
		public string E_MAIL { get; set; }
		[XmlElement(ElementName="COUNTRY1")]
		public string COUNTRY1 { get; set; }
		[XmlAttribute(AttributeName="SEGMENT")]
		public string SEGMENT { get; set; }
	}

	[XmlRoot(ElementName="E1EDT10")]
	public class E1EDT10 {
		[XmlElement(ElementName="QUALF")]
		public string QUALF { get; set; }
		[XmlElement(ElementName="NTANF")]
		public string NTANF { get; set; }
		[XmlElement(ElementName="NTANZ")]
		public string NTANZ { get; set; }
		[XmlElement(ElementName="NTEND")]
		public string NTEND { get; set; }
		[XmlElement(ElementName="NTENZ")]
		public string NTENZ { get; set; }
		[XmlElement(ElementName="ISDD")]
		public string ISDD { get; set; }
		[XmlElement(ElementName="ISDZ")]
		public string ISDZ { get; set; }
		[XmlElement(ElementName="IEDD")]
		public string IEDD { get; set; }
		[XmlElement(ElementName="IEDZ")]
		public string IEDZ { get; set; }
		[XmlAttribute(AttributeName="SEGMENT")]
		public string SEGMENT { get; set; }
	}

	[XmlRoot(ElementName="E1TXTH6")]
	public class E1TXTH6 {
		[XmlElement(ElementName="TDOBJECT")]
		public string TDOBJECT { get; set; }
		[XmlElement(ElementName="TDOBNAME")]
		public string TDOBNAME { get; set; }
		[XmlElement(ElementName="TDID")]
		public string TDID { get; set; }
		[XmlElement(ElementName="TDSPRAS")]
		public string TDSPRAS { get; set; }
		[XmlElement(ElementName="LANGUA_ISO")]
		public string LANGUA_ISO { get; set; }
		[XmlAttribute(AttributeName="SEGMENT")]
		public string SEGMENT { get; set; }
		[XmlElement(ElementName="E1TXTP6")]
		public List<E1TXTP6> E1TXTP6 { get; set; }
	}

	[XmlRoot(ElementName="E1TXTP6")]
	public class E1TXTP6 {
		[XmlElement(ElementName="TDFORMAT")]
		public string TDFORMAT { get; set; }
		[XmlElement(ElementName="TDLINE")]
		public string TDLINE { get; set; }
		[XmlAttribute(AttributeName="SEGMENT")]
		public string SEGMENT { get; set; }
	}

	[XmlRoot(ElementName="E1EDT50")]
	public class E1EDT50 {
		[XmlElement(ElementName="TSTYP_BEZ")]
		public string TSTYP_BEZ { get; set; }
		[XmlElement(ElementName="LAUFK_BEZ")]
		public string LAUFK_BEZ { get; set; }
		[XmlElement(ElementName="FBSTA_BEZ")]
		public string FBSTA_BEZ { get; set; }
		[XmlAttribute(AttributeName="SEGMENT")]
		public string SEGMENT { get; set; }
	}

	[XmlRoot(ElementName="E1EDT44")]
	public class E1EDT44 {
		[XmlElement(ElementName="QUALI")]
		public string QUALI { get; set; }
		[XmlElement(ElementName="KNOTE")]
		public string KNOTE { get; set; }
		[XmlElement(ElementName="WERKS")]
		public string WERKS { get; set; }
		[XmlAttribute(AttributeName="SEGMENT")]
		public string SEGMENT { get; set; }
	}

	[XmlRoot(ElementName="E1EDK33")]
	public class E1EDK33 {
		[XmlElement(ElementName="TSNUM")]
		public string TSNUM { get; set; }
		[XmlElement(ElementName="TSRFO")]
		public string TSRFO { get; set; }
		[XmlElement(ElementName="TSTYP")]
		public string TSTYP { get; set; }
		[XmlElement(ElementName="LAUFK")]
		public string LAUFK { get; set; }
		[XmlElement(ElementName="DISTZ")]
		public string DISTZ { get; set; }
		[XmlElement(ElementName="FAHZT")]
		public string FAHZT { get; set; }
		[XmlElement(ElementName="GESZT")]
		public string GESZT { get; set; }
		[XmlElement(ElementName="GESZTD")]
		public string GESZTD { get; set; }
		[XmlElement(ElementName="FAHZTD")]
		public string FAHZTD { get; set; }
		[XmlElement(ElementName="GESZTDA")]
		public string GESZTDA { get; set; }
		[XmlElement(ElementName="FAHZTDA")]
		public string FAHZTDA { get; set; }
		[XmlElement(ElementName="FRKRL")]
		public string FRKRL { get; set; }
		[XmlElement(ElementName="SKALSM")]
		public string SKALSM { get; set; }
		[XmlElement(ElementName="FBSTA")]
		public string FBSTA { get; set; }
		[XmlElement(ElementName="WARZTD")]
		public string WARZTD { get; set; }
		[XmlElement(ElementName="WARZTDA")]
		public string WARZTDA { get; set; }
		[XmlElement(ElementName="E1EDT50")]
		public E1EDT50 E1EDT50 { get; set; }
		[XmlElement(ElementName="E1EDT44")]
		public List<E1EDT44> E1EDT44 { get; set; }
		[XmlAttribute(AttributeName="SEGMENT")]
		public string SEGMENT { get; set; }
	}

	[XmlRoot(ElementName="E1EDT47")]
	public class E1EDT47 {
		[XmlElement(ElementName="ADD02")]
		public string ADD02 { get; set; }
		[XmlAttribute(AttributeName="SEGMENT")]
		public string SEGMENT { get; set; }
	}

	[XmlRoot(ElementName="Z1EDL20")]
	public class Z1EDL20 {
		[XmlElement(ElementName="QUALF")]
		public string QUALF { get; set; }
		[XmlElement(ElementName="VALUE")]
		public string VALUE { get; set; }
		[XmlAttribute(AttributeName="SEGMENT")]
		public string SEGMENT { get; set; }
		[XmlElement(ElementName="VALUE2")]
		public string VALUE2 { get; set; }
	}

	[XmlRoot(ElementName="E1ADRE1")]
	public class E1ADRE1 {
		[XmlElement(ElementName="EXTEND_Q")]
		public string EXTEND_Q { get; set; }
		[XmlElement(ElementName="EXTEND_D")]
		public string EXTEND_D { get; set; }
		[XmlAttribute(AttributeName="SEGMENT")]
		public string SEGMENT { get; set; }
	}

	[XmlRoot(ElementName="E1ADRM1")]
	public class E1ADRM1 {
		[XmlElement(ElementName="PARTNER_Q")]
		public string PARTNER_Q { get; set; }
		[XmlElement(ElementName="PARTNER_ID")]
		public string PARTNER_ID { get; set; }
		[XmlElement(ElementName="LANGUAGE")]
		public string LANGUAGE { get; set; }
		[XmlElement(ElementName="NAME1")]
		public string NAME1 { get; set; }
		[XmlElement(ElementName="STREET1")]
		public string STREET1 { get; set; }
		[XmlElement(ElementName="POSTL_COD1")]
		public string POSTL_COD1 { get; set; }
		[XmlElement(ElementName="CITY1")]
		public string CITY1 { get; set; }
		[XmlElement(ElementName="TELEX")]
		public string TELEX { get; set; }
		[XmlElement(ElementName="E_MAIL")]
		public string E_MAIL { get; set; }
		[XmlElement(ElementName="COUNTRY1")]
		public string COUNTRY1 { get; set; }
		[XmlElement(ElementName="E1ADRE1")]
		public E1ADRE1 E1ADRE1 { get; set; }
		[XmlAttribute(AttributeName="SEGMENT")]
		public string SEGMENT { get; set; }
		[XmlElement(ElementName="NAME2")]
		public string NAME2 { get; set; }
		[XmlElement(ElementName="FORMOFADDR")]
		public string FORMOFADDR { get; set; }
		[XmlElement(ElementName="TELEPHONE1")]
		public string TELEPHONE1 { get; set; }
		[XmlElement(ElementName="TELEFAX")]
		public string TELEFAX { get; set; }
	}

	[XmlRoot(ElementName="E1EDT13")]
	public class E1EDT13 {
		[XmlElement(ElementName="QUALF")]
		public string QUALF { get; set; }
		[XmlElement(ElementName="NTANF")]
		public string NTANF { get; set; }
		[XmlElement(ElementName="NTANZ")]
		public string NTANZ { get; set; }
		[XmlElement(ElementName="NTEND")]
		public string NTEND { get; set; }
		[XmlElement(ElementName="NTENZ")]
		public string NTENZ { get; set; }
		[XmlElement(ElementName="TZONE_BEG")]
		public string TZONE_BEG { get; set; }
		[XmlElement(ElementName="ISDD")]
		public string ISDD { get; set; }
		[XmlElement(ElementName="ISDZ")]
		public string ISDZ { get; set; }
		[XmlElement(ElementName="IEDD")]
		public string IEDD { get; set; }
		[XmlElement(ElementName="IEDZ")]
		public string IEDZ { get; set; }
		[XmlElement(ElementName="TZONE_END")]
		public string TZONE_END { get; set; }
		[XmlAttribute(AttributeName="SEGMENT")]
		public string SEGMENT { get; set; }
	}

	[XmlRoot(ElementName="Z1EDL25")]
	public class Z1EDL25 {
		[XmlElement(ElementName="QUALF")]
		public string QUALF { get; set; }
		[XmlElement(ElementName="VALUE")]
		public string VALUE { get; set; }
		[XmlElement(ElementName="VALUE2")]
		public string VALUE2 { get; set; }
		[XmlAttribute(AttributeName="SEGMENT")]
		public string SEGMENT { get; set; }
	}

	[XmlRoot(ElementName="Z1CUVAL")]
	public class Z1CUVAL {
		[XmlElement(ElementName="INST_ID")]
		public string INST_ID { get; set; }
		[XmlElement(ElementName="CHARC")]
		public string CHARC { get; set; }
		[XmlElement(ElementName="CHARC_TXT")]
		public string CHARC_TXT { get; set; }
		[XmlElement(ElementName="VALUE")]
		public string VALUE { get; set; }
		[XmlElement(ElementName="VALUE_TXT")]
		public string VALUE_TXT { get; set; }
		[XmlAttribute(AttributeName="SEGMENT")]
		public string SEGMENT { get; set; }
		[XmlElement(ElementName="AUTHOR")]
		public string AUTHOR { get; set; }
	}

	[XmlRoot(ElementName="Z1EDL15")]
	public class Z1EDL15 {
		[XmlElement(ElementName="QUALF")]
		public string QUALF { get; set; }
		[XmlElement(ElementName="VALUE")]
		public string VALUE { get; set; }
		[XmlElement(ElementName="Z1CUVAL")]
		public List<Z1CUVAL> Z1CUVAL { get; set; }
		[XmlAttribute(AttributeName="SEGMENT")]
		public string SEGMENT { get; set; }
	}

	[XmlRoot(ElementName="E1TXTP9")]
	public class E1TXTP9 {
		[XmlElement(ElementName="TDFORMAT")]
		public string TDFORMAT { get; set; }
		[XmlElement(ElementName="TDLINE")]
		public string TDLINE { get; set; }
		[XmlAttribute(AttributeName="SEGMENT")]
		public string SEGMENT { get; set; }
	}

	[XmlRoot(ElementName="E1TXTH9")]
	public class E1TXTH9 {
		[XmlElement(ElementName="TDOBJECT")]
		public string TDOBJECT { get; set; }

		[XmlElement(ElementName="TDOBNAME")]
		public string TDOBNAME { get; set; }

		[XmlElement(ElementName="TDID")]
		public string TDID { get; set; }

		[XmlElement(ElementName="TDSPRAS")]
		public string TDSPRAS { get; set; }

		[XmlElement(ElementName="LANGUA_ISO")]
		public string LANGUA_ISO { get; set; }

		[XmlElement(ElementName="E1TXTP9")]
		public List<E1TXTP9> E1TXTP9 { get; set; }

		[XmlAttribute(AttributeName="SEGMENT")]
		public string SEGMENT { get; set; }
	}

	[XmlRoot(ElementName="E1EDL24")]
	public class E1EDL24 {
		[XmlElement(ElementName="POSNR")]
		public string POSNR { get; set; }
		[XmlElement(ElementName="MATNR")]
		public string MATNR { get; set; }
		[XmlElement(ElementName="MATWA")]
		public string MATWA { get; set; }
		[XmlElement(ElementName="ARKTX")]
		public string ARKTX { get; set; }
		[XmlElement(ElementName="MATKL")]
		public string MATKL { get; set; }
		[XmlElement(ElementName="WERKS")]
		public string WERKS { get; set; }
		[XmlElement(ElementName="LGORT")]
		public string LGORT { get; set; }
		[XmlElement(ElementName="KDMAT")]
		public string KDMAT { get; set; }
		[XmlElement(ElementName="LFIMG")]
		public string LFIMG { get; set; }
		[XmlElement(ElementName="VRKME")]
		public string VRKME { get; set; }
		[XmlElement(ElementName="LGMNG")]
		public string LGMNG { get; set; }
		[XmlElement(ElementName="MEINS")]
		public string MEINS { get; set; }
		[XmlElement(ElementName="NTGEW")]
		public string NTGEW { get; set; }
		[XmlElement(ElementName="BRGEW")]
		public string BRGEW { get; set; }
		[XmlElement(ElementName="GEWEI")]
		public string GEWEI { get; set; }
		[XmlElement(ElementName="VOLUM")]
		public string VOLUM { get; set; }
		[XmlElement(ElementName="VOLEH")]
		public string VOLEH { get; set; }
		[XmlElement(ElementName="VKBUR")]
		public string VKBUR { get; set; }
		[XmlElement(ElementName="VTWEG")]
		public string VTWEG { get; set; }
		[XmlElement(ElementName="SPART")]
		public string SPART { get; set; }
		[XmlElement(ElementName="GRKOR")]
		public string GRKOR { get; set; }
		[XmlElement(ElementName="MFRGR")]
		public string MFRGR { get; set; }
		[XmlElement(ElementName="POSEX")]
		public string POSEX { get; set; }
		[XmlElement(ElementName="VFDAT")]
		public string VFDAT { get; set; }
		[XmlElement(ElementName="EXPIRY_DATE_EXT")]
		public string EXPIRY_DATE_EXT { get; set; }
		[XmlElement(ElementName="VGBEL")]
		public string VGBEL { get; set; }
		[XmlElement(ElementName="VGPOS")]
		public string VGPOS { get; set; }
		[XmlElement(ElementName="ORMNG")]
		public string ORMNG { get; set; }
		[XmlElement(ElementName="EXPIRY_DATE_EXT_B")]
		public string EXPIRY_DATE_EXT_B { get; set; }
		[XmlElement(ElementName="Z1EDL25")]
		public List<Z1EDL25> Z1EDL25 { get; set; }
		[XmlElement(ElementName="Z1EDL15")]
		public List<Z1EDL15> Z1EDL15 { get; set; }
		[XmlElement(ElementName="E1TXTH9")]
		public List<E1TXTH9> E1TXTH9 { get; set; }
		[XmlAttribute(AttributeName="SEGMENT")]
		public string SEGMENT { get; set; }
	}

	[XmlRoot(ElementName="E1EDL20")]
	public class E1EDL20 {
		[XmlElement(ElementName="VBELN")]
		public string VBELN { get; set; }
		[XmlElement(ElementName="VSTEL")]
		public string VSTEL { get; set; }
		[XmlElement(ElementName="VKORG")]
		public string VKORG { get; set; }
		[XmlElement(ElementName="LGNUM")]
		public string LGNUM { get; set; }
		[XmlElement(ElementName="ABLAD")]
		public string ABLAD { get; set; }
		[XmlElement(ElementName="INCO1")]
		public string INCO1 { get; set; }
		[XmlElement(ElementName="INCO2")]
		public string INCO2 { get; set; }
		[XmlElement(ElementName="ROUTE")]
		public string ROUTE { get; set; }
		[XmlElement(ElementName="BTGEW")]
		public string BTGEW { get; set; }
		[XmlElement(ElementName="NTGEW")]
		public string NTGEW { get; set; }
		[XmlElement(ElementName="GEWEI")]
		public string GEWEI { get; set; }
		[XmlElement(ElementName="VOLUM")]
		public string VOLUM { get; set; }
		[XmlElement(ElementName="VOLEH")]
		public string VOLEH { get; set; }
		[XmlElement(ElementName="ANZPK")]
		public string ANZPK { get; set; }
		[XmlElement(ElementName="PODAT")]
		public string PODAT { get; set; }
		[XmlElement(ElementName="POTIM")]
		public string POTIM { get; set; }
		[XmlElement(ElementName="Z1EDL20")]
		public List<Z1EDL20> Z1EDL20 { get; set; }
		[XmlElement(ElementName="E1ADRM1")]
		public List<E1ADRM1> E1ADRM1 { get; set; }
		[XmlElement(ElementName="E1EDT13")]
		public List<E1EDT13> E1EDT13 { get; set; }
		[XmlElement(ElementName="E1EDL24")]
		public E1EDL24 E1EDL24 { get; set; }
		[XmlAttribute(AttributeName="SEGMENT")]
		public string SEGMENT { get; set; }
	}

	[XmlRoot(ElementName="E1EDT20")]
	public class E1EDT20 {
		[XmlElement(ElementName="TKNUM")]
		public string TKNUM { get; set; }
		[XmlElement(ElementName="SHTYP")]
		public string SHTYP { get; set; }
		[XmlElement(ElementName="ABFER")]
		public string ABFER { get; set; }
		[XmlElement(ElementName="ABWST")]
		public string ABWST { get; set; }
		[XmlElement(ElementName="BFART")]
		public string BFART { get; set; }
		[XmlElement(ElementName="VSART")]
		public string VSART { get; set; }
		[XmlElement(ElementName="LAUFK")]
		public string LAUFK { get; set; }
		[XmlElement(ElementName="ROUTE")]
		public string ROUTE { get; set; }
		[XmlElement(ElementName="EXTI1")]
		public string EXTI1 { get; set; }
		[XmlElement(ElementName="STTRG")]
		public string STTRG { get; set; }
		[XmlElement(ElementName="DTMEG")]
		public string DTMEG { get; set; }
		[XmlElement(ElementName="DTMEV")]
		public string DTMEV { get; set; }
		[XmlElement(ElementName="DISTZ")]
		public string DISTZ { get; set; }
		[XmlElement(ElementName="FAHZT")]
		public string FAHZT { get; set; }
		[XmlElement(ElementName="GESZT")]
		public string GESZT { get; set; }
		[XmlElement(ElementName="FBGST")]
		public string FBGST { get; set; }
		[XmlElement(ElementName="STERM_DONE")]
		public string STERM_DONE { get; set; }
		[XmlElement(ElementName="SDABW")]
		public string SDABW { get; set; }
		[XmlElement(ElementName="GESZTD")]
		public string GESZTD { get; set; }
		[XmlElement(ElementName="FAHZTD")]
		public string FAHZTD { get; set; }
		[XmlElement(ElementName="GESZTDA")]
		public string GESZTDA { get; set; }
		[XmlElement(ElementName="FAHZTDA")]
		public string FAHZTDA { get; set; }
		[XmlElement(ElementName="WARZTD")]
		public string WARZTD { get; set; }
		[XmlElement(ElementName="WARZTDA")]
		public string WARZTDA { get; set; }
		[XmlElement(ElementName="EXT_FREIGHT_ORDER")]
		public string EXT_FREIGHT_ORDER { get; set; }
		[XmlElement(ElementName="EXT_TM_SYS")]
		public string EXT_TM_SYS { get; set; }
		[XmlElement(ElementName="Z1EDIDC")]
		public Z1EDIDC Z1EDIDC { get; set; }
		[XmlElement(ElementName="Z1EDT20")]
		public List<Z1EDT20> Z1EDT20 { get; set; }
		[XmlElement(ElementName="E1EDT22")]
		public E1EDT22 E1EDT22 { get; set; }
		[XmlElement(ElementName="E1ADRM4")]
		public List<E1ADRM4> E1ADRM4 { get; set; }
		[XmlElement(ElementName="E1EDT10")]
		public List<E1EDT10> E1EDT10 { get; set; }
		[XmlElement(ElementName="E1TXTH6")]
		public List<E1TXTH6> E1TXTH6 { get; set; }
		[XmlElement(ElementName="E1EDK33")]
		public E1EDK33 E1EDK33 { get; set; }
		[XmlElement(ElementName="E1EDT47")]
		public E1EDT47 E1EDT47 { get; set; }
		[XmlElement(ElementName="E1EDL20")]
		public E1EDL20 E1EDL20 { get; set; }
		[XmlAttribute(AttributeName="SEGMENT")]
		public string SEGMENT { get; set; }
	}

	[XmlRoot(ElementName="IDOC")]
	public class IDOC {
		[XmlElement(ElementName="EDI_DC40")]
		public EDI_DC40 EDI_DC40 { get; set; }
		[XmlElement(ElementName="E1EDT20")]
		public E1EDT20 E1EDT20 { get; set; }
		[XmlAttribute(AttributeName="BEGIN")]
		public string BEGIN { get; set; }
	}

	[XmlRoot(ElementName="ZCUST")]
	public class ZCUST {
		[XmlElement(ElementName="IDOC")]
		public IDOC IDOC { get; set; }
	}

}
