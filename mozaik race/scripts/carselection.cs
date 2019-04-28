using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class carselection : MonoBehaviour {

  //  private GameObject[] characterlist;

    //private int index;

    //private void Start()
     
   // {
     // index = PlayerPrefs.GetInt("CharacterSelected");

//     characterlist = new GameObject[transform.childCount];

  //  for (int i = 0; i < transform.childCount; i++)
    //  characterlist[i] = transform.GetChild(i).gameObject;

    //foreach (GameObject go in characterlist)

      //go.SetActive(false);


    //if (characterlist[index])

      //characterlist[index].SetActive(true);

        
    //}
    

    //public void ToggleLeft()
   // {
     //   characterlist[index].SetActive(false);

      //  index--;
       // if (index < 0)
         //  index = characterlist.Length - 1;

      //  characterlist[index].SetActive(true);
   // }

    //public void ToggleRight()
   // {
     //   characterlist[index].SetActive(false);

       // index++;
        //if (index == characterlist.Length)
          //  index = 0;

        //characterlist[index].SetActive(true);
    //}

    public void selectbutton()
    {
       // PlayerPrefs.SetInt("CharacterSelected", index);
        SceneManager.LoadScene("map1");
    }
}
