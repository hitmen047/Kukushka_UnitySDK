using KykyshkaSDK.Models;
using UnityEngine;

namespace KykyshkaSDK
{
    public class KykyshkaSample : MonoBehaviour
    {
        private Kykyshka _sdkInstance;

        private void Start()
        {
            _sdkInstance = new Kykyshka(new SDKOptions()
            {
                DebugMode = true,
                AppKey = "UnYBlR6tujyxGGpCO1aUTe7nWgmDqMQzRbAlCzsmaUeZOmidIrODLTFsyFanXW6F",
                UserID = "demouserid",
            });

            _sdkInstance.OnSurveyStart = () => Debug.Log("Started");
            _sdkInstance.OnSuccess = hq => Debug.Log("Success");
            _sdkInstance.OnFail = data => Debug.Log("Failed");
            _sdkInstance.OnLoadFail = () => Debug.Log("Load fail");

            _sdkInstance.OnSurveyAvailable = () => Debug.Log("Available");
            _sdkInstance.OnSurveyUnavailable = () => Debug.Log("Unavailable");

            _sdkInstance.OnError = message => Debug.Log($"Error: {message}");
            
            _sdkInstance.HasSurvey();
            _sdkInstance.ShowSurvey();
        }
    }
}