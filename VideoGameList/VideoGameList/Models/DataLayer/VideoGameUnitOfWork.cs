using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoGameList.Models
{
    public class VideoGameUnitOfWork : IVideoGameUnitOfWork
    {
        private VideoGameContext context { get; set; }
        public VideoGameUnitOfWork(VideoGameContext ctx) => context = ctx;
        Repository<VideoGame> gameData;
        Repository<ESRB> esrbData;
        public Repository<VideoGame> Games
        {
            get
            {
                if (gameData == null)
                    gameData = new Repository<VideoGame>(context);
                return gameData;
            }
        }
        public Repository<ESRB> ESRB
        {
            get
            {
                if (esrbData == null)
                    esrbData = new Repository<ESRB>(context);
                return esrbData;
            }
        }
        public void Save() => context.SaveChanges();
    }
}
