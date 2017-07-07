using DependentLibrary;

namespace Library
{
    public class LClass
    {
        public void Do()
        {
            var other = new DlClass();
            other.Do();
        }
    }
}
