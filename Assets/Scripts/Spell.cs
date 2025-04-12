using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spell : MonoBehaviour
{
    public Transform spellObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var spellRot = spellObject.rotation;
        var spellDirection = spellRot * spellObject.forward;
        transform.Translate(spellDirection * 25 * Time.deltaTime);
    }
}
