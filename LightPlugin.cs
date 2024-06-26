﻿using DesignCopilotDemo;
using Microsoft.SemanticKernel;
using System.ComponentModel;

public class LightPlugin
{
    public bool IsOn { get; set; } = false;
    public string ColorName { get; set; } = "white";

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
        gui.addLog($"GetState() returns: {getStateString(IsOn)}");
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
            gui.addLog($"ChangeState({newState} - Light is turning from {getStateString(IsOn)} to {getStateString(newState)}");
        }
        else
        {
            gui.addLog($"ChangeState({newState} - [Light is already {getStateString(IsOn)}");
        }
        gui.setTheLight(IsOn = newState);
        return getStateString(IsOn);
    }
    // ------------------------------------------------------------------------
    [KernelFunction]
    [Description("Gets the color of the light.")]
    public string GetColor()
    {
        gui.addLog($"GetColor() returns: {ColorName}");
        return ColorName;
    }
    // ------------------------------------------------------------------------
    [KernelFunction]
    [Description("Changes the color of the light.'")]
    public string ChangeColor(string newColor)
    {
        newColor = newColor.ToLower();
        if (newColor != ColorName)
        {
            switch (newColor)
            {
                case "white": gui.setTheColor(Color.White); break;
                case "red": gui.setTheColor(Color.Red); break;
                case "green": gui.setTheColor(Color.Green); break;
                case "blue": gui.setTheColor(Color.Blue); break;
                default:
                    gui.addLog($"ChangeColor({newColor}) - {newColor} is not supprted");
                    return ColorName;
            }
            ColorName = newColor;
            gui.addLog($"ChangeColor({newColor}) - Color is turning from {ColorName} to {newColor}");
        }
        else
        {
            gui.addLog($"ChangeColor({newColor}) - Color is already {ColorName}");
        }
        ChangeState(true);
        
        return newColor;
    }
    // ------------------------------------------------------------------------
    [KernelFunction]
    [Description("Gets the supported colors of the lamp.'")]
    public string GetColorList()
    {
        string colorList = "white, red, green, blue";
        gui.addLog($"GetColorList() - returns: {colorList}");
        return colorList;
    }
    // ------------------------------------------------------------------------
    #endregion
}
