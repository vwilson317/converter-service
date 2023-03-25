using FluentAssertions;
using Xml2CSharp;

namespace MyTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void product()
        {
            //arrange
            var path = @$"{nameof(IDOC)}.{nameof(E1EDT20)}.{nameof(E1EDL20)}.{nameof(E1EDL24)}.{nameof(E1TXTH9)}.
                {nameof(E1TXTH9.TDID)}=ZMAT&{nameof(E1TXTH9.TDSPRAS)}=E.{nameof(E1TXTP6.TDLINE)}";
            var expected = "75% PEFC certified. INS-PEFC-COC-205328";
            var data = new ZCUST();
            data.IDOC = new IDOC
            {
                E1EDT20 = new E1EDT20
                {
                    E1EDL20 = new E1EDL20
                    {
                        E1EDL24 = new E1EDL24
                        {
                            E1TXTH9 = new List<E1TXTH9>
                            {
                                //product
                                new E1TXTH9{TDID = "ZMAT", TDSPRAS = "E", E1TXTP9 = new List<E1TXTP9>{
                                    new E1TXTP9 { TDLINE = expected }
                                }},
                                //certifaction
                                new E1TXTH9{TDID = "ZCER", TDSPRAS = "E", E1TXTP9 = new List<E1TXTP9>{
                                    new E1TXTP9 { TDLINE = "CLASSIC FBB 225,0 G/M2 REEL" }
                                }},
                            }
                        }
                    }
                }
            };

            //act
            var actual = XmlToCsvService.GetValueByPath(data, path, null);

            //assert
            expected.Should().Be(actual.ToString());
        }

        [Test]
        public void incoterms()
        {
            //arrange
            var path = @$"{nameof(IDOC)}.{nameof(E1EDT20)}.{nameof(E1EDL20)}.{nameof(E1EDL20.INCO1)}&{nameof(E1EDL20.INCO2)}";
            var expected = "DAP-OGGIONO (LC)";
            var data = new ZCUST();
            data.IDOC = new IDOC
            {
                E1EDT20 = new E1EDT20
                {
                    E1EDL20 = new E1EDL20
                    {
                        INCO1 = "DAP",
                        INCO2 = "OGGIONO (LC)"
                    }
                }
            };

            //act
            var actual = XmlToCsvService.GetValueByPath(data, path, '-');

            //assert
            expected.Should().Be(actual.ToString());
        }
    }
}