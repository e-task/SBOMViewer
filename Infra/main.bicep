param location string = 'EastUS2'
param appName string = 'app-SBOMViewer'
param repositoryUrl string = 'https://github.com/NavneetHegde/SBOMViewer'
param branch string = 'main'
param skuTier string = 'Free'
param skuSize string = 'Free'

resource staticWebApp 'Microsoft.Web/staticSites@2024-04-01' = {
  name: appName
  location: location
  sku: {
    name: skuTier
    tier: skuSize
  }
  properties: {
    repositoryUrl: repositoryUrl
    branch: branch
    buildProperties: {
      apiLocation: null 
      appLocation: 'wwwroot'  // Blazor WASM output
      outputLocation: ''
    }
  }
}

// Initial Steps

//**  Create Resource **//
// PS /home/navneet> az  group create --name rg-sbomviewer-eastus2-001 --location EASTUS2                                                                                                      

//**  Create Static Web App **//
// PS /home/navneet> az deployment group create --resource-group rg-sbomviewer-eastus2-001 --template-file main.bicep --parameters appName=app-sbomviewer-eastus-001 repositoryUrl=https://github.com/NavneetHegde/SBOMViewer
