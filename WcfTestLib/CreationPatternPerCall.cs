﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Diagnostics;


namespace WcfTestLib
{
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.PerCall)]
    [System.ServiceModel.Activation.AspNetCompatibilityRequirements(RequirementsMode= System.ServiceModel.Activation.AspNetCompatibilityRequirementsMode.Allowed)]
    public class CreationPatternPerCall : ICreationPatterns
    {
        int _count = 0;

        /// <summary>
        /// Konstruktor
        /// </summary>
        public CreationPatternPerCall()
        {
            _count++;
        }

        /// <summary>
        /// Destruktor
        /// </summary>
        ~CreationPatternPerCall()
        {
            _count++;
            Debug.WriteLine("Im Destruktor von CreationPatternPerCall");
        }

        public void ResetCounter()
        {
            _count = 0;
        }

        public int NextValue()
        {
            return ++_count;
        }

        const string NameOfSessionCounter = "CreationPatternsCounter";

        public void ResetAspNetSessionCounter()
        {
            System.Web.HttpContext.Current.Session[NameOfSessionCounter] = (int)0;
        }

        public int NextAspNetSessionValue()
        {
            int counter = (int)System.Web.HttpContext.Current.Session[NameOfSessionCounter];
            counter++;
            System.Web.HttpContext.Current.Session[NameOfSessionCounter] = counter;
            return counter;
        }


        public void StartNewSession()
        {
            Debug.WriteLine("Sitzung beginnt");
        }

        public void TerminateSession()
        {
            Debug.WriteLine("Sitzung endet");
        }
    }
}
