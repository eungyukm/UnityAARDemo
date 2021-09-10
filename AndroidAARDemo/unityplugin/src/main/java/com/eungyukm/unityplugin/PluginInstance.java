package com.eungyukm.unityplugin;

import android.app.Activity;
import android.widget.Toast;

public class PluginInstance {

    private  static Activity unityActivity;

    public static void receiveUnityActivity(Activity inputActivity)
    {
        unityActivity = inputActivity;
    }

    public void Toast(String msg)
    {
        Toast.makeText(unityActivity, msg, Toast.LENGTH_SHORT).show();
    }
}
