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

namespace WOWSharp.Community.ObjectModel
{
    /// <summary>
    /// Represents a character's standing with a faction
    /// </summary>
    public enum Standing
    {
        /// <summary>
        /// Hated
        /// </summary>
        Hated = 0,
        /// <summary>
        /// Hostile
        /// </summary>
        Hostile = 1,
        /// <summary>
        /// Unfriendlt
        /// </summary>
        Unfriendly = 2,
        /// <summary>
        /// Neutral
        /// </summary>
        Neutral = 3,
        /// <summary>
        /// Friendly
        /// </summary>
        Friendly = 4,
        /// <summary>
        /// Honored
        /// </summary>
        Honored = 5,
        /// <summary>
        /// Revered
        /// </summary>
        Revered = 6,
        /// <summary>
        /// Exalted
        /// </summary>
        Exalted = 7
    }
}
