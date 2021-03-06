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
    using System.Xml.Serialization;

    [Serializable]
    public partial class PortfolioLiquidityProfile
    {

        public decimal PortfolioLiquidityInDays0to1Rate { get; set; }

        public decimal PortfolioLiquidityInDays2to7Rate { get; set; }

        public decimal PortfolioLiquidityInDays8to30Rate { get; set; }

        public decimal PortfolioLiquidityInDays31to90Rate { get; set; }

        public decimal PortfolioLiquidityInDays91to180Rate { get; set; }

        public decimal PortfolioLiquidityInDays181to365Rate { get; set; }

        public decimal PortfolioLiquidityInDays365MoreRate { get; set; }

        [XmlElement(DataType = "integer")]
        public string UnencumberedCash { get; set; }
    }
}
