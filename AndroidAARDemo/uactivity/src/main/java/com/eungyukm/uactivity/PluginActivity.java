package com.eungyukm.uactivity;

import android.os.Bundle;
import android.widget.Toast;
import com.unity3d.player.UnityPlayer;
import com.unity3d.player.UnityPlayerActivity;

public class PluginActivity extends UnityPlayerActivity {
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        Toast.makeText(UnityPlayer.currentActivity, "Called from PluginActivity.", Toast.LENGTH_SHORT).show();
    }

    public  void ShowToast(String msg) {
        Toast.makeText(UnityPlayer.currentActivity, msg, Toast.LENGTH_SHORT).show();
    }

    public  void ReceiveInput(String input) {
        if(input != null) {
            // s1 : UnityGameObject s2 호출할 메서드 이름
            UnityPlayer.UnitySendMessage("UnityActivity", "SetText", input);
        } else {
            Toast.makeText(UnityPlayer.currentActivity, "Input is incorrect", Toast.LENGTH_LONG).show();
        }
    }
}
