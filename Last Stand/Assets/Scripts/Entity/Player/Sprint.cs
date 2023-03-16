using UnityEngine;
using UnityEngine.Events;

public class Sprint : MonoBehaviour
{
    public UnityEvent onSprint;
    public UnityEvent onWalk;
    private void Update()
    {
        OnSprint();
        OnStopSprint();
    }

    public void OnSprint()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            onSprint.Invoke();

        }
    }

    public void OnStopSprint()
    {
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            onWalk.Invoke();
        }
    }

    
}
