﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.237
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WOWSharp.Community {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ErrorMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ErrorMessages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WOWSharp.Community.ErrorMessages", typeof(ErrorMessages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;arrayIndex&apos; parameter must be greater than or equal to zero and less than array&apos;s length..
        /// </summary>
        internal static string ArrayIndexOutOfRange {
            get {
                return ResourceManager.GetString("ArrayIndexOutOfRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Array is too small..
        /// </summary>
        internal static string ArrayTooSmall {
            get {
                return ResourceManager.GetString("ArrayTooSmall", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to End is already called on this IAsyncResult object..
        /// </summary>
        internal static string EndCalledAlready {
            get {
                return ResourceManager.GetString("EndCalledAlready", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid arena team size..
        /// </summary>
        internal static string InvalidArenaTeamSize {
            get {
                return ResourceManager.GetString("InvalidArenaTeamSize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid IAsyncResult object..
        /// </summary>
        internal static string InvalidAsyncResult {
            get {
                return ResourceManager.GetString("InvalidAsyncResult", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This object is readonly..
        /// </summary>
        internal static string ObjectIsReadOnly {
            get {
                return ResourceManager.GetString("ObjectIsReadOnly", resourceCulture);
            }
        }
    }
}
