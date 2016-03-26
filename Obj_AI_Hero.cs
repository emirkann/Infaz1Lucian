using System;
using EloBuddy;

namespace InfazLucian
{
    internal class Obj_AI_Hero
    {
        public string ChampionName { get; internal set; }
        public float Health { get; internal set; }
        public object HPBarPosition { get; internal set; }
        public bool IsAlly { get; internal set; }
        public float MaxHealth { get; internal set; }
        public object Position { get; internal set; }

        public static implicit operator Obj_AI_Hero(AIHeroClient v)
        {
            throw new NotImplementedException();
        }
    }
}