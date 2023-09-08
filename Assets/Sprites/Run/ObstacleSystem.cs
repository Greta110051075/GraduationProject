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
    public GameObject[] Obstacle;

    [SerializeField, Header("障礙物數量")]
    public int a, b;

    public Transform Maker;

    private int j;
    private int AmountObstacle;
    private List<Vector2> obstaclePositions;


    void Start()
    {
        ObstacleRandom();
        obstaclePositions = new List<Vector2>();
    }

    private void ObstacleRandom()
    {
        AmountObstacle = Random.Range(a, b);

        for (int i = AmountObstacle; i >= 0; i--)

            Instantiate(Obstacle[j], new Vector2(Random.Range(right, left), Random.Range(up, down)), Quaternion.Euler(0, 0, 90), Maker);


        for (int i = AmountObstacle; i >= 0; i--)

            Instantiate(Obstacle[j + 1], new Vector2(Random.Range(right, left), Random.Range(up, down)), Quaternion.identity, Maker);
    }

    bool IsOverlapping(Vector2 position)
    {
        for (int i = 0; i < obstaclePositions.Count; i++)
        {
            if (Vector2.Distance(position, obstaclePositions[i]) < 1.0f)
            {
                return true;
            }

        }
        return false;

    }
}
