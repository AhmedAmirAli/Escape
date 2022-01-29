using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameComplete : MonoBehaviour
{
public int sceneBuildIndex;
public bool PressurePlateState = false;
public GameObject OtherPressurePlate;

public GameObject completeLevelUI;

private void OnTriggerEnter2D(Collider2D collider)
    {
        
        if(collider.tag == "Player" || collider.tag == "Player2")
        {
            PressurePlateState = true;   
            if(PressurePlateState && OtherPressurePlate.GetComponent<GameComplete>().PressurePlateState)
            {
                completeLevelUI.SetActive(true);
            }
        }   
    }
private void OnTriggerExit2D(Collider2D collider)
{
     if(collider.tag == "Player" || collider.tag == "Player2")
     {
        PressurePlateState = false;
     }
    }

}

