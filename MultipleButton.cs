using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class MultipleButton : MonoBehaviour
        {
            public Transform Canvas;
        public Button button;
            // Start is called before the first frame update
            void Start()
            {
                for ( int i=0;i<25;i++)
            {
            
                GameObject but = Instantiate(button,Canvas).gameObject;
                
                but.GetComponentInChildren<Text>().text="Button"+""+(i+1);
                but.name="Button"+""+(i+1);

               // Button buttoncomponents=but.GetComponent<Button>();
             // 
            }
        Button[] buts=Canvas.GetComponentsInChildren<Button>();
     //   Button buttoncomponents=buts.GetComponent<Button>();
     foreach(Button butprefab in buts)
 {butprefab.onClick.AddListener(delegate {NamePrint(butprefab.name);});}
           
            }

            // Update is called once per frame
           
           void NamePrint(string name)
           {
       Debug.Log("Clicked"+""+  name);
           }
            void Update()
            {
                
            }
        }
