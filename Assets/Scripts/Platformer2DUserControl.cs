using System;
using UnityEngine;
namespace UnityStandardAssets._2D
{
    [RequireComponent(typeof (PlatformerCharacter2D))]
    public class Platformer2DUserControl : MonoBehaviour
    {
        private PlatformerCharacter2D Character;
        private bool Jump;


        private void Awake()
        {
            Character = GetComponent<PlatformerCharacter2D>();
        }


        private void Update()
        {
            if (!Jump)
            {
                Jump = Input.GetButtonDown("Jump");

            }
        }


        private void FixedUpdate()
        {
            Character.Move(1, false, Jump);
            Jump = false;
        }
    }
}
