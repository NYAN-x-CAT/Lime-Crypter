using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lime_Crypter.Util
{
    public class RandomFileInfo
    {
        private readonly Random random = new Random();
        private readonly RandomCharacters randomCharacters;
        private int lastIndex;

        public RandomFileInfo(RandomCharacters randomCharacters)
        {
            this.randomCharacters = randomCharacters;
        }

        public PremadeFileInfo getRandomFileInfo()
        {
            const int numWords = 2;
            const int randomVersionUpper = 10;
            const int randomVersionLower = 0;
            if (random.Next(0, 7) == 0) // 1 in 7 chance to generate random words
            {
                return new PremadeFileInfo()
                {
                    Title = randomWords(numWords),
                    Description = randomWords(numWords),
                    Product = randomWords(numWords),
                    Company = randomWords(numWords),
                    Copyright = randomWords(numWords),
                    Trademark = randomWords(numWords),
                    MajorVersion = random.Next(randomVersionLower, randomVersionUpper).ToString(),
                    MinorVersion = random.Next(randomVersionLower, randomVersionUpper).ToString(),
                    BuildPart = random.Next(randomVersionLower, randomVersionUpper).ToString(),
                    PrivatePart = random.Next(randomVersionLower, randomVersionUpper).ToString()
                };
            }

            var newIndex = lastIndex;
            do // Make sure we don't give the same file 2 times in a row
            {
                newIndex = random.Next(0, premadeFileInfoList.Count - 1);
            }
            while (newIndex == lastIndex);

            lastIndex = newIndex;
            return premadeFileInfoList[newIndex];
        }

        private string randomWords(int numberOfWords)
        {
            var generatedWords = new List<string>();
            for (int i = 0; i < numberOfWords; i++)
            {
                generatedWords.Add(this.randomCharacters.getRandomCharacters(random.Next(5, 10)));
            }

            return string.Join(" ", generatedWords);
        }

        private readonly List<PremadeFileInfo> premadeFileInfoList = new List<PremadeFileInfo>() {
   {
    new PremadeFileInfo() {
     Title = "chome_exe",
      Description = "Google Chrome",
      Product = "Google Chrome",
      Company = "Google Inc.",
      Copyright = "Copyright 2017 Google Inc. All rights reserved.",
      Trademark = "",
      MajorVersion = "67",
      MinorVersion = "0",
      BuildPart = "3396",
      PrivatePart = "99"
    }
   }, {
    new PremadeFileInfo() {
     Title = "vlc",
      Description = "VLC media player",
      Product = "VLC media player",
      Company = "VideoLAN",
      Copyright = "Copyright © 1996-2018 VideoLAN and VLC Author",
      Trademark = "VLC media player, VideoLAN and x264 are registered trademarks from VideoLAN",
      MajorVersion = "3",
      MinorVersion = "0",
      BuildPart = "3",
      PrivatePart = "0"
    }
   }, {
    new PremadeFileInfo() {
     Title = "HWMonitor.exe",
      Description = "HWMonitor",
      Product = "CPUID Hardware Monitor",
      Company = "CPUID",
      Copyright = "(c)2008-2018 CPUID.  All rights reserved.",
      Trademark = "",
      MajorVersion = "1",
      MinorVersion = "3",
      BuildPart = "4",
      PrivatePart = "0"
    }
   }, {
    new PremadeFileInfo() {
     Title = "CamtasiaStudio.exe",
      Description = "TechSmith Camtasia 2018",
      Product = "Camtasia",
      Company = "TechSmith Corporation",
      Copyright = "Copyright © 2011-2018 TechSmith Corporation. All rights reserved.",
      Trademark = "18",
      MajorVersion = "0",
      MinorVersion = "0",
      BuildPart = "31",
      PrivatePart = "0"
    }
   }
  };
    }
}
