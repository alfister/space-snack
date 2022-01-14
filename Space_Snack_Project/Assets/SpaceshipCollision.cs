using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpaceshipCollision : MonoBehaviour
{
    Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Astronaut")
        {
            StartCoroutine(EnterSpaceship());
        }
    }

    IEnumerator EnterSpaceship()
    {
        rend.enabled = false;
        yield return new WaitForSeconds(0.1f);
        rend.enabled = true;
        SceneManager.LoadScene(1);
    }
}