/*  BitString and BitString<TFlags> structures
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
using System.ComponentModel;

namespace BACnet.ProtocolTypes
{
    public struct BitString
    {
        #region Static Members
        /// <summary>
        /// Calculates the bitwise mask for the index'th
        /// bit in the bitstring
        /// </summary>
        /// <param name="index">The index of the bit</param>
        /// <returns>The mask for the index'th bit</returns>
        private static ulong mask(int index)
        {
            ulong mask = 128;
            mask <<= 8 * (int)(index / 8);
            mask >>= index % 8;
            return mask;
        }
        #endregion

        #region Fields
        /// <summary>
        /// Current length of the bitstring.
        /// Byte works fine because we currently
        /// only support bitstrings up to length 64 (bounded by the ulong below)
        /// </summary>
        private byte length;

        /// <summary>
        /// The current flags of the bitstring variable
        /// </summary>
        private ulong flags;
        #endregion

        #region Constructors
        /// <summary>
        /// Constructs an untyped bitstring with
        /// the provided length and flags
        /// </summary>
        /// <param name="length">The length of the bitstring</param>
        /// <param name="flags">The default flags of the bitstring</param>
        public BitString(byte length, ulong flags)
        {
            this.length = length;
            this.flags = flags;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the index'th bit in
        /// the bitstring
        /// </summary>
        /// <param name="index">The index of the bit</param>
        /// <returns>Whether or not the index'th bit is set</returns>
        public bool this[int index]
        {
            get
            {
                return (flags & mask(index)) > 0;
            }
            set
            {
                if (value)
                    flags |= mask(index);
                else
                    flags &= ~mask(index);
            }
        }

        /// <summary>
        /// The current length of the bitstring
        /// </summary>
        public byte Length
        {
            get { return length; }
            set { length = value; }
        }

        /// <summary>
        /// The current flags of the bitstring
        /// </summary>
        public ulong Flags
        {
            get { return flags; }
            set { flags = value; }
        }
        #endregion
    }

    public struct BitString<TFlags> where TFlags : struct
    {
        #region Static Members
        /// <summary>
        /// The default length for a typed bitstring with
        /// values enumeration TFlags
        /// </summary>
        private static byte defaultLength = 0;

        /// <summary>
        /// Static constructor to check the TFlags
        /// argument and calculate the default length
        /// for the bitstring
        /// </summary>
        static BitString()
        {
            if (!typeof(TFlags).IsEnum) throw new InvalidOperationException("TFlags must be an enumeration type");

            Type type = typeof(TFlags);
            Array values = Enum.GetValues(type);
            for (int i = 0; i < values.Length; i++)
            {
                defaultLength = Math.Max(defaultLength, (byte)(int)values.GetValue(i));
            }
            defaultLength++;
        }

        /// <summary>
        /// Calculates the bitwise mask
        /// for the bit index'th bit
        /// in the bitstring
        /// </summary>
        /// <param name="index">The index to calculate the mask for</param>
        /// <returns>The mask for the index'th bit</returns>
        private static ulong mask(int index)
        {
            ulong mask = 128;
            mask <<= 8 * (int)(index / 8);
            mask >>= index % 8;
            return mask;
        }
        #endregion

        #region Fields
        /// <summary>
        /// Current length of the bitstring.
        /// Byte works fine because we currently
        /// only support bitstrings up to length 64 (bounded by the ulong below)
        /// </summary>
        private byte length;

        /// <summary>
        /// The current flags of the bitstring variable
        /// </summary>
        private ulong flags;
        #endregion

        #region Constructors
        /// <summary>
        /// Constructs a typed bitstring with the provided
        /// flags and the default length
        /// </summary>
        /// <param name="flags"></param>
        public BitString(ulong flags)
        {
            this.length = defaultLength;
            this.flags = flags;
        }

        /// <summary>
        /// Constructs a typed bitstring with the provided
        /// flags set and the default length
        /// </summary>
        /// <param name="flags"></param>
        public BitString(params TFlags[] flags)
        {
            this.length = defaultLength;
            this.flags = 0;
            for (int i = 0; i < flags.Length; i++)
                this[flags[i]] = true;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the bitstring's bit for the index'th
        /// bit
        /// </summary>
        /// <param name="index">The index of the bit</param>
        /// <returns>Whether or not the bit is set</returns>
        public bool this[int index]
        {
            get
            {
                return (flags & mask(index)) > 0;
            }
            set
            {
                if (value)
                    flags |= mask(index);
                else
                    flags &= ~mask(index);
            }
        }

        /// <summary>
        /// Gets or sets the bitstring's bit for the index'th
        /// bit
        /// </summary>
        /// <param name="index">The TFlags value of the bit to set</param>
        /// <returns>Whether or not the corresponding bit is set</returns>
        public bool this[TFlags index]
        {
            get { return this[EnumerationUtilities<TFlags>.ToInt32(index)]; }
            set { this[EnumerationUtilities<TFlags>.ToInt32(index)] = value; }
        }

        /// <summary>
        /// The current length of the bitstring
        /// </summary>
        public byte Length
        {
            get { return length == 0 ? defaultLength : length; }
        }

        /// <summary>
        /// The current state of all the flags
        /// in the bitstring
        /// </summary>
        public ulong Flags
        {
            get { return flags; }
            set { flags = value; }
        }
        #endregion

        #region Operator Overloads
        /// <summary>
        /// Implict operator for assigning a typed bitstring
        /// to an untyped bitstring
        /// </summary>
        /// <param name="bs">The typed bitstring instance</param>
        /// <returns>The equivalent untyped bitstring instance</returns>
        public static implicit operator BitString(BitString<TFlags> bs)
        {
            return new BitString(bs.Length, bs.Flags);
        }
        #endregion
    }
}
