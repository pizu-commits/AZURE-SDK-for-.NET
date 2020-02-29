// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;

    /// <summary>
    /// The Azure SQL Database management API provides a RESTful set of web
    /// services that interact with Azure SQL Database services to manage your
    /// databases. The API enables you to create, retrieve, update, and delete
    /// databases.
    /// </summary>
    public partial class SqlManagementClient : ServiceClient<SqlManagementClient>, ISqlManagementClient, IAzureClient
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        public System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        public JsonSerializerSettings SerializationSettings { get; private set; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        public JsonSerializerSettings DeserializationSettings { get; private set; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        public ServiceClientCredentials Credentials { get; private set; }

        /// <summary>
        /// The subscription ID that identifies an Azure subscription.
        /// </summary>
        public string SubscriptionId { get; set; }

        /// <summary>
        /// The preferred language for the response.
        /// </summary>
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The retry timeout in seconds for Long Running Operations. Default value is
        /// 30.
        /// </summary>
        public int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// Whether a unique x-ms-client-request-id should be generated. When set to
        /// true a unique x-ms-client-request-id value is generated and included in
        /// each request. Default is true.
        /// </summary>
        public bool? GenerateClientRequestId { get; set; }

        /// <summary>
        /// Gets the IRecoverableDatabasesOperations.
        /// </summary>
        public virtual IRecoverableDatabasesOperations RecoverableDatabases { get; private set; }

        /// <summary>
        /// Gets the IRestorableDroppedDatabasesOperations.
        /// </summary>
        public virtual IRestorableDroppedDatabasesOperations RestorableDroppedDatabases { get; private set; }

        /// <summary>
        /// Gets the IServerConnectionPoliciesOperations.
        /// </summary>
        public virtual IServerConnectionPoliciesOperations ServerConnectionPolicies { get; private set; }

        /// <summary>
        /// Gets the IDatabaseThreatDetectionPoliciesOperations.
        /// </summary>
        public virtual IDatabaseThreatDetectionPoliciesOperations DatabaseThreatDetectionPolicies { get; private set; }

        /// <summary>
        /// Gets the IDataMaskingPoliciesOperations.
        /// </summary>
        public virtual IDataMaskingPoliciesOperations DataMaskingPolicies { get; private set; }

        /// <summary>
        /// Gets the IDataMaskingRulesOperations.
        /// </summary>
        public virtual IDataMaskingRulesOperations DataMaskingRules { get; private set; }

        /// <summary>
        /// Gets the IFirewallRulesOperations.
        /// </summary>
        public virtual IFirewallRulesOperations FirewallRules { get; private set; }

        /// <summary>
        /// Gets the IGeoBackupPoliciesOperations.
        /// </summary>
        public virtual IGeoBackupPoliciesOperations GeoBackupPolicies { get; private set; }

        /// <summary>
        /// Gets the IDatabasesOperations.
        /// </summary>
        public virtual IDatabasesOperations Databases { get; private set; }

        /// <summary>
        /// Gets the IElasticPoolsOperations.
        /// </summary>
        public virtual IElasticPoolsOperations ElasticPools { get; private set; }

        /// <summary>
        /// Gets the IRecommendedElasticPoolsOperations.
        /// </summary>
        public virtual IRecommendedElasticPoolsOperations RecommendedElasticPools { get; private set; }

        /// <summary>
        /// Gets the IReplicationLinksOperations.
        /// </summary>
        public virtual IReplicationLinksOperations ReplicationLinks { get; private set; }

        /// <summary>
        /// Gets the IServerCommunicationLinksOperations.
        /// </summary>
        public virtual IServerCommunicationLinksOperations ServerCommunicationLinks { get; private set; }

        /// <summary>
        /// Gets the IServiceObjectivesOperations.
        /// </summary>
        public virtual IServiceObjectivesOperations ServiceObjectives { get; private set; }

        /// <summary>
        /// Gets the IElasticPoolActivitiesOperations.
        /// </summary>
        public virtual IElasticPoolActivitiesOperations ElasticPoolActivities { get; private set; }

        /// <summary>
        /// Gets the IElasticPoolDatabaseActivitiesOperations.
        /// </summary>
        public virtual IElasticPoolDatabaseActivitiesOperations ElasticPoolDatabaseActivities { get; private set; }

        /// <summary>
        /// Gets the IServiceTierAdvisorsOperations.
        /// </summary>
        public virtual IServiceTierAdvisorsOperations ServiceTierAdvisors { get; private set; }

        /// <summary>
        /// Gets the ITransparentDataEncryptionsOperations.
        /// </summary>
        public virtual ITransparentDataEncryptionsOperations TransparentDataEncryptions { get; private set; }

        /// <summary>
        /// Gets the ITransparentDataEncryptionActivitiesOperations.
        /// </summary>
        public virtual ITransparentDataEncryptionActivitiesOperations TransparentDataEncryptionActivities { get; private set; }

        /// <summary>
        /// Gets the IServerUsagesOperations.
        /// </summary>
        public virtual IServerUsagesOperations ServerUsages { get; private set; }

        /// <summary>
        /// Gets the IDatabaseUsagesOperations.
        /// </summary>
        public virtual IDatabaseUsagesOperations DatabaseUsages { get; private set; }

        /// <summary>
        /// Gets the IDatabaseAutomaticTuningOperations.
        /// </summary>
        public virtual IDatabaseAutomaticTuningOperations DatabaseAutomaticTuning { get; private set; }

        /// <summary>
        /// Gets the IEncryptionProtectorsOperations.
        /// </summary>
        public virtual IEncryptionProtectorsOperations EncryptionProtectors { get; private set; }

        /// <summary>
        /// Gets the IFailoverGroupsOperations.
        /// </summary>
        public virtual IFailoverGroupsOperations FailoverGroups { get; private set; }

        /// <summary>
        /// Gets the IOperations.
        /// </summary>
        public virtual IOperations Operations { get; private set; }

        /// <summary>
        /// Gets the IServerKeysOperations.
        /// </summary>
        public virtual IServerKeysOperations ServerKeys { get; private set; }

        /// <summary>
        /// Gets the ISyncAgentsOperations.
        /// </summary>
        public virtual ISyncAgentsOperations SyncAgents { get; private set; }

        /// <summary>
        /// Gets the ISyncGroupsOperations.
        /// </summary>
        public virtual ISyncGroupsOperations SyncGroups { get; private set; }

        /// <summary>
        /// Gets the ISyncMembersOperations.
        /// </summary>
        public virtual ISyncMembersOperations SyncMembers { get; private set; }

        /// <summary>
        /// Gets the ISubscriptionUsagesOperations.
        /// </summary>
        public virtual ISubscriptionUsagesOperations SubscriptionUsages { get; private set; }

        /// <summary>
        /// Gets the IVirtualClustersOperations.
        /// </summary>
        public virtual IVirtualClustersOperations VirtualClusters { get; private set; }

        /// <summary>
        /// Gets the IVirtualNetworkRulesOperations.
        /// </summary>
        public virtual IVirtualNetworkRulesOperations VirtualNetworkRules { get; private set; }

        /// <summary>
        /// Gets the IExtendedDatabaseBlobAuditingPoliciesOperations.
        /// </summary>
        public virtual IExtendedDatabaseBlobAuditingPoliciesOperations ExtendedDatabaseBlobAuditingPolicies { get; private set; }

        /// <summary>
        /// Gets the IExtendedServerBlobAuditingPoliciesOperations.
        /// </summary>
        public virtual IExtendedServerBlobAuditingPoliciesOperations ExtendedServerBlobAuditingPolicies { get; private set; }

        /// <summary>
        /// Gets the IServerBlobAuditingPoliciesOperations.
        /// </summary>
        public virtual IServerBlobAuditingPoliciesOperations ServerBlobAuditingPolicies { get; private set; }

        /// <summary>
        /// Gets the IDatabaseBlobAuditingPoliciesOperations.
        /// </summary>
        public virtual IDatabaseBlobAuditingPoliciesOperations DatabaseBlobAuditingPolicies { get; private set; }

        /// <summary>
        /// Gets the IDatabaseVulnerabilityAssessmentRuleBaselinesOperations.
        /// </summary>
        public virtual IDatabaseVulnerabilityAssessmentRuleBaselinesOperations DatabaseVulnerabilityAssessmentRuleBaselines { get; private set; }

        /// <summary>
        /// Gets the IDatabaseVulnerabilityAssessmentsOperations.
        /// </summary>
        public virtual IDatabaseVulnerabilityAssessmentsOperations DatabaseVulnerabilityAssessments { get; private set; }

        /// <summary>
        /// Gets the IJobAgentsOperations.
        /// </summary>
        public virtual IJobAgentsOperations JobAgents { get; private set; }

        /// <summary>
        /// Gets the IJobCredentialsOperations.
        /// </summary>
        public virtual IJobCredentialsOperations JobCredentials { get; private set; }

        /// <summary>
        /// Gets the IJobExecutionsOperations.
        /// </summary>
        public virtual IJobExecutionsOperations JobExecutions { get; private set; }

        /// <summary>
        /// Gets the IJobsOperations.
        /// </summary>
        public virtual IJobsOperations Jobs { get; private set; }

        /// <summary>
        /// Gets the IJobStepExecutionsOperations.
        /// </summary>
        public virtual IJobStepExecutionsOperations JobStepExecutions { get; private set; }

        /// <summary>
        /// Gets the IJobStepsOperations.
        /// </summary>
        public virtual IJobStepsOperations JobSteps { get; private set; }

        /// <summary>
        /// Gets the IJobTargetExecutionsOperations.
        /// </summary>
        public virtual IJobTargetExecutionsOperations JobTargetExecutions { get; private set; }

        /// <summary>
        /// Gets the IJobTargetGroupsOperations.
        /// </summary>
        public virtual IJobTargetGroupsOperations JobTargetGroups { get; private set; }

        /// <summary>
        /// Gets the IJobVersionsOperations.
        /// </summary>
        public virtual IJobVersionsOperations JobVersions { get; private set; }

        /// <summary>
        /// Gets the ILongTermRetentionBackupsOperations.
        /// </summary>
        public virtual ILongTermRetentionBackupsOperations LongTermRetentionBackups { get; private set; }

        /// <summary>
        /// Gets the IBackupLongTermRetentionPoliciesOperations.
        /// </summary>
        public virtual IBackupLongTermRetentionPoliciesOperations BackupLongTermRetentionPolicies { get; private set; }

        /// <summary>
        /// Gets the IManagedBackupShortTermRetentionPoliciesOperations.
        /// </summary>
        public virtual IManagedBackupShortTermRetentionPoliciesOperations ManagedBackupShortTermRetentionPolicies { get; private set; }

        /// <summary>
        /// Gets the IManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesOperations.
        /// </summary>
        public virtual IManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesOperations ManagedRestorableDroppedDatabaseBackupShortTermRetentionPolicies { get; private set; }

        /// <summary>
        /// Gets the IServerAutomaticTuningOperations.
        /// </summary>
        public virtual IServerAutomaticTuningOperations ServerAutomaticTuning { get; private set; }

        /// <summary>
        /// Gets the IServerDnsAliasesOperations.
        /// </summary>
        public virtual IServerDnsAliasesOperations ServerDnsAliases { get; private set; }

        /// <summary>
        /// Gets the IServerSecurityAlertPoliciesOperations.
        /// </summary>
        public virtual IServerSecurityAlertPoliciesOperations ServerSecurityAlertPolicies { get; private set; }

        /// <summary>
        /// Gets the IRestorableDroppedManagedDatabasesOperations.
        /// </summary>
        public virtual IRestorableDroppedManagedDatabasesOperations RestorableDroppedManagedDatabases { get; private set; }

        /// <summary>
        /// Gets the IRestorePointsOperations.
        /// </summary>
        public virtual IRestorePointsOperations RestorePoints { get; private set; }

        /// <summary>
        /// Gets the IManagedDatabaseSecurityAlertPoliciesOperations.
        /// </summary>
        public virtual IManagedDatabaseSecurityAlertPoliciesOperations ManagedDatabaseSecurityAlertPolicies { get; private set; }

        /// <summary>
        /// Gets the IManagedServerSecurityAlertPoliciesOperations.
        /// </summary>
        public virtual IManagedServerSecurityAlertPoliciesOperations ManagedServerSecurityAlertPolicies { get; private set; }

        /// <summary>
        /// Gets the ISensitivityLabelsOperations.
        /// </summary>
        public virtual ISensitivityLabelsOperations SensitivityLabels { get; private set; }

        /// <summary>
        /// Gets the IManagedInstanceAdministratorsOperations.
        /// </summary>
        public virtual IManagedInstanceAdministratorsOperations ManagedInstanceAdministrators { get; private set; }

        /// <summary>
        /// Gets the IDatabaseOperations.
        /// </summary>
        public virtual IDatabaseOperations DatabaseOperations { get; private set; }

        /// <summary>
        /// Gets the IElasticPoolOperations.
        /// </summary>
        public virtual IElasticPoolOperations ElasticPoolOperations { get; private set; }

        /// <summary>
        /// Gets the IDatabaseVulnerabilityAssessmentScansOperations.
        /// </summary>
        public virtual IDatabaseVulnerabilityAssessmentScansOperations DatabaseVulnerabilityAssessmentScans { get; private set; }

        /// <summary>
        /// Gets the IManagedDatabaseVulnerabilityAssessmentRuleBaselinesOperations.
        /// </summary>
        public virtual IManagedDatabaseVulnerabilityAssessmentRuleBaselinesOperations ManagedDatabaseVulnerabilityAssessmentRuleBaselines { get; private set; }

        /// <summary>
        /// Gets the IManagedDatabaseVulnerabilityAssessmentScansOperations.
        /// </summary>
        public virtual IManagedDatabaseVulnerabilityAssessmentScansOperations ManagedDatabaseVulnerabilityAssessmentScans { get; private set; }

        /// <summary>
        /// Gets the IManagedDatabaseVulnerabilityAssessmentsOperations.
        /// </summary>
        public virtual IManagedDatabaseVulnerabilityAssessmentsOperations ManagedDatabaseVulnerabilityAssessments { get; private set; }

        /// <summary>
        /// Gets the IInstanceFailoverGroupsOperations.
        /// </summary>
        public virtual IInstanceFailoverGroupsOperations InstanceFailoverGroups { get; private set; }

        /// <summary>
        /// Gets the IBackupShortTermRetentionPoliciesOperations.
        /// </summary>
        public virtual IBackupShortTermRetentionPoliciesOperations BackupShortTermRetentionPolicies { get; private set; }

        /// <summary>
        /// Gets the ITdeCertificatesOperations.
        /// </summary>
        public virtual ITdeCertificatesOperations TdeCertificates { get; private set; }

        /// <summary>
        /// Gets the IManagedInstanceTdeCertificatesOperations.
        /// </summary>
        public virtual IManagedInstanceTdeCertificatesOperations ManagedInstanceTdeCertificates { get; private set; }

        /// <summary>
        /// Gets the IManagedInstanceKeysOperations.
        /// </summary>
        public virtual IManagedInstanceKeysOperations ManagedInstanceKeys { get; private set; }

        /// <summary>
        /// Gets the IManagedInstanceEncryptionProtectorsOperations.
        /// </summary>
        public virtual IManagedInstanceEncryptionProtectorsOperations ManagedInstanceEncryptionProtectors { get; private set; }

        /// <summary>
        /// Gets the IRecoverableManagedDatabasesOperations.
        /// </summary>
        public virtual IRecoverableManagedDatabasesOperations RecoverableManagedDatabases { get; private set; }

        /// <summary>
        /// Gets the IManagedInstanceVulnerabilityAssessmentsOperations.
        /// </summary>
        public virtual IManagedInstanceVulnerabilityAssessmentsOperations ManagedInstanceVulnerabilityAssessments { get; private set; }

        /// <summary>
        /// Gets the IServerVulnerabilityAssessmentsOperations.
        /// </summary>
        public virtual IServerVulnerabilityAssessmentsOperations ServerVulnerabilityAssessments { get; private set; }

        /// <summary>
        /// Gets the IManagedDatabaseSensitivityLabelsOperations.
        /// </summary>
        public virtual IManagedDatabaseSensitivityLabelsOperations ManagedDatabaseSensitivityLabels { get; private set; }

        /// <summary>
        /// Gets the IInstancePoolsOperations.
        /// </summary>
        public virtual IInstancePoolsOperations InstancePools { get; private set; }

        /// <summary>
        /// Gets the IUsagesOperations.
        /// </summary>
        public virtual IUsagesOperations Usages { get; private set; }

        /// <summary>
        /// Gets the IManagedInstancesOperations.
        /// </summary>
        public virtual IManagedInstancesOperations ManagedInstances { get; private set; }

        /// <summary>
        /// Gets the IPrivateEndpointConnectionsOperations.
        /// </summary>
        public virtual IPrivateEndpointConnectionsOperations PrivateEndpointConnections { get; private set; }

        /// <summary>
        /// Gets the IPrivateLinkResourcesOperations.
        /// </summary>
        public virtual IPrivateLinkResourcesOperations PrivateLinkResources { get; private set; }

        /// <summary>
        /// Gets the IServersOperations.
        /// </summary>
        public virtual IServersOperations Servers { get; private set; }

        /// <summary>
        /// Gets the ICapabilitiesOperations.
        /// </summary>
        public virtual ICapabilitiesOperations Capabilities { get; private set; }

        /// <summary>
        /// Gets the ILongTermRetentionManagedInstanceBackupsOperations.
        /// </summary>
        public virtual ILongTermRetentionManagedInstanceBackupsOperations LongTermRetentionManagedInstanceBackups { get; private set; }

        /// <summary>
        /// Gets the IManagedInstanceLongTermRetentionPoliciesOperations.
        /// </summary>
        public virtual IManagedInstanceLongTermRetentionPoliciesOperations ManagedInstanceLongTermRetentionPolicies { get; private set; }

        /// <summary>
        /// Gets the IWorkloadGroupsOperations.
        /// </summary>
        public virtual IWorkloadGroupsOperations WorkloadGroups { get; private set; }

        /// <summary>
        /// Gets the IWorkloadClassifiersOperations.
        /// </summary>
        public virtual IWorkloadClassifiersOperations WorkloadClassifiers { get; private set; }

        /// <summary>
        /// Gets the IManagedDatabasesOperations.
        /// </summary>
        public virtual IManagedDatabasesOperations ManagedDatabases { get; private set; }

        /// <summary>
        /// Gets the IServerAzureADAdministratorsOperations.
        /// </summary>
        public virtual IServerAzureADAdministratorsOperations ServerAzureADAdministrators { get; private set; }

        /// <summary>
        /// Initializes a new instance of the SqlManagementClient class.
        /// </summary>
        /// <param name='httpClient'>
        /// HttpClient to be used
        /// </param>
        /// <param name='disposeHttpClient'>
        /// True: will dispose the provided httpClient on calling SqlManagementClient.Dispose(). False: will not dispose provided httpClient</param>
        protected SqlManagementClient(HttpClient httpClient, bool disposeHttpClient) : base(httpClient, disposeHttpClient)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the SqlManagementClient class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected SqlManagementClient(params DelegatingHandler[] handlers) : base(handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the SqlManagementClient class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected SqlManagementClient(HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : base(rootHandler, handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the SqlManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        protected SqlManagementClient(System.Uri baseUri, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the SqlManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        protected SqlManagementClient(System.Uri baseUri, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the SqlManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public SqlManagementClient(ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the SqlManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='httpClient'>
        /// HttpClient to be used
        /// </param>
        /// <param name='disposeHttpClient'>
        /// True: will dispose the provided httpClient on calling SqlManagementClient.Dispose(). False: will not dispose provided httpClient</param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public SqlManagementClient(ServiceClientCredentials credentials, HttpClient httpClient, bool disposeHttpClient) : this(httpClient, disposeHttpClient)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the SqlManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public SqlManagementClient(ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the SqlManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public SqlManagementClient(System.Uri baseUri, ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            BaseUri = baseUri;
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the SqlManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public SqlManagementClient(System.Uri baseUri, ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            BaseUri = baseUri;
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// An optional partial-method to perform custom initialization.
        /// </summary>
        partial void CustomInitialize();
        /// <summary>
        /// Initializes client properties.
        /// </summary>
        private void Initialize()
        {
            RecoverableDatabases = new RecoverableDatabasesOperations(this);
            RestorableDroppedDatabases = new RestorableDroppedDatabasesOperations(this);
            ServerConnectionPolicies = new ServerConnectionPoliciesOperations(this);
            DatabaseThreatDetectionPolicies = new DatabaseThreatDetectionPoliciesOperations(this);
            DataMaskingPolicies = new DataMaskingPoliciesOperations(this);
            DataMaskingRules = new DataMaskingRulesOperations(this);
            FirewallRules = new FirewallRulesOperations(this);
            GeoBackupPolicies = new GeoBackupPoliciesOperations(this);
            Databases = new DatabasesOperations(this);
            ElasticPools = new ElasticPoolsOperations(this);
            RecommendedElasticPools = new RecommendedElasticPoolsOperations(this);
            ReplicationLinks = new ReplicationLinksOperations(this);
            ServerCommunicationLinks = new ServerCommunicationLinksOperations(this);
            ServiceObjectives = new ServiceObjectivesOperations(this);
            ElasticPoolActivities = new ElasticPoolActivitiesOperations(this);
            ElasticPoolDatabaseActivities = new ElasticPoolDatabaseActivitiesOperations(this);
            ServiceTierAdvisors = new ServiceTierAdvisorsOperations(this);
            TransparentDataEncryptions = new TransparentDataEncryptionsOperations(this);
            TransparentDataEncryptionActivities = new TransparentDataEncryptionActivitiesOperations(this);
            ServerUsages = new ServerUsagesOperations(this);
            DatabaseUsages = new DatabaseUsagesOperations(this);
            DatabaseAutomaticTuning = new DatabaseAutomaticTuningOperations(this);
            EncryptionProtectors = new EncryptionProtectorsOperations(this);
            FailoverGroups = new FailoverGroupsOperations(this);
            Operations = new Operations(this);
            ServerKeys = new ServerKeysOperations(this);
            SyncAgents = new SyncAgentsOperations(this);
            SyncGroups = new SyncGroupsOperations(this);
            SyncMembers = new SyncMembersOperations(this);
            SubscriptionUsages = new SubscriptionUsagesOperations(this);
            VirtualClusters = new VirtualClustersOperations(this);
            VirtualNetworkRules = new VirtualNetworkRulesOperations(this);
            ExtendedDatabaseBlobAuditingPolicies = new ExtendedDatabaseBlobAuditingPoliciesOperations(this);
            ExtendedServerBlobAuditingPolicies = new ExtendedServerBlobAuditingPoliciesOperations(this);
            ServerBlobAuditingPolicies = new ServerBlobAuditingPoliciesOperations(this);
            DatabaseBlobAuditingPolicies = new DatabaseBlobAuditingPoliciesOperations(this);
            DatabaseVulnerabilityAssessmentRuleBaselines = new DatabaseVulnerabilityAssessmentRuleBaselinesOperations(this);
            DatabaseVulnerabilityAssessments = new DatabaseVulnerabilityAssessmentsOperations(this);
            JobAgents = new JobAgentsOperations(this);
            JobCredentials = new JobCredentialsOperations(this);
            JobExecutions = new JobExecutionsOperations(this);
            Jobs = new JobsOperations(this);
            JobStepExecutions = new JobStepExecutionsOperations(this);
            JobSteps = new JobStepsOperations(this);
            JobTargetExecutions = new JobTargetExecutionsOperations(this);
            JobTargetGroups = new JobTargetGroupsOperations(this);
            JobVersions = new JobVersionsOperations(this);
            LongTermRetentionBackups = new LongTermRetentionBackupsOperations(this);
            BackupLongTermRetentionPolicies = new BackupLongTermRetentionPoliciesOperations(this);
            ManagedBackupShortTermRetentionPolicies = new ManagedBackupShortTermRetentionPoliciesOperations(this);
            ManagedRestorableDroppedDatabaseBackupShortTermRetentionPolicies = new ManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesOperations(this);
            ServerAutomaticTuning = new ServerAutomaticTuningOperations(this);
            ServerDnsAliases = new ServerDnsAliasesOperations(this);
            ServerSecurityAlertPolicies = new ServerSecurityAlertPoliciesOperations(this);
            RestorableDroppedManagedDatabases = new RestorableDroppedManagedDatabasesOperations(this);
            RestorePoints = new RestorePointsOperations(this);
            ManagedDatabaseSecurityAlertPolicies = new ManagedDatabaseSecurityAlertPoliciesOperations(this);
            ManagedServerSecurityAlertPolicies = new ManagedServerSecurityAlertPoliciesOperations(this);
            SensitivityLabels = new SensitivityLabelsOperations(this);
            ManagedInstanceAdministrators = new ManagedInstanceAdministratorsOperations(this);
            DatabaseOperations = new DatabaseOperations(this);
            ElasticPoolOperations = new ElasticPoolOperations(this);
            DatabaseVulnerabilityAssessmentScans = new DatabaseVulnerabilityAssessmentScansOperations(this);
            ManagedDatabaseVulnerabilityAssessmentRuleBaselines = new ManagedDatabaseVulnerabilityAssessmentRuleBaselinesOperations(this);
            ManagedDatabaseVulnerabilityAssessmentScans = new ManagedDatabaseVulnerabilityAssessmentScansOperations(this);
            ManagedDatabaseVulnerabilityAssessments = new ManagedDatabaseVulnerabilityAssessmentsOperations(this);
            InstanceFailoverGroups = new InstanceFailoverGroupsOperations(this);
            BackupShortTermRetentionPolicies = new BackupShortTermRetentionPoliciesOperations(this);
            TdeCertificates = new TdeCertificatesOperations(this);
            ManagedInstanceTdeCertificates = new ManagedInstanceTdeCertificatesOperations(this);
            ManagedInstanceKeys = new ManagedInstanceKeysOperations(this);
            ManagedInstanceEncryptionProtectors = new ManagedInstanceEncryptionProtectorsOperations(this);
            RecoverableManagedDatabases = new RecoverableManagedDatabasesOperations(this);
            ManagedInstanceVulnerabilityAssessments = new ManagedInstanceVulnerabilityAssessmentsOperations(this);
            ServerVulnerabilityAssessments = new ServerVulnerabilityAssessmentsOperations(this);
            ManagedDatabaseSensitivityLabels = new ManagedDatabaseSensitivityLabelsOperations(this);
            InstancePools = new InstancePoolsOperations(this);
            Usages = new UsagesOperations(this);
            ManagedInstances = new ManagedInstancesOperations(this);
            PrivateEndpointConnections = new PrivateEndpointConnectionsOperations(this);
            PrivateLinkResources = new PrivateLinkResourcesOperations(this);
            Servers = new ServersOperations(this);
            Capabilities = new CapabilitiesOperations(this);
            LongTermRetentionManagedInstanceBackups = new LongTermRetentionManagedInstanceBackupsOperations(this);
            ManagedInstanceLongTermRetentionPolicies = new ManagedInstanceLongTermRetentionPoliciesOperations(this);
            WorkloadGroups = new WorkloadGroupsOperations(this);
            WorkloadClassifiers = new WorkloadClassifiersOperations(this);
            ManagedDatabases = new ManagedDatabasesOperations(this);
            ServerAzureADAdministrators = new ServerAzureADAdministratorsOperations(this);
            BaseUri = new System.Uri("https://management.azure.com");
            AcceptLanguage = "en-US";
            LongRunningOperationRetryTimeout = 30;
            GenerateClientRequestId = true;
            SerializationSettings = new JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            SerializationSettings.Converters.Add(new TransformationJsonConverter());
            DeserializationSettings = new JsonSerializerSettings
            {
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            CustomInitialize();
            DeserializationSettings.Converters.Add(new TransformationJsonConverter());
            DeserializationSettings.Converters.Add(new CloudErrorJsonConverter());
        }
    }
}
