﻿using System;
using System.Threading.Tasks;
using Microsoft.Azure.Management.V2.Resource.Core.DAG;

namespace Microsoft.Azure.Management.V2.Resource.Core.ResourceActions
{
    public abstract class Creatable<IFluentResourceT, InnerResourceT, FluentResourceT> : 
        IndexableRefreshableWrapper<IFluentResourceT, InnerResourceT>,
        IResourceCreator
        where FluentResourceT : class
        where IFluentResourceT : IResource
    {
        protected Creatable(string name, InnerResourceT innerObject) : base(name, innerObject)
        {
            IResourceCreator creator =this as IResourceCreator;
            CreatorTaskGroup = new CreatorTaskGroup(name, creator);
        }

        protected void AddCreatableDependency(IResourceCreator creatableResource)
        {
            creatableResource.CreatorTaskGroup.Merge(CreatorTaskGroup);
        }

        protected async Task<FluentResourceT> CreateAsync()
        {
            if (!CreatorTaskGroup.IsPreparer)
            {
                throw new InvalidOperationException("Interal Error: Creatable::CreateAsync can be invoked only on preparer");
            }

            CreatorTaskGroup.Prepare();
            await CreatorTaskGroup.ExecuteAsync();
            FluentResourceT thisResource = this as FluentResourceT;
            if (thisResource == null)
            {
                throw new InvalidOperationException("Interal Error: Expected 'of type' '" + typeof(FluentResourceT) + "', but got '" + this.GetType().Namespace + "'");
            }
            return thisResource;
        }


        protected IResource CreatedResource(string key)
        {
            return CreatorTaskGroup.TaskResult(key);
        }

        #region Implementation of IResourceCreator

        public CreatorTaskGroup CreatorTaskGroup { get; private set; }

        public abstract Task<IResource> CreateResourceAsync();

        #endregion
    }

    public interface IResourceCreator
    {
        Task<IResource> CreateResourceAsync();
        CreatorTaskGroup CreatorTaskGroup { get; }
    }
}
