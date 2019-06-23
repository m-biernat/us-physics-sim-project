using UnityEngine;

public class CenterOfMass : MonoBehaviour
{
    public PhysicsBody body1, body2;

    public GameObject centerOfMass;

    private LineRenderer lineRenderer;

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    void LateUpdate()
    {
        lineRenderer.SetPosition(0, body1.transform.position);
        lineRenderer.SetPosition(1, body2.transform.position);

        centerOfMass.transform.position = CalculateCenterOfMass();
    }

    private Vector3 CalculateCenterOfMass()
    {
        Vector3 v1 = body1.mass * body1.transform.position;
        Vector3 v2 = body2.mass * body2.transform.position;

        return ((v1 + v2) / (body1.mass + body2.mass));
    }
}