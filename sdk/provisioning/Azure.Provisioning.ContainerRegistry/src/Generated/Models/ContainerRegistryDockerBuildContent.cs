// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.ContainerRegistry;

/// <summary>
/// The parameters for a docker quick build.
/// </summary>
public partial class ContainerRegistryDockerBuildContent : ContainerRegistryRunContent
{
    /// <summary>
    /// The fully qualified image names including the repository and tag.
    /// </summary>
    public BicepList<string> ImageNames { get => _imageNames; set => _imageNames.Assign(value); }
    private readonly BicepList<string> _imageNames;

    /// <summary>
    /// The value of this property indicates whether the image built should be
    /// pushed to the registry or not.
    /// </summary>
    public BicepValue<bool> IsPushEnabled { get => _isPushEnabled; set => _isPushEnabled.Assign(value); }
    private readonly BicepValue<bool> _isPushEnabled;

    /// <summary>
    /// The value of this property indicates whether the image cache is enabled
    /// or not.
    /// </summary>
    public BicepValue<bool> NoCache { get => _noCache; set => _noCache.Assign(value); }
    private readonly BicepValue<bool> _noCache;

    /// <summary>
    /// The Docker file path relative to the source location.
    /// </summary>
    public BicepValue<string> DockerFilePath { get => _dockerFilePath; set => _dockerFilePath.Assign(value); }
    private readonly BicepValue<string> _dockerFilePath;

    /// <summary>
    /// The name of the target build stage for the docker build.
    /// </summary>
    public BicepValue<string> Target { get => _target; set => _target.Assign(value); }
    private readonly BicepValue<string> _target;

    /// <summary>
    /// The collection of override arguments to be used when executing the run.
    /// </summary>
    public BicepList<ContainerRegistryRunArgument> Arguments { get => _arguments; set => _arguments.Assign(value); }
    private readonly BicepList<ContainerRegistryRunArgument> _arguments;

    /// <summary>
    /// Run timeout in seconds.
    /// </summary>
    public BicepValue<int> TimeoutInSeconds { get => _timeoutInSeconds; set => _timeoutInSeconds.Assign(value); }
    private readonly BicepValue<int> _timeoutInSeconds;

    /// <summary>
    /// The platform properties against which the run has to happen.
    /// </summary>
    public BicepValue<ContainerRegistryPlatformProperties> Platform { get => _platform; set => _platform.Assign(value); }
    private readonly BicepValue<ContainerRegistryPlatformProperties> _platform;

    /// <summary>
    /// The CPU configuration in terms of number of cores required for the run.
    /// </summary>
    public BicepValue<int> AgentCpu { get => _agentCpu; set => _agentCpu.Assign(value); }
    private readonly BicepValue<int> _agentCpu;

    /// <summary>
    /// The URL(absolute or relative) of the source context. It can be an URL
    /// to a tar or git repository.             If it is relative URL, the
    /// relative path should be obtained from calling listBuildSourceUploadUrl
    /// API.
    /// </summary>
    public BicepValue<string> SourceLocation { get => _sourceLocation; set => _sourceLocation.Assign(value); }
    private readonly BicepValue<string> _sourceLocation;

    /// <summary>
    /// The properties that describes a set of credentials that will be used
    /// when this run is invoked.
    /// </summary>
    public BicepValue<ContainerRegistryCredentials> Credentials { get => _credentials; set => _credentials.Assign(value); }
    private readonly BicepValue<ContainerRegistryCredentials> _credentials;

    /// <summary>
    /// Creates a new ContainerRegistryDockerBuildContent.
    /// </summary>
    public ContainerRegistryDockerBuildContent() : base()
    {
        BicepValue<string>.DefineProperty(this, "type", ["type"], defaultValue: "DockerBuildRequest");
        _imageNames = BicepList<string>.DefineProperty(this, "ImageNames", ["imageNames"]);
        _isPushEnabled = BicepValue<bool>.DefineProperty(this, "IsPushEnabled", ["isPushEnabled"]);
        _noCache = BicepValue<bool>.DefineProperty(this, "NoCache", ["noCache"]);
        _dockerFilePath = BicepValue<string>.DefineProperty(this, "DockerFilePath", ["dockerFilePath"]);
        _target = BicepValue<string>.DefineProperty(this, "Target", ["target"]);
        _arguments = BicepList<ContainerRegistryRunArgument>.DefineProperty(this, "Arguments", ["arguments"]);
        _timeoutInSeconds = BicepValue<int>.DefineProperty(this, "TimeoutInSeconds", ["timeout"]);
        _platform = BicepValue<ContainerRegistryPlatformProperties>.DefineProperty(this, "Platform", ["platform"]);
        _agentCpu = BicepValue<int>.DefineProperty(this, "AgentCpu", ["agentConfiguration", "cpu"]);
        _sourceLocation = BicepValue<string>.DefineProperty(this, "SourceLocation", ["sourceLocation"]);
        _credentials = BicepValue<ContainerRegistryCredentials>.DefineProperty(this, "Credentials", ["credentials"]);
    }
}
