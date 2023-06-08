using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Transition1 : MonoBehaviour
{
    public string Parabola;
    public float delay = 5f;

    private void Start()
    {
        StartCoroutine(TriggerSceneChange());
    }

    private System.Collections.IEnumerator TriggerSceneChange()
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(Parabola);
    }
}
