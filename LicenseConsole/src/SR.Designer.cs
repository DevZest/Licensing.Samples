﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LicenseConsole {
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
    internal class SR {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SR() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("LicenseConsole.SR", typeof(SR).Assembly);
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
        ///   Looks up a localized string similar to Save.
        /// </summary>
        internal static string Caption_OverwriteDistributableLicense {
            get {
                return ResourceManager.GetString("Caption_OverwriteDistributableLicense", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is no AssemblyProductAttribute for the assembly..
        /// </summary>
        internal static string Exception_NoAssemblyProductAttribute {
            get {
                return ResourceManager.GetString("Exception_NoAssemblyProductAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The distributable license file &quot;{0}&quot; has been saved under folder &quot;{1}&quot;. 
        ///
        ///Please add this file as embedded resource of the assembly if the assembly is signed with a strong name; or the assembly specified by EmbeddedAssemblyLicense attribute if the assembly is not signed.
        ///
        ///IMPORTANT: Don&apos;t modify or rename the saved license file, or your assembly will not be properly licensed..
        /// </summary>
        internal static string Format_DistributableLicenseSaved {
            get {
                return ResourceManager.GetString("Format_DistributableLicenseSaved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You should not get distributable license for component &apos;{0}&apos; itself. An assembly/executable which references component &apos;{0}&apos; should be entered..
        /// </summary>
        internal static string Format_GetDistributableLicense_SelfComponent {
            get {
                return ResourceManager.GetString("Format_GetDistributableLicense_SelfComponent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error launching the default email client: {0}.
        /// </summary>
        internal static string Format_LaunchEmailClientFailed {
            get {
                return ResourceManager.GetString("Format_LaunchEmailClientFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Evaluation ({0}).
        /// </summary>
        internal static string Format_LicenseState_Evaluation {
            get {
                return ResourceManager.GetString("Format_LicenseState_Evaluation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Evaluation Expired.
        /// </summary>
        internal static string Format_LicenseState_EvaluationExpired {
            get {
                return ResourceManager.GetString("Format_LicenseState_EvaluationExpired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Free Feature.
        /// </summary>
        internal static string Format_LicenseState_FreeFeature {
            get {
                return ResourceManager.GetString("Format_LicenseState_FreeFeature", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not Licensed.
        /// </summary>
        internal static string Format_LicenseState_NotLicensed {
            get {
                return ResourceManager.GetString("Format_LicenseState_NotLicensed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Paid.
        /// </summary>
        internal static string Format_LicenseState_Paid {
            get {
                return ResourceManager.GetString("Format_LicenseState_Paid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to License Console - {0}.
        /// </summary>
        internal static string Format_MainWindowTitle {
            get {
                return ResourceManager.GetString("Format_MainWindowTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The distributable license file &quot;{0}&quot; already exists. Are you sure you want to overwrite it?.
        /// </summary>
        internal static string Format_OverwriteDistributableLicense {
            get {
                return ResourceManager.GetString("Format_OverwriteDistributableLicense", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The registry key &quot;{0}&quot; does not exist..
        /// </summary>
        internal static string Format_RegistryKeyNotExist {
            get {
                return ResourceManager.GetString("Format_RegistryKeyNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please add this license file as embedded resource of your assembly..
        /// </summary>
        internal static string Message_AddLicenseFileAsEmbeddedResource {
            get {
                return ResourceManager.GetString("Message_AddLicenseFileAsEmbeddedResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Check of UpgradeExpirationDate failed. You can not use current version of the assembly..
        /// </summary>
        internal static string Message_InvalidUpgradeExpirationDate {
            get {
                return ResourceManager.GetString("Message_InvalidUpgradeExpirationDate", resourceCulture);
            }
        }
    }
}
