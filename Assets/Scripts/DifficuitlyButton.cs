using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DifficuitlyButton : MonoBehaviour
{
    private Button button;
    public int difficulty;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);
    }
    void SetDifficulty(){
        Debug.Log(gameObject.name + " was clicked");
        GameManager.instance.StartGame(difficulty);
    
    }

  }
