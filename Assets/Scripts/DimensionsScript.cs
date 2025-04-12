using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public List<GameObject> invertedObjects;

    public GameObject floor;

    public float currentTime;

    public float timeToLive;

    public float Th;

    

    public SpriteRenderer pallette;
    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject go in invertedObjects)
        {
           go.GetComponent<SpriteRenderer>().material.GetFloat("_Threshold" );
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach(GameObject go in invertedObjects){
        if(GameManager.Instance.swapped == true)
        {
            go.GetComponent<SpriteRenderer>().material.SetFloat("_Threshold", Th + 1.0f);
       
            Debug.Log("Fart");
        }
        else
        {
            go.GetComponent<SpriteRenderer>().material.SetFloat("_Threshold", Th = 0.0f);
            currentTime = 0.0f;
        }
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
