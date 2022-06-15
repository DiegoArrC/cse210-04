namespace Unit04.Game.Casting
{
    /// <summary>
    /// <para>
    /// The responsibility of Scorekeeper is to keep track of the players score
    /// </para>
    /// </summary>
    public class Scorekeeper
    {
        private int score;
        public Scorekeeper()
        {
            score = 0;
        }

        public int getScore()
        {
            return score;
        }

        public void updateScore(Actor actor) // We can think about using something other than hard coded values for the symbols to make the code more maintainable. This way if it's updated in the Artifacts class, it updates here too. 
        {
            string symbol = actor.GetText();
            if (symbol == "$")
            {
                score += 1;
            }
            else if (symbol == "*")
            {
                score -= 1;
            }
        }

    }
}