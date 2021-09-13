using UnityEngine;
using UnityEngine.UI;

public class PluginActivity : MonoBehaviour
{
    AndroidJavaObject pluginActivity;
    [SerializeField] private Text text;

    void Start()
    {
        pluginActivity = new AndroidJavaObject("com.eungyukm.uactivity.PluginActivity");
    }

    public void TostMessage()
    {
        if (pluginActivity != null)
        {
            pluginActivity.Call("ShowToast", "Called from Unity");
        }
    }

    public void AndroidInputCall()
    {
        if (pluginActivity != null)
        {
            Debug.Log("AndroidInputCall!!");
            pluginActivity.Call("ReceiveInput", "Hello");
        }
    }

    public void SetText(string input)
    {
        text.text = input;
    }
}
