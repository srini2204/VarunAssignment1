using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CrozzleValidator.Validator
{
    enum Orietation
    {
        Horizontal,
        Vertical
    }
    class CrozzleWord
    {
        int hPos { get; set; }
        int vPos { get; set; }
        Orietation orientation;
        internal Orietation Orientation
        {
          get { return orientation; }
          set { 
              orientation = value;
              switch (orientation)
                {
                    case Orietation.Horizontal:
                        vCrozzleWords = new LinkedList<CrozzleWord>();
                        break;
                    case Orietation.Vertical:
                        hCrozzleWords = new LinkedList<CrozzleWord>();
                        break;
                    default:
                        break;
                }
          }
        }
        LinkedList<CrozzleWord> hCrozzleWords;
        LinkedList<CrozzleWord> vCrozzleWords;


        public CrozzleWord()
        {
           
        }
    }
}
