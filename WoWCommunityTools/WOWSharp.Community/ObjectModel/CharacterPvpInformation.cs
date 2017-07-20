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
    /// represents information about a character's rated battleground and arena ratings
    /// </summary>
    [Serializable]
    [DataContract]
    public class CharacterPvpInformation : BaseExtensibleDataObject
    {
        /// <summary>
        /// Gets or set the character rated battleground information
        /// </summary>
        [DataMember(Name = "ratedBattlegrounds", IsRequired = false)]
        public CharacterRatedBattlegroundInformation RatedBattlegrounds
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or set the character's arena teams
        /// </summary>
        [DataMember(Name = "arenaTeams", IsRequired = false)]
        public CharacterArenaTeam[] ArenaTeams
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or set the character total honorable kills
        /// </summary>
        [DataMember(Name = "totalHonorableKills", IsRequired = false)]
        public int  TotalHonorableKills
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
            return string.Format("Honorable Kills: {0}, {1}", this.TotalHonorableKills, this.RatedBattlegrounds);
        }
    }
}
