using System;

namespace Coordination.ESF_1
{
    public static class Interaction
    {
        [ThreadStatic]
        private static InteractionModes mode = InteractionModes.NotSet;

        public static InteractionModes Mode
        {
            get => mode;
            internal set => mode = value;
        }
    }
}