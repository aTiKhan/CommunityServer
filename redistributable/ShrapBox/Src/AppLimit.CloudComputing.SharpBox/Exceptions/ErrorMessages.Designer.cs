﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppLimit.CloudComputing.SharpBox.Exceptions {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AppLimit.CloudComputing.SharpBox.Exceptions.ErrorMessages", typeof(ErrorMessages).Assembly);
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
        ///   Looks up a localized string similar to Couldn&apos;t contact storage service.
        /// </summary>
        internal static string ErrorCouldNotContactStorageService {
            get {
                return ResourceManager.GetString("ErrorCouldNotContactStorageService", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Couldn&apos;t retrieve child elements from the server.
        /// </summary>
        internal static string ErrorCouldNotRetrieveDirectoryList {
            get {
                return ResourceManager.GetString("ErrorCouldNotRetrieveDirectoryList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Instancing the cloud storage provider failed, verify the inner exception.
        /// </summary>
        internal static string ErrorCreateProviderInstanceFailed {
            get {
                return ResourceManager.GetString("ErrorCreateProviderInstanceFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File not found.
        /// </summary>
        internal static string ErrorFileNotFound {
            get {
                return ResourceManager.GetString("ErrorFileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No more space in cloud storage available.
        /// </summary>
        internal static string ErrorInsufficientDiskSpace {
            get {
                return ResourceManager.GetString("ErrorInsufficientDiskSpace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The gived consumer Key/Secret are invalid.
        /// </summary>
        internal static string ErrorInvalidConsumerKeySecret {
            get {
                return ResourceManager.GetString("ErrorInvalidConsumerKeySecret", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The gived credentials or configuration format does not fits to the storage provider.
        /// </summary>
        internal static string ErrorInvalidCredentialsOrConfiguration {
            get {
                return ResourceManager.GetString("ErrorInvalidCredentialsOrConfiguration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid file or directory name.
        /// </summary>
        internal static string ErrorInvalidFileOrDirectoryName {
            get {
                return ResourceManager.GetString("ErrorInvalidFileOrDirectoryName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to One or more parameters are invalid.
        /// </summary>
        internal static string ErrorInvalidParameters {
            get {
                return ResourceManager.GetString("ErrorInvalidParameters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Configured file size limit for transfer exceeded.
        /// </summary>
        internal static string ErrorLimitExceeded {
            get {
                return ResourceManager.GetString("ErrorLimitExceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No valid storage provider was found for the given configuration type.
        /// </summary>
        internal static string ErrorNoValidProviderFound {
            get {
                return ResourceManager.GetString("ErrorNoValidProviderFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The operation needs an opened connection to the cloud storage, please call the open method before!.
        /// </summary>
        internal static string ErrorOpenedConnectionNeeded {
            get {
                return ResourceManager.GetString("ErrorOpenedConnectionNeeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The datatransfer was interrupted from the application during a callback.
        /// </summary>
        internal static string ErrorTransferAbortedManually {
            get {
                return ResourceManager.GetString("ErrorTransferAbortedManually", resourceCulture);
            }
        }
    }
}
