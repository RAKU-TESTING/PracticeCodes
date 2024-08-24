    using System.Collections;
    using System.Collections.Generic;
    using UnityEditor.SceneManagement;
    using UnityEngine;
    using UnityEngine.EventSystems;
    using UnityEngine.UI;

    //using UnityEngine.UIElements;

    public class NewScript : MonoBehaviour,IPointerClickHandler
    {
    Text lastBetText;
    int lastbetvalue;
    public Text eachScore;
    int j=0;            
    int lastbet;

    void Start()
    {
    GV.lastbet.interactable=false;

    }
    public void OnPointerClick (PointerEventData eventData)
    {
        if (eventData.button== PointerEventData.InputButton.Left)
        {
    AddBet();
        }
    }

    public void AddBet()
    {
            if(GV.bal>0)
        {
            if(ToggleAssign())
            {
                j=j+chipSelection();
                eachScore.text=j.ToString();

            GV.lastbet.interactable=true;
            
                GV.k=GV.bal-chipSelection();
            
            GV.baltext.text=GV.k.ToString();
            GV.bal=GV.k;
                
            GV.l=GV.l+chipSelection();
            GV.playtext.text=GV.l.ToString();
            lastbet=j;

            if(GV.dicto.ContainsKey(this.gameObject.name))
            {
                    GV.dicto[this.gameObject.name]=j;
            }
            else
            {
    GV.dicto.Add(this.gameObject.name,j);
            }
    //         int  getInstanceID =eachScore.GetInstanceID();
    //         if(GV.dicto.ContainsKey(getInstanceID))
    //         GV.dicto[getInstanceID]+=j;
    //         else
    //         {
    //             GV.dicto.Add(getInstanceID,j);
    //         }
        
    PrintDicto();

            }
                }
            }
    public void PrintDicto()
        {
            foreach (var kvp in GV.dicto)
            {
                Debug.Log("Key: " + kvp.Key + ", Value: " + kvp.Value);
            }
        }

    public bool ToggleAssign()
    {
        for(int i=0;i<GV.t.Length;i++)
        {
            if(GV.t[i].isOn)
            {
                return true;
            }

        }
        return false;
    }
    public int chipSelection()
    {
        int selectedchip = 0;
        for (int i=0;i<GV.chip.Length;i++)
        { if(GV.t[i].isOn)
        {
            selectedchip=GV.chip[i];
        }

        }    
        return selectedchip;
    }
    
    }
