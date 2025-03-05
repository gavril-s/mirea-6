using UnityEngine;

public class RandomXPositionAtStart : MonoBehaviour
{
    public float min;
    public float max;    
    void Start()
    {
        Vector3 position = transform.position;
        position.x = Random.Range(min, max);
        transform.position = position;
    }
}
