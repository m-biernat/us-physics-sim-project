using UnityEngine;

public class PhysicsBody : MonoBehaviour
{
    public float mass;
    public float radius;

    public float velocity;
    public Vector3 direction;

    public Vector3 force;
    public Vector3 momentum;

    void OnEnable()
    {
        float d = 2 * radius;
        transform.localScale = new Vector3(d, d, d);
    }

    public void CalculateMomentum()
    {
        Vector3 v = velocity * direction;
        momentum = v * mass;
    }
}
