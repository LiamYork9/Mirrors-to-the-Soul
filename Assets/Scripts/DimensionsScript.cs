using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject floor;

    public float currentTime;

    public float timeToLive;

    public float Th;

    

    public SpriteRenderer pallette;
    // Start is called before the first frame update
    void Start()
    {
        Th =  floor.GetComponent<SpriteRenderer>().material.GetFloat("_Threshold" );
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.Instance.swapped == true)
        {
          Th = 1.0f;
       
            Debug.Log("Fart");
        }
        else
        {
            pallette.color = new Color(1f, 1f, 1f, 1f);
            currentTime = 0.0f;
        }

        if(GameManager.Instance.isSwapped == true)
        {
            currentTime  += Time.deltaTime;
        }
        if(currentTime >= timeToLive)
        {
            GameManager.Instance.swapped = false;
            GameManager.Instance.isSwapped = false;
            currentTime = 0.0f;
        }
    }
}
