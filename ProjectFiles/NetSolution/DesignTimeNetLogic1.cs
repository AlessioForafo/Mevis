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

public class DesignTimeNetLogic1 : BaseNetLogic
{
    [ExportMethod]
    public void CreaAllarmi()
    {
        // Insert code to be executed by the method
        for (int i = 0; i < 100; i++)
        {
            var mioAllarme = InformationModel.Make<DigitalAlarm>("Allarme_" + i);
            Project.Current.Get("Alarms").Add(mioAllarme);
        }
    }
}
