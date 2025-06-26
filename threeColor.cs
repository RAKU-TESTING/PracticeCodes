using System.Collections;
using System.Collections.Generic;
//using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.UI;

public class threeColor : MonoBehaviour
{

    public Image[] imgs;
 //   int index;
    // Start is called before the first frame update
    void Start()
    {
    //    imgs[].color=GetComponent<Color>();
      imgs[0].color=Color.red;
      imgs[1].color=Color.blue;
      imgs[2].color=Color.yellow;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
