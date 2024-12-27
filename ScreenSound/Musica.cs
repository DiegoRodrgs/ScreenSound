namespace ScreenSound
{
    record Musica(string Nome, Banda Artista, int Duracao, bool Disponivel, Genero Genero)
    {
        public Musica(Banda artista, string nome) : this(nome, artista, default, default, default)
        {
        }

        public string DescricaoResumida =>
            $"A música {Nome} pertence à banda {Artista}";


        public void ExibirFichaTecnica()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Artista: {Artista.Nome}");
            Console.WriteLine($"Duração: {Duracao}");
            if (Disponivel)
            {
                Console.WriteLine("Disponível no plano.");
            }
            else
            {
                Console.WriteLine("Adquira o plano Plus+");
            }
        }
    }
}