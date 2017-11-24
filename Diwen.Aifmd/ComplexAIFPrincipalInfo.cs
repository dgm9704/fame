//
//  This file is part of Diwen.Aifmd
//
//  Author:
//       John Nordberg <john.nordberg@gmail.com>
//
//  Copyright (c) 2017 John Nordberg
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
    public partial class ComplexAIFPrincipalInfo
    {
        public ComplexAIFIdentifier AIFIdentification {get; set;}
        public bool ShareClassFlag {get; set;}

        [XmlArrayItem("ShareClassIdentifier", IsNullable = false)]
        public ComplexShareClassIdentifier[] ShareClassIdentification {get; set;}

        public ComplexAIFDescription AIFDescription {get; set;}

        [XmlArrayItem("MainInstrumentTraded", IsNullable = false)]
        public ComplexMainInstrumentTraded[] MainInstrumentsTraded {get; set;}

        public ComplexNAVGeographicalFocus NAVGeographicalFocus {get; set;}

        public ComplexAUMGeographicalFocus AUMGeographicalFocus {get; set;}

        [XmlArrayItem("PrincipalExposure", IsNullable = false)]
        public ComplexPrincipalExposure[] PrincipalExposures {get; set;}

        public ComplexMostImportantConcentration MostImportantConcentration {get; set;}
    }
}
