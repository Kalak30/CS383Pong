using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainmenu_ButtonPress : MonoBehaviour
{
    public void PlayGamePress(){
        ButtonManager.PlayGamePress();
    }

    public void HelpMenuPress(){
        ButtonManager.HelpPressMM();
    }

    public void QuitPress(){
        ButtonManager.QuitPress();
    }
}
