using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSystem : MonoBehaviour
{
    public  Transform movePoint;

    [Header("左右速度")]
    private  float speedHoruzontal =10f;

    [Header("速度")]
    [SerializeField, Range(10, 0)]
    private  float speedVertical = 10f;

    private void Update()
    {
        float h = Input.GetAxis("Horizontal");

        transform.Translate(speedHoruzontal * Time.deltaTime * h, speedVertical*Time.deltaTime, 0);

        if (transform.position.x >= 13)
        {
            transform.position = new Vector3(speedHoruzontal * Time.deltaTime* 13, speedVertical * Time.deltaTime, 0);
        }
        if (transform.position.x <= -13)
        {
            transform.position = new Vector3(speedHoruzontal * Time.deltaTime * -13, speedVertical * Time.deltaTime, 0);
        }


    }
}

