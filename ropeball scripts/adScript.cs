﻿using GoogleMobileAds.Api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class adScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

        showBannerAd();

    }
    

    private void showBannerAd()
    {
        string adID = "ca-app-pub-4325721457220275/7521698385";

        //***For Testing in the Device***
       // AdRequest request = new AdRequest.Builder()
       //.AddTestDevice(AdRequest.TestDeviceSimulator)       // Simulator.
       //.AddTestDevice("3D0E903C2C2E98735BCCE6022614913B")  // My test device.
       //.Build();

        //***For Production When Submit App***
        AdRequest request = new AdRequest.Builder().Build();

        BannerView bannerAd = new BannerView(adID, AdSize.Leaderboard, AdPosition.BottomLeft);
        bannerAd.LoadAd(request);
    }

    // Update is called once per frame
    void Update()
    {

    }
}