using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flusher : DentistTool
{
    public ParticleSystem warterEffect;

    public new void Update()
    {
        base.Update();
        if (ToolManager.instance.currentTool == this)
        {
            ActivateTool();
        }
        else
        {
            DeActivateTool();
        }
    }

    public void ActivateTool()
    {
        warterEffect.gameObject.SetActive(true);
    }


    public void DeActivateTool()
    {
        warterEffect.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Debris"))
        {
            Rigidbody2D debrisRB = collision.gameObject.GetComponent<Rigidbody2D>();
            debrisRB.bodyType = RigidbodyType2D.Dynamic;
            Destroy(collision.gameObject, 2);
        }
    }

}
