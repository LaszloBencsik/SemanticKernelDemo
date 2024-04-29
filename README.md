# Simple demo app for Azure Open AI services

| Demo created:  |    25/04/2024  
| ------------------ | ------------------
| Application type:  |  Windows Application (WinForm)    
| Target framework:  |  .NET 8.0  
| Source code:  |     C#  
| Environment:  |     Visual Studio or Visual Studio Code

This demo help you start developing your own copilot with [Sementic Kernel](https://learn.microsoft.com/en-us/semantic-kernel/overview/)
using Azure Open AI services.
C# class LightPlugin is a very simple [plugin](https://learn.microsoft.com/en-us/semantic-kernel/agents/plugins/?tabs=Csharp) 
interoperates with [Large Langueges models](https://learn.microsoft.com/en-us/training/modules/introduction-large-language-models/)
and chnages the color of a panel control left side on the demo window.
You can write commands or questions in natural language in the textbox at the bottom.
There is a text log area at the right side showing called plugin functions while kernel orchestrates your ask.
![ScreenShot](/Screenshot1.png)

## Step by step guide to prepare your demo environment:

### 1. Select or activate azure subscription
    
Option #A: activate azure credit from visual studio subscription:  
(https://learn.microsoft.com/en-us/azure/devtest/offer/quickstart-individual-credit)

Option #B: create free Azure subscrition: (https://azure.microsoft.com/en-us/free/)

### 2. Create Azure Open AI services

Direct link to create: (https://portal.azure.com/#create/Microsoft.CognitiveServicesOpenAI)  
Guide: (https://learn.microsoft.com/en-us/azure/ai-services/openai/how-to/create-resource)  

You may need to [apply](https://aka.ms/oai/access) for access to Azure OpenAI.

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
 
### 6. Review Kernel Functions in LightPlugin.cs

``` csharp
    [Description("Gets the state of the light.")]
    public string GetState()

    [Description("Changes the state of the light.'")]
    public string ChangeState(bool newState)

    [Description("Gets the color of the light.")]
    public string GetColor()

    [Description("Changes the color of the light.'")]
    public string ChangeColor(string newColor)

    [Description("Gets the supported colors of the lamp.'")]
    public string GetColorList()
```

### 7. Build and run your application

write instructions into the TextBox "prompt:"  
> "turn on the light"  
> "is the light on?"  
> "toggle the lamp"  
> "change to color of the lamp to Red"
> "change to color of the lamp to xxxx"
> "what colors are supported by the lamp?"
