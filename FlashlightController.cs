using UnityEngine;
using UnityEngine.UI;

public class FlashlightController : MonoBehaviour
{
    private AndroidJavaObject androidContext;
    private AndroidJavaClass androidJavaClass;

    bool toggleBool = true;
    public Text text_btn;

    private void Start()
    {
        // Ottieni il contesto dell'applicazione Android
        using (var activityClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
        {
            androidContext = activityClass.GetStatic<AndroidJavaObject>("currentActivity");
        }

        // Assicurati che il nome del pacchetto sia corretto
        androidJavaClass = new AndroidJavaClass("com.stecavalli.mylibrary.FlashlightPlugin");
    }

    public void ToggleFlashlight()
    {
        // Chiama il metodo Java per accendere/spegnere la torcia
        androidJavaClass.CallStatic("toggleFlashlight", androidContext);
        toggleBool = !toggleBool;
        if (toggleBool)
        {
            text_btn.text = "turn on torch";
        }
        else
        {
            text_btn.text = "turn off torch";
        }
    }
}
