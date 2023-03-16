using UnityEngine;

public class ScopeScript : MonoBehaviour
{

    public GameObject scopeCamera;
    public GameObject scopeImg;

    enum ScopeOnOff
    {
        On,
        Off
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    

    public void ZoomIn()
    {
        scopeCamera.SetActive(true);
        scopeImg.SetActive(true);
        Debug.Log("Evento enviado por ScopeManager y recibido por ScopeScript");
    }
    public void ZoomOut()
    {
        scopeCamera.SetActive(false);
        scopeImg.SetActive(false);
        Debug.Log("Evento enviado por ScopeManager y recibido por ScopeScript");

    }
}
