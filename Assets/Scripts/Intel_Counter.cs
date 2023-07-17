using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intel_Counter : MonoBehaviour
{
    private int counter;
    private TMPro.TMP_Text text;
    // Update is called once per frame

    void Start()
    {
        text = this.gameObject.GetComponent<TMPro.TMP_Text>();
    }

    public void increase()
    {
        counter += 1;
    }
    public void decrease()
    {
        counter -= 1;
    }
    public void upTen()
    {
        counter += 10;
    }
    public void downten()
    {
        counter -= 10;
    }
    void Update()
    {
        text.text = "" + counter;
    }
}
