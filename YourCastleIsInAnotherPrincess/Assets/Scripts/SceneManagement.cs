using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public void restart()
    {
        SceneManager.LoadScene("Mountain");
    }

    public void close()
    {
        Application.Quit();
    }
}
