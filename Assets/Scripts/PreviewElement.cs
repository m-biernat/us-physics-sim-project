using UnityEngine;
using UnityEngine.UI;

public class PreviewElement : MonoBehaviour
{
    public Text label, massT, velocityT, momentumT, forceT, positionT;

    public InputField massInput;

    public PhysicsBody body;

    void OnEnable()
    {
        label.text = body.name;
    }

    void LateUpdate()
    {
        massT.text = body.mass.ToString("F2");
        velocityT.text = body.velocity.ToString("F2");

        momentumT.text = body.momentum.ToString();
        forceT.text = body.force.ToString();
        positionT.text = body.transform.position.ToString();
    }

    public void FollowBody()
    {
        CameraController.bodyPosition = body.transform;
    }

    public void ToggleEditMode()
    {
        bool toggle = massInput.gameObject.activeSelf;
        massInput.gameObject.SetActive(!toggle);

        if (!toggle)
        {
            massInput.text = body.mass.ToString("F2");
        }
    }

    public void ApplyChanges()
    {
        body.mass = float.Parse(massInput.text);
        ToggleEditMode();
    }
}
