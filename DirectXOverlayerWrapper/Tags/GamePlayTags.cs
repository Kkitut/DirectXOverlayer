using DirectXOverlayer.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectXOverlayer.Tags
{
    public class GamePlayTags
    {
        [Tag("Progress", Dummy: double.NaN)]
        public static double Progress()
        {
            return (double)((!scrLevelMaker.instance) ? 0f : scrController.instance.percentComplete) * 100.0;
        }

        [Tag("Accuracy", Dummy: double.NaN)]
        public static double Accuracy()
        {
            return scrController.instance.mistakesManager.percentAcc * 100.0;
        }

        [Tag("XAccuracy", Dummy: double.NaN)]
        public static double XAccuracy()
        {
            return scrController.instance.mistakesManager.percentXAcc * 100.0;
        }

        [FieldTag("RealBpm", Dummy: double.NaN)]
        public static double RealBpm;
        [FieldTag("TileBpm", Dummy: double.NaN)]
        public static double TileBpm;
        [FieldTag("ReqKps", Dummy: double.NaN)]
        public static double ReqKps;
    }
}
