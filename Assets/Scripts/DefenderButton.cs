using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour
{
    private void OnMouseDown()
    {
        var buttons = FindObjectsOfType<DefenderButton>();
        foreach (DefenderButton button in buttons)
        {
            button.ChangeButtonColor(new Color32(108, 108, 108, 108));
        }

        ChangeButtonColor(Color.white);
    }

    private void ChangeButtonColor(Color color)
    {
        GetComponent<SpriteRenderer>().color = color;
    }
}
