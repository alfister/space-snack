﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour
{
    void OnMouseUp()
    {
        SnacksFound.numFound = 0;
        SceneManager.LoadScene(0);
    }
}
