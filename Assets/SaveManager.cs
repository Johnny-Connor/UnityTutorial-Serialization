using UnityEngine;
using System.IO;
using System.Runtime.Serialization;
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
        try
        {
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(file, player.myStats);
        }
        catch (SerializationException error)
        {
            Debug.LogError("Error serializing data: " + error.Message);
        }
        finally
        {
            file.Close();
        }
    }

    public void Load()
    {
        FileStream file = new FileStream(Application.persistentDataPath + "/Player.dat", FileMode.Open);
        try
        {
            BinaryFormatter formatter = new BinaryFormatter();
            player.myStats = (Stats)formatter.Deserialize(file); //or "[...] as Stats"
        }
        catch (SerializationException error)
        {
            Debug.LogError("Error deserializing data: " + error.Message);
        }
        finally
        {
            file.Close();
        }
    }

}
