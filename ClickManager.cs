using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManager : MonoBehaviour
{

    public static void NanoFirstInteraction()
    {
        GlobalControl.Instance.nanoDialog = 0;
    }

    public static void SetKeyboardStatus()
    {
        GlobalControl.Instance.globalInventory["keyboard"].acquired = true;
        //Debug.Log(GlobalControl.Instance.globalInventory["keyboard"].acquired);

    }

    public static void SetFluteStatus()
    {
        GlobalControl.Instance.globalInventory["flute"].acquired = true;
    }

    public static void SetMicStatus()
    {
        GlobalControl.Instance.globalInventory["mic"].acquired = true;
    }

    public static void SetGuitarStatus()
    {
        GlobalControl.Instance.globalInventory["guitar"].acquired = true;
    }

    public static void SetClockStatus()
    {
        GlobalControl.Instance.globalInventory["clock"].acquired = true;
    }

    public static void SetHammerStatus()
    {
        GlobalControl.Instance.globalInventory["hammer"].acquired = true;
    }

    public static void SetPanStatus()
    {
        GlobalControl.Instance.globalInventory["pan"].acquired = true;
    }

    public static void SetOmniStatus()
    {
        GlobalControl.Instance.globalInventory["omni"].acquired = true;
    }

}
