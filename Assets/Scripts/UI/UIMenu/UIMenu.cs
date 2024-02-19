using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class UIMenu : MonoBehaviour
{
    [SerializeField]
    private string nameScene;
    public void ResetWorld()
    {
        SceneManager.LoadScene(nameScene);
    }
}
