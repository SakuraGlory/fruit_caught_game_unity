using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed;
    public bool face;
    private SpriteRenderer _renderer;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        TouchMove();
    }
    void TouchMove()
    {
        if(Input.GetMouseButton(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
             
            if(mousePos.x > 1)
            {
                transform.localScale = new Vector2(0.684491f,0.7046446f);
                transform.Translate(moveSpeed,0,0);
                  
              
            }
            else if (mousePos.x < -1)
            {
                 transform.localScale = new Vector2(-0.684491f,0.7046446f);
                transform.Translate(-moveSpeed,0,0);
                
            
            }
            
        }
    }
   

    
        





}
