using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using d7p4n4.Algebra.Class;
using d7p4n4.Final.Class;
using d7p4n4.Context.Class;


namespace d7p4n4.EFMethods.Class
{
    public class Ac4yIdentificationEntityMethods : Ac4yIdentificationAlgebra
    {
		public string baseName { get; set; }

        public Ac4yIdentificationEntityMethods() { }

        public Ac4yIdentificationEntityMethods(string newBaseName)
        {
            baseName = newBaseName;
        }
	
        public Ac4yIdentification findFirstById(Int32 id)
        {
            Ac4yIdentification a = null;

            using (var ctx = new AllContext(baseName))
            {
                var query = ctx.Ac4yIdentifications
                                .Where(ss => ss.id == id)
                                .FirstOrDefault<Ac4yIdentification>();

                a = query;
            }
            return a;
        }

	public void addNew(Ac4yIdentification _Ac4yIdentification)
	{
		using (var ctx = new AllContext(baseName))
            {
                ctx.Ac4yIdentifications.Add(_Ac4yIdentification);

                ctx.SaveChanges();
            }
	}
    }
}
