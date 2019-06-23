using UnityEngine;
using System.Collections.Generic;

public class SimulationSetup : MonoBehaviour
{
    public List<SetupElement> setupElements;

    public GameObject simulationManager;

    public GameObject buttomPanel;
    public GameObject previewPanel;

    void Start()
    {
        foreach(SetupElement element in setupElements)
        {
            element.gameObject.SetActive(true);
        }
    }

    public void RunSimulation()
    {
        foreach (SetupElement element in setupElements)
        {
            element.Apply();
        }

        simulationManager.GetComponent<PhysicsSimulation>().enabled = true;
        simulationManager.GetComponent<SimulationController>().enabled = true;

        previewPanel.SetActive(true);
        buttomPanel.SetActive(true);
        
        gameObject.SetActive(false);
    }
}
