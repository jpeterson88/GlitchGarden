﻿using UnityEngine;
using UnityEngine.UI;

public class StarDisplay : MonoBehaviour
{
    [SerializeField] int stars = 100;
    Text starText;

    void Start()
    {
        starText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        starText.text = stars.ToString();
    }

    public void AddStars(int starsToAdd)
    {
        stars += starsToAdd;
        UpdateDisplay();
    }

    public void SpendStars(int starsToSpend)
    {
        if (stars >= starsToSpend)
        {
            stars -= starsToSpend;
            UpdateDisplay();
        }
    }
}
