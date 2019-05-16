using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DentistTool : MonoBehaviour
{

    public DentistTool currentTool;

    

    private void Update()
    {
        if(currentTool)
            gameObject.transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, gameObject.transform.position.y);

    }

    public virtual void PickUp(DentistTool pickUp)
    {
        currentTool = pickUp;
        //Cursor.visible = false;
    }

    public virtual void ReplaceTool()
    {

    }

    public virtual void UseTool()
    {

    }
}
