using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class OnTheStairs : MonoBehaviour
{
    public string sceneToLoad;
    [SerializeField] Animator transitionAnim;


    private void OnMouseDown()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    public void ChangeScene()
    {
        StartCoroutine(LoadRoxnoa());
    }
    IEnumerator LoadRoxnoa()
    {
        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1);
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
        transitionAnim.SetTrigger("start");

    }

}
