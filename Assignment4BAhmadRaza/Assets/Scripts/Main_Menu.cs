using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{
    public GameObject panelmainmenu;
    public GameObject panelhummingbirds;
    // Start is called before the first frame update
    void Start()
    {
        panelmainmenu.SetActive(true);
    }
    public void loadPenguingame()
    {
        SceneManager.LoadScene("Penguin_Train");
    }
    public void loadHummingbirdmenu()
    {
        panelhummingbirds.SetActive(true);
        panelmainmenu.SetActive(false);
    }
    public void loadMlAgent()
    {
        SceneManager.LoadScene("Training");
    }
    public void loadBattlewithmlagent()
    {
        SceneManager.LoadScene("FlowerIsland");
    }
    public void back()
    {
        panelmainmenu.SetActive(true);
        panelhummingbirds.SetActive(false);
    }
}