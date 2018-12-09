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
    public enum AIFReportingCode
    {

        [XmlEnum("1")]
        [Description("AIF (of an Registered AIFM)")]
        Item1,

        [XmlEnum("2")]
        [Description("Leveraged EU AIF (of an opt-in AIFM)")]
        Item2,

        [XmlEnum("3")]
        [Description("Leveraged non EU AIF (of an opt-in AIFM) marketed in the Union")]
        Item3,

        [XmlEnum("4")]
        [Description("Leveraged non EU AIF (of an opt-in AIFM), not marketed in the Union")]
        Item4,

        [XmlEnum("5")]
        [Description("Unleveraged EU AIF (of an opt-in AIFM)")]
        Item5,

        [XmlEnum("6")]
        [Description("Unleveraged non EU AIF (of an opt-in AIFM) marketed in the Union")]
        Item6,

        [XmlEnum("7")]
        [Description("Unleveraged non EU AIF (of an opt-in AIFM), not marketed in the Union")]
        Item7,

        [XmlEnum("8")]
        [Description("Unleveraged EU AIF (of an AIFM with only unleveraged AIFs investing in non-listed companies and issuers in order to acquire control)")]
        Item8,

        [XmlEnum("9")]
        [Description("Unleveraged non EU AIF (of an AIFM with only unleveraged AIFs investing in non-listed companies and issuers in order to acquire control) marketed in the Union")]
        Item9,

        [XmlEnum("10")]
        [Description("Unleveraged non EU AIF (of an AIFM with only unleveraged AIFs investing in non-listed companies and issuers in order to acquire control), not marketed in the Union")]
        Item10,

        [XmlEnum("11")]
        [Description("Under 500M Leveraged EU AIF (of an AIFM with half yearly obligation)")]
        Item11,

        [XmlEnum("12")]
        [Description("Under 500M Leveraged non EU AIF (of an AIFM with half yearly obligation) marketed in the Union")]
        Item12,

        [XmlEnum("13")]
        [Description("Under 500M Leveraged non EU AIF (of an AIFM with half yearly obligation), not marketed in the Union")]
        Item13,

        [XmlEnum("14")]
        [Description("Under 500M Unleveraged EU AIF (of an AIFM with half yearly obligation)")]
        Item14,

        [XmlEnum("15")]
        [Description("Under 500M Unleveraged non EU AIF (of an AIFM with half yearly obligation) marketed in the Union")]
        Item15,

        [XmlEnum("16")]
        [Description("Under 500M Unleveraged non EU AIF (of an AIFM with half yearly obligation), not marketed in the Union")]
        Item16,

        [XmlEnum("17")]
        [Description("Unleveraged EU AIF, investing in non-listed companies in order to acquire control (of an AIFM with half yearly obligation)")]
        Item17,

        [XmlEnum("18")]
        [Description("Unleveraged non EU AIF, investing in non-listed companies in order to acquire control (of an AIFM with half yearly obligation) marketed in the Union")]
        Item18,

        [XmlEnum("19")]
        [Description("Unleveraged non EU AIF, investing in non-listed companies in order to acquire control (of an AIFM with half yearly obligation) not marketed in the Union")]
        Item19,

        [XmlEnum("20")]
        [Description("Over 500M Leveraged EU AIF (of an AIFM with half yearly obligation)")]
        Item20,

        [XmlEnum("21")]
        [Description("Over 500M Leveraged non EU AIF (of an AIFM with half yearly obligation) marketed in the Union")]
        Item21,

        [XmlEnum("22")]
        [Description("Over 500M Leveraged non EU AIF (of an AIFM with half yearly obligation), not marketed in the Union")]
        Item22,

        [XmlEnum("23")]
        [Description("Over 500M Unleveraged EU AIF (of an AIFM with half yearly obligation)")]
        Item23,

        [XmlEnum("24")]
        [Description("Over 500M Unleveraged non EU AIF (of an AIFM with half yearly obligation) marketed in the Union")]
        Item24,

        [XmlEnum("25")]
        [Description("Over 500M Unleveraged non EU AIF (of an AIFM with half yearly obligation), not marketed in the Union")]
        Item25,

        [XmlEnum("26")]
        [Description("Unleveraged EU AIF, investing in non-listed companies in order to acquire control (of an AIFM with quarterly obligation)")]
        Item26,

        [XmlEnum("27")]
        [Description("Unleveraged non EU AIF, investing in non-listed companies in order to acquire control (of an AIFM with quarterly obligation) marketed in the Union")]
        Item27,

        [XmlEnum("28")]
        [Description("Unleveraged non EU AIF, investing in non-listed companies in order to acquire control (of an AIFM with quarterly obligation) not marketed in the Union")]
        Item28,

        [XmlEnum("29")]
        [Description("Leveraged EU AIF (of an AIFM with quarterly obligation)")]
        Item29,

        [XmlEnum("30")]
        [Description("Leveraged non EU AIF (of an AIFM with quarterly obligation) marketed in the Union")]
        Item30,

        [XmlEnum("31")]
        [Description("Leveraged non EU AIF (of an AIFM with quarterly obligation), not marketed in the Union")]
        Item31,

        [XmlEnum("32")]
        [Description("Unleveraged EU AIF (of an AIFM with quarterly obligation)")]
        Item32,

        [XmlEnum("33")]
        [Description("Unleveraged non EU AIF (of an AIFM with quarterly obligation) marketed in the Union")]
        Item33,

        [XmlEnum("34")]
        [Description("Unleveraged non EU AIF (of an AIFM with quarterly obligation), not marketed in the Union")]
        Item34,

        [XmlEnum("35")]
        [Description("Leveraged AIF (of an AIFM under Private Placement Regime with yearly obligation) marketed in the Union")]
        Item35,

        [XmlEnum("36")]
        [Description("Unleveraged AIF (of an AIFM under Private Placement Regime with yearly obligation) marketed in the Union")]
        Item36,

        [XmlEnum("37")]
        [Description("Unleveraged AIF (of an AIFM under Private Placement Regime with only unleveraged AIFs investing in non-listed companies and issuers in order to acquire control) marketed in the Union")]
        Item37,

        [XmlEnum("38")]
        [Description("Under 500M Leveraged AIF (of an AIFM under Private Placement Regime with half yearly obligation) marketed in the union")]
        Item38,

        [XmlEnum("39")]
        [Description("Under 500M Unleveraged AIF (of an AIFM under Private Placement Regime with half yearly obligation) marketed in the union")]
        Item39,

        [XmlEnum("40")]
        [Description("Unleveraged AIF, investing in non-listed companies in order to acquire control (of an AIFM under Private Placement Regime with half yearly obligation) marketed in the Union")]
        Item40,

        [XmlEnum("41")]
        [Description("Over 500M Leveraged AIF (of an AIFM under Private Placement Regime with half yearly obligation) marketed in the union")]
        Item41,

        [XmlEnum("42")]
        [Description("Over 500M Unleveraged AIF (of an AIFM under Private Placement Regime with half yearly obligation) marketed in the union")]
        Item42,

        [XmlEnum("43")]
        [Description("Unleveraged AIF, investing in non-listed companies in order to acquire control (of an AIFM under Private Placement Regime with quarterly obligation) marketed in the Union")]
        Item43,

        [XmlEnum("44")]
        [Description("Leveraged AIF (of an AIFM under Private Placement Regime with quarterly obligation) marketed in the Union")]
        Item44,

        [XmlEnum("45")]
        [Description("Unleveraged AIF (of an AIFM under Private Placement Regime with quarterly obligation) marketed in the Union")]
        Item45,
    }
}
