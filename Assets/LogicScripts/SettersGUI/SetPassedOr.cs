using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPassedOr : MonoBehaviour
{
    public GameObject SetWhat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SetWhat.GetComponent<LogicOr>().PassedState)
        {
            this.GetComponent<UnityEngine.UI.Toggle>().isOn = true;
        }
        else
        {
            this.GetComponent<UnityEngine.UI.Toggle>().isOn = false;
        }
    }
}
