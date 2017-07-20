﻿// Copyright (C) 2011 by Sherif Elmetainy (Grendiser@Kazzak-EU)
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WOWSharp.Community.Diablo
{
    /// <summary>
    /// Item display color
    /// </summary>
    [DataContract]
    public enum ItemDisplayColor
    {
        /// <summary>
        /// None
        /// </summary>
        [EnumMember(Value = "none")]
        None = 0,
        /// <summary>
        /// Gray (inferior)
        /// </summary>
        [EnumMember(Value = "gray")]
        Grey = 1,
        /// <summary>
        /// White (superior)
        /// </summary>
        [EnumMember(Value = "white")]
        White = 2,
        /// <summary>
        /// Blue (Magic)
        /// </summary>
        [EnumMember(Value = "blue")]
        Blue = 3,
        /// <summary>
        /// Yellow (Rare)
        /// </summary>
        [EnumMember(Value = "yellow")]
        Yellow = 4,
        /// <summary>
        /// Orange (Legendary)
        /// </summary>
        [EnumMember(Value = "orange")]
        Orange = 5,
        /// <summary>
        /// Green (Set)
        /// </summary>
        [EnumMember(Value = "green")]
        Green = 6
    }
}