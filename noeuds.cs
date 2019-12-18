using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormalgorithme_huffman
{
 
        public class noeud_
        {
          
            public byte ASCIICode;
        
            public long Count;
        
            public noeud  parent;
        
            public noeud LNode;
       
            public noeud RNode;
      
            public string CodeWord = "";
    
            public noeud()
            {
                this.ASCIICode = 0;
                this.Count = -1;
                this.parent = null;
                this.LNode = null;
                this.RNode = null;
            }
      



            public noeud(int valeur, long occurence)
            {
                this.ASCIICode = (byte)valeur;
                this.Count = occurence;
                this.parent = null;
                this.LNode = null;
                this.RNode = null;
            }
           
            public noeud(ref noeud_proprietes left, ref noeud_proprietes right)
            {
                this.parent = null;
                this.ASCIICode = 0;
                this.Count = left.Count + right.Count;
                this.LNode = left;
                this.RNode = right;
            }

            public int HasLRChildren()
            {
                int result = 0;

                if (this.LNode != null)
                {
                    result = 1;
                }
                if (this.RNode != null)
                {
                    if (result == 1)
                    {
                        result++;
                    }
                    result++;
                }

                return result;
          }
    }
}
