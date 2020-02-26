using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour
{
    float lives;
    public Text lifeText; 
    // Start is called before the first frame update
    void Start()
    {
        lives = 3.0f;
        lifeText.text = lives.ToString();
    }
}
