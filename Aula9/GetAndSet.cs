using System;

namespace CursoCSharp.Aula9
{
    class GetAndSet
    {
        private string _nome;
        private int _idade;

        public GetAndSet() { }

        public GetAndSet(string _nome, int _idade)
        {
            this._nome = _nome;
            this._idade = _idade;
        }

        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string _nome)
        {
            this._nome = _nome;
        }

        public int GetIdade()
        {
            return _idade = Math.Abs(_idade);
        }

        public void SetNome(int _idade)
        {
            _idade = Math.Abs(_idade);
            this._idade = _idade;
        }

    }

    class Obj
    {
        public static void Main()
        {
            GetAndSet pessoa1 = new GetAndSet("Gabriel", 23);
            Console.WriteLine($"Nome: {pessoa1.GetNome()}");
            Console.WriteLine($"Idade: {pessoa1.GetIdade()}");

            var pessoa2 = new GetAndSet();
            pessoa2.SetNome("João");
            pessoa2.SetNome(-22);
            Console.WriteLine($"Nome: {pessoa2.GetNome()}");
            Console.WriteLine($"Idade: {pessoa2.GetIdade()}");
        }
    }
}
