using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Difficulty_Change : MonoBehaviour
{

    //Not a very Object Oriented way of doing this, but its for a pong game
    public void ChangeDifficulty(){
        Game_Controller.diff = GameObject.Find("Difficulty Slider").GetComponent<Slider>().value;
    }

}
