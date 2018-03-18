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
    public enum ReportingObligationChangeFrequencyCode
    {

        [Description("Yearly to Half yearly reporting obligation")]
        YH,

        [Description("Yearly to Quarterly reporting obligation")]
        YQ,

        [Description("Half yearly to Yearly reporting obligation")]
        HY,

        [Description("Half yearly to Quarterly reporting obligation")]
        HQ,

        [Description("Quarterly to Yearly reporting obligation")]
        QY,

        [Description("Quarterly to Half yearly reporting obligation")]
        QH,

        [Description("No reporting to Quarterly reporting obligation")]
        NQ,

        [Description("No reporting to Half yearly reporting obligation")]
        NH,

        [Description("No reporting to Yearly reporting obligation")]
        NY,
    }
}
