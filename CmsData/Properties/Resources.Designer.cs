﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CmsData.Properties {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CmsData.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        ///&lt;FieldTypes&gt;
        ///  &lt;FieldType Name=&quot;Empty&quot; /&gt;
        ///  &lt;FieldType Name=&quot;Group&quot;&gt;
        ///    &lt;Comparison Type=&quot;AllTrue&quot; /&gt;
        ///    &lt;Comparison Type=&quot;AnyTrue&quot; /&gt;
        ///    &lt;Comparison Type=&quot;AllFalse&quot; /&gt;
        ///    &lt;Comparison Type=&quot;AnyFalse&quot; /&gt;
        ///  &lt;/FieldType&gt;
        ///  &lt;FieldType Name=&quot;Bit&quot;&gt;
        ///    &lt;Comparison Type=&quot;Equal&quot; Display=&quot;{0} = {1}&quot; /&gt;
        ///    &lt;Comparison Type=&quot;NotEqual&quot; Display=&quot;{0} &amp;lt;&amp;gt; {1}&quot; /&gt;
        ///  &lt;/FieldType&gt;
        ///  &lt;FieldType Name=&quot;NullBit&quot;&gt;
        ///    &lt;Comparison Type=&quot;Equal&quot; Display=&quot;{0} = {1}&quot; /&gt;
        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string CompareMap {
            get {
                return ResourceManager.GetString("CompareMap", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        ///&lt;Fields&gt;
        ///  &lt;Category Title=&quot;Grouping&quot;&gt;
        ///    &lt;Field Name=&quot;Group&quot; Type=&quot;Group&quot;&gt;
        ///      Groups conditions or other groups together in an &quot;all true&quot; or &quot;any one true&quot; relationship
        ///    &lt;/Field&gt;
        ///  &lt;/Category&gt;
        ///  &lt;Category Title=&quot;Personal&quot;&gt;
        ///    &lt;Field Name=&quot;Age&quot; Type=&quot;NullInteger&quot;&gt;
        ///      Selects on age if birthdate is available
        ///    &lt;/Field&gt;
        ///    &lt;Field Name=&quot;GenderId&quot; Title=&quot;Gender&quot; Type=&quot;Code&quot; DataSource=&quot;GenderCodes&quot; DataValueField=&quot;IdCode&quot;&gt;
        ///      Search by gender  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string FieldMap2 {
            get {
                return ResourceManager.GetString("FieldMap2", resourceCulture);
            }
        }
    }
}
