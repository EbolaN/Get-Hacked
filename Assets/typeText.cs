using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class typeText : MonoBehaviour
{
    string myString = "Welcome to" + "\n" + "Get Hacked!";

    public AudioClip[] klick;

    public AudioSource ljud;

    // Use this for initialization
    void Start()
    {
        StartCoroutine("AutoType");
    }

    // Update is called once per frame
    IEnumerator AutoType()
    {
        foreach (char letter in myString.ToCharArray())
        {       
            GetComponent<GUIText>().text += letter;
            if (!Input.anyKey)
            {
                ljud.clip = klick[Random.Range(0, klick.Length)];
                ljud.Play();
                yield return new WaitForSeconds(0.1f);
                ljud.Stop();
            }
            
        } 
        
    }
}