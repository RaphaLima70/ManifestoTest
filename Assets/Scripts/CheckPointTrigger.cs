using System.Collections;
using System.Collections.Generic;
using Platformer.Gameplay;
using UnityEngine;
using static Platformer.Core.Simulation;

namespace Platformer.Mechanics
{
    public class CheckPointTrigger : MonoBehaviour
    {
        internal Collider2D _collider; 

        void Awake()
        {
            _collider = GetComponent<Collider2D>();
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            var player = collision.gameObject.GetComponent<PlayerController>();
            if (player != null)
            {
                _collider.enabled = false;
                var ev = Schedule<UpdateSpawnPoint>();
                ev.newPos = transform;
            }
        }
    }
}