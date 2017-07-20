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
    /// Represents a realm auctions dump
    /// </summary>
    [Serializable]
    [DataContract]
    public class AuctionDump : ApiResponse
    {
        /// <summary>
        /// Gets or sets the realm for which the dump belongs (note that realm type, status and queue are not retrieved)
        /// </summary>
        [DataMember(Name = "realm", IsRequired = true)]
        public Realm Realm
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the alliance auction house data
        /// </summary>
        [DataMember(Name = "alliance", IsRequired = true)]
        public AuctionHouse Alliance
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the horde auction house data
        /// </summary>
        [DataMember(Name = "horde", IsRequired = true)]
        public AuctionHouse Horde
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the neutral auction house data
        /// </summary>
        [DataMember(Name = "neutral", IsRequired = true)]
        public AuctionHouse Neutral
        {
            get;
            set;
        }
    }
}
