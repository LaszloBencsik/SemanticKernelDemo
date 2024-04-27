# Simple demo app for Azure Open AI services

| Demo created:  |    25/04/2024  
| ------------------ | ------------------
| Application type:  |  Windows Application (WinForm)    
| Target framework:  |  .NET 8.0  
| Source code:  |     C#  
| Environment:  |     Visual Studio or Visual Studio Code  

## Step by step guide to prepare your demo environment:

### 1. Select or activate azure subscription
    
Option #A: activate azure credit from visual studio subscription:  
(https://learn.microsoft.com/en-us/azure/devtest/offer/quickstart-individual-credit)

Option #B: create free Azure subscrition: (https://azure.microsoft.com/en-us/free/)

### 2. Create Azure Open AI services

Direct link to create: (https://portal.azure.com/#create/Microsoft.CognitiveServicesOpenAI)  
Guide: (https://learn.microsoft.com/en-us/azure/ai-services/openai/how-to/create-resource)  

### 3. Deploy Azure Open AI model

| Model name: |      "gpt-4"  
| ----------- | ------------
| Version: |         "0125-Preview"  
| Deployment type: | "Standard"  

Guide: (https://learn.microsoft.com/en-us/azure/ai-studio/how-to/deploy-models-openai)  

### 4. Configure your developer environment

Install NuGet Packages (you can try higher versions):
| NuGet | Version
| ----- | -------
| "Microsoft.Extensions.Configuration.Json" |  "8.0.0"  
| "Microsoft.SemanticKernel"                |  "1.9.0"  
| "Microsoft.SemanticKernel.Plugins.Core"   |  "1.9.0-alpha"  

Guides:  
    (https://www.nuget.org/packages/Microsoft.Extensions.Configuration.Json/)
    (https://www.nuget.org/packages/Microsoft.SemanticKernel/)
    (https://www.nuget.org/packages/Microsoft.SemanticKernel.Plugins.Core/)

### 5. Update Service Parameters

Open "FormLightingDemo.cs"
Update service enpoint and service key parameters from your azure portal:

``` csharp
    private void addService(IKernelBuilder kernelBuilder)
    {
        kernelBuilder.Services.AddAzureOpenAIChatCompletion(
            "gpt-4",                              // model  "gpt-35-turbo" does not work properly with this demo
            "https://xxxxxxxx.openai.azure.com/", // service endpoint
            "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");  // service key
    }
```

Do not publish your service key. Use secret solutions in your project, example Azure Key Vault.
    (https://learn.microsoft.com/en-us/azure/key-vault/general/basic-concepts)
 
### 6. Build and run your application

write instructions into the TextBox "prompt:"  
> "turn on the light"  
> "is the light on?"  
> "toggle the lamp"  

