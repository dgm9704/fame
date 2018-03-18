//  Copyright (c) 2017-2018 John Nordberg 
//  Permission to use, copy, modify, and/or distribute this software for any purpose with or without fee is hereby granted.

namespace Diwen.Aifmd.Test
{
    using Xunit;
    using Diwen.Aifmd;

    public class Sampletests
    {
        [Fact]
        public void ExportManager()
            => new AIFMReportingInfo().ToFile("manager_out.xml");

        [Fact]
        public void ImportManager()
            => AIFMReportingInfo.FromFile("AIFMSample.xml");

        [Fact]
        public void ExportFund()
            => new AIFReportingInfo().ToFile("fund_out.xml");

        [Fact]
        public void ImportFund()
            => AIFReportingInfo.FromFile("AIFSample.xml");
     }
}
