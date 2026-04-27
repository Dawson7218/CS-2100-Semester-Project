using RimWorld.Planet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;

namespace RimlightArchive
{
// IncidentWorker_ThrumboPasses

    public class SprenSpawnerMapComponent : MapComponent
    {
        public SprenSpawnerMapComponent(Map map) : base(map) 
        {
        }

        public Map SourceMap => (map.Parent as PocketMapParent)?.sourceMap;

    }
}
