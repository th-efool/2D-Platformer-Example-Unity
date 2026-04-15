using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitTrigger : MonoBehaviour
{
    //public Animator anim;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine("LevelExit");
            collision.gameObject.GetComponent<PlayerController>().enabled = false;
        }
    }

    IEnumerator LevelExit()
    {
        //anim.SetTrigger("Exit");
        yield return new WaitForSeconds(0.005f);

        UIManager.instance.fadeToBlack = true;

        yield return new WaitForSeconds(0.01f);
        // Do something after flag anim
        GameManager.instance.LevelComplete();
    }
}
