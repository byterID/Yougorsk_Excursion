using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour
{
    public GameObject buttonsMenu1;
    public GameObject buttonsMenu2;
    public GameObject buttonsExit;
    public GameObject buttonsLeave;



    public void ExitGame()
    {
        Application.Quit();
    }

    public void NewGameLoadScen1()
    {
        SceneManager.LoadScene("01");
    }

    public void NewGameLoadScen2()
    {
        SceneManager.LoadScene("02");
    }
    public void NewGameLoadScen3()
    {
        SceneManager.LoadScene("03");
    }


    public void LoadMain()
    {
        SceneManager.LoadScene("SampleScene");
    }
}