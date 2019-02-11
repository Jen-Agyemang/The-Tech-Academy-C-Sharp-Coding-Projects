﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class Game
    {
        public List<Player> Players { get; set; } = new List<Player>();

        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get; set; } = new Dictionary<Player, int>();
        public abstract void Play();

        public virtual void ListPlayers()

        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }

    }
}
