using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scanner
{
    class Symbol
    {
        //public static int T_nil = 0;
        //public static int T_int = 1;
        //public static int T_array = 2;

        private string name=null;
        private int type = 0;
        private Boolean isFunc = false;
        private int numbrOfParms = 0;
        private List<Symbol> table = new List<Symbol>();
        private List<Symbol> paramtable = new List<Symbol>();

        public Symbol(string name, int type , Boolean isFunc, int numbrOfParms)
        {
            this.name = name;
            this.type = type;
            this.isFunc = isFunc;
            this.numbrOfParms = numbrOfParms;

        }

        public Symbol()
        {
            

        }

        public void SetName(string name)
        {
            this.name = name;

        }
        public void SetType(int type)
        {
            this.type = type;

        }
        public void SetFunc(Boolean isFunc)
        {
            this.isFunc = isFunc;

        }
        public void SetNumbrOfParms()
        {
            this.numbrOfParms++;

        }
        public void SetTable(List<Symbol> symbols)
        {
            this.table = symbols;
        }
        public void AddSymbol(Symbol symbol)
        {
            this.table.Add(symbol);
        }







        public string GetName()
        {
            return this.name;

        }
        public int GetType()
        {
            return this.type;

        }
        public Boolean GetFunc()
        {
            return this.isFunc;

        }
        public int GetNumbrOfParms()
        {
            return this.numbrOfParms;

        }
        public List<Symbol> GetTable()
        {
            return this.table;
        }



        public void addNode(Symbol symbol)
        {
            table.Add(symbol);
        }

        public void addparam(Symbol symbol)
        {
            this.paramtable.Add(symbol);
        }
        public List<Symbol> GetParamTable()
        {
            return this.paramtable;
        }





    }
}
