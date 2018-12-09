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
    public enum AssetType
    {

        [Description("Cash and cash equivalent")]
        SEC_CSH,

        [Description("Listed equities")]
        SEC_LEQ,

        [Description("Unlisted equities")]
        SEC_UEQ,

        [Description("Corporate bonds not issued by financial institutions")]
        SEC_CPN,

        [Description("Corporate bonds issued by financial institutions")]
        SEC_CPI,

        [Description("Sovereign bonds")]
        SEC_SBD,

        [Description("Municipal bonds")]
        SEC_MBN,

        [Description("Convertible bonds not issued by financial institutions")]
        SEC_CBN,

        [Description("Convertible bonds issued by financial institutions")]
        SEC_CBI,

        [Description("Loans")]
        SEC_LON,

        [Description("Structured/securitised products")]
        SEC_SSP,

        [Description("Equity derivatives")]
        DER_EQD,

        [Description("Fixed income derivatives")]
        DER_FID,

        [Description("CDS")]
        DER_CDS,

        [Description("Foreign exchange")]
        DER_FEX,

        [Description("Interest rate derivatives")]
        DER_IRD,

        [Description("Commodity derivatives")]
        DER_CTY,

        [Description("Other derivatives")]
        DER_OTH,

        [Description("Physical: real estate")]
        PHY_RES,

        [Description("Physical: Commodities")]
        PHY_CTY,

        [Description("Physical: Timber")]
        PHY_TIM,

        [Description("Physical: Art and collectablesPhysical: Art and collectables")]
        PHY_ART,

        [Description("Physical: Transportation assets")]
        PHY_TPT,

        [Description("Physical: Other")]
        PHY_OTH,

        [Description("Investment in CIU operated/managed by the AIFM")]
        CIU_OAM,

        [Description("Investment in CIU not operated/managed by the AIFM")]
        CIU_NAM,

        [Description("Total Other")]
        OTH_OTH,

        [Description("N/A")]
        NTA_NTA,
    }
}
