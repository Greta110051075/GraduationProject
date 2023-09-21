using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WayPointFollow : MonoBehaviour
{
    public UnityStandardAssets.Utility.WaypointCircuit circuit; //�w�q�@�ӷs���ܼƸ��|
    public int currentWP = 0; //��b�}�C���@�����Ъ��Ʀr�ܼ�

    public float speed = 1; 
    public float closePoint = 0.5f;
    public float rotSpeed;

    void Update()
    {
        if (circuit.Waypoints.Length == 0) return;

        Vector3 lookAtGoal = new Vector3(circuit.Waypoints[currentWP].transform.position.x, this.transform.position.y, circuit.Waypoints[currentWP].transform.position.z); 

        Vector3 direction = lookAtGoal - this.transform.position;
        Vector3 directVertical = lookAtGoal - circuit.Waypoints[currentWP].transform.position;

        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * rotSpeed);

        if (direction.magnitude < closePoint) //�C��Ĳ����I�A�ɯ�}�C�ܼƫ��дN�|�����U�@�X
        {
            currentWP++;
            if(currentWP >= circuit.Waypoints.Length)
            {
                currentWP = 0; //��Ĳ��Ҧ��ܼƫ�A���з|��_��0
            }
        }
        this.transform.Translate(0, 0, speed * Time.deltaTime);//����V�e���ʤ覡
    }
}
