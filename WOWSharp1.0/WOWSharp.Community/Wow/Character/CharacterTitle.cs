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

using System.Runtime.Serialization;

namespace WOWSharp.Community.Wow
{
    /// <summary>
    ///   Represents a character's title
    /// </summary>
    [DataContract]
    public class CharacterTitle
    {
        /// <summary>
        ///   Gets or sets the id of the title
        /// </summary>
        private int _id;

        /// <summary>
        ///   Gets or sets whether this title is currently selected
        /// </summary>
        private bool _isSelected;

        /// <summary>
        ///   Gets or sets the name of the title. Note that %s is replaced with character's name
        /// </summary>
        private string _name;

        /// <summary>
        ///   Gets or sets the id of the title
        /// </summary>
        [DataMember(Name = "id", IsRequired = true)]
        public int Id
        {
            get
            {
                return _id;
            }
            internal set
            {
                _id = value;
            }
        }

        /// <summary>
        ///   Gets or sets the name of the title. Note that %s is replaced with character's name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true)]
        public string Name
        {
            get
            {
                return _name;
            }
            internal set
            {
                _name = value;
            }
        }

        /// <summary>
        ///   Gets or sets whether this title is currently selected
        /// </summary>
        [DataMember(Name = "selected", IsRequired = false)]
        public bool IsSelected
        {
            get
            {
                return _isSelected;
            }
            internal set
            {
                _isSelected = value;
            }
        }

        /// <summary>
        ///   Gets string representation (for debugging purposes)
        /// </summary>
        /// <returns> Gets string representation (for debugging purposes) </returns>
        public override string ToString()
        {
            return Name;
        }
    }
}