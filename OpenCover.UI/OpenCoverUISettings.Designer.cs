﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpenCover.UI {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    internal sealed partial class OpenCoverUISettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static OpenCoverUISettings defaultInstance = ((OpenCoverUISettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new OpenCoverUISettings())));
        
        public static OpenCoverUISettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string NUnitPath {
            get {
                return ((string)(this["NUnitPath"]));
            }
            set {
                this["NUnitPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string OpenCoverPath {
            get {
                return ((string)(this["OpenCoverPath"]));
            }
            set {
                this["OpenCoverPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ReportGeneratorPath {
            get {
                return ((string)(this["ReportGeneratorPath"]));
            }
            set {
                this["ReportGeneratorPath"] = value;
            }
        }
    }
}
