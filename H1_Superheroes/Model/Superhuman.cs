using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Superheroes
{
    /// <summary>
    /// Class <see cref="Superhuman"/> represents a superhuman and contains attributes that define a superhuman
    /// </summary>
    internal class Superhuman
    {
        private string _identity;
        private Ability[] _abilities;
        private string[] _equipment;
        private string[] _suit;
        private string[] _league;
        private string _moralCode;
        private Superhuman _archenemy;
        private string _backgroundStory;

        /// <summary>
        /// Name of the superhuman
        /// </summary>
        public string Identity
        {
            get { return _identity; }
            set { _identity = value; }
        }
        public Ability[] Abilities
        {
            get { return _abilities; }
            set { _abilities = value; }
        }
        public string[] Equipment
        {
            get { return _equipment; }
            set { _equipment = value; }
        }
        public string[] Suit
        {
            get { return _suit; }
            set { _suit = value; }
        }
        public string[] League
        {
            get { return _league; }
            set { _league = value; }
        }
        public string MoralCode
        {
            get { return _moralCode; }
            set { _moralCode = value; }
        }
        public Superhuman Archenemy
        {
            get { return _archenemy; }
            set { _archenemy = value; }
        }

        /// <summary>
        /// Story of the superhuman, and the daily problems they have.
        /// </summary>
        public string BackgroundStory
        {
            get { return _backgroundStory; }
            set { _backgroundStory = value; }
        }
    }
}
