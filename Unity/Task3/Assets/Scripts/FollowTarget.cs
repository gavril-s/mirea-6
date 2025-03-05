using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    void Start() {}

    void Update()
    {
        transform.position = target.position + offset;
    }
}
