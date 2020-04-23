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

    [Serializable]
    public enum ReportingPeriodType
    {

        [Description("1st quarter")]
        Q1,

        [Description("2nd quarter")]
        Q2,

        [Description("3rd quarter")]
        Q3,

        [Description("4th quarter")]
        Q4,

        [Description("1st half of calendar year")]
        H1,

        [Description("2nd half of calendar year")]
        H2,

        [Description("1st year")]
        Y1,

        [Description("period from 1st quarter to 3rd quarter")]
        X1,

        [Description("period from 2nd quarter to 4th quarter")]
        X2,
    }
}
