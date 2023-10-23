using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Display : MonoBehaviour
{
    public Canvas inventory;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            inventory.SetActive(true);
        }
        else
        {
            //canvas not visible
        }
    }
}
