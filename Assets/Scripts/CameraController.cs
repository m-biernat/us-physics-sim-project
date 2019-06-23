using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform pivot, arm;

    public float rotationSpeed = 5.0f, camDistance = -50f;

    private float xAxisInput = 0, yAxisInput = 0, zAxisInput = 0,
                  camRotationX = 0, camRotationY = 0;

    private bool rotate = false;

    [SerializeField]
    private float maxCameraDistance = -100f;
    private float minCameraDistance = 5f;

    public static Transform bodyPosition;

    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            rotate = true;
            xAxisInput = Input.GetAxis("Mouse Y");
            yAxisInput = Input.GetAxis("Mouse X");
        }
        else
        {   rotate = false; }

        zAxisInput = Input.GetAxis("Mouse ScrollWheel");            
    }

    void LateUpdate()
    {
        if (rotate)
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            pivot.transform.eulerAngles = CalculateRotation();
        }
        else
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }

        if (zAxisInput != 0f) { SetDistance(); }

        SetPosition();
    }

    private Vector3 CalculateRotation()
    {
        camRotationX -= xAxisInput * rotationSpeed;
        camRotationX = Mathf.Clamp(camRotationX, -90f, 90f);

        camRotationY += yAxisInput * rotationSpeed;
        camRotationY = Mathf.Clamp(camRotationY, -360f, 360f);

        return new Vector3(camRotationX, camRotationY, 0f);
    }

    private void SetDistance()
    {
        camDistance += zAxisInput * 50;
        camDistance = Mathf.Clamp(camDistance, maxCameraDistance, -minCameraDistance);
        arm.transform.localPosition = new Vector3(0f, 0f, camDistance);
    }

    public void ResetPosition()
    {
        bodyPosition = null;
        pivot.transform.position = Vector3.zero;
    }

    private void SetPosition()
    {
        if (bodyPosition)
        {
            pivot.transform.position = bodyPosition.position;
        }
    }
}
