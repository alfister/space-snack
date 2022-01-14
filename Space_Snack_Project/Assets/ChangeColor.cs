using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeColor : MonoBehaviour
{
    public Color oldColor = Color.white;
    public Color newColor = Color.magenta;
    public GameObject txt;
    public Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material.color = oldColor;
    }

    void OnMouseUp()
    {
        if (tag == "HomeBase")
        {
            SceneManager.LoadScene(2);
        } else if (tag == "PartyPlanet")
        {
            SceneManager.LoadScene(3);
        } else if (tag == "RockRealm")
        {
            SceneManager.LoadScene(4);
        } else if (tag == "GiveUp")
        {
            SnacksFound.helpNeeded = true;
        }
    }

    void OnMouseEnter()
    {
        rend.material.color = newColor;
    }

    void OnMouseExit()
    {
        rend.material.color = oldColor;
    }


}
