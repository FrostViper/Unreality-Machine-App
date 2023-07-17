using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatCardHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject[] statSheets;

    // Update is called once per frame
    public void SwapClass()
    {
        TMPro.TMP_Dropdown dropDown = this.GetComponent<TMPro.TMP_Dropdown>();

        for (int i = 0; i < statSheets.Length; i++)
        {
            if (i == dropDown.value)
            {
                statSheets[i].transform.localPosition = new Vector3(0, 0, 0);
            }
            else
            {
                statSheets[i].transform.localPosition = new Vector3(6000, 0, 0);
            }
        }


    }
}
