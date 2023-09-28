using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float PlayerSpeed;      //unity内でプレイヤースピードを変更
    public float RotationSpeed;

    public Animator PlayerAnimator;
    bool isRun;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
        var speed = Vector3.zero;       //座標x,y,z

        if (Input.GetKey(KeyCode.RightArrow))
        {
            speed.y = RotationSpeed;      //z軸
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            speed.y = -RotationSpeed;     //z軸
        }
        transform.eulerAngles += speed;
    }

    void Move()
    {/*if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 0, 0.1f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, 0, -0.1f);
        }*/

        var speed = Vector3.zero; //座標x,y,z

        isRun = false;

        if (Input.GetKey(KeyCode.W))
        {
            isRun = true;
            speed.z = PlayerSpeed;      //z軸
            // isRun = true;
        }
        if (Input.GetKey(KeyCode.S))
        {
            isRun = true;
            speed.z = -PlayerSpeed;     //z軸
            //isRun = true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            speed.x = PlayerSpeed;      //x軸
            isRun = true;
        }
        if (Input.GetKey(KeyCode.A))
        {
            speed.x = -PlayerSpeed;     //x軸
            isRun = true;
        }
        transform.Translate(speed);     //プレイヤーが向いている方向へ
        PlayerAnimator.SetBool("run", isRun);
    }

   /* void MoveSet()
    {
        speed.z = PlayerSpeed;
    }*/
}


