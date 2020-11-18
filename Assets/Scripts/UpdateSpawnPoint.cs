using System.Collections;
using System.Collections.Generic;
using Platformer.Core;
using Platformer.Model;
using UnityEngine;

namespace Platformer.Gameplay
{
    /// <summary>
    /// Fired when the player has died.
    /// </summary>
    /// <typeparam name="PlayerDeath"></typeparam>
    public class UpdateSpawnPoint : Simulation.Event<UpdateSpawnPoint>
    {
        PlatformerModel model = Simulation.GetModel<PlatformerModel>();
        public Transform newPos;
        public override void Execute()
        {
            model.spawnPoint = newPos;

        }
    }
}