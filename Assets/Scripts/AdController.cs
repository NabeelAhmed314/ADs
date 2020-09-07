using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.Monetization;

public class AdController : MonoBehaviour
{

    public string store_id ="3304954";
    public bool testMode = true;

    public string inGameBanner_id = "InGameBanner";


    void Start()
    {
        Advertisement.Initialize(store_id, testMode);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
