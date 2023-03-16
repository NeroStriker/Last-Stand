using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public Transform playerBody;
    float xRot = 0f;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRot -= mouseY;
        xRot = Mathf.Clamp(xRot, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRot,0,0);
        playerBody.Rotate(Vector3.up * mouseX);
    }


   
}
