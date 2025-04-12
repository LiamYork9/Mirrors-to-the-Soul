using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public List<GameObject> invertedObjects;

   public float currentTime;

    public float timeToLive;

    public float Th;

    public TimerBar timer;

    public ManaBar mana;

    public float barLength;

    public GameObject reflected;

    

   
    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject go in invertedObjects)
        {
           go.GetComponent<SpriteRenderer>().material.GetFloat("_Threshold" );
        }
        timer.SetMaxTimer(timeToLive);
        barLength = timeToLive;
    }

    // Update is called once per frame
    void Update()
    {
       Inversion();

        if(GameManager.Instance.isSwapped == true)
        {
            reflected.SetActive(true);
            currentTime  += Time.deltaTime;
            barLength -= Time.deltaTime;
            timer.SetTimer(barLength);
            mana.SetMana((int)currentTime);
        }
        if(currentTime >= timeToLive)
        {
            GameManager.Instance.swapped = false;
            GameManager.Instance.isSwapped = false;
            reflected.SetActive(false);
            currentTime = 0.0f;
            barLength = timeToLive;
        }
    }

    public void Inversion()
    {
        foreach(GameObject go in invertedObjects){
            if(go == null){
                return;
            }
        if(GameManager.Instance.swapped == true)
        {
            go.GetComponent<SpriteRenderer>().material.SetFloat("_Threshold", Th + 1.0f);
       
            if (go.CompareTag("GetRid"))
            {
                go.GetComponent<BoxCollider2D>().enabled = false;
            }
        }
        else
        {
            go.GetComponent<SpriteRenderer>().material.SetFloat("_Threshold", Th = 0.0f);
            currentTime = 0.0f;

             if (go.CompareTag("GetRid"))
            {
                 go.GetComponent<BoxCollider2D>().enabled = true;
            }
        }
        }
    }
}
