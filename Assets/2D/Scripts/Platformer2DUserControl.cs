using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets._2D
{
    [RequireComponent(typeof (PlatformerCharacter2D))]
    public class Platformer2DUserControl : MonoBehaviour
    {
        private PlatformerCharacter2D m_Character;
        private bool m_Jump;
        private GameObject _goal;
        private Serial _serial;

        void Start() {
            _goal = GameObject.Find("Goal");
            _serial = _goal.GetComponent<Serial>();
            InvokeRepeating("checkJump", 0.1f, 0.1f);
        }


        private void Awake()
        {
            m_Character = GetComponent<PlatformerCharacter2D>();
        }


        private void Update()
        {
            if (!m_Jump)
            {
                // Read the jump input in Update so button presses aren't missed.
                m_Jump = CrossPlatformInputManager.GetButtonDown("Jump");
            }
        }


        private void FixedUpdate()
        {
            // Read the inputs.
            bool crouch = Input.GetKey(KeyCode.LeftControl);
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            // Pass all parameters to the character control script.
            m_Character.Move(1, crouch, m_Jump);
            m_Jump = false;
        }

        private void checkJump() {
            if(!m_Jump) {
                if(this._serial.GetLastLine() == "jump") {
                    bool crouch = Input.GetKey(KeyCode.LeftControl);
                    m_Character.Move(1, crouch, true);
                }
            }
        }
    }
}
