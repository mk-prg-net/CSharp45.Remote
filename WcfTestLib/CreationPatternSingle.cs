using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Diagnostics;


namespace WcfTestLib
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    [System.ServiceModel.Activation.AspNetCompatibilityRequirements(RequirementsMode = System.ServiceModel.Activation.AspNetCompatibilityRequirementsMode.Allowed)]
    public class CreationPatternSingle : ICreationPatterns
    {
        int _count = 0;

        /// <summary>
        /// Konstruktor
        /// </summary>
        public CreationPatternSingle()
        {
            _count++;
        }

        /// <summary>
        /// Destruktor
        /// </summary>
        ~CreationPatternSingle()
        {
            _count++;
            Debug.WriteLine("Im Destruktor von CreationPatternSingle");
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
