// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.SelfHelp;
using Azure.ResourceManager.SelfHelp.Models;

namespace Azure.ResourceManager.SelfHelp.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableSelfHelpArmClient : ArmResource
    {
        private ClientDiagnostics _checkNameAvailabilityClientDiagnostics;
        private CheckNameAvailabilityRestOperations _checkNameAvailabilityRestClient;
        private ClientDiagnostics _discoverySolutionClientDiagnostics;
        private DiscoverySolutionRestOperations _discoverySolutionRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableSelfHelpArmClient"/> class for mocking. </summary>
        protected MockableSelfHelpArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableSelfHelpArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableSelfHelpArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableSelfHelpArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private ClientDiagnostics CheckNameAvailabilityClientDiagnostics => _checkNameAvailabilityClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.SelfHelp", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private CheckNameAvailabilityRestOperations CheckNameAvailabilityRestClient => _checkNameAvailabilityRestClient ??= new CheckNameAvailabilityRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics DiscoverySolutionClientDiagnostics => _discoverySolutionClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.SelfHelp", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private DiscoverySolutionRestOperations DiscoverySolutionRestClient => _discoverySolutionRestClient ??= new DiscoverySolutionRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of SelfHelpDiagnosticResources in the ArmClient. </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <returns> An object representing collection of SelfHelpDiagnosticResources and their operations over a SelfHelpDiagnosticResource. </returns>
        public virtual SelfHelpDiagnosticCollection GetSelfHelpDiagnostics(ResourceIdentifier scope)
        {
            return new SelfHelpDiagnosticCollection(Client, scope);
        }

        /// <summary>
        /// Get the diagnostics using the 'diagnosticsResourceName' you chose while creating the diagnostic.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Help/diagnostics/{diagnosticsResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SelfHelpDiagnosticResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="diagnosticsResourceName"> Unique resource name for insight resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticsResourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="diagnosticsResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SelfHelpDiagnosticResource>> GetSelfHelpDiagnosticAsync(ResourceIdentifier scope, string diagnosticsResourceName, CancellationToken cancellationToken = default)
        {
            return await GetSelfHelpDiagnostics(scope).GetAsync(diagnosticsResourceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the diagnostics using the 'diagnosticsResourceName' you chose while creating the diagnostic.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Help/diagnostics/{diagnosticsResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SelfHelpDiagnosticResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="diagnosticsResourceName"> Unique resource name for insight resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticsResourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="diagnosticsResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<SelfHelpDiagnosticResource> GetSelfHelpDiagnostic(ResourceIdentifier scope, string diagnosticsResourceName, CancellationToken cancellationToken = default)
        {
            return GetSelfHelpDiagnostics(scope).Get(diagnosticsResourceName, cancellationToken);
        }

        /// <summary> Gets a collection of SolutionResources in the ArmClient. </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <returns> An object representing collection of SolutionResources and their operations over a SolutionResource. </returns>
        public virtual SolutionResourceCollection GetSolutionResources(ResourceIdentifier scope)
        {
            return new SolutionResourceCollection(Client, scope);
        }

        /// <summary>
        /// Get the solution using the applicable solutionResourceName while creating the solution.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Help/solutions/{solutionResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Solution_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SolutionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="solutionResourceName"> Solution resource Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="solutionResourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="solutionResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SolutionResource>> GetSolutionResourceAsync(ResourceIdentifier scope, string solutionResourceName, CancellationToken cancellationToken = default)
        {
            return await GetSolutionResources(scope).GetAsync(solutionResourceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the solution using the applicable solutionResourceName while creating the solution.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Help/solutions/{solutionResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Solution_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SolutionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="solutionResourceName"> Solution resource Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="solutionResourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="solutionResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<SolutionResource> GetSolutionResource(ResourceIdentifier scope, string solutionResourceName, CancellationToken cancellationToken = default)
        {
            return GetSolutionResources(scope).Get(solutionResourceName, cancellationToken);
        }

        /// <summary> Gets a collection of TroubleshooterResources in the ArmClient. </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <returns> An object representing collection of TroubleshooterResources and their operations over a TroubleshooterResource. </returns>
        public virtual TroubleshooterResourceCollection GetTroubleshooterResources(ResourceIdentifier scope)
        {
            return new TroubleshooterResourceCollection(Client, scope);
        }

        /// <summary>
        /// Gets troubleshooter instance result which includes the step status/result of the troubleshooter resource name that is being executed.&lt;br/&gt; Get API is used to retrieve the result of a Troubleshooter instance, which includes the status and result of each step in the Troubleshooter workflow. This API requires the Troubleshooter resource name that was created using the Create API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Help/troubleshooters/{troubleshooterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Troubleshooters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TroubleshooterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="troubleshooterName"> Troubleshooter resource Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="troubleshooterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="troubleshooterName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<TroubleshooterResource>> GetTroubleshooterResourceAsync(ResourceIdentifier scope, string troubleshooterName, CancellationToken cancellationToken = default)
        {
            return await GetTroubleshooterResources(scope).GetAsync(troubleshooterName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets troubleshooter instance result which includes the step status/result of the troubleshooter resource name that is being executed.&lt;br/&gt; Get API is used to retrieve the result of a Troubleshooter instance, which includes the status and result of each step in the Troubleshooter workflow. This API requires the Troubleshooter resource name that was created using the Create API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Help/troubleshooters/{troubleshooterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Troubleshooters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TroubleshooterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="troubleshooterName"> Troubleshooter resource Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="troubleshooterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="troubleshooterName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<TroubleshooterResource> GetTroubleshooterResource(ResourceIdentifier scope, string troubleshooterName, CancellationToken cancellationToken = default)
        {
            return GetTroubleshooterResources(scope).Get(troubleshooterName, cancellationToken);
        }

        /// <summary>
        /// This API is used to check the uniqueness of a resource name used for a diagnostic, troubleshooter or solutions
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Help/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CheckNameAvailability_Post</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="content"> The required parameters for availability check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> is null. </exception>
        public virtual async Task<Response<SelfHelpNameAvailabilityResult>> CheckSelfHelpNameAvailabilityAsync(ResourceIdentifier scope, SelfHelpNameAvailabilityContent content = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));

            using var scope0 = CheckNameAvailabilityClientDiagnostics.CreateScope("MockableSelfHelpArmClient.CheckSelfHelpNameAvailability");
            scope0.Start();
            try
            {
                var response = await CheckNameAvailabilityRestClient.PostAsync(scope, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This API is used to check the uniqueness of a resource name used for a diagnostic, troubleshooter or solutions
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Help/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CheckNameAvailability_Post</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="content"> The required parameters for availability check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> is null. </exception>
        public virtual Response<SelfHelpNameAvailabilityResult> CheckSelfHelpNameAvailability(ResourceIdentifier scope, SelfHelpNameAvailabilityContent content = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));

            using var scope0 = CheckNameAvailabilityClientDiagnostics.CreateScope("MockableSelfHelpArmClient.CheckSelfHelpNameAvailability");
            scope0.Start();
            try
            {
                var response = CheckNameAvailabilityRestClient.Post(scope, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the relevant Azure diagnostics and solutions using [problemClassification API](https://learn.microsoft.com/rest/api/support/problem-classifications/list?tabs=HTTP)) AND  resourceUri or resourceType.&lt;br/&gt; Discovery Solutions is the initial entry point within Help API, which identifies relevant Azure diagnostics and solutions. We will do our best to return the most effective solutions based on the type of inputs, in the request URL  &lt;br/&gt;&lt;br/&gt; Mandatory input :  problemClassificationId (Use the [problemClassification API](https://learn.microsoft.com/rest/api/support/problem-classifications/list?tabs=HTTP)) &lt;br/&gt;Optional input: resourceUri OR resource Type &lt;br/&gt;&lt;br/&gt; &lt;b&gt;Note: &lt;/b&gt;  ‘requiredInputs’ from Discovery solutions response must be passed via ‘additionalParameters’ as an input to Diagnostics and Solutions API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Help/discoverySolutions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiscoverySolution_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="filter"> 'ProblemClassificationId' or 'Id' is a mandatory filter to get solutions ids. It also supports optional 'ResourceType' and 'SolutionType' filters. The filter supports only 'and', 'or' and 'eq' operators. Example: $filter=ProblemClassificationId eq '1ddda5b4-cf6c-4d4f-91ad-bc38ab0e811e'. </param>
        /// <param name="skiptoken"> Skiptoken is only used if a previous operation returned a partial result. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> is null. </exception>
        /// <returns> An async collection of <see cref="SelfHelpSolutionMetadata"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SelfHelpSolutionMetadata> GetSelfHelpDiscoverySolutionsAsync(ResourceIdentifier scope, string filter = null, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));

            HttpMessage FirstPageRequest(int? pageSizeHint) => DiscoverySolutionRestClient.CreateListRequest(scope, filter, skiptoken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DiscoverySolutionRestClient.CreateListNextPageRequest(nextLink, scope, filter, skiptoken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, SelfHelpSolutionMetadata.DeserializeSelfHelpSolutionMetadata, DiscoverySolutionClientDiagnostics, Pipeline, "MockableSelfHelpArmClient.GetSelfHelpDiscoverySolutions", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the relevant Azure diagnostics and solutions using [problemClassification API](https://learn.microsoft.com/rest/api/support/problem-classifications/list?tabs=HTTP)) AND  resourceUri or resourceType.&lt;br/&gt; Discovery Solutions is the initial entry point within Help API, which identifies relevant Azure diagnostics and solutions. We will do our best to return the most effective solutions based on the type of inputs, in the request URL  &lt;br/&gt;&lt;br/&gt; Mandatory input :  problemClassificationId (Use the [problemClassification API](https://learn.microsoft.com/rest/api/support/problem-classifications/list?tabs=HTTP)) &lt;br/&gt;Optional input: resourceUri OR resource Type &lt;br/&gt;&lt;br/&gt; &lt;b&gt;Note: &lt;/b&gt;  ‘requiredInputs’ from Discovery solutions response must be passed via ‘additionalParameters’ as an input to Diagnostics and Solutions API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Help/discoverySolutions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiscoverySolution_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="filter"> 'ProblemClassificationId' or 'Id' is a mandatory filter to get solutions ids. It also supports optional 'ResourceType' and 'SolutionType' filters. The filter supports only 'and', 'or' and 'eq' operators. Example: $filter=ProblemClassificationId eq '1ddda5b4-cf6c-4d4f-91ad-bc38ab0e811e'. </param>
        /// <param name="skiptoken"> Skiptoken is only used if a previous operation returned a partial result. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> is null. </exception>
        /// <returns> A collection of <see cref="SelfHelpSolutionMetadata"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SelfHelpSolutionMetadata> GetSelfHelpDiscoverySolutions(ResourceIdentifier scope, string filter = null, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));

            HttpMessage FirstPageRequest(int? pageSizeHint) => DiscoverySolutionRestClient.CreateListRequest(scope, filter, skiptoken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DiscoverySolutionRestClient.CreateListNextPageRequest(nextLink, scope, filter, skiptoken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, SelfHelpSolutionMetadata.DeserializeSelfHelpSolutionMetadata, DiscoverySolutionClientDiagnostics, Pipeline, "MockableSelfHelpArmClient.GetSelfHelpDiscoverySolutions", "value", "nextLink", cancellationToken);
        }
        /// <summary>
        /// Gets an object representing a <see cref="SelfHelpDiagnosticResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SelfHelpDiagnosticResource.CreateResourceIdentifier" /> to create a <see cref="SelfHelpDiagnosticResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SelfHelpDiagnosticResource"/> object. </returns>
        public virtual SelfHelpDiagnosticResource GetSelfHelpDiagnosticResource(ResourceIdentifier id)
        {
            SelfHelpDiagnosticResource.ValidateResourceId(id);
            return new SelfHelpDiagnosticResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SolutionResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SolutionResource.CreateResourceIdentifier" /> to create a <see cref="SolutionResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SolutionResource"/> object. </returns>
        public virtual SolutionResource GetSolutionResource(ResourceIdentifier id)
        {
            SolutionResource.ValidateResourceId(id);
            return new SolutionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="TroubleshooterResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="TroubleshooterResource.CreateResourceIdentifier" /> to create a <see cref="TroubleshooterResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="TroubleshooterResource"/> object. </returns>
        public virtual TroubleshooterResource GetTroubleshooterResource(ResourceIdentifier id)
        {
            TroubleshooterResource.ValidateResourceId(id);
            return new TroubleshooterResource(Client, id);
        }
    }
}
