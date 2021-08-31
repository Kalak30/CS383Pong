using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{

    public static void ResumePress(){
        Time.timeScale = 1;
        Game_Controller.reappear();
        SceneManager.UnloadSceneAsync("Help_Screen");
    }

    public static void MainMenuPress(){
        Time.timeScale = 1;
        SceneManager.LoadSceneAsync(0, LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync(2);
        SceneManager.UnloadSceneAsync(1);
    }

    public static void PlayGamePress(){
        
        SceneManager.UnloadSceneAsync(0);
        SceneManager.LoadSceneAsync(1, LoadSceneMode.Additive);
    }

    //If help screen is opened from game
    public static void HelpPressGame(){
        Time.timeScale = 0;
        Game_Controller.disappear();
        SceneManager.LoadSceneAsync("Help_Screen", LoadSceneMode.Additive);
    }

    //If help screen is opened from main menu
    public static void HelpPressMM(){
        SceneManager.UnloadSceneAsync(0);
        SceneManager.LoadSceneAsync(2, LoadSceneMode.Additive);
    }

    public static void QuitPress(){
        Application.Quit();
    }
}
