using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    /**
     * PlayControl Rigidbody2D
     */
    public Rigidbody2D play2D;

    /**
     * Play Move Speed
     */
    public float playSpeed = 8f;

    public float playJump = 20f;

    public Animator anim;

    public static int defauleJumpNum;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PlayMoveMent();
        PlayAnimation();
    }
    /**
     * Play Move
     */
    void PlayMoveMent()
    {
        float horizontalMent = Input.GetAxis("Horizontal");
        float playFacedorection = Input.GetAxisRaw("Horizontal");
        if (horizontalMent != 0)
        {
            play2D.velocity = new Vector2(horizontalMent * playSpeed, play2D.velocity.y);
            anim.SetFloat("runningFlag",Mathf.Abs(playFacedorection));
        }
        if (playFacedorection != 0)
        {
            transform.localScale = new Vector2(playFacedorection, 1);
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //检查是否还能接着跳跃
            if(defauleJumpNum >= 2)
            {
                Debug.Log("无法进行多段跳跃");
                return;
            }
            ++defauleJumpNum;
            Debug.Log(defauleJumpNum + "段跳");
            play2D.velocity = new Vector2(play2D.velocity.x, playJump);
        }
        


    }

    void PlayAnimation()
    {

    }
}
