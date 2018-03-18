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

    [Serializable]
    public enum InvestorGroupType
    {

        [Description("Non-financial corporations")]
        NFCO,

        [Description("Banks")]
        BANK,

        [Description("Insurance corporations")]
        INSC,

        [Description("Other financial institutions")]
        OFIN,

        [Description("Pension plans / funds")]
        PFND,

        [Description("General government")]
        GENG,

        [Description("Other collective investment undertakings (e.g. fund of funds or master)")]
        OCIU,

        [Description("Households")]
        HHLD,

        [Description("Unknown")]
        UNKN,

        [Description("None")]
        NONE,
    }
}
