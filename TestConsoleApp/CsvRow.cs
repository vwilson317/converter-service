public class CsvRow
{
    [Path("IDOC.E1EDT20.E1EDL20.VBELN")]
    public string delivery_note { get; set; }

    [Path("IDOC.E1EDT20.E1EDT10.QUALF=005.NTANF")]
    public string displach_date { get; set; }

    [Path("IDOC.E1EDT20.E1EDT10.QUALF=005.NTEND")]
    public string delivery_date { get; set; }

    [Path("IDOC.E1EDT20.E1EDL20.E1EDL24.Z1EDL25.QUALF=09.VALUE")]
    public string po_number { get; set; }

    [Path("IDOC.E1EDT20.TKNUM")]
    public string shipment { get; set; }

    [Path("IDOC.E1EDT20.E1EDL20.E1EDL24.VGBEL")]
    public string our_order { get; set; }

    [Path("IDOC.E1EDT20.E1EDL20.E1EDL24.VGPOS")]
    public string our_order_item { get; set; }

    [Path("IDOC.E1EDT20.E1EDL20.INCO1&INCO2:-")]
    public string incoterms { get; set; }

    [Path("IDOC.E1EDT20.E1EDL20.E1EDL24.MATWA")]
    public string customer_article { get; set; }

    [Path("IDOC.E1EDT20.E1EDL20.E1EDL24.E1TXTH9.TDID=ZMAT&TDSPRAS=E.TDLINE")]
    public string product { get; set; }

    [Path("IDOC.E1EDT20.E1EDL20.E1EDL24.Z1EDL15.Z1CUVAL.CHARC=SUBSTANCE_GM2.VALUE")]
    public string grammage { get; set; }

    [Path("IDOC.E1EDT20.E1EDL20.E1EDL24.Z1EDL25.QUALF=40.VALUE")]
    public string width { get; set; }

    [Path("IDOC.E1EDT20.E1EDL20.E1EDL24.Z1EDL25.QUALF=41.VALUE")]
    public string length { get; set; }

    [Path("IDOC.E1EDT20.E1EDL20.E1EDL24.MFRGR")]
    public string packing { get; set; }

    [Path("IDOC.E1EDT20.E1EDL20.E1EDL24.E1TXTH9.TDID=ZCER&TDSPRAS=E.TDLINE")]
    public string certification { get; set; }

    [Path("IDOC.E1EDT20.E1EDL20.E1EDL24.Z1EDL15.Z1CUVAL.CHARC=SALES_ORDER_NO.VALUE")]
    public string sales_order { get; set; }

    [Path("IDOC.E1EDT20.E1EDL20.E1EDL24.Z1EDL15.Z1CUVAL.CHARC=PRODUCTION_ORDER_NO.VALUE")]
    public string production_order { get; set; }

    [Path("IDOC.E1EDT20.E1EDL20.E1EDL24.Z1EDL15.Z1CUVAL.CHARC=PACKAGE_ID_BAR_CODE.VALUE")]
    public string package_id_in_mes { get; set; }

    [Path("IDOC.E1EDT20.E1EDL20.E1EDL24.Z1EDL15.Z1CUVAL.CHARC=PACKING_DATE.VALUE")]
    public string packing_date { get; set; }

    [Path("IDOC.E1EDT20.E1EDL20.E1EDL24.Z1EDL15.QUALF=01.VALUE")]
    public string package { get; set; }

    [Path("IDOC.E1EDT20.E1EDL20.E1EDL24.Z1EDL15.Z1CUVAL.CHARC=WEIGHT_NET.VALUE")]
    public string net_weight { get; set; }

    [Path("IDOC.E1EDT20.E1EDL20.E1EDL24.Z1EDL15.Z1CUVAL.CHARC=WEIGHT_GROSS.VALUE")]
    public string gross_weight { get; set; }

    [Path("IDOC.E1EDT20.E1EDL20.E1EDL24.Z1EDL15.Z1CUVAL.CHARC=WEIGHT_THEORETICAL.VALUE")]
    public string thcal_weight { get; set; }

    [Path("IDOC.E1EDT20.E1EDL20.E1EDL24.Z1EDL15.Z1CUVAL.CHARC=REEL_LENGTH_M.VALUE")]
    public string reel_length { get; set; }

    [Path("IDOC.E1EDT20.E1EDL20.E1EDL24.Z1EDL15.Z1CUVAL.CHARC=REEL_DIA_MM.VALUE")]
    public string reel_diameter { get; set; }
}
