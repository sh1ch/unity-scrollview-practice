using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    [SerializeField]
    private Text _Text;

    public void Click()
    {
        var name = _Text?.text ?? "no name";

        Debug.Log($"Clicked {name}.");
    }
}
