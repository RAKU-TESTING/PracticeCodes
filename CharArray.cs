using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Properties;
using UnityEngine;

public class CharArray : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {  


        
    }

    // Update is called once per frame
    void Update()
    {
//         if(Input.anyKeyDown)        
//       {  
//           for(int i=1;i<=126;i++)
//   { 
//             //char a=Convert.ToChar(i);
//             if (Input.GetKeyDown((KeyCode)i))
//            {
//       Debug.Log("KeyPressed"+(char)(i));
//         break;
//            }}
// }
for(int i=1;i<=126;i++)
{
  if(Input.GetKeyDown((KeyCode)i))
  {
    Debug.Log("KeyPressed"+" "+(char)i);
  }
  
} 
   //         string b=a.ToString();  //         Debug.Log(b);
  }  //       if (Input.GetKeyDown(b)) 
}      
    //     {
    //         Debug.Log("Pressed key: " +""+b);
    //         break;
    //         }
    //     }
    // if (Input.anyKeyDown)
    //     {
    //         // Get the last key pressed and print it to the console
    //         string keyName = Input.inputString;
    //         string key=Input.inputString;
    //         Debug.Log("Key pressed: " + keyName);
    //     }

            
        //   if (Input.GetKeyDown(KeyCode.A))
        // {
        //     Debug.Log("A key pressed");
        // }

          
    //    if(Input.GetKeyDown())

    
