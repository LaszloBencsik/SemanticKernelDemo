using DesignCopilotDemo;
using Microsoft.SemanticKernel;
using System.ComponentModel;

public class LightPlugin
{
    public bool IsOn { get; set; } = false;

    #region Private methods and properties
    private static FormLightingDemo gui { get { return DesignCopilotDemo.FormLightingDemo.Instance; } }
    // ------------------------------------------------------------------------
    private static string getStateString(bool state)
    {
        return state ? "on" : "off";
    }
    #endregion

    #region Kernel functions
    // ------------------------------------------------------------------------
//#pragma warning disable CA1024 // Use properties where appropriate
    [KernelFunction]
    [Description("Gets the state of the light.")]
    public string GetState()
    {
        gui.addLog($"[Light query result: {getStateString(IsOn)}]");
        return getStateString(IsOn);
    }
//#pragma warning restore CA1024 // Use properties where appropriate
    // ------------------------------------------------------------------------
    [KernelFunction]
    [Description("Changes the state of the light.'")]
    public string ChangeState(bool newState)
    {
        if (newState != IsOn)
        {
            gui.addLog($"[Light is turning {getStateString(IsOn)} to {getStateString(newState)}]");
        }
        else
        {
            gui.addLog($"[Light is already {getStateString(IsOn)}]");
        }
        gui.setTheLight(IsOn = newState);
        return getStateString(IsOn);
    }
    // ------------------------------------------------------------------------
    #endregion
}
