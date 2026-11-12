using PRN212.DependencyInjection.Entities;

namespace PRN212.DependencyInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IForm form = new Entities.Exdream();
            Zeztz zeztz = new Zeztz(form);

            zeztz.Henshin();
        }
    }
}
