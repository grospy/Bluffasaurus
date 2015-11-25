﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasHoldem.AI.SmartPlayer.Helpers
{
    using Logic.Cards;
    using Logic.Helpers;

    public class CardsStrengthEvaluation
    {
        public static int RateCards(IEnumerable<Card> cards)
        {
            var evaluator = new HandEvaluator();
            var strength = (int)evaluator.GetBestHand(cards).RankType;

            return strength;
        }
    }
}
