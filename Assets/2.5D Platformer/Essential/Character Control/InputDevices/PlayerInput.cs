using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Roundbeargames
{
    public class PlayerInput : MonoBehaviour
    {
        public SavedKeys savedKeys;
        public string[] axisBindings;

        void Update()
        {
            //VirtualInputManager.Instance.Turbo = Input.GetKey(VirtualInputManager.Instance.DicKeys[InputKeyType.KEY_TURBO]);
            //VirtualInputManager.Instance.MoveUp = Input.GetKey(VirtualInputManager.Instance.DicKeys[InputKeyType.KEY_MOVE_UP]);
            //VirtualInputManager.Instance.MoveDown = Input.GetKey(VirtualInputManager.Instance.DicKeys[InputKeyType.KEY_MOVE_DOWN]);
            //VirtualInputManager.Instance.MoveLeft = Input.GetKey(VirtualInputManager.Instance.DicKeys[InputKeyType.KEY_MOVE_LEFT]);
            //VirtualInputManager.Instance.MoveRight = Input.GetKey(VirtualInputManager.Instance.DicKeys[InputKeyType.KEY_MOVE_RIGHT]);
            //VirtualInputManager.Instance.Jump = Input.GetKey(VirtualInputManager.Instance.DicKeys[InputKeyType.KEY_JUMP]);
            VirtualInputManager.Instance.Turbo = (Input.GetAxis(axisBindings[0]) >= 1) || Input.GetKey(KeyCode.LeftShift);
            VirtualInputManager.Instance.MoveUp = Input.GetKey(VirtualInputManager.Instance.DicKeys[InputKeyType.KEY_MOVE_UP]);
            VirtualInputManager.Instance.MoveDown = Input.GetKey(VirtualInputManager.Instance.DicKeys[InputKeyType.KEY_MOVE_DOWN]);
            VirtualInputManager.Instance.MoveLeft = (Input.GetAxis(axisBindings[2]) <= -1) || Input.GetKey(VirtualInputManager.Instance.DicKeys[InputKeyType.KEY_MOVE_LEFT]);
            VirtualInputManager.Instance.MoveRight = (Input.GetAxis(axisBindings[2]) >= 1) || Input.GetKey(VirtualInputManager.Instance.DicKeys[InputKeyType.KEY_MOVE_RIGHT]);            
            VirtualInputManager.Instance.Block = Input.GetKey(VirtualInputManager.Instance.DicKeys[InputKeyType.KEY_BLOCK]) || Input.GetKey(KeyCode.LeftArrow);
            VirtualInputManager.Instance.Attack = Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.DownArrow)
                || Input.GetKey(VirtualInputManager.Instance.DicKeys[InputKeyType.KEY_ATTACK]) 
                || Input.GetKey(VirtualInputManager.Instance.DicKeys[InputKeyType.KEY_MOVE_UP]) && !VirtualInputManager.Instance.Turbo
                || Input.GetKey(VirtualInputManager.Instance.DicKeys[InputKeyType.KEY_MOVE_RIGHT]) && !VirtualInputManager.Instance.Turbo;
        }
    }
}