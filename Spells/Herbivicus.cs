﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WiiWandz.Strokes;
using WiiWandz.Ifttt;

namespace WiiWandz.Spells
{
	class Herbivicus : CloudBitSpell
	{
        public Herbivicus(double confidence) : base(confidence) 
        {
            this.minConfidence = 0.9999;
            this.minPercentOfTotalBetweenStartAndEndPoints = 85;
            this.maxPercentOfTotalBetweenStartAndEndPoints = 100;
            this.acceptableDirectionsFromStartToEndPoint.Add(StrokeDirection.DownToTheRight);
        }

        public Herbivicus(String device, String authorization, String iftttKey, String iftttEvent)
            : base(device, authorization, iftttKey, iftttEvent)
		{
            List<StrokeDirection> directions = new List<StrokeDirection>();
            directions.Add(StrokeDirection.Down);
            directions.Add(StrokeDirection.Up);
            directions.Add(StrokeDirection.UpToTheRight);
            directions.Add(StrokeDirection.Right);
            directions.Add(StrokeDirection.DownToTheLeft);
            directions.Add(StrokeDirection.Down);
            this.strokesForSpell.Add(directions);

            directions = new List<StrokeDirection>();
            directions.Add(StrokeDirection.Down);
            directions.Add(StrokeDirection.UpToTheRight);
            directions.Add(StrokeDirection.DownToTheLeft);
            directions.Add(StrokeDirection.Down);
            this.strokesForSpell.Add(directions);

		}
	}
}
