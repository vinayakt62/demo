﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=.\\sqlexpress;Initial Catalog=GoogleDemo;Integrated Security=True;Pool" +
            "ing=False")]
        public string GoogleDemoConnectionString {
            get {
                return ((string)(this["GoogleDemoConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=.\\SQLEXPRESS;Initial Catalog=\"C:\\PROGRAM FILES\\MICROSOFT SQL SERVER\\M" +
            "SSQL.1\\MSSQL\\DATA\\GOOGLEDEMO.MDF\";Integrated Security=True")]
        public string C__PROGRAM_FILES_MICROSOFT_SQL_SERVER_MSSQL_1_MSSQL_DATA_GOOGLEDEMO_MDFConnectionString {
            get {
                return ((string)(this["C__PROGRAM_FILES_MICROSOFT_SQL_SERVER_MSSQL_1_MSSQL_DATA_GOOGLEDEMO_MDFConnection" +
                    "String"]));
            }
        }
    }
}
