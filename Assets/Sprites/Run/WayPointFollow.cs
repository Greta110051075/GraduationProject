using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityStandardAssets.Utility;


public class WayPointFollow : MonoBehaviour
{
    public UnityStandardAssets.Utility.WaypointCircuit circuit;
    public int currentWP = 0;

    public float speed = 5; //控制車速
    public float closePoint = 0.5f; //控制距離路徑點最近距離
    public float rotSpeed = 2; //控制旋轉速度

    private void Update()
    {
        if (circuit.Waypoints.Length == 0) return;

        Vector3 lookAtGoal
    }
}
