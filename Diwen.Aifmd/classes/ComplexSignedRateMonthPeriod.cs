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
    public partial class ComplexSignedRateMonthPeriod
    {
        public decimal RateJanuary { get; set; }

        [XmlIgnore]
        public bool RateJanuarySpecified { get; set; }

        public decimal RateFebruary { get; set; }

        [XmlIgnore]
        public bool RateFebruarySpecified { get; set; }

        public decimal RateMarch { get; set; }

        [XmlIgnore]
        public bool RateMarchSpecified { get; set; }

        public decimal RateApril { get; set; }

        [XmlIgnore]
        public bool RateAprilSpecified { get; set; }
        public decimal RateMay { get; set; }

        [XmlIgnore]
        public bool RateMaySpecified { get; set; }

        public decimal RateJune { get; set; }

        [XmlIgnore]
        public bool RateJuneSpecified { get; set; }

        public decimal RateJuly { get; set; }

        [XmlIgnore]
        public bool RateJulySpecified { get; set; }

        public decimal RateAugust { get; set; }

        [XmlIgnore]
        public bool RateAugustSpecified { get; set; }

        public decimal RateSeptember { get; set; }

        [XmlIgnore]
        public bool RateSeptemberSpecified { get; set; }

        public decimal RateOctober { get; set; }

        [XmlIgnore]
        public bool RateOctoberSpecified { get; set; }

        public decimal RateNovember { get; set; }

        [XmlIgnore]
        public bool RateNovemberSpecified { get; set; }

        public decimal RateDecember { get; set; }

        [XmlIgnore]
        public bool RateDecemberSpecified { get; set; }
    }
}
