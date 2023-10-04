using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSystem : MonoBehaviour
{
    [SerializeField, Header("障礙物範圍")]
    public int up;
    public int down;
    public int left;
    public int right;

    [SerializeField, Header("障礙物")]
    public GameObject[] ObstaclePrefabs;

    [SerializeField, Header("障礙物數量範圍")]
    public int minObstacles;
    public int maxObstacles;

    [SerializeField, Header("Y軸選轉角度")]
    public int r;

    public Transform Maker;

    void Start()
    {
        GenerateObstacles();
    }

    private void GenerateObstacles()
    {
        int obstacleCount = Random.Range(minObstacles, maxObstacles + 1);

        for (int i = 0; i < obstacleCount; i++)
        {
            int randomObstacleIndex = Random.Range(0, ObstaclePrefabs.Length);
            Vector3 randomPosition = new Vector3(Random.Range(left, right), 0, Random.Range(down, up)); // Y 座標設置為 0，確保生成在 XZ 平面上

            // 隨機指定 Y 軸旋轉角度
            Quaternion randomRotation = Quaternion.Euler(90, r, 0);

            GameObject newObstacle = Instantiate(ObstaclePrefabs[randomObstacleIndex], randomPosition, randomRotation);
            newObstacle.transform.SetParent(Maker);
        }
    }
}

