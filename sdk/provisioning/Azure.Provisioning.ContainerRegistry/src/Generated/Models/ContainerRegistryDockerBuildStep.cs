// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.ContainerRegistry;

/// <summary>
/// The Docker build step.
/// </summary>
public partial class ContainerRegistryDockerBuildStep : ContainerRegistryTaskStepProperties
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
    /// The Docker file path relative to the source context.
    /// </summary>
    public BicepValue<string> DockerFilePath { get => _dockerFilePath; set => _dockerFilePath.Assign(value); }
    private readonly BicepValue<string> _dockerFilePath;

    /// <summary>
    /// The name of the target build stage for the docker build.
    /// </summary>
    public BicepValue<string> Target { get => _target; set => _target.Assign(value); }
    private readonly BicepValue<string> _target;

    /// <summary>
    /// The collection of override arguments to be used when executing this
    /// build step.
    /// </summary>
    public BicepList<ContainerRegistryRunArgument> Arguments { get => _arguments; set => _arguments.Assign(value); }
    private readonly BicepList<ContainerRegistryRunArgument> _arguments;

    /// <summary>
    /// Creates a new ContainerRegistryDockerBuildStep.
    /// </summary>
    public ContainerRegistryDockerBuildStep() : base()
    {
        BicepValue<string>.DefineProperty(this, "type", ["type"], defaultValue: "Docker");
        _imageNames = BicepList<string>.DefineProperty(this, "ImageNames", ["imageNames"]);
        _isPushEnabled = BicepValue<bool>.DefineProperty(this, "IsPushEnabled", ["isPushEnabled"]);
        _noCache = BicepValue<bool>.DefineProperty(this, "NoCache", ["noCache"]);
        _dockerFilePath = BicepValue<string>.DefineProperty(this, "DockerFilePath", ["dockerFilePath"]);
        _target = BicepValue<string>.DefineProperty(this, "Target", ["target"]);
        _arguments = BicepList<ContainerRegistryRunArgument>.DefineProperty(this, "Arguments", ["arguments"]);
    }
}
