// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.Resources.Models;
using Microsoft.WindowsAzure;

namespace Microsoft.Azure.Management.Resources
{
    /// <summary>
    /// Operations for managing resource groups.
    /// </summary>
    public partial interface IResourceGroupOperations
    {
        /// <summary>
        /// Begin deleting resource group.To determine whether the operation
        /// has finished processing the request, call
        /// GetLongRunningOperationStatus.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to be deleted. The name is case
        /// insensitive.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<LongRunningOperationResponse> BeginDeletingAsync(string resourceGroupName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Checks whether resource group exists.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to check. The name is case
        /// insensitive.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Resource group information.
        /// </returns>
        Task<ResourceGroupExistsResult> CheckExistenceAsync(string resourceGroupName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Create a resource group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to be created or updated.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the create or update resource group service
        /// operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Resource group information.
        /// </returns>
        Task<ResourceGroupCreateOrUpdateResult> CreateOrUpdateAsync(string resourceGroupName, BasicResourceGroup parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Delete resource group and all of its resources.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to be deleted. The name is case
        /// insensitive.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<OperationResponse> DeleteAsync(string resourceGroupName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Get a resource group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to get. The name is case insensitive.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Resource group information.
        /// </returns>
        Task<ResourceGroupGetResult> GetAsync(string resourceGroupName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets a resource group permissions.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to get the permissions for.The name is
        /// case insensitive.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Permissions information.
        /// </returns>
        Task<PermissionGetResult> GetPermissionsAsync(string resourceGroupName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets a collection of resource groups.
        /// </summary>
        /// <param name='parameters'>
        /// Query parameters. If null is passed returns all resource groups.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// List of resource groups.
        /// </returns>
        Task<ResourceGroupListResult> ListAsync(ResourceGroupListParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Get a list of deployments.
        /// </summary>
        /// <param name='nextLink'>
        /// NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// List of resource groups.
        /// </returns>
        Task<ResourceGroupListResult> ListNextAsync(string nextLink, CancellationToken cancellationToken);
        
        /// <summary>
        /// Resource groups can be updated through a simple PATCH operation to
        /// a group address. The format of the request is the same as that for
        /// creating a resource groups, though if a field is unspecified
        /// current value will be carried over.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to be created or updated. The name
        /// is case insensitive.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the update state resource group service
        /// operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Resource group information.
        /// </returns>
        Task<ResourceGroupPatchResult> PatchAsync(string resourceGroupName, BasicResourceGroup parameters, CancellationToken cancellationToken);
    }
}
