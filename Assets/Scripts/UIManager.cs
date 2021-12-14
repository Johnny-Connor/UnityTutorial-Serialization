using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{

    [SerializeField]
    private TMP_Text lifeStat, vitalityStat, attackStat, defenseStat;
    [SerializeField]
    private TMP_Text posX, posY, posZ;

    void Update()
    {
        Player player = FindObjectOfType<Player>();
        lifeStat.text = "Life: " + player.myStats.Life;
        vitalityStat.text = "Vitality: " + player.myStats.Vitality;
        attackStat.text = "Attack: " + player.myStats.Attack;
        defenseStat.text = "Defense: " + player.myStats.Defense;
        posX.text = "X: " + player.myStats.myPos.x;
        posY.text = "Y: " + player.myStats.myPos.y;
        posZ.text = "Z: " + player.myStats.myPos.z;
    }

    public void RandomizeStats()
    {
        Player player = FindObjectOfType<Player>();
        player.myStats.Life = Random.Range(40, 120);
        player.myStats.Vitality = Random.Range(40, 120);
        player.myStats.Attack = Random.Range(40, 120);
        player.myStats.Defense = Random.Range(40, 120);
        player.myStats.myPos.x = Random.Range(-4.35f, 4.35f);
        player.myStats.myPos.y = Random.Range(-2.3f, 2.3f);
        player.myStats.myPos.z = Random.Range(0f, 3);
    }

}