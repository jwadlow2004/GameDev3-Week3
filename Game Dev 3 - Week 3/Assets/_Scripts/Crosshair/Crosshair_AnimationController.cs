using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDevWithMarco.Crosshair
{
    public class Crosshair_AnimationController : MonoBehaviour
    {
        private Animator animVariable;

        // Start is called before the first frame update
        void Start()
        {
            animVariable = GetComponent<Animator>();
        }


        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                FireAnimation();
            }
        }

        public void FireAnimation()
        {
            animVariable.SetTrigger("Shoot");
        }
    }
}