using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField]
    float speed;
    float height;

    string input;
    public bool isRight;

    // Start is called before the first frame update
    void Start()
    {
        height = transform.localScale.y;
        speed = 10f;
    }

    // Update is called once per frame
    void Update()
    {

        //Using transform component rather than the rigidbody2D component for movement for simplicity
        float move = Input.GetAxis(input) * Time.deltaTime * speed;

        if(transform.position.y < Game_Controller.bottomLeft.y + height / 2 && move < 0){
            move = 0;
        }
        if(transform.position.y > Game_Controller.topRight.y - height / 2 && move > 0){
            move = 0;
        }

        transform.Translate(move * Vector2.up);
    }

    public void init(bool isRightPaddle){
        isRight = isRightPaddle;

        Vector2 pos = Vector2.zero;

        /* Each paddle needs to be in a different position and
            also need a different input
        */
        if(isRightPaddle){
            pos = new Vector2(Game_Controller.topRight.x,0);
            pos -= Vector2.right * transform.localScale.x;

            input = "PaddleRight";
        }
        else{
            pos = new Vector2(Game_Controller.bottomLeft.x, 0);
            pos += Vector2.right * transform.localScale.x;

            input = "PaddleLeft";
        }

        transform.position = pos;

        transform.name = input;
    }

}
