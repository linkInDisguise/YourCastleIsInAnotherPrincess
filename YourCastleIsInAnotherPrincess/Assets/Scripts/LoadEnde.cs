using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadEnde : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene("Ende");
    }
}
