using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class creditsPopup : MonoBehaviour
{
    public TextMeshProUGUI creditsText; 
    [SerializeField] private List<string> names = new List<string>(); // รายชื่อ
    private bool creditsVisible = false; // เช็คว่าโชว์เครดิตอยู่ไหม

    public void OnBackgroundClick()
    {
        if (!creditsVisible)
        {
            // เรียก
            string displayText = "Credits:\n\n" + string.Join("\n", names.ToArray());
            creditsText.text = displayText;
            creditsVisible = true;
        }
        else
        {
            // ซ่อน
            creditsText.text = "";
            creditsVisible = false;
        }
    }
}