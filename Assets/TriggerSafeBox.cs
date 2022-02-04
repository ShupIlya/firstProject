using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerSafeBox : MonoBehaviour
{

    public LockPanel safeBox;
    public GameObject canvas;

    private void OnTriggerEnter(Collider other)
    {
        if (!safeBox.isSafeOpen){
            if (other.CompareTag("Player"))
            {
                canvas.SetActive(true);
                Cursor.lockState = CursorLockMode.Confined;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        canvas.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }
}
