// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.OneDrive.Sdk
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    
    using Microsoft.Graph;

    /// <summary>
    /// The type ShareRequest.
    /// </summary>
    public partial class ShareRequest : BaseRequest, IShareRequest
    {
        /// <summary>
        /// Constructs a new ShareRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ShareRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Share using PUT.
        /// </summary>
        /// <param name="shareToCreate">The Share to create.</param>
        /// <returns>The created Share.</returns>
        public Task<Share> CreateAsync(Share shareToCreate)
        {
            return this.CreateAsync(shareToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified Share using PUT.
        /// </summary>
        /// <param name="shareToCreate">The Share to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Share.</returns>
        public async Task<Share> CreateAsync(Share shareToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PUT";
            var newEntity = await this.SendAsync<Share>(shareToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified Share.
        /// </summary>
        /// <returns>The task to await.</returns>
        public Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified Share.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<Share>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified Share.
        /// </summary>
        /// <returns>The Share.</returns>
        public Task<Share> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified Share.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Share.</returns>
        public async Task<Share> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<Share>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified Share using PATCH.
        /// </summary>
        /// <param name="shareToUpdate">The Share to update.</param>
        /// <returns>The updated Share.</returns>
        public Task<Share> UpdateAsync(Share shareToUpdate)
        {
            return this.UpdateAsync(shareToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified Share using PATCH.
        /// </summary>
        /// <param name="shareToUpdate">The Share to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated Share.</returns>
        public async Task<Share> UpdateAsync(Share shareToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<Share>(shareToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IShareRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IShareRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="shareToInitialize">The <see cref="Share"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Share shareToInitialize)
        {
        
            if (shareToInitialize != null && shareToInitialize.AdditionalData != null)
            {
        
                if (shareToInitialize.Items != null && shareToInitialize.Items.CurrentPage != null)
                {
                    shareToInitialize.Items.AdditionalData = shareToInitialize.AdditionalData;

                    object nextPageLink;
                    shareToInitialize.AdditionalData.TryGetValue("items@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        shareToInitialize.Items.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }
        
            }

        
        }
    }
}
