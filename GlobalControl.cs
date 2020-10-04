using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalControl : MonoBehaviour
{
    public static GlobalControl Instance;

    public bool introComplete;

    public Instrument keyboard;
    public Instrument flute;
    public Instrument guitar;
    public Instrument mic;
    public Instrument clock;
    public Instrument hammer;
    public Instrument pan;
    public Instrument omni;

    public Dictionary<string, Instrument> globalInventory;
    public Dictionary<string, string> finalInventory;

    public int nanoDialog;
    public bool dialogEnd;

    public bool nanoHelp;
    public bool frogHelp;
    public bool mantisHelp;
    public bool otterHelp;

    public List<string> finalBand;
    public List<string> finalNPC;


    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }

        nanoDialog = 0;

        finalBand = new List<string>();
        finalNPC = new List<string>();

        keyboard = gameObject.AddComponent<Instrument>();
        flute = gameObject.AddComponent<Instrument>();
        guitar = gameObject.AddComponent<Instrument>();
        mic = gameObject.AddComponent<Instrument>();
        clock = gameObject.AddComponent<Instrument>();
        hammer = gameObject.AddComponent<Instrument>();
        pan = gameObject.AddComponent<Instrument>();
        omni = gameObject.AddComponent<Instrument>();


        keyboard.inst_name = "keyboard";
        keyboard.acquired = false;
        keyboard.songNum = 0;

        flute.inst_name = "flute";
        flute.acquired = false;
        flute.songNum = 0;

        guitar.inst_name = "guitar";
        guitar.acquired = false;
        guitar.songNum = 0;

        mic.inst_name = "mic";
        mic.acquired = false;
        mic.songNum = 0;

        clock.inst_name = "clock";
        clock.acquired = false;
        clock.songNum = 0;

        hammer.inst_name = "hammer";
        hammer.acquired = false;
        hammer.songNum = 0;

        pan.inst_name = "pan";
        pan.acquired = false;
        pan.songNum = 0;

        omni.inst_name = "omni";
        omni.acquired = false;
        omni.songNum = 0;



        globalInventory = new Dictionary<string, Instrument>();
        finalInventory = new Dictionary<string, string>();

        globalInventory.Add("keyboard", keyboard);
        globalInventory.Add("flute", flute);
        globalInventory.Add("guitar", guitar);
        globalInventory.Add("mic", mic);
        globalInventory.Add("clock", clock);
        globalInventory.Add("hammer", hammer);
        globalInventory.Add("pan", pan);
        globalInventory.Add("omni", omni);


    }

    public void AddBandmate( string inst )
    {
        finalBand.Add(inst);

        finalInventory.Add(inst, inst);

    }

    public void AddNPC( string npc )
    {
        finalNPC.Add(npc);
    }

    /*

    public List<string> ImageSort()
    {
        List<string> instruments = new List<string>();

        foreach (KeyValuePair<string, Instrument> inst in globalInventory)
        {
            if (inst.Value.acquired)
            {
                instruments.Add(inst.Value.name);
            }
        }

        return instruments;
    }
    */


}
