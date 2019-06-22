using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class SimulationManager : MonoBehaviour
{
    public float t = 0, dt = 0.01f;

    public List<PhysicsBody> bodies;

    public int activeSceneIndex = 0;

    public void ReturnToMenu()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }

    public void ResetSimulation()
    {
        SceneManager.LoadScene(activeSceneIndex, LoadSceneMode.Single);
    }

    public void CloseApplication()
    {
        Application.Quit();
    }
}
