using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Displaytime : MonoBehaviour
{
    TextMeshProUGUI TimeText;
    
    public int hour;
    public int minutes;

    // Start is called before the first frame update
    void Start()
    {
       


    }

    // Update is called once per frame
    void Update()
    {
        hour = System.DateTime.Now.Hour;
        minutes = System.DateTime.Now.Minute;
        TimeText = GetComponent<TextMeshProUGUI>();
        TimeText.text = "" + hour + ":" + minutes;
    }
}
