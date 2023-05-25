

namespace _00_Biblioteca
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
    }
    public class MoqUsuario
    {
        public static Usuario SingleUsuario()
        {
            Usuario? usuario = new Usuario()
            {
                Nome = "Daniel de Lima",
                CPF = "123.123.123-12",
                Email = "meuemail@gmail.com"
            };
            return usuario;
        }
        public static List<Usuario> ListUsuario()
        {
            List<Usuario>? usuarios = new List<Usuario>()
            { new Usuario{
                Nome = "Daniel de Lima",
                CPF = "111.111.111-11",
                Email = "daniel@gmail.com"
            },
            new Usuario{
                Nome = "Joao",
                CPF = "222.222.222-22",
                Email = "joao@gmail.com"
            },
            new Usuario{
                Nome = "fulano",
                CPF = "333.333.333-333",
                Email = "fulano@gmail.com"
            }
            };
            return usuarios;
        }
    }
}