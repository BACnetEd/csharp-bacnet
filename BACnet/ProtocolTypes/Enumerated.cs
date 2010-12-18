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
