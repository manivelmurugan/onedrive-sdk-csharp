// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.OneDrive.Sdk
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    
    using Microsoft.Graph;

    /// <summary>
    /// The type ItemCreateSessionRequestBuilder.
    /// </summary>
    public partial class ItemCreateSessionRequestBuilder : BaseRequestBuilder, IItemCreateSessionRequestBuilder
    {
    
        public ItemCreateSessionRequestBuilder(
            string requestUrl,
            IBaseClient client,
            ChunkedUploadSessionDescriptor item = null)
            : base(requestUrl, client)
        {
            
            this.Item = item;

        }
    
        /// <summary>
        /// Gets the value of Item.
        /// </summary>
        public ChunkedUploadSessionDescriptor Item { get; set; }
    
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IItemCreateSessionRequest Request(IEnumerable<Option> options = null)
        {
                
            return new ItemCreateSessionRequest(
                this.RequestUrl,
                this.Client,
                options,
                this.Item);
        
        }

    }
}

