using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnThatOn : MonoBehaviour
{
    public int killCount = 0;

    public int killsNeeded;

    public GameObject stairs;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(killCount == killsNeeded)
        {
            stairs.SetActive(true);
        }
    }
}
