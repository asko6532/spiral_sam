using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void OnObjectClick();
    public static event OnObjectClick onObjectClick;

    public delegate void OnExitTextBox();
    public static event OnExitTextBox onExitTextBox;

    public delegate void OnIntroComplete();
    public static event OnIntroComplete onIntroComplete;

    public delegate void OnClickPlant();
    public static event OnClickPlant onClickPlant;

    public delegate void OnStartSong();
    public static event OnStartSong onStartSong;

    public delegate void OnChangeDir();
    public static event OnChangeDir onChangeDir;

    public static void OpenTextWindow()
    {
        if ( onObjectClick != null )
        {
            onObjectClick();
        }
    }

    public static void CloseTextWindow()
    {
        if( onExitTextBox != null )
        {
            onExitTextBox();
        }
    }


    public static void SlideSnail()
    {
        if( onIntroComplete != null)
        {
            onIntroComplete();
        }
    }

    public static void MovePlant()
    {
        if( onClickPlant != null)
        {
            onClickPlant();
        }
    }

    public static void Finale()
    {
        if( onStartSong != null)
        {
            onStartSong();
        }
    }

    public static void RotateBack()
    {
        if (onChangeDir != null)
        {
            onChangeDir();
        }
    }


}
