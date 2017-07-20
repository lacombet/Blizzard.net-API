﻿/*
 Copyright (C) 2011 by Sherif Elmetainy (Grendizer@Doomhammer-EU)

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace WOWSharp.Community.ObjectModel
{
    /// <summary>
    /// Represents information about an item use spell or an item's proc
    /// </summary>
    [DataContract]
    [Serializable]
    public class ItemSpell : BaseExtensibleDataObject
    {
        /// <summary>
        /// Gets or sets the spell id
        /// </summary>
        [DataMember(Name = "spellId", IsRequired = true)]
        public int SpellId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the item spell information
        /// </summary>
        [DataMember(Name = "spell", IsRequired = false)]
        public Spell Spell
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the number of times the spell can be used (0 means unlimited)
        /// </summary>
        [DataMember(Name = "nCharges", IsRequired = true)]
        public int NumberOfCharges
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the item is consumed when the spell is used
        /// </summary>
        [DataMember(Name = "consumable", IsRequired = true)]
        public bool Consumable
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the item's spell cooldown category (used to determine which items share CD with that item)
        /// </summary>
        [DataMember(Name = "categoryId", IsRequired = true)]
        public int CooldownCategoryId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets string representation (for debugging purposes)
        /// </summary>
        /// <returns>Gets string representation (for debugging purposes)</returns>
        public override string ToString()
        {
            return this.Spell == null ? "" : this.Spell.ToString();
        }
    }
}
