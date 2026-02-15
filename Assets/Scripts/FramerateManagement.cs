using UnityEngine;

public class FrameRateManager : MonoBehaviour
{
    void Awake()
    {
        if (Application.isMobilePlatform) // always stable 60 fps on mobile
        {
            QualitySettings.vSyncCount = 0; // disable VSync
            Application.targetFrameRate = 60; // lock to 60    
        }
        else
        {
            Application.targetFrameRate = -1; // uncapped
        }
        
    }
}