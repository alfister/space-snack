using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Snack : MonoBehaviour
{
    void Start()
    {
        SnacksFound.helpNeeded = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Astronaut" || other.tag == "Dog")
        {
            StartCoroutine(ChangeScene());
        }
    }

    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(2);
        SnacksFound.numFound += 1;
        print(SnacksFound.numFound);

        if (SnacksFound.numFound == SnacksFound.numTotal)
        {
            SceneManager.LoadScene(5);
        } else
        {
            SceneManager.LoadScene(1);
        }
    }
}
