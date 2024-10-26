namespace CM_CSharp_Course.Interfaces;

public class IDisposable
{
    public void IDispsableMainMethod()
    {
        using (FileStream fileStream = File.Open("C:\\Users\\" + Environment.UserName + ".txt", FileMode.Open))
        {
            fileStream.Read(new Span<byte>());
        }
        
        using (SaveSystem saveSystem = new SaveSystem())
        {
            
        }
    }
    
    public class SaveSystem : IDisposable, System.IDisposable
    {
        public void Dispose()
        {
            // TODO release managed resources here
        }
    }
}