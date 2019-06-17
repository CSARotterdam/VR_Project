using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerInOut : MonoBehaviour
{
    public GameObject ItemToShow;
    public GameObject World;
    public bool IsPanorama;
    // Start is called before the first frame update

    private void Start()
    {
        ItemToShow.SetActive(false);
        if (IsPanorama == true)
        {
            World = GameObject.Find("World");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.name == "[VRTK][AUTOGEN][BodyColliderContainer]")
        {
            ItemToShow.SetActive(true);
            if (IsPanorama == true)
            {
                World.SetActive(false);
                this.transform.GetChild(0).gameObject.SetActive(false);
            }
        }
    }

    // Update is called once per frame
    void OnTriggerExit(Collider other)
    {
        if (other.transform.name == "[VRTK][AUTOGEN][BodyColliderContainer]")
        {
            ItemToShow.SetActive(false);
            if (IsPanorama == true)
            {
                World.SetActive(true);
                this.transform.GetChild(0).gameObject.SetActive(true);
            }
        }
    }
}
