using UnityEngine;
using UnityEngine.UI;

public class SetupElement : MonoBehaviour
{
    public Text label;

    public InputField massInput, velocityInput,
                      dxInput, dyInput, dzInput,
                      pxInput, pyInput, pzInput;

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

        dxInput.text = body.direction.x.ToString();
        dyInput.text = body.direction.y.ToString();
        dzInput.text = body.direction.z.ToString();

        pxInput.text = body.transform.position.x.ToString();
        pyInput.text = body.transform.position.y.ToString();
        pzInput.text = body.transform.position.z.ToString();
    }

    public void Apply()
    {
        body.mass = float.Parse(massInput.text);
        body.velocity = float.Parse(velocityInput.text);

        Vector3 direction = Vector3.zero;

        direction.x = float.Parse(dxInput.text);
        direction.y = float.Parse(dyInput.text);
        direction.z = float.Parse(dzInput.text);

        body.direction = direction;

        Vector3 position = Vector3.zero;

        position.x = float.Parse(pxInput.text);
        position.y = float.Parse(pyInput.text);
        position.z = float.Parse(pzInput.text);

        body.transform.position = position;

        body.CalculateMomentum();
    }
}
