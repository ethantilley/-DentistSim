using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolManager : MonoBehaviour
{
    public static ToolManager instance = null;

    public int debrisActive, decayedTeeth;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }

    }

    public DentistTool currentTool = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        debrisActive = GameObject.FindGameObjectsWithTag("Debris").Length;
        decayedTeeth = GameObject.FindGameObjectsWithTag("Tooth").Length;
    }
}
