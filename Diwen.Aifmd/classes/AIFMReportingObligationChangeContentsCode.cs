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
    using System.ComponentModel;
    using System.Xml.Serialization;
    [Serializable]
    public enum AIFMReportingObligationChangeContentsCode
    {
        [XmlEnum("1")]
        [Description("'24(1) for all AIFs managed' to '3(3d) for all AIFs managed'")]
        Item1,

        [XmlEnum("2")]
        [Description("'24(1) for all AIFs managed' to '24(1) for all AIFs marketed in the Member State'")]
        Item2,

        [XmlEnum("3")]
        [Description("'24(1) for all AIFs marketed in the Member State' to '3(3d) for all AIFs managed'")]
        Item3,

        [XmlEnum("4")]
        [Description("'24(1) for all AIFs marketed in the Member State' to '24(1) for all AIFs managed'")]
        Item4,

        [XmlEnum("5")]
        [Description("'3(3d) for all AIFs managed' to '24(1) for all AIFs marketed in the Member State'")]
        Item5,

        [XmlEnum("6")]
        [Description("'3(3d) for all AIFs managed' to '24(1) for all AIFs managed'")]
        Item6,
    }
}
