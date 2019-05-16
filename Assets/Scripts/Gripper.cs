using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gripper : DentistTool
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        PickUp(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
