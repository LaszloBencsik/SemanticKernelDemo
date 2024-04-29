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
                logQueue.Enqueue(_promptCount.ToString() + "> " + DateTime.Now.ToString("HH:mm:ss.fff") + " " + text);
            }
        }
        // ------------------------------------------------------------------------
        public void setTheLight(bool lightState)
        {
            _lightState = lightState;
        }
        // ------------------------------------------------------------------------
        public void setTheColor(Color? color)
        {
            _color = color;
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
            addLog("User prompted: " + question);
            textBoxHistory.Text += _promptCount.ToString() + "> " + question + Environment.NewLine;
            history.AddUserMessage(question);

            var result = await chatCompletionService.GetChatMessageContentAsync(
                history,
                executionSettings: openAIPromptExecutionSettings,
                kernel: kernel);

            textBoxHistory.Text += result + Environment.NewLine;
            history.AddMessage(result.Role, result.Content ?? string.Empty);
            addLog("Assistant finished");
            _promptCount++;
            textBoxInput.Enabled = true;
            textBoxInput.Focus();
        }
        // ------------------------------------------------------------------------
        private void textBoxInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                var userInput = textBoxInput.Text;
                textBoxInput.Text = null;
                textBoxInput.Enabled = false;
                processQuestion(userInput);
            }
        }
        // ------------------------------------------------------------------------
        private void timer1_Tick(object sender, EventArgs e)
        {
            string? text;
            while (!logQueue.IsEmpty && logQueue.TryDequeue(out text) && text is not null)
            {
                textBoxLog.Text += text + Environment.NewLine;
            }
            if (_lightState)
            {
                if (_color is not null)
                {
                    pictureBoxLamp.BackColor = _color.Value;
                    _color = null;
                }
                else
                {
                    if (pictureBoxLamp.BackColor == Color.Black)
                    {
                        pictureBoxLamp.BackColor = Color.White;
                    }
                }
            }
            else
            {
               pictureBoxLamp.BackColor = Color.Black;
            }
        }
        // ------------------------------------------------------------------------
        private void FormLightingDemo_Load(object sender, EventArgs e)
        {
            //textBoxInput.Focus();
        }
        // ------------------------------------------------------------------------
        #endregion

        #region Private properties
        ConcurrentQueue<string> logQueue = new ConcurrentQueue<string>();
        int _promptCount = 1;
        bool _lightState = false;
        Color? _color = null;
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
