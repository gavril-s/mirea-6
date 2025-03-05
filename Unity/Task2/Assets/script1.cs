using UnityEngine;

public class script1 : MonoBehaviour
{
    public float number;
    public GameObject obj;
    private Vector3[] points = {new Vector3(1, 2, 0), new Vector3(2, 1, 0), new Vector3(0, 0, 0)};

    void Start(){}

    void Update()
    {
        Randomizer();
    }

    void Randomizer() 
    {
        number = Random.Range(1, 10);
        Debug.Log(number); 

        if (number == 5) {
            int pointInd = Random.Range(0, 3);
            obj.transform.position = points[pointInd];
        }
    }
}
