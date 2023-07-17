using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassSelectionHandler : MonoBehaviour
{
    public GameObject[] drawButtons;

    public void SwapClass()
    {
        TMPro.TMP_Dropdown dropDown = this.GetComponent<TMPro.TMP_Dropdown>();
        
        for(int i = 0; i < drawButtons.Length; i++)
        {
            if(i == dropDown.value)
            {
                drawButtons[i].transform.position = new Vector3(842f, 686.5f, 0);
            }
            else
            {
                drawButtons[i].transform.position = new Vector3(-200, 0, 0);
            }
        }

    }
}
