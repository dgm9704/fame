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
    public enum RiskMeasure
    {

        [Description("Net Equity Delta")]
        NET_EQTY_DELTA,

        [Description("Net DV01")]
        NET_DV01,

        [Description("Net CS01")]
        NET_CS01,

        [Description("VAR")]
        VAR,

        [Description("Net FX Delta")]
        VEGA_EXPO,

        [Description("Net Commodity Delta")]
        NET_FX_DELTA,

        [Description("Vega Exposure")]
        NET_CTY_DELTA,
    }
}
