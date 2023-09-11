using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Superheroes
{
    /// <summary>
    /// Class <see cref="Ability"/> represents a ability or abilities which a superhuman would be able to have
    /// </summary>
    internal class Ability
    {
        #region Fields
        private string _name;
        private string _description;
        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="Ability"/> class, using multiple arguments
        /// </summary>
        /// <param name="name">name of ability</param>
        /// <param name="description">description of ability</param>
        public Ability(string name, string description)
        { 
            _name = name;
            _description = description;
        }

        #region Properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        #endregion
    }
}
