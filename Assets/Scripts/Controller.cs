using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public PlayerControl playerControl;

    private void OnEnable()
    {
        playerControl.OnHorizontal += PlayerControl_OnHorizontal;
    }

    private void PlayerControl_OnHorizontal(float a)
    {
        transform.Translate(Vector3.right * a * Time.deltaTime);
    }
}
