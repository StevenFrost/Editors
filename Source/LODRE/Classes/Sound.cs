using System;
using System.Runtime.InteropServices;

namespace LODRadiusEditor.Sound
{
    class LODRESound : IDisposable
    {
        [DllImport("WinMM.dll")]
        public static extern bool PlaySound(string fname, int Mod, int flag);

        public int SND_ASYNC = 0x0001;     // Play asynchronously
        public int SND_FILENAME = 0x00020000; // Use file name
        public int SND_PURGE = 0x0040;     // Purge non-static events

        /// <summary>
        /// Plays the specified sound under the specified params
        /// </summary>
        /// <param name="fname">The location of the sound file</param>
        /// <param name="SoundFlags">SND_ASYNC, SND_FILENAME, SND_PURGE</param>
        public void Play(string fname, int SoundFlags)
        {
            PlaySound(fname, 0, SoundFlags);
        }

        /// <summary>
        /// Stops the sound that is currently playing
        /// </summary>
        public void StopPlay()
        {
            PlaySound(null, 0, SND_PURGE);
        }

        /// <summary>
        /// Disposes of the class
        /// </summary>
        void IDisposable.Dispose()
        {
        }
    }
}