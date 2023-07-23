using System;

namespace Animais
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Animal animal = new Animal();
            AnimalDomestico animDom = new AnimalDomestico();
            AnimalSelvagem animSelv = new AnimalSelvagem();
 
            Console.Write("\nDigite o nome do animal: ");
            animal.nome = Console.ReadLine();
            Console.Write("\nDigite a cor do animal: ");
            animal.cor = Console.ReadLine();
            Console.Write("\nDigite o tipo do animal(Doméstico/Selvagem): ");
            animal.tipo = Console.ReadLine();
            if(animal.tipo == "Doméstico" || animal.tipo == "doméstico")
            {
                Console.Write("\nDigite o som do animal: ");
                animDom.som = Console.ReadLine();
                Console.Write("\nDigite o endereço do animal: ");
                animDom.endereco = Console.ReadLine();
                Console.Write("\nDigite a espécie do animal(Aquático/Terrestre/Aéreo): ");
                animDom.especie = Console.ReadLine();

                if(animDom.especie == "Aquático" || animDom.especie == "aquático")
                {
                    Console.WriteLine($"\nNome do animal: {animal.nome}\n Cor do animal: {animal.cor}\n Tipo do animal: {animal.tipo}\n Som do animal: {animDom.som}\n Endereço do animal: {animDom.endereco}\n Locomoção do animal: Nadar");
                }
                else if (animDom.especie == "Terrestre" || animDom.especie == "terrestre")
                {
                    Console.WriteLine($"\nNome do animal: {animal.nome}\n Cor do animal: {animal.cor}\n Tipo do animal: {animal.tipo}\n Som do animal: {animDom.som}\n Endereço do animal: {animDom.endereco}\n Locomoção do animal: Andar");
                }
                else
                {
                    Console.WriteLine($"\nNome do animal: {animal.nome}\n Cor do animal: {animal.cor}\n Tipo do animal: {animal.tipo}\n Som do animal: {animDom.som}\n Endereço do animal: {animDom.endereco}\n Locomoção do animal: Voar");
                }
            }
            else
            {
                Console.Write("\nDigite o som do animal: ");
                animSelv.som = Console.ReadLine();
                Console.Write("Digite o habitat do animal: ");
                animSelv.habitat = Console.ReadLine();
                Console.Write("\nDigite a espécie do animal(Aquático/Terrestre/Aéreo): ");
                animSelv.especie = Console.ReadLine();

                if (animSelv.especie == "Aquático" || animSelv.especie == "aquático")
                {
                    Console.WriteLine($"\nNome do animal: {animal.nome}\n Cor do animal: {animal.cor}\n Tipo do animal: {animal.tipo}\n Som do animal: {animSelv.som}\n Endereço do animal: {animSelv.habitat}\n Locomoção do animal: Nadar");
                }
                else if (animSelv.especie == "Terrestre" || animSelv.especie == "terrestre")
                {
                    Console.WriteLine($"\nNome do animal: {animal.nome}\n Cor do animal: {animal.cor}\n Tipo do animal: {animal.tipo}\n Som do animal: {animSelv.som}\n Endereço do animal: {animSelv.habitat}\n Locomoção do animal: Andar");
                }
                else
                {
                    Console.WriteLine($"\nNome do animal: {animal.nome}\n Cor do animal: {animal.cor}\n Tipo do animal: {animal.tipo}\n Som do animal: {animSelv.som}\n Endereço do animal: {animSelv.habitat}\n Locomoção do animal: Voar");
                }
            }
        }
    }
}