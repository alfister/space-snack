using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProgress : MonoBehaviour
{
    TextMesh tm;

    void Start()
    {
        tm = GetComponent<TextMesh>();
        tm.text = "Snacks Found: " + SnacksFound.numFound + " / " + SnacksFound.numTotal;
    }
}
