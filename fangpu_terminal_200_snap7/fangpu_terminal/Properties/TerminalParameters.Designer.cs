﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace fangpu_terminal.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    public sealed partial class TerminalParameters : global::System.Configuration.ApplicationSettingsBase {
        
        private static TerminalParameters defaultInstance = ((TerminalParameters)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new TerminalParameters())));
        
        public static TerminalParameters Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("192.168.1.51")]
        public string plc1_tcp_ip {
            get {
                return ((string)(this["plc1_tcp_ip"]));
            }
            set {
                this["plc1_tcp_ip"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int plc1_tcp_port {
            get {
                return ((int)(this["plc1_tcp_port"]));
            }
            set {
                this["plc1_tcp_port"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string plc2_tcp_ip {
            get {
                return ((string)(this["plc2_tcp_ip"]));
            }
            set {
                this["plc2_tcp_ip"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public string plc2_tcp_port {
            get {
                return ((string)(this["plc2_tcp_port"]));
            }
            set {
                this["plc2_tcp_port"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("data\\datalocal.db")]
        public string localdatapath {
            get {
                return ((string)(this["localdatapath"]));
            }
            set {
                this["localdatapath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("COM12")]
        public string plc_com_port {
            get {
                return ((string)(this["plc_com_port"]));
            }
            set {
                this["plc_com_port"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("187500")]
        public int plc_com_baudrate {
            get {
                return ((int)(this["plc_com_baudrate"]));
            }
            set {
                this["plc_com_baudrate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("D17")]
        public string terminal_id {
            get {
                return ((string)(this["terminal_id"]));
            }
            set {
                this["terminal_id"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public int heart_connect_interval {
            get {
                return ((int)(this["heart_connect_interval"]));
            }
            set {
                this["heart_connect_interval"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("D17")]
        public string terminal_name {
            get {
                return ((string)(this["terminal_name"]));
            }
            set {
                this["terminal_name"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("192.168.1.25")]
        public string terminal_server_ip {
            get {
                return ((string)(this["terminal_server_ip"]));
            }
            set {
                this["terminal_server_ip"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4096")]
        public int PLC_TSAP_Remote {
            get {
                return ((int)(this["PLC_TSAP_Remote"]));
            }
            set {
                this["PLC_TSAP_Remote"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4097")]
        public int PLC_TSAP_Local {
            get {
                return ((int)(this["PLC_TSAP_Local"]));
            }
            set {
                this["PLC_TSAP_Local"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("root")]
        public string terminal_server_id {
            get {
                return ((string)(this["terminal_server_id"]));
            }
            set {
                this["terminal_server_id"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10000")]
        public int terminal_server_port {
            get {
                return ((int)(this["terminal_server_port"]));
            }
            set {
                this["terminal_server_port"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("fangpu_datacenter")]
        public string terminal_server_db {
            get {
                return ((string)(this["terminal_server_db"]));
            }
            set {
                this["terminal_server_db"] = value;
            }
        }
    }
}
