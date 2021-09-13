using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PluginInit : MonoBehaviour
{
    AndroidJavaClass unityClass;
    AndroidJavaObject unityActivity;
    AndroidJavaObject pluginInstance;

    void Start()
    {
        pluginInstance = new AndroidJavaObject("com.eungyukm.uactivity.PluginActivity");
    }

    private void InitializePlugin(string pluginName)
    {
        unityClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        unityActivity = unityClass.GetStatic<AndroidJavaObject>("currentActivity");
        pluginInstance = new AndroidJavaObject(pluginName);
        if(pluginName == null)
        {
            Debug.Log("Plugin Instance Error");
        }
        pluginInstance.CallStatic("receiveUnityActivity", unityActivity);
    }

    public void TostMessage()
    {
        if(pluginInstance != null)
        {
            pluginInstance.Call("Toast", "Hello from Unity");
        }
    }
}
