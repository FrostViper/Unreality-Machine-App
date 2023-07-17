using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ruleBookControl : MonoBehaviour
{
    private bool isOut = false;
    public GameObject entryButton;
    public float inButtonXCord;
    public float ButtonYCord;
    public float outButtonXCord;
    public float outXCord;
    public float outYCord;
    public float inXCord;
    public float inYCord;


    void CanvasMove()
    {
        if (isOut)
        {
            this.GetComponent<RectTransform>().position = new Vector3(inXCord, inYCord, 0);
            this.entryButton.transform.localPosition = new Vector3(inButtonXCord, ButtonYCord, 0);
            isOut = !isOut;
        }
        else
        {
            this.GetComponent<RectTransform>().position = new Vector3(outXCord, outYCord, 0);
            entryButton.transform.localPosition = new Vector3(outButtonXCord, ButtonYCord, 0);
            isOut = !isOut;
        }
    }
}
