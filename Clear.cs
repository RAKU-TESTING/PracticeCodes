using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clear : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Clearer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Clearer()
  {
   SceneManager.LoadScene(1);
}

}
