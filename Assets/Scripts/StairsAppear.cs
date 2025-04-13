using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class StairsAppear : MonoBehaviour
{
    public int theNumber;

     public int theSlumber;

    public GameObject stair1;
    public GameObject stair2;
    public GameObject stair3;

    public GameObject laser1;

    public GameObject laser2;

    public GameObject laser3;

    public GameObject laser4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.Instance.swapped == false)
        {
         theNumber = Random.Range(0, 3);
         stair1.SetActive(false);
         stair2.SetActive(false);
         stair3.SetActive(false);

          theSlumber = Random.Range(0, 4);

          laser1.SetActive(false);
          laser2.SetActive(false);
          laser3.SetActive(false);
          laser4.SetActive(false);
        }

        if(GameManager.Instance.swapped == true){

        if(theNumber == 0)
        {
            stair1.SetActive(true);
        }

         if(theNumber == 1)
        {
            stair2.SetActive(true);
        }

         if(theNumber == 2)
        {
            stair3.SetActive(true);
            
        }

        if(theSlumber== 0)
        {
            laser2.SetActive(true);
            laser1.SetActive(true);
        }
        if(theSlumber == 1)
        {
            laser1.SetActive(true);
            laser3.SetActive(true);
        }
        if(theSlumber == 2)
        {
            laser4.SetActive(true);
            laser2.SetActive(true);
        }
        if(theSlumber == 3)
        {
            laser3.SetActive(true);
            laser4.SetActive(true);
        }
         


        }
    }
}
