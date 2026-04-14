using System;
using System.Collections.Generic;

namespace Casino
{
    public abstract class Game
    {
        private List<Player> _player = new List<Player>();
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();
        public List<Player> Player { get { return _player; } set { _player = value; } }

        public string Name { get; set; }
    public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }

        public abstract void Play();

        public virtual void ListPlayers()
        {
            foreach (Player player in Player)
            {
                Console.WriteLine(player.Name);

            }
        }
    }
}
