using Project.Scripts.Player.StateMachine;
using UnityEngine;

namespace Project.Scripts.Player.Actions
{
    [CreateAssetMenu(menuName = "StateMachine/Player/Actions/PlayerChase")]
    public class PlayerChase : PlayerAction
    {
        public override void Act(PlayerStateData data)
        {
            data.PlayerRigidBody2D.velocity = (data.CurrentTargetPosition - data.PlayerPosition).normalized *
                                              data.playerMoveSpeed.Value;
        }
    }
}