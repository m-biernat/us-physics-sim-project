using UnityEngine;
using System.Collections.Generic;

public class PhysicsSimulation : MonoBehaviour
{
    public List<PhysicsBody> bodies;

    float t, dt;

	void Start ()
    {
        t = 0;
        dt = 0.01f;
	}
	
	void FixedUpdate ()
    {
        foreach (PhysicsBody body in bodies)
        {
            foreach (PhysicsBody attractingBody in bodies)
            {
                if (attractingBody != body)
                {
                    body.force = PhysicsForce.CalculateForce(body, attractingBody);
                    body.momentum = body.momentum + body.force * dt;

                    Vector3 newPosition = body.transform.position + body.momentum / body.mass * dt;
                    body.transform.position = newPosition;
                }
            }
        }

        t = t + dt;
        
        Debug.Log(t);
    }
}
