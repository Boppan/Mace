using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartMenuDisplayCoinsCollected : MonoBehaviour
{

    [SerializeField] private Text textComponent;

    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = "TOTAL BEERS DRUNK: " + PlayerPrefs.GetInt("CoinAmount");
    }

}
