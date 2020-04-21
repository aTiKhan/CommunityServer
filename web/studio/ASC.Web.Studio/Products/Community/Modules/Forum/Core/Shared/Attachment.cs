/*
 *
 * (c) Copyright Ascensio System Limited 2010-2020
 *
 * This program is freeware. You can redistribute it and/or modify it under the terms of the GNU 
 * General Public License (GPL) version 3 as published by the Free Software Foundation (https://www.gnu.org/copyleft/gpl.html). 
 * In accordance with Section 7(a) of the GNU GPL its Section 15 shall be amended to the effect that 
 * Ascensio System SIA expressly excludes the warranty of non-infringement of any third-party rights.
 *
 * THIS PROGRAM IS DISTRIBUTED WITHOUT ANY WARRANTY; WITHOUT EVEN THE IMPLIED WARRANTY OF MERCHANTABILITY OR
 * FITNESS FOR A PARTICULAR PURPOSE. For more details, see GNU GPL at https://www.gnu.org/copyleft/gpl.html
 *
 * You can contact Ascensio System SIA by email at sales@onlyoffice.com
 *
 * The interactive user interfaces in modified source and object code versions of ONLYOFFICE must display 
 * Appropriate Legal Notices, as required under Section 5 of the GNU GPL version 3.
 *
 * Pursuant to Section 7 § 3(b) of the GNU GPL you must retain the original ONLYOFFICE logo which contains 
 * relevant author attributions when distributing the software. If the display of the logo in its graphic 
 * form is not reasonably feasible for technical reasons, you must include the words "Powered by ONLYOFFICE" 
 * in every copy of the program you distribute. 
 * Pursuant to Section 7 § 3(e) we decline to grant you any rights under trademark law for use of our trademarks.
 *
*/


using System;
using System.Reflection;

namespace ASC.Forum
{
	public enum AttachmentContentType
    {
        Uknown = 0,

        Audio = 2,

        Video = 1,

        Image = 3,

        Application = 4,

        Office = 5,

        Text = 6,

        Zip = 7,

        Others = 8
    }

	public class Attachment
    {       
        public virtual int ID{get; set;}

        public virtual DateTime CreateDate { get; set; }
       
        public virtual string Name{get; set;}  
        
        public virtual int Size{get; set;}

        public virtual int DownloadCount{get; set;}

        public virtual AttachmentContentType ContentType { get; set; }      

        public virtual string MIMEContentType { get; set; }

        public virtual string OffsetPhysicalPath { get; set; }

        public virtual int PostID { get; set; }

        public virtual int TenantID { get; set; }

        public Attachment()
        {
            this.ID= 0;            
            this.Name = "";
            this.CreateDate = ASC.Core.Tenants.TenantUtil.DateTimeNow();
            this.Size = 0;
            this.MIMEContentType = "";
            this.ContentType = AttachmentContentType.Uknown;
            this.OffsetPhysicalPath = "";
        }
    }
}
