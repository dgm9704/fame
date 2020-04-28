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

namespace Diwen.Aifmd.Extensions
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    public static class XElementExtensions
    {
        public static string GetPath(this XElement element)
        {
            if (element == null)
                throw new ArgumentNullException(nameof(element));

            var path = element.Name.LocalName;

            if (element.Parent != null)
            {
                int idx;
                var siblings = element.Parent.Elements(element.Name).ToList();
                if (siblings.Count != 1)
                {
                    idx = siblings.IndexOf(element) + 1;
                    if (idx != 0)
                        path += $"[{idx}]";
                }
                path = $"{GetPath(element.Parent)}.{path}";
            }
            return path;
        }
    }
}