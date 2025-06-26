using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Multipleeee : MonoBehaviour
{
public Transform Canvas;
public Button button;
    void Start()
    {
        for(int i = 0;i<30;i++)
        {
            GameObject but=Instantiate(button,Canvas).gameObject;
            but.GetComponentInChildren<Text>().text="Button"+""+i;
        } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
