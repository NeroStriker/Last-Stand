using UnityEngine;
using UnityEngine.Events;

public class ScopeManager : MonoBehaviour
{
    public UnityEvent zoomIn, zoomOut;
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            zoomIn.Invoke();
        }

        if (Input.GetMouseButtonUp(1))
        {
            zoomOut.Invoke();
        }
    }
}
