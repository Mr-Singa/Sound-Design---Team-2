using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroLoad : MonoBehaviour
{
    public string sceneName;

    private void Start()
    {
        StartCoroutine(Itimer());
    }

    public IEnumerator Itimer()
    {
        yield return new WaitForSeconds(GetComponent<AudioSource>().clip.length);

        SceneManager.LoadScene(sceneName);
    }
}
