using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnBasedBattle : MonoBehaviour
{
    private EnterBattle EnterBattleScript = new EnterBattle();
    private BattleEnumerator.Battle currentState; //The current state of the battle

    // Use this for initialization
    void Start()
    {
        currentState = BattleEnumerator.Battle.Start;
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentState)
        {
            case (BattleEnumerator.Battle.Start):
                CreatePlayerDisplay.CreatePlayer();

                //Gives a list of enemies to be created when the battle starts, will need overhauling
                List<BaseEnemyClass> EnemyList = new List<BaseEnemyClass>();
                EnemyList.Add(new BaseSkeleton());
                EnemyList.Add(new BaseSkeleton());
                //EnterBattle.BattleStart(EnemyList);

                //Test for note generation sequence, will eventually be moved to the EnemyTurn state along with enemy AI
                CreateSequence.CreateTestSequence();

                currentState = BattleEnumerator.Battle.PlayerTurn;
                break;
            case (BattleEnumerator.Battle.PlayerTurn):
                //Setup Battle Function
                break;
            case (BattleEnumerator.Battle.EnemyTurn):
                //Setup Battle Function
                
                break;
            case (BattleEnumerator.Battle.Win):
                //Setup Battle Function
                break;
            case (BattleEnumerator.Battle.Lose):
                //Setup Battle Function
                break;
        }

    }
}
