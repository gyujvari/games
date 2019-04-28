﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public int timeLeft = 5;
    public Text countdownText;
    public GameObject failmenuUI;
    public GameObject rope1;
    public GameObject rope2;
    public Rigidbody2D rb;
    public Rigidbody2D rb1;

    // Use this for initialization
    void Start()
    {
        StartCoroutine("LoseTime");
    }

    // Update is called once per frame
    void Update()
        
    {
        rb = GetComponent<Rigidbody2D>();
        rb1 = GetComponent<Rigidbody2D>();
        countdownText.text = ("Time Left : " + timeLeft);

        if (timeLeft <= 0)
        {
            StopCoroutine("LoseTime");
            countdownText.text = "Times Up!";
            failmenuUI.SetActive(true);
            //rope1.SetActive(false);
            //rope2.SetActive(false);
            //Time.timeScale = 1f;
        }
    }

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
        }
    }
}
