using UnityEngine;

// Classes must receive the "Serializable" attribute in order to be serialized.
[System.Serializable]
public struct SerializableVector3
{

    public float x;
    public float y;
    public float z;

    public Vector3 GetPos()
    {
        return new Vector3(x, y, z);
    }

}

[System.Serializable]
public class Stats
{

    [SerializeField]
    private int life, vitality, attack, defense;

    public SerializableVector3 myPos;

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
