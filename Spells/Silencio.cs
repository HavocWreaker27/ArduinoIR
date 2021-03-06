﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WiiWandz.Strokes;
using WiiWandz.Ifttt;

namespace WiiWandz.Spells
{
    class Silencio : CloudBitSpell
    {
        public Silencio(double confidence)
            : base(confidence)
        {
            this.minPercentOfTotalBetweenStartAndEndPoints = 50;
            this.maxPercentOfTotalBetweenStartAndEndPoints = 100;
            this.acceptableDirectionsFromStartToEndPoint.Add(StrokeDirection.DownToTheLeft);
        }

        public Silencio(String device, String authorization, String iftttKey, String iftttEvent)
            : base(device, authorization, iftttKey, iftttEvent)
        {
            List<StrokeDirection> directions = new List<StrokeDirection>();
            directions.Add(StrokeDirection.Down);
            directions.Add(StrokeDirection.DownToTheLeft);
            directions.Add(StrokeDirection.Left);
            directions.Add(StrokeDirection.UpToTheLeft);
            directions.Add(StrokeDirection.Up);
            directions.Add(StrokeDirection.Down);
            this.strokesForSpell.Add(directions);

            directions = new List<StrokeDirection>();
            directions.Add(StrokeDirection.Down);
            directions.Add(StrokeDirection.DownToTheLeft);
            directions.Add(StrokeDirection.UpToTheLeft);
            directions.Add(StrokeDirection.Down);
            this.strokesForSpell.Add(directions);

        }
    }
}
