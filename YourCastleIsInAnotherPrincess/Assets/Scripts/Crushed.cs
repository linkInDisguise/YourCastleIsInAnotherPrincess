using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crushed : MonoBehaviour
{
    Vector3 originalPosition;
    public Animator anim;
    public GameObject Warning;
    GameObject tmpObj = null;
    public AudioSource[] source;
    public GameObject player;

    void Start()
    {
        originalPosition = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        source = GetComponents<AudioSource>();
    }

    void Update()
    {
        Debug.Log("Test");
        if(tmpObj != null)
        {
            Debug.Log(tmpObj.transform.position);
        }
        //Vec2 pos = new Vec2(gameObject.transform.position.x, 7);
        
        if (15 < (gameObject.transform.position.y - player.transform.position.y) && (gameObject.transform.position.y - player.transform.position.y) < 16 && tmpObj == null)
        {
           tmpObj = Instantiate(Warning, new Vector3(gameObject.transform.position.x, 0, 0), Quaternion.identity);
        }
        else if (7 < (gameObject.transform.position.y - player.transform.position.y) && (gameObject.transform.position.y - player.transform.position.y) < 15 && tmpObj != null) 
        {
            tmpObj.transform.position = new Vector3(gameObject.transform.position.x, 0, 0);

        }
        else if (5 < (gameObject.transform.position.y - player.transform.position.y) && (gameObject.transform.position.y - player.transform.position.y) < 6 && tmpObj != null)
        {
            DestroyImmediate(tmpObj);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        { 
            anim.SetBool("isDead", true);
            source[1].Play();
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else
        {
            source[0].Play();
            gameObject.transform.position = originalPosition;
        }
    }
}