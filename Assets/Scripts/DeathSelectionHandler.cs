using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathSelectionHandler : MonoBehaviour
{

    public GameObject[] eventButtons;
    public GameObject[] classButtons;
    public GameObject dropDown;
    private bool deathMode = false;
    private Vector3 dropPos;

    void Start()
    {
        dropPos = dropDown.transform.position;
    }

    public void eventSwap()
    {
        if (!deathMode)
        {
            Vector3 temp = eventButtons[0].transform.position;
            eventButtons[0].transform.position = eventButtons[1].transform.position;
            eventButtons[1].transform.position = temp;
            deathMode = !deathMode;

            dropDown.transform.position = new Vector3(-1000, 1000, 0);
        }
        else
        {
            Vector3 temp = eventButtons[1].transform.position;
            eventButtons[1].transform.position = eventButtons[0].transform.position;
            eventButtons[0].transform.position = temp;
            deathMode = !deathMode;

            dropDown.transform.position = new Vector3(610, 630, 0);
        }

    }

    public void classSwap()
    {
        if (deathMode)
        {
            for(int i = 0; i < classButtons.Length; i++)
            {
                if(i != 0)
                {
                    classButtons[i].transform.position = new Vector3(-1000, 1000, 0);
                }
                else
                {
                    classButtons[i].transform.position = new Vector3(842f, 686.5f, 0);
                }

            }
        }
        else
        {
            classButtons[0].transform.position = new Vector3(-1000, 1000, 0);
            dropDown.SendMessage("SwapClass");
        }
    }

}

