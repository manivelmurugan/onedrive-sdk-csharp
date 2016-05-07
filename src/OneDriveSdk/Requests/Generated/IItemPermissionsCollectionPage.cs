// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.OneDrive.Sdk
{
    using System;
    
    using Microsoft.Graph;
    using Newtonsoft.Json;
    
    /// <summary>
    /// The interface IItemPermissionsCollectionPage.
    /// </summary>
    [JsonConverter(typeof(InterfaceConverter<ItemPermissionsCollectionPage>))]
    public interface IItemPermissionsCollectionPage : ICollectionPage<Permission>
    {
        /// <summary>
        /// Gets the next page <see cref="IItemPermissionsCollectionRequest"/> instance.
        /// </summary>
        IItemPermissionsCollectionRequest NextPageRequest { get; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString);
    }
}
