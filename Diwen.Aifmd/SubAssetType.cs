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
    public enum SubAssetType
    {

        [Description("Certificates of deposit")]
        SEC_CSH_CODP,

        [Description("Commercial papers")]
        SEC_CSH_COMP,

        [Description("Other deposits")]
        SEC_CSH_OTHD,

        [Description("Other cash and cash equivalents (excluding government securities)")]
        SEC_CSH_OTHC,

        [Description("Listed equities issued by financial institutions")]
        SEC_LEQ_IFIN,

        [Description("Other listed equity")]
        SEC_LEQ_OTHR,

        [Description("Unlisted equities")]
        SEC_UEQ_UEQY,

        [Description("Corporate bonds not issued by financial institutions-Investment grade")]
        SEC_CPN_INVG,

        [Description("Corporate bonds not issued by financial institutions-Non-investment grade")]
        SEC_CPN_NIVG,

        [Description("Corporate bonds issued by financial institutions-Investment grade")]
        SEC_CPI_INVG,

        [Description("Corporate bonds issued by financial institutions-Non-investment grade")]
        SEC_CPI_NIVG,

        [Description("EU bonds with a 0-1 year term to maturity")]
        SEC_SBD_EUBY,

        [Description("EU bonds with a 1+ year term to maturity")]
        SEC_SBD_EUBM,

        [Description("Non-G10 bonds with a 0-1 year term to maturity")]
        SEC_SBD_NOGY,

        [Description("Non-G10 bonds with a 1+ year term to maturity")]
        SEC_SBD_NOGM,

        [Description("G10 non EU bonds with a 0-1 year term to maturity")]
        SEC_SBD_EUGY,

        [Description("G10 non EU bonds with a 1+ year term to maturity")]
        SEC_SBD_EUGM,

        [Description("Municipal bonds")]
        SEC_MBN_MNPL,

        [Description("Convertible bonds not issued by financial institutions-Investment grade")]
        SEC_CBN_INVG,

        [Description("Convertible bonds not issued by financial institutionsNon-investment grade")]
        SEC_CBN_NIVG,

        [Description("Convertible bonds issued by financial institutionsInvestment grade")]
        SEC_CBI_INVG,

        [Description("Convertible bonds issued by financial institutions-Non-investment grade")]
        SEC_CBI_NIVG,

        [Description("Leveraged loans")]
        SEC_LON_LEVL,

        [Description("Other loans")]
        SEC_LON_OTHL,

        [Description("ABS")]
        SEC_SSP_SABS,

        [Description("RMBS")]
        SEC_SSP_RMBS,

        [Description("CMBS")]
        SEC_SSP_CMBS,

        [Description("Agency MBS")]
        SEC_SSP_AMBS,

        [Description("ABCP")]
        SEC_SSP_ABCP,

        [Description("CDO/CLO")]
        SEC_SSP_CDOC,

        [Description("Structured certificates")]
        SEC_SSP_STRC,

        [Description("ETP")]
        SEC_SSP_SETP,

        [Description("Other Structured/securitised products")]
        SEC_SSP_OTHS,

        [Description("Equity derivatives related to financial institutions")]
        DER_EQD_FINI,

        [Description("Other equity derivatives")]
        DER_EQD_OTHD,

        [Description("Fixed income derivatives")]
        DER_FID_FIXI,

        [Description("Single name financial CDS")]
        DER_CDS_SNFI,

        [Description("Single name sovereign CDS")]
        DER_CDS_SNSO,

        [Description("Single name other CDS")]
        DER_CDS_SNOT,

        [Description("Index CDS")]
        DER_CDS_INDX,

        [Description("Exotic (incl. credit default tranche)")]
        DER_CDS_EXOT,

        [Description("Other CDS")]
        DER_CDS_OTHR,

        [Description("Foreign exchange (for investment purposes)")]
        DER_FEX_INVT,

        [Description("Foreign exchange (for hedging purposes)")]
        DER_FEX_HEDG,

        [Description("Interest rate derivatives")]
        DER_IRD_INTR,

        [Description("Energy/Crude oil")]
        DER_CTY_ECOL,

        [Description("Energy/Natural gas")]
        DER_CTY_ENNG,

        [Description("Energy/Power")]
        DER_CTY_ENPW,

        [Description("Energy/Other")]
        DER_CTY_ENOT,

        [Description("Precious metals/Gold ")]
        DER_CTY_PMGD,

        [Description("Precious metals/Other ")]
        DER_CTY_PMOT,

        [Description("Other commodities/Industrial metals")]
        DER_CTY_OTIM,

        [Description("Other commodities/Livestock")]
        DER_CTY_OTLS,

        [Description("Other commodities/Agricultural products")]
        DER_CTY_OTAP,

        [Description("Other commodities/Other")]
        DER_CTY_OTHR,

        [Description("Other derivatives")]
        DER_OTH_OTHR,

        [Description("Residential real estate")]
        PHY_RES_RESL,

        [Description("Commercial real estate")]
        PHY_RES_COML,

        [Description("Other real estate")]
        PHY_RES_OTHR,

        [Description("Physical: Commodities")]
        PHY_CTY_PCTY,

        [Description("Physical: Timber")]
        PHY_TIM_PTIM,

        [Description("Physical: Art and collectables")]
        PHY_ART_PART,

        [Description("Physical: Transportation assets")]
        PHY_TPT_PTPT,

        [Description("Physical: Other")]
        PHY_OTH_OTHR,

        [Description("Investment in CIU operated/managed by the AIFM-Money Market Funds and cash management CIU")]
        CIU_OAM_MMFC,

        [Description("Investment in CIU operated/managed by the AIFM-ETF")]
        CIU_OAM_AETF,

        [Description("Investment in CIU operated/managed by the AIFM-Other CIU")]
        CIU_OAM_OTHR,

        [Description("Investment in CIU not operated/managed by the AIFM-Money Market Funds and cash management CIU")]
        CIU_NAM_MMFC,

        [Description("Investment in CIU not operated/managed by the AIFM-ETF")]
        CIU_NAM_AETF,

        [Description("Investment in CIU not operated/managed by the AIFM-Other CIU")]
        CIU_NAM_OTHR,

        [Description("Total Other")]
        OTH_OTH_OTHR,

        [Description("N/A")]
        NTA_NTA_NOTA,
    }
}
