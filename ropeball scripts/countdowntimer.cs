using System.Collections;

using UnityEngine;
using UnityEngine.UI;

public class countdowntimer : MonoBehaviour {

    private float timer = 0f;
    private Text timerSeconds;
    public GameObject retrymenuUI;
	// Use this for initialization
	void Start ()
    {
        timerSeconds = GetComponent<Text>();	
	}
	
	// Update is called once per frame
	void Update ()
    {
        timer = Time.deltaTime;
        timerSeconds.text = timer.ToString("f0");
        if (timer == 0)
        {
            retrymenuUI.SetActive(true);
                
        }
	}
}
