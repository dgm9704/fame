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
    public partial class MainInstrumentTraded
    {

        public FiveRanking Ranking { get; set; }

        public SubAssetType SubAssetType { get; set; }

        public InstrumentCodeType InstrumentCodeType { get; set; }

        [XmlIgnore]
        public bool InstrumentCodeTypeSpecified { get; set; }

        public string InstrumentName { get; set; }

        [XmlElement("AIIInstrumentIdentification", typeof(AIIInstrumentIdentification))]
        [XmlElement("ISINInstrumentIdentification", typeof(string))]
        public object Item { get; set; }

        [XmlElement(DataType = "integer")]
        public string PositionValue { get; set; }

        public PositionType PositionType { get; set; }

        [XmlIgnore]
        public bool PositionTypeSpecified { get; set; }

        public decimal ShortPositionHedgingRate { get; set; }

        [XmlIgnore]
        public bool ShortPositionHedgingRateSpecified { get; set; }
    }
}
