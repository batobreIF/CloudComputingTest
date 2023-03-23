param location string = resourceGroup().location

resource storageaccount 'Microsoft.Storage/storageAccounts@2021-02-01' = {
  name: 'sasimplestorage6'
  location: location
  kind: 'StorageV2'
  sku: {
    name: 'Standard_LRS'
  }
}
