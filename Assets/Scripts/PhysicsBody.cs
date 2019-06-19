using UnityEngine;

public class PhysicsBody : MonoBehaviour
{
    public float mass;
    public float radius;

    public Vector3 force;
    public Vector3 momentum;

    void OnEnable()
    {
        float d = 2 * radius;
        transform.localScale = new Vector3(d, d, d);
    }
}
