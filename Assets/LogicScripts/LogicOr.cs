using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicOr : MonoBehaviour
{
    public GameObject Item1;
    public GameObject Item2;
    public bool state;
    public bool PassedState;

    // Start is called before the first frame update
    void Start()
    {


    }

    public void ToggleState()
    {
        if (state)
        {
            state = false;
        }
        else
        {
            state = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (!state)
        {
            PassedState = Item1.GetComponent<LogicBool>().State;
        }
        else
        {
            PassedState = Item2.GetComponent<LogicBool>().State;
        }
    }
}
