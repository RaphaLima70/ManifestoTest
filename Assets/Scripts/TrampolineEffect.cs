using Platformer.Core;
using Platformer.Mechanics;
using Platformer.Model;
using UnityEngine;
using static Platformer.Core.Simulation;

namespace Platformer.Gameplay
{

    /// <summary>
    /// Fired when a Player collides with an Enemy.
    /// </summary>
    /// <typeparam name="EnemyCollision"></typeparam>
    public class TrampolineEffect : Simulation.Event<TrampolineEffect>
    {
        public TrampolineTrigger trampoline;
        public PlayerController player;

        PlatformerModel model = Simulation.GetModel<PlatformerModel>();

        public override void Execute()
        {
            var willJump = player.Bounds.center.y >= trampoline.Bounds.max.y;

            if (willJump)
            {
                var enemyHealth = trampoline.GetComponent<Health>();
                player.Bounce(7);
            }
        }
    }
}