using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoGameList.Models
{
    interface IVideoGameUnitOfWork
    {
        Repository<VideoGame> Games { get; }
        Repository<ESRB> ESRB { get; }
        void Save();
    }
}
