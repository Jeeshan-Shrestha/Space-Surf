using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
  private void Awake() {
   int numberOfMusic =  FindObjectsOfType<MusicPlayer>().Length;
   if(numberOfMusic > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject); //if we crash don't start from the beginning
        }
  }
}
