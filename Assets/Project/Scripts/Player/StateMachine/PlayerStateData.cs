using Project.Scripts.StateMachine;
using UnityEngine;

namespace Project.Scripts.Player.StateMachine
{
    public class PlayerStateData : ObjectStateData
    {
        #region fields
        
        [SerializeField] public IntVariable playerHealth;
        [SerializeField] public IntConstant playerMaximumHealth;
        [SerializeField] public GameObjectVariable currentTarget;
        [SerializeField] public FloatVariable playerMoveSpeed;
        [SerializeField] public Collider2DVariable playerScannerCollider;
        
        private Transform _playerTransform;

        #endregion
        
        #region properties
        
        public Rigidbody2D PlayerRigidBody2D { get; private set; }

        public Vector2 CurrentTargetPosition { get; private set; }

        public Vector2 PlayerPosition { get; private set; }

        #endregion
        
        #region methods
        
        private void Awake()
        {
            _playerTransform = GetComponent<Transform>();
            PlayerPosition = _playerTransform.position;
            PlayerRigidBody2D = GetComponent<Rigidbody2D>();
            CurrentTargetPosition = currentTarget.Value.transform.position;
        }
        
        #endregion
    }
}