using UnityEngine;

public class DestroyOnCollide : MonoBehaviour
{
    public string destroyOnCollideTag;
    void OnCollisionEnter(Collision collision) 
    {
        if (collision.collider.tag == destroyOnCollideTag) 
        {
            Destroy(gameObject);
        }
    }
}
