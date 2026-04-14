using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.interfaces
{
    public interface IWalkAway
    {
        void WalkAway(Player player);

    }

    public static class WalkAwayExtensions
    {
        public static void WalkAwayWithReason(this IWalkAway walker, Player player, string reason)
        {
            // call existing behavior
            walker.WalkAway(player);
            // additional logic based on reason
        }
    }
}
