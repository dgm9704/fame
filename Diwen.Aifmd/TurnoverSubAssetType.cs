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
    [Serializable]
    public enum TurnoverSubAssetType
    {

        SEC_CSH_CSH,

        SEC_LEQ_LEQ,

        SEC_UEQ_UEQ,

        SEC_CPN_IVG,

        SEC_CPN_NIG,

        SEC_CPI_CPI,

        SEC_SBD_EUB,

        SEC_SBD_NEU,

        SEC_MUN_MUN,

        SEC_CBD_CBD,

        SEC_LON_LON,

        SEC_SSP_SSP,

        DER_EQD_EQD,

        DER_FID_FID,

        DER_CDS_CDS,

        DER_FEX_INV,

        DER_FEX_HED,

        DER_IRD_IRD,

        DER_CTY_CTY,

        DER_OTH_OTH,

        PHY_RES_RES,

        PHY_CTY_CTY,

        PHY_TIM_TIM,

        PHY_ART_ART,

        PHY_TPT_TPT,

        PHY_OTH_OTH,

        CIU_CIU_CIU,

        OTH_OTH_OTH,
    }
}
