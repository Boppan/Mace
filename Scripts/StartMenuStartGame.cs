﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuStartGame : MonoBehaviour
{
    public void StartGame() {
        //PlayerPrefs.SetInt("CoinAmount", 0);
        SceneManager.LoadScene(1);
    }
}
