//  Copyright (c) 2017-2020 John Nordberg 
//  Permission to use, copy, modify, and/or distribute this software for any purpose with or without fee is hereby granted.

namespace Diwen.Aifmd.Test
{
    using Xunit;
    using Diwen.Aifmd;
    using System.Xml.Schema;
    using Xunit.Abstractions;
    using System.IO;
    using System.Linq;
    using System;
    using System.Collections.Generic;

    public class ImportExportTests
    {
        private readonly ITestOutputHelper output;

        public ImportExportTests(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void ExportManager()
            => new AIFMReportingInfo().ToFile("output/manager_out.xml");

        [Fact]
        public void ImportManager()
            => AIFMReportingInfo.FromFile("report/aifmsample.xml");

        [Fact]
        public void ExportFund()
            => new AIFReportingInfo().ToFile("output/fund_out.xml");

        [Fact]
        public void ImportFund()
            => AIFReportingInfo.FromFile("report/aifsample.xml");

        private static XmlSchemaSet GetSchemas()
        {
            var schemas = new XmlSchemaSet();
            Directory.GetFiles("schema", "*.xsd").ToList().ForEach(s => schemas.Add(null, s));
            schemas.Compile();
            return schemas;
        }

        void ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            var message = $"{e.Severity}: {e.Message}";
            output.WriteLine(message);
            Console.WriteLine(message);
        }

        [Fact]
        public void ExportImportData()
        {
            var first = AIFReportingInfo.FromFile("report/aifsample.xml");
            var records = first.GetData();

            var shuffled =
                records.
                OrderByDescending(i => i.Value).
                ToDictionary(
                    i => i.Key,
                    i => i.Value);

            var second = AIFReportingInfo.FromData(shuffled);
            second.ToFile("output/aifroundtrip.xml");
        }

        private void WriteRecords(Dictionary<string, string> records, string path)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(path));
            File.WriteAllLines(path, records.Select(r => $"{r.Key};{r.Value}"));
        }

        private Dictionary<string, string> ReadRecords(string path)
        => File.
            ReadAllLines(path).
            Select(l => l.Split(';')).
            ToDictionary(
                l => l.First(),
                l => l.Last());

    }
}