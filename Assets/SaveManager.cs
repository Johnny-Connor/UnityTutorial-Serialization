using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveManager : MonoBehaviour
{

    private Player player;

    private void Awake()
    {
        player = GameObject.FindObjectOfType<Player>();
    }

    public void Save()
    {
        FileStream file = new FileStream(Application.persistentDataPath + "/Player.dat", FileMode.OpenOrCreate);
        BinaryFormatter formatter = new BinaryFormatter();
        formatter.Serialize(file, player.myStats);
        file.Close();
    }

    public void Load()
    {
        FileStream file = new FileStream(Application.persistentDataPath + "/Player.dat", FileMode.Open);
        BinaryFormatter formatter = new BinaryFormatter();
        player.myStats = (Stats) formatter.Deserialize(file); //or "[...] as Stats"
        file.Close();
    }

}
