using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment4
{
    /// <summary>
    /// Converts words to digits
    /// </summary>
    public class Digitizer
    {
        #region Fields

        // declare your Dictionary field and create the Dictionary object for it here
        Dictionary <string,int> numbers = new Dictionary<string,int>();

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public Digitizer()
        {
            // populate your dictionary field here
            numbers.Add("zero", 0);
            numbers.Add("One", 1);
            numbers.Add("tWo", 2);
            numbers.Add("three", 3);
            numbers.Add("four", 4);
            numbers.Add("five", 5);
            numbers.Add("six", 6);
            numbers.Add("seven", 7);
            numbers.Add("eight", 8);
            numbers.Add("nine", 9);
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Converts the given word to the corresponding digit.
        /// If the word isn't a valid digit name, returns -1
        /// </summary>
        /// <param name="word">word to convert</param>
        /// <returns>corresponding digit or -1</returns>
        public int ConvertWordToDigit(string word)
        {
            if (numbers.ContainsKey(word)) 
            {
                return numbers[word];
            }
            else
            {
                return -1;
            }
        }

        #endregion
    }
}
