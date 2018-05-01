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
                CreatePlayerDisplay.CreatePlayer();

                //Gives a list of enemies to be created when the battle starts, will need overhauling
                var EnemyList = new List<BaseEnemyClass>();
                EnemyList.Add(new BaseSkeleton());
                EnemyList.Add(new BaseSkeleton());
                EnterBattleScript.BattleStart(EnemyList);

                //Test for note generation sequence, will eventually be moved to the EnemyTurn state along with enemy AI
                CreateSequence.CreateTestSequence();

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
}
