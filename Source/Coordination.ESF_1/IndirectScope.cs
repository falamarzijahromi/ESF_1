using System;

namespace Coordination.ESF_1
{
    public class IndirectScope : IDisposable
    {
        private IndirectScope()
        {
            Interaction.Mode = InteractionModes.Indirect;
        }

        public static IndirectScope Begin()
        {
            return new IndirectScope();
        }

        public void Dispose()
        {
            Interaction.Mode = InteractionModes.NotSet;
        }
    }
}
