using UnityEngine;
using StateStuff;



public class SecondState : State<AI>
{
    //public WorldBuilder worldBuilder;

    private static SecondState _instance;


    private SecondState()
    {
        if (_instance != null)
        {
            return;
        }

        _instance = this;


    }

    public static SecondState Instance
    {
        get
        {
            if (_instance == null)
            {
                new SecondState();
            }
            return _instance;
        }
    }

    public override void EnterState(AI _Owner)
    {
        Camera.main.backgroundColor = Color.black;
       
    }

    public override void ExitState(AI _Owner)
    {
       
    }

    public override void UpdateState(AI _Owner)
    {
        if (!_Owner.switchState)
        {
            _Owner.stateMachine.ChangeState(FirstState.Instance);
        }

    }
}