using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Mail : MonoBehaviour {


    #region TODO



    //Gammla mail är kvar
    //Radera mail
    //SKICKA INTE MAIL SOM REDAN HAR FÅTTS!!! checkifsamemail() { if(mail == sentMail.count) { Cyka skicka inte mail }}




    #endregion

    public Text textMail;
    string mailtext;

    public Canvas emailWindow;
    public Button icon;

    ArrayList Emails = new ArrayList();

    System.Random rnd = new System.Random();

    string mail;
    int r;

    bool timeForMail;
    bool hasMail;
    bool Read;

    bool windowIsOpen;

    public Image notification;
    public AudioSource sound;

    public static int level = 0;

    //Random r = new Random();


    // Use this for initialization

    void Start () {
        
        emailWindow.enabled = false;
        notification.enabled = false;
        #region mails
        if (level == 0)
        {
            Emails.Add("Hello!\nI want you to hack my moms computer!\nI want you to change her password to \"123\"\n- Pelle\n\nReward: 10$\n\nDifficulty: "+level.ToString());
        }
        if (level == 1)
        {
            Emails.Add("Hello!\nI want you to hack the us cyber security headquarters \n- Hao");
            Emails.Add("I want you to hack Donald Trump!\nI want you to get access to his twitter and tweet out \"I am a big fat orange\"\n- DonaldTrumpHator205\nReward: 100$");
            Emails.Add("Hello!\nBla bla bla I like you to hack this cod noob thx\n- Bosse");
        }
        if(level == 100)
        {
            Emails.Add("Hi and congratulations!");
        }
        #endregion
        r = rnd.Next(Emails.Count);

        //Debug.Log(Emails[r]);
    }
	
	// Update is called once per frame
	void Update () {
        checkIfMail();
        mailHandler();
    }

    public void mailWindowOpen()
    {
        windows.OpenWindow = true;
        Debug.Log("Open Mail");
        emailWindow.enabled = true;
        windowIsOpen = true;
        notification.enabled = false;

        //if(hasMail)
        //{
        //    AcceptButton.enabled = true;
        //    DeclainButton.enabled = true;
        //} else
        //{
        //    AcceptButton.enabled = false;
        //    DeclainButton.enabled = false;
        //}

    }
    public void mailWindowClose()
    {
        if(windowIsOpen)
        {
            windowIsOpen = false;
            windows.OpenWindow = false;
            Debug.Log("Close Mail");
            emailWindow.enabled = false;
        }
    }
    void mailHandler()
    {
        if(hasMail)
        {
            textMail.fontSize = 24;
            textMail.text = Emails[r].ToString();
        }
        else
        {
            textMail.fontSize = 145;
            textMail.text = "No new mails!";
        }

    }


    void checkIfMail()
    {
        //if(!hasMail && Random.Range(1, Random.Range(150, Random.Range(700, 1000))) == 1)
        if (!hasMail && Random.Range(1, 300) == 1)
        {
            Debug.Log("Mail!");
            Read = false;
            hasMail = true;
            notification.enabled = true;
            sound.Play();
            
        }

    }
}
