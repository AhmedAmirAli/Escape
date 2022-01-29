using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelThree : MonoBehaviour
{
public int sceneBuildIndex;
public bool PressurePlateState = false;
public GameObject OtherPressurePlate;

private void OnTriggerEnter2D(Collider2D collider)
    {
        
        if(collider.tag == "Player" || collider.tag == "Player2")
        {
            PressurePlateState = true;   
            if(PressurePlateState && OtherPressurePlate.GetComponent<LevelThree>().PressurePlateState)
            {
                SceneManager.LoadScene(2);
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

