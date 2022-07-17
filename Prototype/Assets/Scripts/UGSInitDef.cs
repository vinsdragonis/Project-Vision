using UnityEngine;
using Unity.Services.Core;
using Unity.Services.Analytics;
using System.Collections.Generic;

public class UGSInitDef: MonoBehaviour
{
    async void Start()
    {
        try
        {
            await UnityServices.InitializeAsync();
            List<string> consentIdentifiers = await AnalyticsService.Instance.CheckForRequiredConsents();
        }
        catch (ConsentCheckException e)
        {
          // Something went wrong when checking the GeoIP, check the e.Reason and handle appropriately.
        }
    }
}