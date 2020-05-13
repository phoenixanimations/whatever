using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Story : MonoBehaviour
{
    public GameObject how;
    public GameObject why;
    public List<GameObject> whyDialogue = new List<GameObject>();

    void Update()
    {
	if(how == null)
        {
            WhyDialogue();
        }
    }

    int iTimer = 0;
    int iDialogue = 0;
    void WhyDialogue()
    {
        if(iDialogue == 0)
        {
            whyDialogue[iDialogue].SetActive(true);
            iDialogue++;
            return;
        }
        
        iTimer++;
        if((iTimer == 60) &&
           (iDialogue < whyDialogue.Count))
        {
            whyDialogue[iDialogue - 1].SetActive(false);
            whyDialogue[iDialogue].SetActive(true);
            iDialogue++;
            iTimer = 0;
        }
    }
}
