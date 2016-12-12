using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 
public class meny : MonoBehaviour
{
    public Canvas optionMenu;
    public Button startText;
    public Button settingsText;
    public Button exitText;

    void Start()

    {
        optionMenu = optionMenu.GetComponent<Canvas>();
        startText = startText.GetComponent<Button>();
        settingsText = settingsText.GetComponent<Button>();
        exitText = exitText.GetComponent<Button>();
        optionMenu.enabled = false;

    }

    public void OptionPress()

    {
        optionMenu.enabled = true; 
        startText.enabled = false;
        settingsText.enabled = false;
        exitText.enabled = false;

    }

    public void NoPress() 

    {
        optionMenu.enabled = false; 
        startText.enabled = true;
        settingsText.enabled = true;
        exitText.enabled = true;

    }

    public void StartLevel()

    {
        Debug.Log("Start");
        SceneManager.LoadScene(1);

    }

    public void ExitGame()

    {
        Application.Quit(); 

    }

}