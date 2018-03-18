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
    public enum TypicalPositionSize
    {

        [Description("Very small less than €5m")]
        V_SMALL,

        [Description("Small (€5m to €25m)")]
        SMALL,

        [Description("Low/mid-market (€25m to €150m)")]
        LOW_MID_MKT,

        [Description("Upper mid-market (€150m to €500m)")]
        UP_MID_MKT,

        [Description("Large cap (€500m to €1bn)")]
        L_CAP,

        [Description("Mega cap (€1bn and greater)")]
        M_CAP,
    }
}
