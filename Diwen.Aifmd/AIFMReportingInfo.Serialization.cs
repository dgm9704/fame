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
    using System.Collections.Generic;
    using System.Xml;
    using System.Xml.Linq;
    using Diwen.Aifmd.Extensions;

    public partial class AIFMReportingInfo : AifmdReporting
    {
        public static AIFMReportingInfo FromFile(string path)
        => FromFile<AIFMReportingInfo>(path);

        public void ToFile(string path)
        => ToFile<AIFMReportingInfo>(this, path);

        public XmlDocument ToXmlDocument()
        => ToXmlDocument<AIFMReportingInfo>(this);

        public static AIFMReportingInfo FromData(Dictionary<string, string> data)
        {
            var document = new XDocument();
            document.ReadData(data);
            return FromXDocument<AIFMReportingInfo>(document);
        }

        public Dictionary<string, string> GetData()
        => GetData<AIFMReportingInfo>(this);
    }
}