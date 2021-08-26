using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToWords.Interfaces
{
    /// <summary>
    /// Convrts a 3 digits triplet to Words
    /// </summary>
    public interface ITripletToWordsConverter
    {
        string ToWords(double number, int groupLevel, double remainingNumber);
    }
}
