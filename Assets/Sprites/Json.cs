using UnityEngine;

public class City : MonoBehaviour
{
    public string cityName;
    public int districts;
    public float income;

    public string SaveToString()
    {
        return JsonUtility.ToJson(this);
    }

    // Given:
    // cityName = "Berlin"
    // districts = 12
    // income = 90000.87f
    // SaveToString returns:
    // {"cityName":"Berlin","districts":12,"income":90000.87}
}