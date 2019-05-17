using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Implant : DentistTool
{ 

    public new void Update()
    {
        base.Update();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("MissingTooth"))
        {
            if (Input.GetMouseButtonDown(0))
            {
                
                collision.gameObject.transform.parent.GetComponent<Animator>().SetTrigger("Implant");
                collision.gameObject.tag = "Fixed";
                --ToolManager.instance.implantsLeft;
            }
        }
    }
}
