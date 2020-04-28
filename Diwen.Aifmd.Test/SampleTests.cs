//  Copyright (c) 2017-2020 John Nordberg 
//  Permission to use, copy, modify, and/or distribute this software for any purpose with or without fee is hereby granted.

namespace Diwen.Aifmd.Test
{
    using Xunit;
    using Diwen.Aifmd;
    using System.Xml.Linq;
    using System.Xml.Schema;
    using Xunit.Abstractions;
    using System.IO;
    using System.Linq;
    using System.Xml;
    using System;
    using System.Collections.Generic;

    public class SampleTests
    {
        private readonly ITestOutputHelper output;

        public SampleTests(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void ExportManager()
            => new AIFMReportingInfo().ToFile("report/manager_out.xml");

        [Fact]
        public void ImportManager()
            => AIFMReportingInfo.FromFile("report/AIFMSample.xml");

        [Fact]
        public void ExportFund()
            => new AIFReportingInfo().ToFile("report/fund_out.xml");

        [Fact]
        public void ImportFund()
            => AIFReportingInfo.FromFile("report/AIFSample.xml");

        [Fact]
        public void ImportIncorrect()
        {
            var a0 = AIFReportingInfo.FromFile("report/incorrect.xml");
            var a1 = XDocument.Load("report/incorrect.xml");

            var schemas = GetSchemas();

            a1.Validate(schemas, (o, e) => ValidationEventHandler(o, e));

            a0.ToFile("report/correct.xml");

            var a2 = XDocument.Load("report/correct.xml");

            a2.Validate(schemas, (o, e) => ValidationEventHandler(o, e));

        }


        private static XmlSchemaSet GetSchemas()
        {
            var schemas = new XmlSchemaSet();
            Directory.GetFiles("schema", "*.xsd").ToList().ForEach(s => schemas.Add(null, s));
            schemas.Compile();
            return schemas;
        }


        [Fact]
        public void ImportFoo()
        {

            var settings = new XmlReaderSettings();
            settings.Schemas.Add("", "schema/AIFMD_REPORTING_DataTypes_V1.2.xsd");
            settings.Schemas.Add("", "schema/AIFMD_DATAIF_V1.2.xsd");
            settings.ValidationType = ValidationType.Schema;

            var reader = XmlReader.Create("correct.xml", settings);
            var document = new XmlDocument();
            document.Load(reader);

            var eventHandler = new ValidationEventHandler(ValidationEventHandler);

            // the following call to Validate succeeds.
            document.Validate(eventHandler);

        }

        void ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            var message = $"{e.Severity}: {e.Message}";
            output.WriteLine(message);
            Console.WriteLine(message);
        }

        [Fact]
        public void ExportReport()
        {
            var report = Aifmd.AIFReportingInfo.FromFile("report/aifsample.xml");
            var records = report.GetRecords();
            WriteRecords(records, "output/aifsample.txt");
        }

        [Fact]
        public void ImportReport()
        {
            var data =
                File.ReadAllLines("report/import_shuffle.txt").
                Select(l => l.Split(";")).
                ToDictionary(
                    l => l.First(),
                    l => l.Last());

            var document = AIFReportingInfo.WriteReport(data);
            Directory.CreateDirectory("output");
            document.Save("output/import_shuffle.xml");

            var report = AIFReportingInfo.FromFile("output/import_shuffle.xml");
            report.ToFile("output/corrected.xml");

        }

        private void WriteRecords(Dictionary<string, string> records, string path)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(path));
            File.WriteAllLines(path, records.Select(r => $"{r.Key};{r.Value}"));
        }

        [Fact]
        public void ExportAttributesTest()
        {
            var document = XDocument.Parse(@"<?xml version='1.0' encoding='utf-8' ?>
<Customers>
  <customer name='Steve John' Id='CUST0001' location='New York' country='United States' DOB='12/23/1960' Phone='+1 212 666 1111' />
  <customer name='Sagar Mehta' Id='CUST0106' location='Bangalore' country='India' DOB='07/23/1978' Phone='+91 80 8888 1001' />
  <customer name='Rahul Raj' Id='CUST0190' location='Delhi' country='India' DOB='01/31/1980' Phone='+91 11 6666 1111' />
  <customer name='John Roderix' Id='CUST0301' location='Sydney' country='Australia' DOB='02/13/1956' Phone='+61 (0)2 8062 3999' />
</Customers> ");

            var attributes =
                document.
                Descendants().
                SelectMany(d => d.Attributes());

            var data =
                attributes.
                ToDictionary(
                    a => Helper.GetPath(a),
                    a => a.Value
                );

            output.WriteLine(string.Join("\n", data.Select(d => $"{d.Key};{d.Value}")));

        }

        [Fact]
        public void ImportAttributesTest()
        {
            var data =
            File.ReadAllLines("report/dummy_attr.txt").
                Select(l => l.Split(';')).
                ToDictionary(
                    a => a.First(),
                    a => a.Last()
                );


            var report = new XDocument();
            foreach (var item in data)
            {
                var attribute = Helper.AttributeFromPath(report, item.Key);
                attribute.Value = item.Value;
            }

            output.WriteLine(report.ToString());

        }
    }
}
