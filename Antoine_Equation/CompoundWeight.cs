using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antoine_Equation
{
    class CompoundWeight
    {
        public CompoundWeight(string symbol, string name, double weight, double atoms)
        {
            Symbol = symbol;
            Name = name;
            Weight = weight;
            Atoms = atoms;
        }

        public string Symbol { get; }
        public string Name { get; }
        public double Weight { get; }
        public double Atoms { get; }
        public double MoleMass { get { return Weight * Atoms; } }
    }
}
