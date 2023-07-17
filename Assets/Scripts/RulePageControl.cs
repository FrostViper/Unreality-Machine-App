using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RulePageControl : MonoBehaviour
{
    private int count;
    public GameObject[] rulePages;
    public GameObject nextBut;
    public GameObject prevBut;

    void Start()
    {
        count = 1;
    }

    public void countUp()
    {
        if(count < 7)
        {
            count++;
        }
    }

    public void countDown()
    {
        if(count > 1)
        {
            count--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        switch (count)
        {
            case 1:
                for(int i = 0; i < rulePages.Length; i++)
                {
                    if(i ==0 || i == 1)
                    {
                        rulePages[0].transform.localPosition = new Vector3(-332, 0, 0);
                        rulePages[1].transform.localPosition = new Vector3(194, 0, 0);
                    }
                    else
                    {
                        rulePages[i].transform.position = new Vector3(-1000, 0, 0);
                    }
                }
                prevBut.transform.localPosition = new Vector3(-1000, -1000, 0);

                break;
            case 2:
                for (int i = 0; i < rulePages.Length; i++)
                {
                    if (i == 1 || i == 2)
                    {
                        rulePages[1].transform.localPosition = new Vector3(-332, 0, 0);
                        rulePages[2].transform.localPosition = new Vector3(194, 0, 0);
                    }
                    else
                    {
                        rulePages[i].transform.position = new Vector3(-1000, 0, 0);
                    }
                }
                prevBut.transform.localPosition = new Vector3(-485, -300, 0);

                break;

            case 3:
                for (int i = 0; i < rulePages.Length; i++)
                {
                    if (i == 2 || i == 3)
                    {
                        rulePages[2].transform.localPosition = new Vector3(-332, 0, 0);
                        rulePages[3].transform.localPosition = new Vector3(194, 0, 0);
                    }
                    else
                    {
                        rulePages[i].transform.position = new Vector3(-1000, 0, 0);
                    }
                }
                break;

            case 4:
                for (int i = 0; i < rulePages.Length; i++)
                {
                    if (i == 3 || i == 4)
                    {
                        rulePages[3].transform.localPosition = new Vector3(-332, 0, 0);
                        rulePages[4].transform.localPosition = new Vector3(194, 0, 0);
                    }
                    else
                    {
                        rulePages[i].transform.position = new Vector3(-1000, 0, 0);
                    }
                }
                break;

            case 5:
                for (int i = 0; i < rulePages.Length; i++)
                {
                    if (i == 4 || i == 5)
                    {
                        rulePages[4].transform.localPosition = new Vector3(-332, 0, 0);
                        rulePages[5].transform.localPosition = new Vector3(194, 0, 0);
                    }
                    else
                    {
                        rulePages[i].transform.position = new Vector3(-1000, 0, 0);
                    }
                }
                nextBut.transform.localPosition = new Vector3(343, -300, 0);

                break;

            case 6:
                for (int i = 0; i < rulePages.Length; i++)
                {
                    if (i == 6 || i == 7)
                    {
                        rulePages[6].transform.localPosition = new Vector3(-332, 0, 0);
                    }
                    else
                    {
                        rulePages[i].transform.position = new Vector3(-1000, 0, 0);
                    }
                }
                nextBut.transform.localPosition = new Vector3(-1000, -1000, 0);

                break;
        }
    }
}
