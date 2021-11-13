using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{

    [SerializeField]
    private TMP_Text lifeStat, vitalityStat, attackStat, defenseStat;

    void Update()
    {
        Player player = FindObjectOfType<Player>();
        lifeStat.text = "Life: " + player.myStats.Life;
        vitalityStat.text = "Vitality: " + player.myStats.Vitality;
        attackStat.text = "Attack: " + player.myStats.Attack;
        defenseStat.text = "Defense: " + player.myStats.Defense;
    }

    public void RandomizeStats()
    {
        Player player = FindObjectOfType<Player>();
        player.myStats.Life = Random.Range(40, 120);
        player.myStats.Vitality = Random.Range(40, 120);
        player.myStats.Attack = Random.Range(40, 120);
        player.myStats.Defense = Random.Range(40, 120);
    }

}