using UnityEngine;
using UnityEngine.UI;

public class TimeStamp : MonoBehaviour
{
    public Text tText, dtText;

    public SimulationManager simulationManager;

    void LateUpdate()
    {
        tText.text = simulationManager.t.ToString("F2");
        dtText.text = simulationManager.dt.ToString("F3");
    }
}
