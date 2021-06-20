using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Roundbeargames
{
    public class PlayerInput : MonoBehaviour
    {
        public SavedKeys savedKeys;

        void Update()
        {
            //VirtualInputManager.Instance.Turbo = Input.GetKey(VirtualInputManager.Instance.DicKeys[InputKeyType.KEY_TURBO]);
            //VirtualInputManager.Instance.MoveUp = Input.GetKey(VirtualInputManager.Instance.DicKeys[InputKeyType.KEY_MOVE_UP]);
            //VirtualInputManager.Instance.MoveDown = Input.GetKey(VirtualInputManager.Instance.DicKeys[InputKeyType.KEY_MOVE_DOWN]);
            //VirtualInputManager.Instance.MoveLeft = Input.GetKey(VirtualInputManager.Instance.DicKeys[InputKeyType.KEY_MOVE_LEFT]);
            //VirtualInputManager.Instance.MoveRight = Input.GetKey(VirtualInputManager.Instance.DicKeys[InputKeyType.KEY_MOVE_RIGHT]);
            VirtualInputManager.Instance.Turbo = (Input.GetAxis("Run") >= 1);
            VirtualInputManager.Instance.MoveUp = (Input.GetAxis("Vertical") >= 1);
            VirtualInputManager.Instance.MoveDown = (Input.GetAxis("Vertical") <= -1) || Input.GetKey(VirtualInputManager.Instance.DicKeys[InputKeyType.KEY_JUMP]);
            VirtualInputManager.Instance.MoveLeft = (Input.GetAxis("Horizontal") <= -1);
            VirtualInputManager.Instance.MoveRight = (Input.GetAxis("Horizontal") >= 1);            
            //VirtualInputManager.Instance.Jump = Input.GetKey(VirtualInputManager.Instance.DicKeys[InputKeyType.KEY_JUMP]);
            VirtualInputManager.Instance.Block = Input.GetKey(VirtualInputManager.Instance.DicKeys[InputKeyType.KEY_BLOCK]);
            VirtualInputManager.Instance.Attack = Input.GetKey(VirtualInputManager.Instance.DicKeys[InputKeyType.KEY_ATTACK]) || Input.GetKey(VirtualInputManager.Instance.DicKeys[InputKeyType.KEY_JUMP]) && !VirtualInputManager.Instance.Turbo;
        }
    }
}