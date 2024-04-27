using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Connectors.OpenAI;
using System.Collections.Concurrent;

namespace DesignCopilotDemo
{
    public partial class FormLightingDemo : Form
    {
        // ------------------------------------------------------------------------
        private void addService(IKernelBuilder kernelBuilder)
        {
            kernelBuilder.Services.AddAzureOpenAIChatCompletion(
                "gpt-4",                              // model  "gpt-35-turbo" does not work properly
                "https://xxxxxxxx.openai.azure.com/", // service endpoint
                "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");  // service key
        }
        // ------------------------------------------------------------------------
        #region Interface for plugins
        // ------------------------------------------------------------------------
        public static FormLightingDemo? Instance { get; private set; }
        // ------------------------------------------------------------------------
        public void addLog(string text)
        {
            if (text is not null)
            {
                queue.Enqueue(text);
            }
        }
        // ------------------------------------------------------------------------
        public void setTheLight(bool lightState)
        {
            _lightState = lightState;
        }
        // ------------------------------------------------------------------------
        #endregion

        #region Form methors and event handlers
        // ------------------------------------------------------------------------
        public FormLightingDemo()
        {
            Instance = this;
            InitializeComponent();
            var builder = Kernel.CreateBuilder();
            addService(builder);
            kernel = builder.Build();
            kernel.ImportPluginFromType<LightPlugin>();
            chatCompletionService = kernel.GetRequiredService<IChatCompletionService>();
        }
        // ------------------------------------------------------------------------
        private async void processQuestion(string question)
        {
            history.AddUserMessage(question);

            var result = await chatCompletionService.GetChatMessageContentAsync(
                history,
                executionSettings: openAIPromptExecutionSettings,
                kernel: kernel);

            textBoxHistory.Text += result + Environment.NewLine;
            textBoxInput.Enabled = true;
            textBoxInput.Focus();
            history.AddMessage(result.Role, result.Content ?? string.Empty);
        }
        // ------------------------------------------------------------------------
        private void textBoxInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                var userInput = textBoxInput.Text;
                textBoxInput.Text = "";
                textBoxInput.Enabled = false;
                textBoxHistory.Text += "> " + userInput + Environment.NewLine;
                processQuestion(userInput);
            }
        }
        // ------------------------------------------------------------------------
        private void timer1_Tick(object sender, EventArgs e)
        {
            string? text;
            while (!queue.IsEmpty && queue.TryDequeue(out text) && text is not null)
            {
                textBoxLog.Text += text + Environment.NewLine;
            }
            panelLight.Visible = _lightState;
        }
        // ------------------------------------------------------------------------
        #endregion

        #region Private properties
        ConcurrentQueue<string> queue = new ConcurrentQueue<string>();
        private bool _lightState = false;
        Kernel kernel;
        IChatCompletionService chatCompletionService;
        ChatHistory history = new ChatHistory();
        OpenAIPromptExecutionSettings openAIPromptExecutionSettings = new()
        {
            ToolCallBehavior = ToolCallBehavior.AutoInvokeKernelFunctions
        };
        #endregion
    }
}
