using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotivy.Interfaces
{
    interface iPlayable
    {
        void Play();
        void Pause();
        void Next();
        void Stop();
        int Length { get; }
    }
}
