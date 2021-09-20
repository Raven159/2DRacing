using UnityEngine;
using System;


[CreateAssetMenu(fileName = "Item", menuName = "Item", order = 1)]
[Serializable]
public class ItemConfig : ScriptableObject
{
    public int id;
    public string title;
}