using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Close : MonoBehaviour
{
    void Update(){
        if(Input.GetKeyDown(KeyCode.Escape)){
            Application.Quit();
        }
    }
}
