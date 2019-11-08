using UnityEngine;

public class Player : MonoBehaviour
{
    // 定義欄位 Field
    //欄位類型 欄位名稱(指定 值)結尾
    [Header("速度"), Range(0f, 100f)]
    public float speed = 3.5f;   // 浮點數
    [Header("跳躍"), Range(100, 2000)]
    public int jump = 300;    //整數
    [Header("是否在地板上"), Tooltip("用來判定角色是否在地板上。")]
    public bool isGround = false; //布林值 - true false 
    [Header("角色名稱")]
    public string _name = "Az";  //字串 需要雙引號
}