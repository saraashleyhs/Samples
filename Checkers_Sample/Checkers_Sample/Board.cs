using System;
using System.Collections.Generic;
using System.Linq;

namespace Checkers_Sample
{
    #region Board Class
    public class Board
    {
        public List<Checker> checkers { get; private set; }

        #region Constructor
        public Board()
        {
            checkers = new List<Checker>();
            for (int r = 0; r < 3; r++)
            {
                for (int i = 0; i < 8; i += 2)
                {
                    // the first three rows are for White checkers (row = 0,1,2)

                    Checker c = new Checker(Color.White, r, (r + 1) % 2 + i);
                    checkers.Add(c);
                }
                for (int i = 0; i < 8; i += 2)
                {
                    // the last three rows are for Black checkers (row=5,6,7)
                    Checker c = new Checker(Color.Black, (r + 5), r % 2 + i);
                    checkers.Add(c);
                }

                ///NOTE: Can we combine the two "for" loops above into one "for" loop?


            }
        }
        #endregion

        #region Methods
        public Checker GetChecker(Position source)
        {
            
            foreach (Checker c in checkers)
            {
                //Fill in the blanks in the if statement below
                if (c.Position.Row == (______) && c.Position.Column == (______))
                {
                    return c;
                }
            }
            //make sure all code paths return a value; what happens if the above condition is not met.  Can the method return a Checker?

        }

        public void MoveChecker(Checker checker, Position destination)
        {
            Checker c = new Checker(checker.Team, destination.Row, destination.Column);
            //Add the checker to our list of checkers.
            checkers.Remove(checker);
        }

        public void RemoveChecker(Checker checker)
        {
            //Fill in the blank in the logic
            if (checker (___) null)
            {
                //Remove the checker from our list of checkers.
            }
        }

        #endregion
    }

    #endregion


}