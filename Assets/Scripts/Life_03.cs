using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life_03 : MonoBehaviour
{
    float lives_03;
    public Text lifeText_03;
    // Start is called before the first frame update
    void Start()
    {
        lives_03 = 1.0f;
        lifeText_03.text = lives_03.ToString();
    }
}
