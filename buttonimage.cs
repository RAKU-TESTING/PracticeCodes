using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;


public class buttonimage : MonoBehaviour
{   

public Image img;
public Sprite[] change;
int i=0;
private Button forward;

private Button backward;

    // Start is called before the first frame update
   void Awake()
   {
  //  Debug.Log("AWWAKKKE");
   }
    void Start()
    {
      //  forward=GameObject.Find("forward").GetComponent<Button>();
       // backward=GameObject.Find("backward").GetComponent<Button>(); 
        img.sprite=change[0];
     //   forward.onClick.AddListener(Next);


        //backward.onClick.AddListener(Previous);
       //  StartCoroutine(Next());
      //  Invoke("Previous",2f);
       InvokeRepeating("Previous",2f,1f);
    //  StartCoroutine(Nextt());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // private  IEnumerator Next()
    // {  
    //     for(int i=0;i<change.Length;i++)
    //     {
        
    //         i=(i+1)%change.Length;      
    //           yield return new WaitForSeconds(2f);    
    //         img.sprite=change[i];
            
    //         }
    // //         StopCoroutine(Next());
                  
    //  }
    public IEnumerator Nextt()
    {
        for(int i=0;i<change.Length;i++)
       {
        
          i=(i+1)%change.Length;
           
           yield return new WaitForSeconds(2f);
           img.sprite=change[i];
     
     }
      StopCoroutine(Nextt());
     }
     public void Next()
     {
        
                 i=(i+1)%change.Length;
                 img.sprite=change[i];
     }
            public void Previous()
     { 
       
          i=(i-1+change.Length)%change.Length;
             
              img.sprite=change[i];
     }
    }
