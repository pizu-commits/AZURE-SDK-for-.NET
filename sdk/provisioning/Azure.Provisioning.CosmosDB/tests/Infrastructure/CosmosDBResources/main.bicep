targetScope = 'resourceGroup'

@description('')
param keyVaultName string

@description('')
param location string = resourceGroup().location


resource keyVault_vxw9QYjTK 'Microsoft.KeyVault/vaults@2022-07-01' existing = {
  name: 'existingVault'
}

resource cosmosDBAccount_HhkYojGJw 'Microsoft.DocumentDB/databaseAccounts@2023-04-15' = {
  name: toLower(take('cosmosDB${uniqueString(resourceGroup().id)}', 24))
  location: location
  kind: 'GlobalDocumentDB'
  properties: {
    databaseAccountOfferType: 'Standard'
    consistencyPolicy: {
      defaultConsistencyLevel: 'Session'
    }
    locations: [
      {
        locationName: location
        failoverPriority: 0
      }
    ]
  }
}

resource cosmosDBSqlDatabase_My5sdwc1q 'Microsoft.DocumentDB/databaseAccounts/sqlDatabases@2023-04-15' = {
  parent: cosmosDBAccount_HhkYojGJw
  name: 'db'
  location: location
  properties: {
    resource: {
      id: 'db'
    }
  }
}

resource keyVaultSecret_5d7zLCL1i 'Microsoft.KeyVault/vaults/secrets@2022-07-01' = {
  parent: keyVault_vxw9QYjTK
  name: 'connectionString'
  location: location
  properties: {
    value: 'AccountEndpoint=${cosmosDBAccount_HhkYojGJw.properties.documentEndpoint};AccountKey=${cosmosDBAccount_HhkYojGJw.listkeys(cosmosDBAccount_HhkYojGJw.apiVersion).primaryMasterKey}'
  }
}
