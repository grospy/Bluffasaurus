﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasHoldem.Tests.GameSimulations.GameSimulators
{
    using AI.SmartPlayer;
    using Logic.Players;

    public class NotASmartVsSmarterPlayerSimulator : BaseGameSimulator
    {
        private readonly IPlayer firstPlayer = new NotASmartPlayer();
        private readonly IPlayer secondPlayer = new SmarterPlayer();

        protected override IPlayer GetFirstPlayer()
        {
            return this.firstPlayer;
        }

        protected override IPlayer GetSecondPlayer()
        {
            return this.secondPlayer;
        }
    }
}
