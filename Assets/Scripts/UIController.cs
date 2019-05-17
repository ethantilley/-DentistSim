using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UIController : MonoBehaviour
{
    public void OnClick_Home()
    {
        SceneManager.LoadScene(0);
    }

    public void OnClick_Reset()
    {
        SceneManager.LoadScene(1);
    }
}
