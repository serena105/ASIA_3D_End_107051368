using UnityEngine;

[CreateAssetMenu(fileName = "NPC 資料", menuName = "S/NPC 資料")]
public class NPCData : MonoBehaviour
{
    [Header("第一段"), TextArea(1, 5)]
    public string dialogA;
    [Header("第二段"), TextArea(1, 5)]
    public string dialogB;
    [Header("第三段"), TextArea(1, 5)]
    public string dialogC;
    [Header("需求數量")]
    public int count;
    [Header("取得數量")]
    public int countCurrent;

}
