using UnityEngine;
using UnityEngine.UI;

public class ShovelCounter : MonoBehaviour
{
    Text text;
    public int shovels_count;
    void Start()
    {
        shovels_count = 30;
        text = GetComponent<Text>();
        text.text = "Shovels left : " + shovels_count;
    }

    public void ChangeShovels()
    {
        shovels_count--;
        text.text = "Shovels left : " + shovels_count;
    }
}
