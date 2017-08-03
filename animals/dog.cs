namespace animals
{
    public class Dog: Animal, Hate_Int
    {
        static int count = 0;

        public Dog(string name): base(name) {
            count++;
            System.Console.WriteLine(count);
        }

        public void Speak(){
            base.Speak("woof");
        }

        public void Move() {
            base.Move("jump");
        }

        public void Hate() {
            System.Console.WriteLine("we hate cats.");
        }
    }
}