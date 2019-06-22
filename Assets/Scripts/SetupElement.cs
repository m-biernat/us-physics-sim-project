using UnityEngine;
using UnityEngine.UI;

public class SetupElement : MonoBehaviour
{
    public Text label;

    public InputField massInput, velocityInput,
                      xInput, yInput, zInput;

    public PhysicsBody body;

    void OnEnable()
    {
        Setup();
    }

    private void Setup()
    {
        label.text = body.name;

        massInput.text = body.mass.ToString();
        velocityInput.text = body.velocity.ToString();

        xInput.text = body.direction.x.ToString();
        yInput.text = body.direction.y.ToString();
        zInput.text = body.direction.z.ToString();
    }

    public void Apply()
    {
        body.mass = float.Parse(massInput.text);
        body.velocity = float.Parse(velocityInput.text);

        Vector3 direction = Vector3.zero;

        direction.x = float.Parse(xInput.text);
        direction.y = float.Parse(yInput.text);
        direction.z = float.Parse(zInput.text);

        body.direction = direction;

        body.CalculateMomentum();
    }
}
