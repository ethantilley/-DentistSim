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
}
