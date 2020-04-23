//
//  This file is part of Diwen.Aifmd
//
//  Author:
//       John Nordberg <john.nordberg@gmail.com>
//
//  Copyright (c) 2017-2020 John Nordberg
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.
//
//  You should have received a copy of the GNU Lesser General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.

namespace Diwen.Aifmd
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class AIFRecordInfo
    {
        public FilingType FilingType { get; set; }

        public AIFContentType AIFContentType { get; set; }

        [XmlElement(DataType = "date")]
        public DateTime ReportingPeriodStartDate { get; set; }

        [XmlElement(DataType = "date")]
        public DateTime ReportingPeriodEndDate { get; set; }

        public ReportingPeriodType ReportingPeriodType { get; set; }

        [XmlElement(DataType = "gYear")]
        public string ReportingPeriodYear { get; set; }

        public ReportingObligationChangeFrequencyCode AIFReportingObligationChangeFrequencyCode { get; set; }

        [XmlIgnore]
        public bool AIFReportingObligationChangeFrequencyCodeSpecified { get; set; }
        public AIFReportingObligationChangeContentsCode AIFReportingObligationChangeContentsCode { get; set; }

        [XmlIgnore]
        public bool AIFReportingObligationChangeContentsCodeSpecified { get; set; }

        public ReportingObligationChangeQuarter AIFReportingObligationChangeQuarter { get; set; }

        [XmlIgnore]
        public bool AIFReportingObligationChangeQuarterSpecified { get; set; }
        public bool LastReportingFlag { get; set; }

        [XmlArrayItem("Assumption", IsNullable = false)]
        public Assumption[] Assumptions { get; set; }

        public string AIFMNationalCode { get; set; }

        public string AIFNationalCode { get; set; }
        public string AIFName { get; set; }

        public bool AIFEEAFlag { get; set; }

        public AIFReportingCode AIFReportingCode { get; set; }

        public string AIFDomicile { get; set; }

        [XmlElement(DataType = "date")]
        public DateTime InceptionDate { get; set; }

        public bool AIFNoReportingFlag { get; set; }

        public AIFCompleteDescription AIFCompleteDescription { get; set; }
    }
}
