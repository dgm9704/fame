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
    public enum TurnoverSubAssetType
    {

        [Description("Cash and cash equivalent")]
        SEC_CSH_CSH,

        [Description("Listed equities")]
        SEC_LEQ_LEQ,

        [Description("Unlisted equities")]
        SEC_UEQ_UEQ,

        [Description("Corporate bonds not issued by financial institutions-Investment grade")]
        SEC_CPN_IVG,

        [Description("Corporate bonds not issued by financial institutions-Non-investment grade")]
        SEC_CPN_NIG,

        [Description("Corporate bonds issued by financial institutions")]
        SEC_CPI_CPI,

        [Description("EU Member State bonds")]
        SEC_SBD_EUB,

        [Description("Non EU Member State bonds")]
        SEC_SBD_NEU,

        [Description("Municipal bonds")]
        SEC_MUN_MUN,

        [Description("Convertible bonds")]
        SEC_CBD_CBD,

        [Description("Loans")]
        SEC_LON_LON,

        [Description("Structured/securitised products")]
        SEC_SSP_SSP,

        [Description("Equity derivatives")]
        DER_EQD_EQD,

        [Description("Fixed income derivatives")]
        DER_FID_FID,

        [Description("CDS")]
        DER_CDS_CDS,

        [Description("Foreign exchange (for investment purposes)")]
        DER_FEX_INV,

        [Description("Foreign exchange (for hedging purposes)")]
        DER_FEX_HED,

        [Description("Interest rate derivatives")]
        DER_IRD_IRD,

        [Description("Commodity derivatives")]
        DER_CTY_CTY,

        [Description("Other derivatives")]
        DER_OTH_OTH,

        [Description("Physical: Real estate")]
        PHY_RES_RES,

        [Description("Physical: Commodities")]
        PHY_CTY_CTY,

        [Description("Physical: Timber")]
        PHY_TIM_TIM,

        [Description("Physical: Art and collectables")]
        PHY_ART_ART,

        [Description("Physical: Transportation assets")]
        PHY_TPT_TPT,

        [Description("Physical: Other")]
        PHY_OTH_OTH,

        [Description("Collective Investment Undertakings")]
        CIU_CIU_CIU,

        [Description("Total Other")]
        OTH_OTH_OTH,
    }
}
