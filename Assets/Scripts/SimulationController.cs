using UnityEngine;

public class SimulationController : MonoBehaviour
{
    private SimulationManager simulationManager;
    private PhysicsSimulation physicsSimulation;

    public GameObject centerOfMass;

	void Start ()
    {
        simulationManager = GetComponent<SimulationManager>();
        physicsSimulation = GetComponent<PhysicsSimulation>();
	}
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.P))
        { TogglePause(); }

        if (Input.GetKeyDown(KeyCode.LeftBracket))
        { SetSpeed(false); }
        if (Input.GetKeyDown(KeyCode.RightBracket))
        { SetSpeed(true); }

        if (Input.GetKeyDown(KeyCode.C))
        { ToggleVisibility(); }
    }

    private void SetSpeed(bool forward)
    {
        if (!forward && simulationManager.dt >= 0.01f)
        { simulationManager.dt /= 10; }
        else if (forward && simulationManager.dt <= 0.01f)
        { simulationManager.dt *= 10; }
    }

    private void TogglePause()
    {
        physicsSimulation.enabled = !physicsSimulation.enabled;
    }

    private void ToggleVisibility()
    {
        centerOfMass.SetActive(!centerOfMass.activeSelf);
    }
}
