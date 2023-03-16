using Cinemachine;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera camera1;
    [SerializeField] private CinemachineVirtualCamera camera2;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            TurnOnCamera(camera1,camera2);            
        }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            TurnOnCamera(camera2, camera1);
        }
    }

    private void TurnOnCamera(CinemachineVirtualCamera cam1, CinemachineVirtualCamera cam2)
    {
        cam1.gameObject.SetActive(true);
        cam2.gameObject.SetActive(false);
    }
}
