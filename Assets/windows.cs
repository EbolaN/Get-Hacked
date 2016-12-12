using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class windows : MonoBehaviour {

    public static bool OpenWindow;


    bool twodigit = false;
    public int clockM;
    public int clockH;
    public float time = 0;

    public string clocktext;

    // Use this for initialization
    void Start () {
        clocktext = GameObject.Find("Clock").GetComponent<Text>().text;
    }
	
	// Update is called once per frame
	void Update () {

        clock();
	}
    #region Clock
    void clock()
    {
        
        
        time += 2*Time.deltaTime;
        if(time >= 30)
        {
            time = 0;
            clockM += 1;
            clocktext = "0" + clockH + ":0" + clockM;
        }
        if (clockM == 60)
        {
            clockM = 0;
            clockH = 1;
            clocktext = "0" + clockH + ":" + clockM;
        }
        if (clockH == 9 && !twodigit)
        {
            twodigit = true;
        }
        
        if(!twodigit)
        {
            clocktext = "0" + clockH + ":" + clockM;
        }

        clocktext = "0" + clockH + ":" + clockM;
        clocktext = GameObject.Find("Clock").GetComponent<Text>().text;

    }
    #endregion
}
