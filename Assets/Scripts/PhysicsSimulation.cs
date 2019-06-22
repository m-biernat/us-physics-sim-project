using UnityEngine;

public class PhysicsSimulation : MonoBehaviour
{
    private SimulationManager simulationManager;

    void Start ()
    {
        simulationManager = GetComponent<SimulationManager>();
	}
	
	void FixedUpdate ()
    {
        foreach (PhysicsBody body in simulationManager.bodies)
        {
            foreach (PhysicsBody attractingBody in simulationManager.bodies)
            {
                if (attractingBody != body)
                {
                    body.force = PhysicsForce.CalculateForce(body, attractingBody);
                    body.momentum = body.momentum + body.force * simulationManager.dt;

                    Vector3 newPosition = body.transform.position + 
                        body.momentum / body.mass * simulationManager.dt;
                    body.transform.position = newPosition;
                }
            }
        }

        simulationManager.t += simulationManager.dt;
        
        //Debug.Log(t);
    }
}
