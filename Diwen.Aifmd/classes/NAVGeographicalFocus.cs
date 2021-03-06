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

    [Serializable]
    public partial class NAVGeographicalFocus
    {

        public decimal AfricaNAVRate { get; set; }

        public decimal AsiaPacificNAVRate { get; set; }

        public decimal EuropeNAVRate { get; set; }

        public decimal EEANAVRate { get; set; }

        public decimal MiddleEastNAVRate { get; set; }

        public decimal NorthAmericaNAVRate { get; set; }

        public decimal SouthAmericaNAVRate { get; set; }

        public decimal SupraNationalNAVRate { get; set; }
    }
}
