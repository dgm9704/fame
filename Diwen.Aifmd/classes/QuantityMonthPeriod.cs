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
    public partial class QuantityMonthPeriodType
    {
        [XmlElement(DataType = "integer")]
        public string QuantityJanuary { get; set; }

        [XmlElement(DataType = "integer")]
        public string QuantityFebruary { get; set; }

        [XmlElement(DataType = "integer")]
        public string QuantityMarch { get; set; }

        [XmlElement(DataType = "integer")]
        public string QuantityApril { get; set; }

        [XmlElement(DataType = "integer")]
        public string QuantityMay { get; set; }

        [XmlElement(DataType = "integer")]
        public string QuantityJune { get; set; }

        [XmlElement(DataType = "integer")]
        public string QuantityJuly { get; set; }

        [XmlElement(DataType = "integer")]
        public string QuantityAugust { get; set; }

        [XmlElement(DataType = "integer")]
        public string QuantitySeptember { get; set; }

        [XmlElement(DataType = "integer")]
        public string QuantityOctober { get; set; }

        [XmlElement(DataType = "integer")]
        public string QuantityNovember { get; set; }

        [XmlElement(DataType = "integer")]
        public string QuantityDecember { get; set; }

    }
}
