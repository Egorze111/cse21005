using System.Collections.Generic;
using cse21005.Game.Casting;
using cse21005.Game.Services;


namespace cse21005.Game.Scripting
{
    /// <summary>
    /// <para>An output action that draws all the actors.</para>
    /// <para>The responsibility of DrawActorsAction is to draw each of the actors.</para>
    /// </summary>
    public class DrawActorsAction : Action
    {
        private VideoService _videoService;

        /// <summary>
        /// Constructs a new instance of ControlActorsAction using the given KeyboardService.
        /// </summary>
        public DrawActorsAction(VideoService videoService)
        {
            this._videoService = videoService;
        }

        /// <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {
            Biker bike1 = (Biker)cast.GetFirstActor("biker1");
            Biker bike2 = (Biker)cast.GetFirstActor("biker2");
            List<Actor> segments1 = bike1.GetSegments();
            List<Actor> segments2 = bike2.GetSegments();
            Actor score = cast.GetFirstActor("score");
//            Actor food = cast.GetFirstActor("food");
            List<Actor> messages = cast.GetActors("messages");
            
            _videoService.ClearBuffer();
            _videoService.DrawActors(segments1);
            _videoService.DrawActors(segments2);
            _videoService.DrawActor(score);
//            _videoService.DrawActor(food);
            _videoService.DrawActors(messages);
            _videoService.FlushBuffer();
        }
    }
}