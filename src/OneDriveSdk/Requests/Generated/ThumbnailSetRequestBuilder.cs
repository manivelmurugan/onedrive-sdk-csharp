// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.OneDrive.Sdk
{
    using System;
    using System.Collections.Generic;
    
    using Microsoft.Graph;

    /// <summary>
    /// The type ThumbnailSetRequestBuilder.
    /// </summary>
    public partial class ThumbnailSetRequestBuilder : BaseRequestBuilder, IThumbnailSetRequestBuilder
    {

        /// <summary>
        /// Constructs a new ThumbnailSetRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ThumbnailSetRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IThumbnailSetRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IThumbnailSetRequest Request(IEnumerable<Option> options)
        {
            return new ThumbnailSetRequest(this.RequestUrl, this.Client, options);
        }
    
    }
}
