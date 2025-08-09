namespace TestConsole.dip
{
    public class Car
    {
        private Engine _engine;
        
        public Car(Engine engine)
        {
            _engine = engine;
        }

        public void start()
        {
            _engine.start();
        }
    }
}