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
    public enum RealEstateFundStrategyType
    {

        [Description("Residential real estate")]
        RESL_REST,

        [Description("Commercial real estate")]
        COML_REST,

        [Description("Industrial real estate")]
        INDL_REST,

        [Description("Multi-strategy real estate fund")]
        MULT_REST,

        [Description("Other real estate strategy")]
        OTHR_REST,
    }
}
