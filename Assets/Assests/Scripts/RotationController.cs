using UnityEngine;

public class PlanetRotationController : MonoBehaviour
{
    // Speed of the planet's rotation
    public float rotationSpeed = 10f;

    // Axis of rotation (default: y-axis)
    public Vector3 rotationAxis = Vector3.up;

    void Update()
    {
        // Rotate the planet around the specified axis
        transform.Rotate(rotationAxis * rotationSpeed * Time.deltaTime, Space.Self);
    }
}
