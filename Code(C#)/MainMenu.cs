using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {

    public int playerLives;
    private ScoreManager points;

    public string startLevel;
    public string levelSelect;
    public string course_2;
    public string course_3;
    public string mainMenu;
    public string help;
    public string leaderBoard;



    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            ScoreManager.score = 0;
            Application.LoadLevel(startLevel);
            PlayerPrefs.SetInt("CurrentPlayerLives", playerLives);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            PlayerPrefs.SetInt("CurrentPlayerLives", playerLives);
            Application.LoadLevel(course_2);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            PlayerPrefs.SetInt("CurrentPlayerLives", playerLives);
            Application.LoadLevel(levelSelect);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Application.Quit();
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            PlayerPrefs.SetInt("CurrentPlayerLives", playerLives);
            Application.LoadLevel(course_3);
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            Application.LoadLevel(help);
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            Application.LoadLevel(mainMenu);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            Application.LoadLevel(leaderBoard);
        }
    }















    //public void Help_Menu()
    //{
        //Application.LoadLevel(help);
    //}

    //public void Course_2()
    //{
        //PlayerPrefs.SetInt("CurrentPlayerLives", playerLives);
        //Application.LoadLevel(course_2);
    //}

    //public void TheMainMenu()
    //{
        //Application.LoadLevel(mainMenu);
    //}

    //public void Course_3()
    //{
        //PlayerPrefs.SetInt("CurrentPlayerLives", playerLives);
        //Application.LoadLevel(course_3);
    //}

    //public void NewGame()
    //{
        //ScoreManager.score = 0;
        //Application.LoadLevel(startLevel);
       //PlayerPrefs.SetInt("CurrentPlayerLives", playerLives);
    //}

    //public void LevelSelect()
    //{
        //PlayerPrefs.SetInt("CurrentPlayerLives", playerLives);
        //Application.LoadLevel(levelSelect);
    //}

    //public void QuiteGame()
    //{
        //Application.Quit();
    //}
}

