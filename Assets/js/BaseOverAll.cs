using UnityEngine;

/**
 * 用于检测物品或者人物是否离开地面
 */
public class BaseOverAll : MonoBehaviour
{
    public bool isGrounded;
    public LayerMask layerMask;


    // Update is called once per frame
    void Update()
    {
        var overlapAll = Physics2D.OverlapBoxAll(transform.position, new Vector2(1.1f, 0.4f), 0, layerMask);
        if (overlapAll.Length > 0)
        {
            isGrounded = true;
            PlayerControl.defauleJumpNum = 0;
        }
        else
        {
            isGrounded = false;
        }
    }
}
