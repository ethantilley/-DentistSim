using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolManager : MonoBehaviour
{
    public static ToolManager instance = null;

    public int debrisActive, decayedTeeth, implantsLeft;

    public GameObject endGamePanel;

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

    public IEnumerator CompleteGame()
    {
        yield return new WaitForSeconds(5);
        //end game
        Debug.Log("Game fin.");
        endGamePanel.SetActive(true);
    }
    IEnumerator endGame;
    // Update is called once per frame
    void Update()
    {
        debrisActive = GameObject.FindGameObjectsWithTag("Debris").Length;

        if (debrisActive <= 0 && decayedTeeth <= 0 && implantsLeft <= 0)
        {
            if(endGame == null)
            {
                endGame = CompleteGame();
                StartCoroutine(endGame);
                
            }
        }

    }
}
