using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LoadCharacter : MonoBehaviour
{
    public GameObject[] characterPrefabs;
    public Transform spawnPoint;
    //public TMP_Text label;
    public Text label;

    // Start is called before the first frame update
    void Start()
    {
        int selectedCharacter = PlayerPrefs.GetInt("SelectedCharacter");
        GameObject prefab = characterPrefabs[selectedCharacter];
        GameObject prefab1 = Instantiate(prefab, spawnPoint.position, Quaternion.identity);
        label.text = prefab.name;
        
    }


}


