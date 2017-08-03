using System;

namespace animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog rocky = new Dog("rocky");
            rocky.Speak();
            rocky.Move();
            Bird polly = new Bird("polly");
            polly.Speak();
            polly.Move();
            Dog fido = new Dog("fido");
            Dog dog3 = new Dog("dog 3");
            fido.Hate();
            polly.Hate();
            
        }
    }
}
