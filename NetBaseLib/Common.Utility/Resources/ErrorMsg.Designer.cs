﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Common.Utility.Resources {
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
    internal class ErrorMsg {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ErrorMsg() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Common.Utility.Resources.ErrorMsg", typeof(ErrorMsg).Assembly);
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
        ///   Looks up a localized string similar to 否.
        /// </summary>
        internal static string Boolean_False {
            get {
                return ResourceManager.GetString("Boolean_False", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 是.
        /// </summary>
        internal static string Boolean_True {
            get {
                return ResourceManager.GetString("Boolean_True", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 对不起，导出失败！本次导出所查询出的结果记录条数超过了允许导出的最大记录条数（{0}），请进一步设置查询条件，以缩小所查出的记录的条数！.
        /// </summary>
        internal static string DataExport_DataTableRowCountExceedLimit {
            get {
                return ResourceManager.GetString("DataExport_DataTableRowCountExceedLimit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 失败记录如下：.
        /// </summary>
        internal static string FailedPromptFormat {
            get {
                return ResourceManager.GetString("FailedPromptFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 共选择{0}条记录，成功{1}条，失败{2}条。.
        /// </summary>
        internal static string PromptTitleFormat {
            get {
                return ResourceManager.GetString("PromptTitleFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .
        /// </summary>
        internal static string String1 {
            get {
                return ResourceManager.GetString("String1", resourceCulture);
            }
        }
    }
}