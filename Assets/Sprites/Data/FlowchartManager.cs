using UnityEngine;
using Fungus;

public class FlowchartManager : MonoBehaviour
{
    public static FlowchartManager instance;

    public Flowchart flowchart;

    public static FlowchartManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<FlowchartManager>();
                if (instance == null)
                {
                    GameObject gameObject = new GameObject("FlowchartManager");
                    instance = gameObject.AddComponent<FlowchartManager>();
                }
            }
            return instance;
        }
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
