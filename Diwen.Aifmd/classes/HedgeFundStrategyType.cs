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
    
    public enum HedgeFundStrategyType
    {

        [Description("Equity: Long Bias")]
        EQTY_LGBS,

        [Description("Equity: Long / Short")]
        EQTY_LGST,

        [Description("Equity: Market Neutral")]
        EQTY_MTNL,

        [Description("Equity: Short Bias")]
        EQTY_STBS,

        [Description("Relative Value: Fixed Income Arbitrage")]
        RELV_FXIA,

        [Description("Relative Value: Convertible Bond Arbitrage")]
        RELV_CBAR,

        [Description("Relative Value: Volatility Arbitrage")]
        RELV_VLAR,

        [Description("Event Driven: Distressed / Restructuring")]
        EVDR_DSRS,

        [Description("Event Driven: Risk Arbitrage / Merger Arbitrage")]
        EVDR_RAMA,

        [Description("Event Driven: Equity Special Situations")]
        EVDR_EYSS,

        [Description("Credit Long / Short")]
        CRED_LGST,

        [Description("Credit Asset Based Lending")]
        CRED_ABLG,

        [Description("Macro")]
        MACR_MACR,

        [Description("Managed Futures / CTA: Fundamental")]
        MANF_CTAF,

        [Description("Managed Futures / CTA: Quantitative")]
        MANF_CTAQ,

        [Description("Multi-strategy hedge fund")]
        MULT_HFND,

        [Description("Other hedge fund strategy")]
        OTHR_HFND,
    }
}
