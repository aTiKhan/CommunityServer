// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System;
using System.IO;
using System.Net.Http;
using System.Threading;

using Microsoft.Graph;

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.OneDrive.Sdk
{
    /// <summary>
    /// The interface IDriveRequest.
    /// </summary>
    public partial interface IDriveRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Drive using PUT.
        /// </summary>
        /// <param name="driveToCreate">The Drive to create.</param>
        /// <returns>The created Drive.</returns>
        System.Threading.Tasks.Task<Drive> CreateAsync(Drive driveToCreate);        /// <summary>
        /// Creates the specified Drive using PUT.
        /// </summary>
        /// <param name="driveToCreate">The Drive to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Drive.</returns>
        System.Threading.Tasks.Task<Drive> CreateAsync(Drive driveToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Drive.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Drive.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Drive.
        /// </summary>
        /// <returns>The Drive.</returns>
        System.Threading.Tasks.Task<Drive> GetAsync();

        /// <summary>
        /// Gets the specified Drive.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Drive.</returns>
        System.Threading.Tasks.Task<Drive> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Drive using PATCH.
        /// </summary>
        /// <param name="driveToUpdate">The Drive to update.</param>
        /// <returns>The updated Drive.</returns>
        System.Threading.Tasks.Task<Drive> UpdateAsync(Drive driveToUpdate);

        /// <summary>
        /// Updates the specified Drive using PATCH.
        /// </summary>
        /// <param name="driveToUpdate">The Drive to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated Drive.</returns>
        System.Threading.Tasks.Task<Drive> UpdateAsync(Drive driveToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDriveRequest Expand(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDriveRequest Select(string value);

    }
}
