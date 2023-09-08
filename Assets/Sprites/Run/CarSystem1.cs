using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSystem1 : MonoBehaviour
{
    [SerializeField, Header("車")]
    public GameObject[] carPrefab;

    [SerializeField, Header("生成點")]
    public Transform[] Points;

    [SerializeField, Header("生成時間間格")]
    public float Ins_Time = 3;

    private void Awake()
    {
        InvokeRepeating("CarRandom", Ins_Time, Ins_Time);        
    }
   


    void CarRandom()
    {
        int a_Index = Random.Range(0, 3);
        int b_Index = Random.Range(0, Points.Length);

        Instantiate(carPrefab[a_Index], Points[b_Index].transform.position, carPrefab[a_Index].transform.rotation);
    }
}
