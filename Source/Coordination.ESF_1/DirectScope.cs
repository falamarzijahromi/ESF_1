using System;

namespace Coordination.ESF_1
{
    public class DirectScope : IDisposable
    {
        private DirectScope()
        {
            Interaction.Mode = InteractionModes.Direct;
        }

        public static DirectScope Begin()
        {
            return new DirectScope();
        }

        public void Dispose()
        {
            Interaction.Mode = InteractionModes.NotSet;
        }
    }
}
