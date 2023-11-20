using System.Linq;
using UnityEngine;

namespace Braindrops.Unolith.Utility
{
    public class BehaviourGroupActivator : ObjectActivator
    {
        private Behaviour[] behaviours;

        public BehaviourGroupActivator(Behaviour[] behaviours)
        {
            this.behaviours = behaviours;
        }

        public void Activate()
        {
            foreach (var behaviour in behaviours)
                behaviour.enabled = true;
        }

        public void Deactivate()
        {
            foreach (var behaviour in behaviours)
                behaviour.enabled = false;
        }
    }
}