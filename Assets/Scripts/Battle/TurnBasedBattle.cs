using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnBasedBattle : MonoBehaviour
{

    private EnterBattle EnterBattleScript = new EnterBattle();


    public enum Battle //The possible states of the battle
    {
        Start,
        PlayerTurn,
        EnemyTurn,
        Lose,
        Win
    }

    private Battle currentState; //The current state of the battle

    // Use this for initialization
    void Start()
    {
        currentState = Battle.Start;
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentState)
        {
            case (Battle.Start):
                CreatePlayer();
                EnterBattleScript.BattleStart(new BaseSkeleton(), null ,new BaseSkeleton());
                currentState = Battle.PlayerTurn;
                break;
            case (Battle.PlayerTurn):
                //Setup Battle Function
                break;
            case (Battle.EnemyTurn):
                //Setup Battle Function
                
                break;
            case (Battle.Win):
                //Setup Battle Function
                break;
            case (Battle.Lose):
                //Setup Battle Function
                break;
        }

    }
    private void CreatePlayer() //Creates new BasePlayers representing current party members
    {
        BasePlayer Player1 = new BasePlayer();
        Player1.MaxHealth = GameInformation.Health1 + GameInformation.Equipment1Weapon.Health + GameInformation.Equipment1Armour.Health + GameInformation.Equipment1Accessory.Health;
        Player1.Health = Player1.MaxHealth;
        Player1.MaxMagic = GameInformation.Magic1 + GameInformation.Equipment1Weapon.Magic + GameInformation.Equipment1Armour.Magic + GameInformation.Equipment1Accessory.Magic;
        Player1.Magic = GameInformation.Magic1;
        Player1.Attack = GameInformation.Attack1 + GameInformation.Equipment1Weapon.Attack + GameInformation.Equipment1Armour.Attack + GameInformation.Equipment1Accessory.Attack;
        Player1.Defence = GameInformation.Defence1 + GameInformation.Equipment1Weapon.Defence + GameInformation.Equipment1Armour.Defence + GameInformation.Equipment1Accessory.Defence;

        if (GameInformation.Player2 == 1)
        {
            BasePlayer Player2 = new BasePlayer();
            Player2.MaxHealth = GameInformation.Health2 + GameInformation.Equipment2Weapon.Health + GameInformation.Equipment2Armour.Health + GameInformation.Equipment2Accessory.Health;
            Player2.Health = Player2.MaxHealth;
            Player2.MaxMagic = GameInformation.Magic2 + GameInformation.Equipment2Weapon.Magic + GameInformation.Equipment2Armour.Magic + GameInformation.Equipment2Accessory.Magic;
            Player2.Magic = GameInformation.Magic2;
            Player2.Attack = GameInformation.Attack2 + GameInformation.Equipment2Weapon.Attack + GameInformation.Equipment2Armour.Attack + GameInformation.Equipment2Accessory.Attack;
            Player2.Defence = GameInformation.Defence2 + GameInformation.Equipment2Weapon.Defence + GameInformation.Equipment2Armour.Defence + GameInformation.Equipment2Accessory.Defence;
        }
        if (GameInformation.Player3 == 1)
        {
            BasePlayer Player3 = new BasePlayer();
            Player3.MaxHealth = GameInformation.Health3 + GameInformation.Equipment3Weapon.Health + GameInformation.Equipment3Armour.Health + GameInformation.Equipment3Accessory.Health;
            Player3.Health = Player3.MaxHealth;
            Player3.MaxMagic = GameInformation.Magic3 + GameInformation.Equipment3Weapon.Magic + GameInformation.Equipment3Armour.Magic + GameInformation.Equipment3Accessory.Magic;
            Player3.Magic = GameInformation.Magic3;
            Player3.Attack = GameInformation.Attack3 + GameInformation.Equipment3Weapon.Attack + GameInformation.Equipment3Armour.Attack + GameInformation.Equipment3Accessory.Attack;
            Player3.Defence = GameInformation.Defence3 + GameInformation.Equipment3Weapon.Defence + GameInformation.Equipment3Armour.Defence + GameInformation.Equipment3Accessory.Defence;
        }
        if (GameInformation.Player4 == 1)
        {
            BasePlayer Player4 = new BasePlayer();
            Player4.MaxHealth = GameInformation.Health4 + GameInformation.Equipment4Weapon.Health + GameInformation.Equipment4Armour.Health + GameInformation.Equipment4Accessory.Health;
            Player4.Health = Player4.MaxHealth;
            Player4.MaxMagic = GameInformation.Magic4 + GameInformation.Equipment4Weapon.Magic + GameInformation.Equipment4Armour.Magic + GameInformation.Equipment4Accessory.Magic;
            Player4.Magic = GameInformation.Magic4;
            Player4.Attack = GameInformation.Attack4 + GameInformation.Equipment4Weapon.Attack + GameInformation.Equipment4Armour.Attack + GameInformation.Equipment4Accessory.Attack;
            Player4.Defence = GameInformation.Defence4 + GameInformation.Equipment4Weapon.Defence + GameInformation.Equipment4Armour.Defence + GameInformation.Equipment4Accessory.Defence;
        }
    }
}
