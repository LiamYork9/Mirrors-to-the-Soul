using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spell : MonoBehaviour
{
    public Transform spellTForm;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var angle = spellTForm.up;
        var spellRot = spellTForm.rotation;
        var spellDirection = spellRot * angle;
        rb.transform.Translate(spellDirection * 10f * Time.deltaTime);
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("ScreenBounds"))
        {
            Destroy(gameObject);
        }
    }
}
