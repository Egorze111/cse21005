using cse21005.Game.Casting;
using cse21005.Game.Directing;
using cse21005.Game.Scripting;
using cse21005.Game.Services;
using cse21005.Game;

namespace cse21005
{
    /// <summary>
    /// The program's entry point.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Starts the program using the given arguments.
        /// </summary>
        /// <param name="args">The given arguments.</param>
        static void Main(string[] args)
        {
            // create the cast
            Cast cast = new Cast();
            //  cast.AddActor("food", new Food());
            cast.AddActor("biker1", new Biker(Constants.CELL_SIZE*5, Constants.PURPLE)); 
            cast.AddActor("biker2", new Biker(Constants.MAX_X - Constants.CELL_SIZE*5, Constants.PURPLE));
            Biker biker2 = (Biker)cast.GetFirstActor("biker2");
            Point direction = new Point(-Constants.CELL_SIZE, 0);
            biker2.TurnHead(direction);
            cast.AddActor("score", new Score());

            // create the services
            KeyboardService keyboardService = new KeyboardService();
            VideoService videoService = new VideoService(false);
           
            // create the script
            Script script = new Script();
            script.AddAction("input", new ControlActorsAction(keyboardService));
            script.AddAction("update", new MoveActorsAction());
            script.AddAction("update", new HandleCollisionsAction());
            script.AddAction("output", new DrawActorsAction(videoService));

            // start the game
            Director director = new Director(videoService);
            director.StartGame(cast, script);
        }
    }
}