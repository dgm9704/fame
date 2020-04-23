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
    public enum AIFReportingObligationChangeContentsCode
    {

        [XmlEnum("1")]
        [Description("'24(1)+(2)+(4)' to '24(1)+(2)'")]
        Item1,

        [XmlEnum("2")]
        [Description("'24(1)+(2)+(4)' to '24(1)'")]
        Item2,

        [XmlEnum("3")]
        [Description("'24(1)+(2)+(4)' to '3(3d)'")]
        Item3,

        [XmlEnum("4")]
        [Description("'24(1)+(2)+(4)' to '24(1)+(4)'")]
        Item4,

        [XmlEnum("5")]
        [Description("'24(1)+(2)' to '24(1)+(2)+(4)'")]
        Item5,

        [XmlEnum("6")]
        [Description("'24(1)+(2)' to '24(1)'")]
        Item6,

        [XmlEnum("7")]
        [Description("'24(1)+(2)' to '3(3d)'")]
        Item7,

        [XmlEnum("8")]
        [Description("'24(1)+(2)' to '4(1)+(4)'")]
        Item8,

        [XmlEnum("9")]
        [Description("'24(1)' to '24(1)+(2)+(4)'")]
        Item9,

        [XmlEnum("10")]
        [Description("'24(1)' to '24(1)+(2)'")]
        Item10,

        [XmlEnum("11")]
        [Description("'24(1)' to '3(3d)'")]
        Item11,

        [XmlEnum("12")]
        [Description("'24(1)' to '24(1)+(4)'")]
        Item12,

        [XmlEnum("13")]
        [Description("'3(3d)' to '24(1)+(2)+(4)'")]
        Item13,

        [XmlEnum("14")]
        [Description("'3(3d)' to '24(1)+(2)'")]
        Item14,

        [XmlEnum("15")]
        [Description("'3(3d)' to '24(1)'")]
        Item15,

        [XmlEnum("16")]
        [Description("'3(3d)' to '24(1)+(4)'")]
        Item16,

        [XmlEnum("17")]
        [Description("'24(1)+(4)' to '24(1)+(2)+(4)'")]
        Item17,

        [XmlEnum("18")]
        [Description("'24(1)+(4)' to '24(1)+(2)'")]
        Item18,

        [XmlEnum("19")]
        [Description("'24(1)+(4)' to '24(1)'")]
        Item19,

        [XmlEnum("20")]
        [Description("'24(1)+(4)' to '3(3d)'")]
        Item20,

        [XmlEnum("21")]
        [Description("'N/A' to '24(1)+(2)+(4)'")]
        Item21,

        [XmlEnum("22")]
        [Description("'N/A' to '24(1)+(2)'")]
        Item22,

        [XmlEnum("23")]
        [Description("'N/A' to '24(1)'")]
        Item23,

        [XmlEnum("24")]
        [Description("'N/A' to '3(3d)'")]
        Item24,

        [XmlEnum("25")]
        [Description("'N/A' to '24(1)+(4)'")]
        Item25,
    }
}
