using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;

namespace RimlightArchive
{
    public class ModExtension_Shardblade : DefModExtension
    {
        public Hediff hediffOnDeath;
        //pawn.TakeDamage(new DamageInfo(DamageDefOf.SurgicalCut, 99999f, 999f, -1f, null, part));
    }

    public class ShardbladeKill : DamageWorker
    {
        public ModExtension_Shardblade Props => base.def.GetModExtension<ModExtension_Shardblade>();

        DamageResult = Apply(DamageInfo, victim);
    }
}
