﻿using DirectXOverlayer.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectXOverlayer.Tags
{
    public class GamePlayTags
    {
        [Tag("Progress", Dummy: 56.8135)]
        public static double Progress()
        {
            return (double)((!scrLevelMaker.instance) ? 0f : scrController.instance.percentComplete) * 100.0;
        }

        [Tag("Accuracy", Dummy: 101.1)]
        public static double Accuracy()
        {
            return scrController.instance.mistakesManager.percentAcc * 100.0;
        }

        [Tag("XAccuracy", Dummy: 99.3)]
        public static double XAccuracy()
        {
            return scrController.instance.mistakesManager.percentXAcc * 100.0;
        }

        [FieldTag("RealBpm", Dummy: 200)]
        public static double RealBpm;
        [FieldTag("TileBpm", Dummy: 100)]
        public static double TileBpm;
        [FieldTag("ReqKps", Dummy: 200d / 60d)]
        public static double ReqKps;
    }
}
