using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToGoal : MonoBehaviour
{
    public Transform goal;
    public float speed;

    private void LateUpdate()
    {
        this.transform.LookAt(goal);
        this.transform.Translate(0, 0, speed * Time.deltaTime);
    }
}
