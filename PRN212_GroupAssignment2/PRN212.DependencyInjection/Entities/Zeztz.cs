using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN212.DependencyInjection.Entities
{
    public class Zeztz
    {
        private readonly IForm _form;

        public Zeztz(IForm form)
        {
            _form = form;
        }

        public void Henshin()
        {
            Console.WriteLine("I'm on it!");
            _form.Henshin();
        }
    }
}
