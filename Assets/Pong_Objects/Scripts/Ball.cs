using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Ball : MonoBehaviour
{
    float speed;
    float radius;
    Vector2 direction;
    Game_Controller gc;
    // Start is called before the first frame update
    void Start()
    {
        gc = Game_Controller.Instance;
        Difficulty();
        transform.position = Vector2.zero;
        direction = Vector2.one.normalized;
        radius = transform.localScale.x / 2;
    }

    // Exponentialy make the game harder between easy, medium and hard difficulties
    // Possible ball speeds are: [5, 8, 13]
    void Difficulty(){
        speed = 4 + Mathf.Pow(Game_Controller.diff+2,2);
    }

    // Update is called once per frame
    void Update()
    {
       

        transform.Translate(direction * speed * Time.deltaTime);

        if(transform.position.y < Game_Controller.bottomLeft.y + radius && direction.y < 0){
            direction.y = -direction.y;
        }
        if(transform.position.y > Game_Controller.topRight.y - radius && direction.y > 0){
            direction.y = -direction.y;
        }

        checkGoal();
        
    }

    //Goal happens when a ball goes behind a paddle and is handled by the game controller
    void checkGoal(){
        if(transform.position.x < Game_Controller.bottomLeft.x + radius && direction.x < 0){
            gc.rightPoint();

        }
        if(transform.position.x > Game_Controller.topRight.x - radius && direction.x > 0){
            gc.leftPoint();
        }
    }

    //Ball needs to change direction when colliding with paddle
    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Paddle"){
            bool isRight = other.GetComponent<Paddle>().isRight;;
            direction.x = -direction.x;
        }
    }
}
