using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DentistTool : MonoBehaviour
{

    private Vector3 startPos;

    private void OnMouseDown()
    {
        PickUp();
    }

    public virtual void Start()
    {
        startPos = transform.position;
    }

    public virtual void Update()
    {
        if(ToolManager.instance.currentTool == this)
        {
            gameObject.transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, gameObject.transform.position.z);
            //print(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        }
        
    }

    public void PickUp()
    {
        if(ToolManager.instance.currentTool == null)


            if (ToolManager.instance.currentTool == this)
            {

            }
        ToolManager.instance.currentTool = this;

        GetComponent<BoxCollider2D>().enabled = false;
        //Cursor.visible = false;
    }

    public void ReplaceTool()
    {

    }

    public void UseTool()
    {

    }
}
