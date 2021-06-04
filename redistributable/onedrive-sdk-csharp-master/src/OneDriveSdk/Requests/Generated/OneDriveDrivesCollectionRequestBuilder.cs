// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

using Microsoft.Graph;

// **NOTE** This file was generated by a tool and any changes will be overwritten.

namespace Microsoft.OneDrive.Sdk
{
    /// <summary>
    /// The type OneDriveDrivesCollectionRequestBuilder.
    /// </summary>
    public partial class OneDriveDrivesCollectionRequestBuilder : BaseRequestBuilder, IOneDriveDrivesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new OneDriveDrivesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public OneDriveDrivesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IOneDriveDrivesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IOneDriveDrivesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new OneDriveDrivesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IDriveRequestBuilder"/> for the specified OneDriveDrive.
        /// </summary>
        /// <param name="id">The ID for the OneDriveDrive.</param>
        /// <returns>The <see cref="IDriveRequestBuilder"/>.</returns>
        public IDriveRequestBuilder this[string id]
        {
            get
            {
                return new DriveRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }
    }
}
