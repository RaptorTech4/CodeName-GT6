using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MoveController))]
public class Player : MonoBehaviour {

    [System.Serializable]
    public class MouseInput
    {
        public Vector2 Damping;
        public Vector2 Sensitivity;
    }

    [SerializeField] float Speed;
    [SerializeField] MouseInput MouseControl;

    private MoveController m_moveController;
    public MoveController moveController
    {
        get
        {
            if(m_moveController == null)
            {
                m_moveController = GetComponent<MoveController>();
            }
            return m_moveController;
        }
    }
    InputController PlayerInput;

    void Awake ()
    {
        PlayerInput = GameManager.Instance.InputController;
        GameManager.Instance.LocalPlayer = this;
	}
	
	
	void Update ()
    {
        Vector2 direction = new Vector2(PlayerInput.Vertical * Speed, PlayerInput.Horizontal * Speed);
        moveController.Move(direction);
	}
}
