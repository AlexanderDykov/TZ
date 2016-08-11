using System;
using UnityEngine;
using System.Collections;

[CreateAssetMenu(menuName = "Create Custom Settings")]
public class Settings : ScriptableObject
{
    public String characterName = "Test";
    public Sprite icon;
    public Color characterColor = Color.white;
}
