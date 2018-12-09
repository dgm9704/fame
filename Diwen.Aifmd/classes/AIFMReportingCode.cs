//
//  This file is part of Diwen.Aifmd
//
//  Author:
//       John Nordberg <john.nordberg@gmail.com>
//
//  Copyright (c) 2017-2018 John Nordberg
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
    public enum AIFMReportingCode
    {
        [XmlEnum("1")]
        [Description("Registered AIFM")]
        Item1,

        [XmlEnum("2")]
        [Description("Authorised AIFM (opt-in)")]
        Item2,

        [XmlEnum("3")]
        [Description("Authorised AIFM with only unleveraged AIFs investing in non-listed companies and issuers in order to acquire control")]
        Item3,

        [XmlEnum("4")]
        [Description("Authorised AIFM with half yearly obligation")]
        Item4,

        [XmlEnum("5")]
        [Description("Authorised AIFM with quarterly obligation for ")]
        Item5,

        [XmlEnum("6")]
        [Description("Non-EU AIFM under Private Placement Regime with annual obligation")]
        Item6,

        [XmlEnum("7")]
        [Description("Non-EU AIFM under Private Placement Regime with only unleveraged AIFs investing in non-listed companies and issuers in order to acquire control")]
        Item7,

        [XmlEnum("8")]
        [Description("Non-EU AIFM under Private Placement Regime with half yearly obligation")]
        Item8,

        [XmlEnum("9")]
        [Description("Non-EU AIFM under Private Placement Regime with quarterly obligation")]
        Item9,
    }
}
