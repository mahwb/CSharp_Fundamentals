namespace animals
{
    public class Bird: Animal, Hate_Int
    {
        public Bird(string name): base(name) {
            
        }

        public void Speak(){
            base.Speak("chirp");
        }

        public void Move() {
            base.Move("fly");
        }

        public void Hate() {
            System.Console.WriteLine("we also hate cats.");
        }
    }
}