using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loader : MonoBehaviour
{
    public Animator transition;

    public float transitionTime = 1f;


public void ClassLoader()
    {

       StartCoroutine(Loadlevel(SceneManager.GetActiveScene().buildIndex + 1));
    }
    public void ClassBacker()
    {

        StartCoroutine(Loadlevel(SceneManager.GetActiveScene().buildIndex - 4));
    }

    IEnumerator Loadlevel(int levelindex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelindex);
    }
}
