using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class PlayerInput : ScriptableObject
{
    public string Jump;
    public string Vertical;
    public string Horizontal;
    public KeyCode Action;
    public KeyCode Attack;
}
