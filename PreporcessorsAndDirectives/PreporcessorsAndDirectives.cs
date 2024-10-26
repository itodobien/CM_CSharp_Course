#define TESTING

namespace CM_CSharp_Course.PreporcessorsAndDirectives
{
    public class PreporcessorsAndDirectives
    {
        #region METHODS
        public void PreporcessorsAndDirectivesMainMethod()
        {
        
        }

#if TESTING
        public void TestingMethod()
        {
            Console.WriteLine("Preporcessors and Directives testing");
        }
#endif
        #endregion
    }
}