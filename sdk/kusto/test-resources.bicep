param id string
param app_id string
param location string = resourceGroup().location

output ID string = id

module cluster './data/cluster.bicep' = {
    name: 'cluster'
    params: {
        id: id
        app_id: app_id
        location: location
    }
    scope: resourceGroup()
}

output CLUSTER_NAME string = cluster.outputs.CLUSTER_NAME
output DATABASE_NAME string = cluster.outputs.DATABASE_NAME
output SCRIPT_CONTENT_TABLE_NAME string = cluster.outputs.TABLE_NAME
output FOLLOWING_CLUSTER_NAME string = cluster.outputs.FOLLOWING_CLUSTER_NAME

module managedIdentity './data/managedIdentity.bicep' = {
    name: 'managedIdentity'
    params: {
        id: id
        location: location
    }
    scope: resourceGroup()
}

output USER_ASSIGNED_IDENTITY_ID string = managedIdentity.outputs.USER_ASSIGNED_IDENTITY_ID
output USER_ASSIGNED_IDENTITY_PRINCIPAL_ID string = managedIdentity.outputs.USER_ASSIGNED_IDENTITY_PRINCIPAL_ID

module storage './data/storage.bicep' = {
    name: 'storage'
    params: {
        id: id
        location: location
    }
    scope: resourceGroup()
}

output STORAGE_ACCOUNT_SAS_TOKEN string = storage.outputs.STORAGE_ACCOUNT_SAS_TOKEN
output STORAGE_ACCOUNT_ID string = storage.outputs.STORAGE_ACCOUNT_ID
output SCRIPT_URI string = storage.outputs.SCRIPT_URI

module dataConnection './data/dataConnection.bicep' = {
    name: 'dataConnection'
    params: {
        id: id
        location: location
    }
    scope: resourceGroup()
}

output EVENT_HUB_ID string = dataConnection.outputs.EVENT_HUB_ID
output IOT_HUB_ID string = dataConnection.outputs.IOT_HUB_ID