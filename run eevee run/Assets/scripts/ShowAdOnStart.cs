using UnityEngine;
using UnityEngine.Advertisements;

public class ShowAdOnStart : MonoBehaviour
{
    public void ShowAd() {
        if (Advertisement.IsReady()) {
            Advertisement.Show();
        }
    }

    void start() {
        ShowAd();
    }
}