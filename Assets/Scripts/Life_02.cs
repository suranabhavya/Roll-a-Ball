using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life_02 : MonoBehaviour
{
    float lives_02;
    public Text lifeText_02;
    // Start is called before the first frame update
    void Start()
    {
        lives_02 = 2.0f;
        lifeText_02.text = lives_02.ToString();
    }
}
