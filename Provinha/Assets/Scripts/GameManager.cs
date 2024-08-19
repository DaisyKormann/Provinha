using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using static UnityEditor.Progress;

public class GameManager : MonoBehaviour
{
    #region Singleton

    public static GameManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

    }

    #endregion

    
    public float speed = 5.0f;
    public float minX = -5.0f; 
    public float maxX = 5.0f;  
    public float minY = -5.0f;  
    public float maxY = 5.0f;   

    void Update()
    {
      
        float moveX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float moveY = Input.GetAxis("Vertical") * speed * Time.deltaTime;

       
        Vector3 newPosition = transform.position + new Vector3(moveX, moveY, 0);

 
        newPosition.x = Mathf.Clamp(newPosition.x, minX, maxX);
        newPosition.y = Mathf.Clamp(newPosition.y, minY, maxY);

  
        transform.position = newPosition;

    }

    [SerializeField] Vector2 ScreenBonds; //limite da tela
    [SerializeField] int score; // pontuacao

    public Vector2 ScreenBonds1 { get => ScreenBonds; }
    public int Score { get => score; set => score = value; }

}
