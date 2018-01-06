﻿using BattleMounts;
using GiddyUpCore.Jobs;
using GiddyUpCore.Storage;
using GiddyUpCore.Utilities;
using RimWorld;
using RimWorld.Planet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;
using Verse.AI;

namespace Battlemounts.Utilities
{
    class EnemyMountUtility
    {
        public static void mountAnimals(List<Pawn> list, IncidentParms parms)
        {
            if (list.Count == 0 || !(parms.raidArrivalMode == PawnsArriveMode.EdgeWalkIn || parms.raidArrivalMode == PawnsArriveMode.Undecided) || (parms.raidStrategy != null && parms.raidStrategy.workerClass == typeof(RaidStrategyWorker_Siege)))
            {
                return;
            }
            NPCMountUtility.generateMounts(list, parms, Base.inBiomeWeight, Base.outBiomeWeight, Base.nonWildWeight, Base.enemyMountChance, Base.enemyMountChanceTribal);
        }
    }
}