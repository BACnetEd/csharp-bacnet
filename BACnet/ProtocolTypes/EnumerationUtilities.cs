/*  EnumerationUtilities for various BACnet Enumeration Types
 *  Copyright (C) 2010 Loren Van Spronsen
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BACnet.ProtocolTypes
{
    /// <summary>
    /// "static" generic class exposing utility
    /// methods on enumeration types. This class
    /// would actually be static if C# allowed
    /// static generic classes
    /// </summary>
    /// <typeparam name="T">The enumeration type to provide utilities for</typeparam>
    public class EnumerationUtilities<T> where T : struct
    {
        /// <summary>
        /// Static constructor for constructing
        /// the toInt32 and fromInt32 delegates
        /// </summary>
        static EnumerationUtilities()
        {
            // parameters used in the following
            // linq expressions
            var t = Expression.Parameter(typeof(T));
            var i = Expression.Parameter(typeof(int));

            // toInt32 = (t => (int)t)
            ToInt32 = Expression.Lambda<Func<T, int>>(
                Expression.Convert(
                    t,
                    typeof(int)),
                t).Compile();

            // fromInt32 = (i => (T)i)
            FromInt32 = Expression.Lambda<Func<int, T>>(
                Expression.Convert(
                    i,
                    typeof(T)),
                i).Compile();
                    
        }

        /// <summary>
        /// Converts an enumeration of type T to
        /// it's Int32 representation without
        /// boxing
        /// </summary>
        public static readonly Func<T, int> ToInt32;

        /// <summary>
        /// Converts an Int32 value to an enumeration
        /// of type T without boxing
        /// </summary>
        public static readonly Func<int, T> FromInt32;
    }
}
