﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieExample
{
    /// <summary>
    /// A die
    /// </summary>
    internal class Die
    {
        #region Fields

        int numSides;
        int topSide;
        Random rand = new Random();

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor for six-sided die
        /// </summary>
        public Die() : this(6)
        {
        }

        /// <summary>
        /// Constructor for die with numSides side
        /// </summary>
        /// <param name="numSides">number of sides</param>
        public Die(int numSides)
        {
            this.numSides = numSides;
            topSide = 1;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the number of sides
        /// </summary>
        public int NumSides
        {
            get { return numSides; }
        }

        /// <summary>
        /// Gets the top side
        /// </summary>
        public int TopSide
        {
            get { return topSide; }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Rolls the die
        /// </summary>
        public void Roll()
        {
            topSide = rand.Next(1, numSides + 1);
        }

        #endregion
    }
}
