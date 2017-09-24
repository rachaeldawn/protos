﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Types
{
    public class WorkerActivity
    {
        public string Activity { get; set; }
        public bool IsInterruptable { get; set; }
        /// <summary>
        /// Create a new WorkerActivity
        /// </summary>
        /// <param name="act">The name of the activity. IE: "Sleeping"</param>
        /// <param name="interr">Can you interrupt the activity?</param>
        public WorkerActivity(string act, bool interr)
        {
            Activity = act;
            IsInterruptable = interr;
        }
    }
}
