using UnityEngine;

[System.Serializable]
public class Stats
{

    [SerializeField]
    private int life, vitality, attack, defense;

    public int Life
    {
        get { return life; }
        set { life = value; }
    }

    public int Vitality
    {
        get { return vitality; }
        set { vitality = value; }
    }

    public int Attack
    {
        get { return attack; }
        set { attack = value; }
    }

    public int Defense
    {
        get { return defense; }
        set { defense = value; }
    }

}
