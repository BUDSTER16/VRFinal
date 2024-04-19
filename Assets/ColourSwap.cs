using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourSwap : MonoBehaviour
{
    [SerializeField] Material ColourBLue;
    [SerializeField] Material ColourGreen;
    [SerializeField] Material ColourRede;
    [SerializeField] Material ColourPurpel;
    [SerializeField] Material ColourPINK;
    [SerializeField] Material ColourYHellow;
    [SerializeField] Material ColourOrang;
    [SerializeField] Material ColourBasic;

    private int current = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwapColour()
    {
        // swaps colours when the ball is held and the trigger is pressed!
        switch(current)
        {
            case 0:
                this.GetComponent<Renderer>().material = ColourRede;
                current++;
                break;
            case 1:
                this.GetComponent<Renderer>().material = ColourOrang;
                current++;
                break;
            case 2:
                this.GetComponent<Renderer>().material = ColourYHellow;
                current++;
                break;
            case 3:
                this.GetComponent<Renderer>().material = ColourGreen;
                current++;
                break;
            case 4:
                this.GetComponent<Renderer>().material = ColourBLue;
                current++;
                break;
            case 5:
                this.GetComponent<Renderer>().material = ColourPurpel;
                current++;
                break;
            case 6:
                this.GetComponent<Renderer>().material = ColourPINK;
                current++;
                break;
            case 7:
                this.GetComponent<Renderer>().material = ColourBasic;
                current = 0;
                break;

        }
    }
}
