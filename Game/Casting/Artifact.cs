namespace Unit04.Game.Casting
{
    /// <summary>
    /// <para>An item of cultural or historical interest.</para>
    /// <para>
    /// The responsibility of an Artifact is to provide a message about itself.
    /// </para>
    /// </summary>
    public class Artifact : Actor
    {
        private string symbol = "";

        /// <summary>
        /// Constructs a new instance of an Artifact.
        /// </summary>
        public Artifact()
        {
        }

        /// <summary>
        /// Gets the artifact's symbol.
        /// </summary>
        /// <returns>The symbol.</returns>
        public string GetSymbol()
        {
            return symbol;
        }

        /// <summary>
        /// Sets the artifact's symbol to the given value.
        /// </summary>
        /// <param name="number">1 for gem. Any other value for rock</param>
        public void SetSymbol(int number)
        {
            if(number == 1)
            {
                symbol = "$";
            }
            else
            {
                symbol = "*";
            }
        }
    }
}