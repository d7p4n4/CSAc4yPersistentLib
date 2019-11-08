using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using d7p4n4.Algebra.Class;
using d7p4n4.Final.Class;
using d7p4n4.Context.Class;


namespace d7p4n4.EFMethods.Class
{
    public class Ac4yEntityMethods : Ac4yAlgebra
    {
		public string baseName { get; set; }

        public Ac4yEntityMethods() { }

        public Ac4yEntityMethods(string newBaseName)
        {
            baseName = newBaseName;
        }
	
       
        public Ac4y findFirstById(Int32 id)
        {
            Ac4y a = null;

            using (var ctx = new AllContext(baseName))
            {
                var query = ctx.Ac4ys
                                .Where(ss => ss.id == id)
                                .FirstOrDefault<Ac4y>();

                a = query;
            }
            return a;
        }


	public void addNew(Ac4y _Ac4y)
	{
		using (var ctx = new AllContext(baseName))
            {
                ctx.Ac4ys.Add(_Ac4y);

                ctx.SaveChanges();
            }
	}
    }
}
