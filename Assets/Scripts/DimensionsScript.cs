using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public List<GameObject> invertedObjects;

   public float currentTime;

    public float timeToLive;

    public float Th;

    

   
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
       Inversion();

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

    public void Inversion()
    {
        foreach(GameObject go in invertedObjects){
        if(GameManager.Instance.swapped == true)
        {
            go.GetComponent<SpriteRenderer>().material.SetFloat("_Threshold", Th + 1.0f);
       
            if (go.CompareTag("GetRid"))
            {
                go.SetActive(false);
            }
        }
        else
        {
            go.GetComponent<SpriteRenderer>().material.SetFloat("_Threshold", Th = 0.0f);
            currentTime = 0.0f;

             if (go.CompareTag("GetRid"))
            {
                go.SetActive(true);
            }
        }
        }
    }
}
