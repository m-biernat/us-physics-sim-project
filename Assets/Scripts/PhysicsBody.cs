using UnityEngine;

public class PhysicsBody : MonoBehaviour
{
    public float mass;
    public float radius;

    public float velocity;
    public Vector3 direction;

    public Vector3 force;
    public Vector3 momentum;

    [HideInInspector]
    public Vector3 lastPosition;

    void OnEnable()
    {
        float d = 2 * radius;
        transform.localScale = new Vector3(d, d, d);

        lastPosition = Vector3.zero;
    }

    public void CalculateMomentum()
    {
        Vector3 v = velocity * direction;
        momentum = v * mass;
    }

    public void CalculateVelocity(float dt)
    {
        velocity = (transform.position - lastPosition).magnitude / dt;
        lastPosition = transform.position;
    }
}
