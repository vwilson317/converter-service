using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using CsvHelper;
using CsvHelper.Configuration;
using Xml2CSharp;

public static class XmlToCsvService
{
    public static string ConvertXmlsToCsvs(string inputDirectoryPath, string schemaFilePath)
    {
        // Load schema file
        XmlSchemaSet schemaSet = new XmlSchemaSet();
        schemaSet.Add("", schemaFilePath);

        // Create XML reader settings with schema validation
        XmlReaderSettings readerSettings = new XmlReaderSettings();
        readerSettings.Schemas = schemaSet;
        readerSettings.ValidationType = ValidationType.Schema;
        readerSettings.ValidationFlags |= XmlSchemaValidationFlags.ReportValidationWarnings;
        readerSettings.ValidationEventHandler += ValidationCallback;

        // Configure CSV writer settings
        var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            HasHeaderRecord = true,
            Delimiter = ",",
        };

        // Get list of XML files in input directory
        string[] xmlFilePaths = Directory.GetFiles(inputDirectoryPath, "*.xml");

        // Convert each XML file to a CSV file
        var csvFiles = new List<string>();
        foreach (string xmlFilePath in xmlFilePaths)
        {
            string csvFilePath = Path.ChangeExtension(xmlFilePath, "csv");
            csvFiles.Add(csvFilePath);
            // Read XML elements and write CSV rows
            using (XmlReader reader = XmlReader.Create(xmlFilePath, readerSettings))
            using (var writer = new StreamWriter(csvFilePath))
            using (var csv = new CsvWriter(writer, csvConfig))
            {
                var serializer = new XmlSerializer(typeof(ZCUST));
                var data = serializer.Deserialize(reader) as ZCUST;

                var props = typeof(CsvRow).GetProperties();
                var row = new CsvRow();

                foreach (var prop in props)
                {
                    var attribute = prop.GetAttribute<PathAttribute>();
                    var value = GetValueByPath(data, attribute.Value, attribute.Separator);
                    prop.SetValue(row, value);
                }
                // Write CSV rows
                csv.WriteRecords(new[] { row });
            }

        }
        return string.Join(Environment.NewLine, csvFiles);

    }

    private static void ValidationCallback(object sender, ValidationEventArgs e)
    {
        if (e.Severity == XmlSeverityType.Error)
        {
            throw new XmlSchemaValidationException(e.Message);
        }
    }

    public static object GetValueByPath(object obj, string propPath, char? seperator)
    {
        var propNames = propPath.Split('.');
        for (var i =0; i < propNames.Length; i++)
        {
            var propName = propNames[i];
            if (propName.Contains("&"))
            {
                var comboProps = propName.Split('&');
                var valueList = new List<dynamic>();

                //prop precedding prop ***special case***
                var items = obj as IEnumerable<E1TXTH9>;
                if (items != null)
                {
                    var item = items.FirstOrDefault(x => x.TDID == comboProps[0].Split("=")[1] && x.TDSPRAS == comboProps[1].Split("=")[1]);
                    return item.E1TXTP9.FirstOrDefault().TDLINE;
                }

                foreach (var comboProp in comboProps)
                {
                    if (comboProp.Contains("="))
                    {
                        var propNameAndFilter = comboProp.Split('=');
                        obj.GetType().GetProperties().Where(x => x.Name == propNameAndFilter[0]).ToList().ForEach(x =>
                        {
                            var prop = x.GetValue(obj, null);
                            valueList.Add(prop);
                        });
                    }
                    else
                    {
                        var prop = obj.GetType().GetProperty(comboProp).GetValue(obj, null);
                        valueList.Add(prop);
                    }
                }
                if (seperator.HasValue)
                {
                    return string.Join(seperator.Value, valueList);
                }
                else
                {
                    return string.Concat(valueList);
                }
            }
            if (propName.Contains("="))
            {
                obj = GetCollection(obj, propName);
            }
            else
            {
                var castedItems = obj as IEnumerable<Z1EDL15>;
                if (castedItems != null)
                {
                    //these will have two more props after that we'll ignore for now
                    var valueForCHARC = propNames[i + 1].Split("=")[1];
                    return castedItems.SelectMany(x => x.Z1CUVAL).FirstOrDefault(z1 => z1.CHARC == valueForCHARC.ToUpper()).VALUE;
                }

                var prop = obj.GetType().GetProperty(propName);
                obj = prop.GetValue(obj, null);
            }
        }

        return obj;
    }

    private static object GetCollection(object obj, string propName)
    {
        var value = propName.Split('=')[1];
        if (int.TryParse(value, out int index))
        {
            return ((IEnumerable<dynamic>)obj).ElementAt(index - 1);
        }
        else
        {
            //assume that value is a string
            return ((IEnumerable<dynamic>)obj).Where(x => x == value);
        }
    }
}