using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WayPointFollow : MonoBehaviour
{
    public UnityStandardAssets.Utility.WaypointCircuit circuit; //定義一個新的變數路徑
    public int currentWP = 0; //放在陣列中作為指標的數字變數

    public float speed = 5; 
    public float closePoint = 0.5f;
    public float rotSpeed = 3;

    void Update()
    {
        if (circuit.Waypoints.Length == 0) return;

        Vector3 lookAtGoal = new Vector3(circuit.Waypoints[currentWP].transform.position.x, circuit.Waypoints[currentWP].transform.position.y, this.transform.position.z); 

        Vector3 direction = lookAtGoal - this.transform.position;
        Vector3 directVertical = lookAtGoal - circuit.Waypoints[currentWP].transform.position;

        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * rotSpeed);

        if (direction.magnitude < closePoint) //每當接觸到航點，導航陣列變數指標就會跳往下一碼
        {
            currentWP++;
            if(currentWP >= circuit.Waypoints.Length)
            {
                currentWP = 0; //接觸到所有變數後，指標會恢復為0
            }
        }
        this.transform.Translate(0, speed * Time.deltaTime, 0);//物件向前移動方式
    }
}
