﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASC.Api.Calendar.Notification {
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
    public class CalendarPatternResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal CalendarPatternResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ASC.Api.Calendar.Notification.CalendarPatternResource", typeof(CalendarPatternResource).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #if($SharingType == &quot;calendar&quot;)
        ///h1.Access Granted to Calendar: $CalendarName
        /// 
        /// 
        ///&quot;$UserName&quot;:&quot;$UserLink&quot; has granted you the access to the calendar: $CalendarName 
        ///
        ///#end
        ///#if($SharingType == &quot;event&quot;)
        ///h1.Access Granted to Event: $EventName
        /// 
        /// 
        ///&quot;$UserName&quot;:&quot;$UserLink&quot; has granted you the access to the event: $EventName
        ///
        ///#end.
        /// </summary>
        public static string CalendarSharingEmailPattern {
            get {
                return ResourceManager.GetString("CalendarSharingEmailPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #if($SharingType == &quot;calendar&quot;)
        ///Calendar. Access Granted to Calendar: $CalendarName
        ///#end
        ///#if($SharingType == &quot;event&quot;)
        ///Calendar. Access Granted to Event: $EventName
        ///#end.
        /// </summary>
        public static string CalendarSharingJabberPattern {
            get {
                return ResourceManager.GetString("CalendarSharingJabberPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #if($SharingType == &quot;calendar&quot;)
        ///Calendar. Access granted to calendar: $CalendarName
        ///#end
        ///#if($SharingType == &quot;event&quot;)
        ///Calendar. Access granted to event: $EventName
        ///#end.
        /// </summary>
        public static string CalendarSharingSubject {
            get {
                return ResourceManager.GetString("CalendarSharingSubject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to h1.Reminder about the Event: $EventName
        /// 
        /// 
        ///The $EventName event is appointed for $EventStartDate #if($EventEndDate!=&quot;&quot;)- $EventEndDate #end
        ///#if($EventDescription!=&quot;&quot;)
        /// 
        /// Event Description:
        /// 
        ///$EventDescription
        ///#end.
        /// </summary>
        public static string EventAlertEmailPattern {
            get {
                return ResourceManager.GetString("EventAlertEmailPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The $EventName event is appointed for $EventStartDate #if($EventEndDate!=&quot;&quot;)- $EventEndDate #end
        ///#if($EventDescription!=&quot;&quot;)
        /// 
        /// Event Description:
        /// 
        ///$EventDescription
        ///#end.
        /// </summary>
        public static string EventAlertJabberPattern {
            get {
                return ResourceManager.GetString("EventAlertJabberPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Calendar. Reminder about the event: $EventName.
        /// </summary>
        public static string EventAlertSubject {
            get {
                return ResourceManager.GetString("EventAlertSubject", resourceCulture);
            }
        }
    }
}
