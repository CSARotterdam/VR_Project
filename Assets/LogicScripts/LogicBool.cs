using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicBool : MonoBehaviour
{
    public bool State;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void ToggleState()
    {
        if (State)
        {
            State = false;
        }
        else
        {
            State = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
