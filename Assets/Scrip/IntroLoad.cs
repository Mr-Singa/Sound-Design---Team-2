using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroLoad : MonoBehaviour
{
    public float timer;
    public string sceneName;

    private void Start()
    {
        StartCoroutine(Itimer());
    }

    public IEnumerator Itimer()
    {
        yield return new WaitForSeconds(timer);

        SceneManager.LoadScene(sceneName);
    }
}
