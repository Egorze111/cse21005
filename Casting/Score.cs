using System;


namespace cse21005.Game.Casting
{
    /// <summary>
    /// <para>A timer for the players.</para>
    /// <para>
    /// The responsibility of Score is to keep track of how much time has passed.
    /// </para>
    /// </summary>
    public class Score : Actor
    {
        private int _points = 0;

        /// <summary>
        /// Constructs a new instance of Score.
        /// </summary>
        public Score()
        {
            AddPoints(0);
        }

        /// <summary>
        /// Adds the given points to the score.
        /// </summary>
        /// <param name="points">The points to add.</param>
        public void AddPoints(int points)
        {
            this._points += points;
            SetText($"Score: {this._points}");
        }
    }
}