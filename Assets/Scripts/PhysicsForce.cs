using UnityEngine;

public class PhysicsForce : MonoBehaviour
{
    public const float G = 6.67f;

    public static Vector3 CalculateForce(PhysicsBody body, PhysicsBody attractingBody)
    {
        Vector3 direction = body.transform.position - attractingBody.transform.position;
        float distance = direction.magnitude;

        if (distance == 0f) return Vector3.zero;

        float forceMagnitude = G * (body.mass * attractingBody.mass) / Mathf.Pow(distance, 2);
        Vector3 force = -forceMagnitude * direction.normalized;

        return force;
    }
}
