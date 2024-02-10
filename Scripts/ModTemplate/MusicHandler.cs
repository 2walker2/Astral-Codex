using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace AstralCodex
{
    internal class MusicHandler
    {
        static AudioClip defaultTravelMusic;

        public static void Initialize()
        {
            GlobalMusicController globalMusicController = Locator.GetGlobalMusicController();

            //Travel music
            defaultTravelMusic = globalMusicController._travelSource.clip;
            globalMusicController._travelSource._audioLibraryClip = 0;
            globalMusicController._travelSource._clipArrayIndex = 0;
            globalMusicController._travelSource._clipArrayLength = 0;
            globalMusicController._travelSource._clipSelectionOnPlay = OWAudioSource.ClipSelectionOnPlay.MANUAL;

            //Override settings on all final end times sources
            globalMusicController._finalEndTimesIntroSource._audioLibraryClip = 0;
            globalMusicController._finalEndTimesIntroSource._clipArrayIndex = 0;
            globalMusicController._finalEndTimesIntroSource._clipArrayLength = 0;
            globalMusicController._finalEndTimesIntroSource._clipSelectionOnPlay = OWAudioSource.ClipSelectionOnPlay.MANUAL;

            globalMusicController._finalEndTimesLoopSource._audioLibraryClip = 0;
            globalMusicController._finalEndTimesLoopSource._clipArrayIndex = 0;
            globalMusicController._finalEndTimesLoopSource._clipArrayLength = 0;
            globalMusicController._finalEndTimesLoopSource._clipSelectionOnPlay = OWAudioSource.ClipSelectionOnPlay.MANUAL;

            globalMusicController._finalEndTimesDarkBrambleSource._audioLibraryClip = 0;
            globalMusicController._finalEndTimesDarkBrambleSource._clipArrayIndex = 0;
            globalMusicController._finalEndTimesDarkBrambleSource._clipArrayLength = 0;
            globalMusicController._finalEndTimesDarkBrambleSource._clipSelectionOnPlay = OWAudioSource.ClipSelectionOnPlay.MANUAL;
        }

        public static void SetTravelMusic(bool ghostSpace)
        {
            if (ghostSpace)
                Locator.GetGlobalMusicController()._travelSource.clip = AssetHandler.audioClips["fourDTravelMusic"];
            else
                Locator.GetGlobalMusicController()._travelSource.clip = defaultTravelMusic;
        }

        public static void SetFinalEndTimes()
        {
            //Switch the final end times audio
            GlobalMusicController globalMusicController = Locator.GetGlobalMusicController();
            AudioClip codecFinalEndTimes = AssetHandler.audioClips["codecFinalEndTimes"];
            globalMusicController._finalEndTimesIntroSource.clip = codecFinalEndTimes;
            globalMusicController._finalEndTimesLoopSource.clip = codecFinalEndTimes;
            globalMusicController._finalEndTimesDarkBrambleSource.clip = codecFinalEndTimes;
        }
    }
}
