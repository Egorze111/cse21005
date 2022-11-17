using System;
using System.Collections.Generic;
using System.Data;
using cse21005.Game.Casting;
using cse21005.Game.Services;


namespace cse21005.Game.Scripting
{
    /// <summary>
    /// <para>An update action that handles interactions between the actors.</para>
    /// <para>
    /// The responsibility of HandleCollisionsAction is to handle the situation when the snake 
    /// collides with the food, or the snake collides with its segments, or the game is over.
    /// </para>
    /// </summary>
    public class HandleCollisionsAction : Action
    {
        private bool _isGameOver = false;

        /// <summary>
        /// Constructs a new instance of HandleCollisionsAction.
        /// </summary>
        public HandleCollisionsAction()
        {
        }

        /// <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {
            if (_isGameOver == false)
            {
                // HandleFoodCollisions(cast);
                HandleSegmentCollisions(cast);
                HandleGameOver(cast);
            }
        }

        /// <summary>
        /// Updates the score nd moves the food if the snake collides with it.
        /// </summary>
        /// <param name="cast">The cast of actors.</param>
        //// keep this commented until we're ready to do powerups
        // private void HandleFoodCollisions(Cast cast)
        // {
        //     Snake snake = (Snake)cast.GetFirstActor("snake");
        //     Score score = (Score)cast.GetFirstActor("score");
        //     Food food = (Food)cast.GetFirstActor("food");
            
        //     if (snake.GetHead().GetPosition().Equals(food.GetPosition()))
        //     {
        //         int points = food.GetPoints();
        //         score.AddPoints(points);
        //         food.Reset();
        //     }
        // }

        /// <summary>
        /// Sets the game over flag if the bikers collide with themselves or the other bike.
        /// </summary>
        /// <param name="cast">The cast of actors.</param>
        private void HandleSegmentCollisions(Cast cast)
        {
            Biker bike1 = (Biker)cast.GetFirstActor("biker1");
            Actor head1 = bike1.GetHead();
            List<Actor> body1 = bike1.GetBody();
            
            Biker bike2 = (Biker)cast.GetFirstActor("biker2");
            Actor head2 = bike2.GetHead();
            List<Actor> body2 = bike2.GetBody();

            foreach (Actor segment1 in body1)
            {
                if (segment1.GetPosition().Equals(head1.GetPosition()))
                {
                    _isGameOver = true;
                }
                else if (segment1.GetPosition().Equals(head2.GetPosition()))
                {
                    _isGameOver = true;
                }
            }

            foreach (Actor segment2 in body2)
            {
                if (segment2.GetPosition().Equals(head2.GetPosition()))
                {
                    _isGameOver = true;
                }
                else if (segment2.GetPosition().Equals(head1.GetPosition()))
                {
                    _isGameOver = true;
                }
            }
        }

        private void HandleGameOver(Cast cast)
        {
            if (_isGameOver == true)
            {
                Biker bike1 = (Biker)cast.GetFirstActor("biker1");
                List<Actor> segments1 = bike1.GetSegments();
                Biker bike2 = (Biker)cast.GetFirstActor("biker2");
                List<Actor> segments2 = bike2.GetSegments();
                // Food food = (Food)cast.GetFirstActor("food");

                // create a "game over" message
                int x = Constants.MAX_X / 2;
                int y = Constants.MAX_Y / 2;
                Point position = new Point(x, y);

                Actor message = new Actor();
                message.SetText("Game Over!");
                message.SetPosition(position);
                cast.AddActor("messages", message);

                // make everything white
                foreach (Actor segment1 in segments1)
                {
                    segment1.SetColor(Constants.WHITE);
                }
                
                foreach (Actor segment2 in segments2)
                {
                    segment2.SetColor(Constants.WHITE);
                }
//                food.SetColor(Constants.WHITE);
            }
        }

    }
}