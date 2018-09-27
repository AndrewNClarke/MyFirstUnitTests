using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace MyFirstUnitTests
{
    public class Thingy
    {
        public int x { get; set; }

        public Thingy()
        {
        }

        public Thingy(int StartValue)
        {
            x = StartValue;
        }
    }
}