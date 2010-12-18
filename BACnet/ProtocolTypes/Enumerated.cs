/*  Enumerated struct for untyped enumerations
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
using System.Text;

namespace BACnet
{
    /// <summary>
    /// Represents an untyped enumerated value
    /// </summary>
    public struct Enumerated
    {
        #region Fields
        /// <summary>
        /// Underlying integer value of the enumeration
        /// </summary>
        public int Value;
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor to create an enumerated
        /// object with the supplied integer value
        /// </summary>
        /// <param name="value">The integer value to give the enumerated object</param>
        public Enumerated(int value) { this.Value = value; }
        #endregion

        #region Operator Overloads
        /// <summary>
        /// Implicit operator for assigning an integer
        /// to an enumerated instance
        /// </summary>
        /// <param name="value">The integer value to assign</param>
        /// <returns>The enumerated value that possesses the supplied integer value</returns>
        public static implicit operator Enumerated(int value)
        {
            return new Enumerated(value);
        }

        /// <summary>
        /// Implicit operator for assigning an enumerated
        /// to an integer
        /// </summary>
        /// <param name="e">The enumerated value to assign</param>
        /// <returns>The integer value posessed by the supplied enumerated value</returns>
        public static implicit operator int(Enumerated e)
        {
            return e.Value;
        }
        #endregion
    }
}
