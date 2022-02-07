using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject ui_thing;

    public void Show()
    {
        ui_thing.SetActive(!ui_thing.activeInHierarchy);
    }
}
