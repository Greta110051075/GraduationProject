using Fungus;
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
    public float closePoint = 0f; //控制距離路徑點最近距離
    public float rotSpeed = 2; //控制旋轉速度

 
    
    private void Update()
    {


        //如果場景沒有任何 waypoint 則回傳 0 (不動作)
        if (circuit.Waypoints.Length == 0) return;

        //面像與目標的相關設定
        Vector3 lookAtGoal = new Vector3(circuit.Waypoints[currentWP].transform.position.x, this.transform.position.y,circuit.Waypoints[currentWP].transform.position.z);

        Vector3 direction = lookAtGoal - this.transform.position;
        Vector3 directionVertical = lookAtGoal - circuit.Waypoints[currentWP].transform.position;
        Debug.DrawRay(this.transform.position, direction, Color.green);
        Debug.DrawRay(circuit.Waypoints[currentWP].transform.position, directionVertical, Color.yellow);

        //使用 Slerp 方法，使移動物件，旋轉朝向目標物
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation,
                                                    Quaternion.LookRotation(direction),
                                                    Time.deltaTime * rotSpeed);

        // 追擊目標時的 waypoint 陣列索引號變更&歸零(重複)
        if (direction.magnitude < closePoint)
        {
            currentWP++;
            if (currentWP >= circuit.Waypoints.Length)
            {
                gameObject.SetActive(false);

            }
        }

        this.transform.Translate(0, 0, speed * Time.deltaTime); //物件向前移動方式

    }
}
