# Simple demonstration application for Azure Open AI services

Application type: Windows Application (WinForm)
Target framework: .NET 8.0
Source code:      C#
Environment:      Visual Studio or Visual Studio Code
Demo created:     25/04/2024

Here is a step by step guide to prepare your demo environment:

# 1. Select or activate azure subscription
    
    Option #A: activate azure credit from visual studio subscription:  
                https://learn.microsoft.com/en-us/azure/devtest/offer/quickstart-individual-credit

    Option #B: create free Azure subscrition
                https://azure.microsoft.com/en-us/free/

# 2. Create Azure Open AI services

    Direct link
                https://portal.azure.com/#create/Microsoft.CognitiveServicesOpenAI
    Guide:
                https://learn.microsoft.com/en-us/azure/ai-services/openai/how-to/create-resource


# 3. Deploy Azure Open AI model

    Model name:      gpt-4
    Version:         0125-Preview
    Deployment type: Standard
    Guide:
                https://learn.microsoft.com/en-us/azure/ai-studio/how-to/deploy-models-openai

# 4. Configure your developer environment

    Install NuGet Packages (you can try higher versions):
        "Microsoft.Extensions.Configuration.Json"   Version="8.0.0"
        "Microsoft.SemanticKernel"                  Version="1.9.0"
        "Microsoft.SemanticKernel.Plugins.Core"     Version="1.9.0-alpha"

        Guides:
                https://www.nuget.org/packages/Microsoft.Extensions.Configuration.Json/
                https://www.nuget.org/packages/Microsoft.SemanticKernel/
                https://www.nuget.org/packages/Microsoft.SemanticKernel.Plugins.Core/

# 5. Update Service Parameters

    Open "FormLightingDemo.cs"
    Update service enpoint and service key parameters from your azure portal:

        private void addService(IKernelBuilder kernelBuilder)
        {
           kernelBuilder.Services.AddAzureOpenAIChatCompletion(
               "gpt-4",                              // model  "gpt-35-turbo" does not work properly
               "https://xxxxxxxx.openai.azure.com/", // service endpoint
               "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");  // service key
        }
    Do not publish your service key. Use secret solutions in your project, example Azure Key Vault.
            https://learn.microsoft.com/en-us/azure/key-vault/general/basic-concepts
 
# 6. Build and run your application

    write instructions into the "prompt:" TextBox like:
                "turn on the light"
                "is the light on?"
                "toggle the lamp"

