using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gripper : DentistTool
{

    public HingeJoint2D hinge;
    public Transform toothGripped;
    public Vector3 initToothPoint, gripPoint;
    [Range(0, 50)]
    public float wiggleSmoothStep;

    public new void Update()
    {
        base.Update();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Tooth"))
        {
            if (Input.GetMouseButtonDown(0))
            {
                toothGripped = collision.gameObject.transform;
                toothGripped.transform.parent.gameObject.GetComponent<Animator>().SetTrigger("PullTooth");
                collision.gameObject.tag = "MissingTooth";

                toothGripped = null;
                --ToolManager.instance.decayedTeeth;

            }
        }
    }
}
