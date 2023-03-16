using UnityEngine;

public class DoorManager : MonoBehaviour
{
    public bool canOpen;
    public void OpenDoor (GameObject obj)
    {
        if (!canOpen)
        {
            KeyText manager = obj.GetComponent<KeyText>();
            if (manager.keyCount < 0)
            {
                canOpen = true;
                manager.UseKey();
            }
        } 
        
    }
}
