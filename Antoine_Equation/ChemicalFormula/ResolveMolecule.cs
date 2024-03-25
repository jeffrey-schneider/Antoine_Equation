using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ChemicalFormula
{
    internal class ResolveMolecule
    {
        public Dictionary<string, double> getElements(string _molecule)
        {
            Dictionary<string, double> dictionary = new Dictionary<string, double>();
            bool flag = Regex.IsMatch(_molecule, "[A-Z][a-z]?\\d*\\((([A-Z][a-z]?\\d*){1,2})\\)\\d*");
            MatchCollection matchCollection = Regex.Matches(_molecule, "\\(?[A-Z][a-z]?\\d*\\)?");
            double num = double.Parse(Regex.IsMatch(_molecule, "\\)\\d+") ? Regex.Match(_molecule, "\\)\\d+").Value.Remove(0, 1) : "1");
            foreach (Match item in matchCollection)
            {
                string value = Regex.Match(item.Value, "[A-Z][a-z]?").Value;
                double result = 0.0;
                result = ((!Regex.IsMatch(item.Value, "[\\(\\)]")) ? double.Parse(string.IsNullOrWhiteSpace(item.Value.Replace(value, "")) ? "1" : item.Value.Replace(value, "")) : (double.TryParse(Regex.Replace(item.Value, "(\\(|\\)|[A-Z]|[a-z])", ""), out result) ? (result * num) : num));
                dictionary.Add(value, result);
            }

            return dictionary;
        }
    }
}