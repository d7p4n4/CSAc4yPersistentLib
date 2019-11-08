using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using d7p4n4.Algebra.Class;
using d7p4n4.Final.Class;
using d7p4n4.Context.Class;


namespace d7p4n4.EFMethods.Class
{
    public class Ac4yIdentificationBaseEntityMethods : Ac4yIdentificationBaseAlgebra
    {
		public string baseName { get; set; }

        public Ac4yIdentificationBaseEntityMethods() { }

        public Ac4yIdentificationBaseEntityMethods(string newBaseName)
        {
            baseName = newBaseName;
        }
	
        public Ac4yIdentificationBase findFirstById(Int32 id)
        {
            Ac4yIdentificationBase a = null;

            using (var ctx = new AllContext(baseName))
            {
                var query = ctx.Ac4yIdentificationBases
                                .Where(ss => ss.id == id)
                                .FirstOrDefault<Ac4yIdentificationBase>();

                a = query;
            }
            return a;
        }


	public void addNew(Ac4yIdentificationBase _Ac4yIdentificationBase)
	{
		using (var ctx = new AllContext(baseName))
            {
                ctx.Ac4yIdentificationBases.Add(_Ac4yIdentificationBase);

                ctx.SaveChanges();
            }
	}
    }
}
