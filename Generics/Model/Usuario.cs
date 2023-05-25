namespace Generics.Model
{
    internal class Usuario
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public Usuario()
        {
            Nome = "Daniel";
            Email = "Daniel@gmail.com";
            Senha = "123456";
        }
        public override string ToString()
        {
            return $"Usuario: {Nome} , Email: {Email} , Senha: {Senha}";
        }
    }
}
