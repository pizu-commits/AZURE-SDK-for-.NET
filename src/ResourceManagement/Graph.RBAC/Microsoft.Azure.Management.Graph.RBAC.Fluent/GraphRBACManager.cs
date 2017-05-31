﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Linq;
using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
using Microsoft.Azure.Management.ResourceManager.Fluent.Authentication;

namespace Microsoft.Azure.Management.Graph.RBAC.Fluent
{
    /// <summary>
    /// Entry point to Azure Graph RBAC management.
    /// </summary>
    public class GraphRbacManager : Manager<IGraphRbacManagementClient>, IGraphRbacManager, IBeta
    {
        #region Fluent private collections
        private IActiveDirectoryUsers users;
        private IServicePrincipals servicePrincipals;
        private IAuthorizationManagementClient roleInner;
        #endregion

        #region ctrs

        public GraphRbacManager(RestClient restClient, string subscriptionId, string tenantId) :
            base(restClient, subscriptionId, new GraphRbacManagementClient(new Uri(restClient.BaseUri),
                restClient.Credentials,
                restClient.RootHttpHandler,
                restClient.Handlers.ToArray())
            {
                TenantID = tenantId
            })
        {
        }

        #endregion

        #region Graph RBAC Manager builder

        public static IGraphRbacManager Authenticate(AzureCredentials credentials, string subscriptionId, string tenantId)
        {
            return new GraphRbacManager(RestClient.Configure()
                    .WithBaseUri(credentials.Environment.GraphEndpoint)
                    .WithCredentials(credentials)
                    .WithDelegatingHandler(new ProviderRegistrationDelegatingHandler(credentials))
                    .Build(), subscriptionId, tenantId);
        }

        public static IGraphRbacManager Authenticate(RestClient restClient, string subscriptionId, string tenantId)
        {
            return new GraphRbacManager(restClient, subscriptionId, tenantId);
        }

        public static IConfigurable Configure()
        {
            return new Configurable();
        }

        #endregion


        #region IConfigurable and it's implementation

        public interface IConfigurable : IAzureConfigurable<IConfigurable>
        {
            IGraphRbacManager Authenticate(AzureCredentials credentials, string subscriptionId, string tenantId);
        }

        protected class Configurable :
            AzureConfigurable<IConfigurable>,
            IConfigurable
        {
            public IGraphRbacManager Authenticate(AzureCredentials credentials, string subscriptionId, string tenantId)
            {
                return new GraphRbacManager(BuildRestClientForGraph(credentials), subscriptionId, tenantId);
            }
        }

        #endregion

        #region IGraphRbacManager implementation 

        public IAuthorizationManagementClient RoleInner
        {
            get
            {
                return roleInner;
            }
        }

        public IActiveDirectoryUsers Users
        {
            get
            {
                if (users == null)
                {
                    users = new ActiveDirectoryUsersImpl(this);
                }

                return users;
            }
        }

        public IServicePrincipals ServicePrincipals
        {
            get
            {
                if (servicePrincipals == null)
                {
                    servicePrincipals = new ServicePrincipalsImpl(Inner.ServicePrincipals, this);
                }
                return servicePrincipals;
            }
        }
        #endregion
    }

    public interface IGraphRbacManager : IManager<IGraphRbacManagementClient>
    {
        IAuthorizationManagementClient RoleInner { get; }
        IActiveDirectoryUsers Users { get; }
        IServicePrincipals ServicePrincipals { get; }
    }
}
