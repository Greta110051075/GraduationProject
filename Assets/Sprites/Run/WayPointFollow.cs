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

    public float speed = 5; // 控制移动速度
    public float closePoint = 0.1f; // 控制与路径点的距离
    public float rotSpeed = 2f; // 控制绕Z轴的旋转速度

    private void Update()
    {
        // 如果场景没有任何 waypoint 则返回（不执行任何操作）
        if (circuit.Waypoints.Length == 0) return;

        // 获取目标点的XZ坐标，忽略Y轴
        Vector3 targetPosition = new Vector3(circuit.Waypoints[currentWP].transform.position.x, circuit.Waypoints[currentWP].transform.position.y, this.transform.position.z);

        // 计算物体朝向目标的方向
        Vector3 direction = targetPosition - this.transform.position;

        //this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * rotSpeed);
        this.transform.LookAt(targetPosition);
        Vector3 currentRotation = this.transform.localRotation.eulerAngles;
        currentRotation.x = 0;
        currentRotation.y = 0;
        this.transform.localRotation = Quaternion.Euler(currentRotation);

        // 当接近路径点时，切换到下一个路径点
        if (direction.magnitude < closePoint)
        {
            currentWP++;
            if (currentWP >= circuit.Waypoints.Length)
            {
                gameObject.SetActive(false);
            }
        }

        // 沿着当前方向移动物体
        this.transform.Translate(0, 0, speed * Time.deltaTime);

    }

}

