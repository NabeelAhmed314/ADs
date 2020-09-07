using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdManagement : MonoBehaviour
{
    public AdController adController;
    void Start()
    {
        Advertisement.Initialize(adController.store_id,adController.testMode);
        StartCoroutine(ShowBannerWhenReady());
    }

    IEnumerator ShowBannerWhenReady()
    {
        while (!Advertisement.IsReady(adController.inGameBanner_id))
        {
            yield return new WaitForSeconds(0.5f);
        }
        Advertisement.Banner.SetPosition(BannerPosition.TOP_CENTER);
        Advertisement.Banner.Show(adController.inGameBanner_id);
    }
}
