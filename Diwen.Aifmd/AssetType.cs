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
    public enum AssetType
    {

        SEC_CSH,

        SEC_LEQ,

        SEC_UEQ,

        SEC_CPN,

        SEC_CPI,

        SEC_SBD,

        SEC_MBN,

        SEC_CBN,

        SEC_CBI,

        SEC_LON,

        SEC_SSP,

        DER_EQD,

        DER_FID,

        DER_CDS,

        DER_FEX,

        DER_IRD,

        DER_CTY,

        DER_OTH,

        PHY_RES,

        PHY_CTY,

        PHY_TIM,

        PHY_ART,

        PHY_TPT,

        PHY_OTH,

        CIU_OAM,

        CIU_NAM,

        OTH_OTH,

        NTA_NTA,
    }
}
