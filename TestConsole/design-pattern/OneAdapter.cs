namespace TestConsole.design_pattern
{
    public class OneAdapter
    {
        private One _one;
        
        public OneAdapter(One one)
        {
            _one = one;
        }

        public void add(string data)
        {
            _one.put(data);
        }
    }
}