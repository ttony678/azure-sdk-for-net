// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerRegistry
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for BuildsOperations.
    /// </summary>
    public static partial class BuildsOperationsExtensions
    {
            /// <summary>
            /// Gets all the builds for a registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='skipToken'>
            /// $skipToken is supported on get list of builds, which provides the next page
            /// in the list of builds.
            /// </param>
            public static IPage<Build> List(this IBuildsOperations operations, string resourceGroupName, string registryName, ODataQuery<BuildFilter> odataQuery = default(ODataQuery<BuildFilter>), string skipToken = default(string))
            {
                return operations.ListAsync(resourceGroupName, registryName, odataQuery, skipToken).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the builds for a registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='skipToken'>
            /// $skipToken is supported on get list of builds, which provides the next page
            /// in the list of builds.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Build>> ListAsync(this IBuildsOperations operations, string resourceGroupName, string registryName, ODataQuery<BuildFilter> odataQuery = default(ODataQuery<BuildFilter>), string skipToken = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, registryName, odataQuery, skipToken, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the detailed information for a given build.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='buildId'>
            /// The build ID.
            /// </param>
            public static Build Get(this IBuildsOperations operations, string resourceGroupName, string registryName, string buildId)
            {
                return operations.GetAsync(resourceGroupName, registryName, buildId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the detailed information for a given build.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='buildId'>
            /// The build ID.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Build> GetAsync(this IBuildsOperations operations, string resourceGroupName, string registryName, string buildId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, registryName, buildId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Patch the build properties.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='buildId'>
            /// The build ID.
            /// </param>
            /// <param name='isArchiveEnabled'>
            /// The value that indicates whether archiving is enabled or not.
            /// </param>
            public static Build Update(this IBuildsOperations operations, string resourceGroupName, string registryName, string buildId, bool? isArchiveEnabled = default(bool?))
            {
                return operations.UpdateAsync(resourceGroupName, registryName, buildId, isArchiveEnabled).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Patch the build properties.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='buildId'>
            /// The build ID.
            /// </param>
            /// <param name='isArchiveEnabled'>
            /// The value that indicates whether archiving is enabled or not.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Build> UpdateAsync(this IBuildsOperations operations, string resourceGroupName, string registryName, string buildId, bool? isArchiveEnabled = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, registryName, buildId, isArchiveEnabled, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a link to download the build logs.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='buildId'>
            /// The build ID.
            /// </param>
            public static BuildGetLogResult GetLogLink(this IBuildsOperations operations, string resourceGroupName, string registryName, string buildId)
            {
                return operations.GetLogLinkAsync(resourceGroupName, registryName, buildId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a link to download the build logs.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='buildId'>
            /// The build ID.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BuildGetLogResult> GetLogLinkAsync(this IBuildsOperations operations, string resourceGroupName, string registryName, string buildId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetLogLinkWithHttpMessagesAsync(resourceGroupName, registryName, buildId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Cancel an existing build.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='buildId'>
            /// The build ID.
            /// </param>
            public static void Cancel(this IBuildsOperations operations, string resourceGroupName, string registryName, string buildId)
            {
                operations.CancelAsync(resourceGroupName, registryName, buildId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Cancel an existing build.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='buildId'>
            /// The build ID.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task CancelAsync(this IBuildsOperations operations, string resourceGroupName, string registryName, string buildId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.CancelWithHttpMessagesAsync(resourceGroupName, registryName, buildId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Patch the build properties.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='buildId'>
            /// The build ID.
            /// </param>
            /// <param name='isArchiveEnabled'>
            /// The value that indicates whether archiving is enabled or not.
            /// </param>
            public static Build BeginUpdate(this IBuildsOperations operations, string resourceGroupName, string registryName, string buildId, bool? isArchiveEnabled = default(bool?))
            {
                return operations.BeginUpdateAsync(resourceGroupName, registryName, buildId, isArchiveEnabled).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Patch the build properties.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='buildId'>
            /// The build ID.
            /// </param>
            /// <param name='isArchiveEnabled'>
            /// The value that indicates whether archiving is enabled or not.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Build> BeginUpdateAsync(this IBuildsOperations operations, string resourceGroupName, string registryName, string buildId, bool? isArchiveEnabled = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, registryName, buildId, isArchiveEnabled, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Cancel an existing build.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='buildId'>
            /// The build ID.
            /// </param>
            public static void BeginCancel(this IBuildsOperations operations, string resourceGroupName, string registryName, string buildId)
            {
                operations.BeginCancelAsync(resourceGroupName, registryName, buildId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Cancel an existing build.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='buildId'>
            /// The build ID.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginCancelAsync(this IBuildsOperations operations, string resourceGroupName, string registryName, string buildId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginCancelWithHttpMessagesAsync(resourceGroupName, registryName, buildId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets all the builds for a registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Build> ListNext(this IBuildsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the builds for a registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Build>> ListNextAsync(this IBuildsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}