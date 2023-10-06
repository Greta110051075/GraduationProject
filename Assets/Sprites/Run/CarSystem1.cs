using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSystem1 : MonoBehaviour
{
    [SerializeField, Header("車")]
    public GameObject[] carPrefab;

    [SerializeField, Header("生成點")]
    public Transform points;

    [SerializeField, Header("生成時間間格")]
    public float Ins_Time = 3;

    private void Awake()
    {
        //Quaternion randomRotation = Quaternion.Euler(90, 0, 0);
        InvokeRepeating("CarRandom", Ins_Time, Ins_Time);        
    }
   


    void CarRandom()
    {
        int a_Index = Random.Range(0, 3);

        Instantiate(carPrefab[a_Index], points.transform.position, carPrefab[a_Index].transform.rotation);

        Quaternion randomRotation = Quaternion.Euler(90, 0, 0);
    }
}
