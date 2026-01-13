#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.UI;
using FTOptix.HMIProject;
using FTOptix.NativeUI;
using FTOptix.Retentivity;
using FTOptix.CoreBase;
using FTOptix.Core;
using FTOptix.NetLogic;
using FTOptix.WebUI;
using FTOptix.CODESYS;
using FTOptix.CommunicationDriver;
using FTOptix.Alarm;
using FTOptix.Recipe;
using FTOptix.SQLiteStore;
using FTOptix.Store;
#endregion

public class CambiaColoreRect : BaseNetLogic
{
    private Rectangle mioRect;
    private IUAVariable indice;

    public override void Start()
    {
        // Insert code to be executed when the user-defined logic is started
        mioRect = (Rectangle)Owner;
        indice = mioRect.GetVariable("Indice");
        indice.VariableChange += Indice_VariableChange;
        ChangeColor(indice.Value);
    }

    private void Indice_VariableChange(object sender, VariableChangeEventArgs e)
    {
        ChangeColor(e.NewValue);
    }

    public override void Stop()
    {
        // Insert code to be executed when the user-defined logic is stopped
        indice.VariableChange -= Indice_VariableChange;
    }

    public void ChangeColor (int value)
    {
        switch (value)
        {
            case 0:
                mioRect.FillColor = Colors.Blue;
                break;
            case 1:
                mioRect.FillColor = Colors.Red;
                break;
            default:
                mioRect.FillColor = Colors.White;
                break;
        }
    }
}
