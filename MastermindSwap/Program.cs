using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using CodeBreaker.UnitTests;
using MastermindKata.Logic;

namespace MastermindSwap
{
    class Program
    {
        static void Main(string[] args)
        {
      
                var masterMindGame = new MastermindGame();
            masterMindGame.StartGame();
        }

      

    }
}
