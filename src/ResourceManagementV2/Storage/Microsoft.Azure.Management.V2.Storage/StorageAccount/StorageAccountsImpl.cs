﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure.Management.Storage;
using Microsoft.Azure.Management.Storage.Models;

namespace Microsoft.Azure.Management.V2.Storage
{
    internal class StorageAccountsImpl :
        IStorageAccounts
    {
        IStorageAccountsOperations innerCollection;
        StorageManager manager;

        internal StorageAccountsImpl(IStorageAccountsOperations innerCollection, StorageManager manager)
        {
            this.innerCollection = innerCollection;
            this.manager = manager;
        }

        public StorageAccount.Definition.IBlank Define(string name)
        {
            Management.Storage.Models.StorageAccount innerObject = new Management.Storage.Models.StorageAccount();
            StorageAccountImpl wrapped = new StorageAccountImpl(name, 
                innerObject, 
                innerCollection,
                this.manager
            );
            wrapped.WithSku(SkuName.StandardGRS)
                   .WithGeneralPurposeAccountKind();
            return wrapped;
        }
    }
}
