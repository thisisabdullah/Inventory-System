using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int playersHp;
    private int playersXp;

    public TMP_Text hpText;
    public TMP_Text xpText;

    public static GameManager instance;

    private void Awake()
    {
        instance = this;
    }

    public void IncreaseHealth(int value)
    {
        playersHp += value;
        hpText.text = playersHp.ToString() + " HP";
    }

    public void IncreaseXp(int value)
    {
        playersXp += value;
        xpText.text = playersXp.ToString() + " XP";
    }
}
