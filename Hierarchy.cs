using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Hierarchy : MonoBehaviour
{// private Image img;
// private Text text;
// private Text text2;
// private Button button;
// //public Sprite photo;
// private int i=0;
// public Button forward;
// public Button Backward;
// private  Text  buttontext;
// private GameObject img2;
// public Sprite []photos;
    // Start is called before the first frame update
    void Start()
    {
//         GameObject []rootGameObjects =SceneManager.GetActiveScene().GetRootGameObjects();  //
GameObject [] rootGameObjects =SceneManager.GetActiveScene().GetRootGameObjects();
foreach(GameObject a in rootGameObjects)
{
    Debug.Log(a.name);
}
     Debug.Log(rootGameObjects[0].name);
     Debug.Log(rootGameObjects[0].transform.name);
    Debug.Log(rootGameObjects[1].transform.childCount);
    Debug.Log(rootGameObjects[1].transform.GetChild(0).transform.name);
// img =GameObject.Find("iii").GetComponent<Image>();
// // text=img.transform.GetChild(0)?.GetComponentInChildren<Text>();
// // text.text="gdff";
// // text.name="textintex";
// // text.color=Color.blue;
//img2=GameObject.Find("Image").GetComponent<Image>().gameObject;
// // img2.GetComponent<Image>().color=Color.black;

// //img.sprite=photo;

// text2=img2.GetComponentInChildren<Text>().transform.GetComponentInChildren<Button>().GetComponentInChildren<Text>();
// text2.text="OK";
// buttontext= GetComponentInParent<Canvas>().transform.GetChild(0).transform.GetChild(0).transform.GetChild(0).transform.GetChild(0).transform.GetComponentInChildren<Button>().transform.GetComponentInChildren<Text>();
// buttontext.text="ssssss";
// button=buttontext.GetComponentInParent<Button>();
// //button.onClick.AddListener(ChangeColor);
// //StartCoroutine(ChangeColor());
// Invoke("FChangeColor",2f);
// InvokeRepeating("FChangeColor",5f,1f);
//     }
// //    public  IEnumerator ChangeColor()
// //     {   yield return new WaitForSeconds(6f);
    
// //             img2.GetComponent<Image>().color=Color.black;
// //     }

//     // Update is called once per frame
//    public void FChangeColor()
//     { //  yield return new WaitForSeconds(6f);
//    //for(int i=0;i<photos.Length;i++)
//    { i=(i+1)%photos.Length;
//     img.sprite=photos[i];
//     }
//     //        img2.GetComponent<Image>().color=Color.black;
//     }
//     public void BChangeColor()
//     { //  yield return new WaitForSeconds(6f);
//     //for(int i=photos.Length-1;i>=0;i--)
//     {i=(i-1+photos.Length)%photos.Length;
//     img.sprite=photos[i];}
//     //        img2.GetComponent<Image>().color=Color.black;
//     }
//     void Update()
//     {
        
//     }
// }
    }}