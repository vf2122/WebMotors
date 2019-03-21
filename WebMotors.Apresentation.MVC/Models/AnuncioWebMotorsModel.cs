namespace WebMotors.Apresentation.MVC.Models
{
    public class AnuncioWebMotorsModel
    {
        public AnuncioWebMotorsModel(int id, string marca, string modelo, string versao, int ano, int quilometragem, string observacao)
        {
            Id = id;
            Marca = marca;
            Modelo = modelo;
            Versao = versao;
            Ano = ano;
            Quilometragem = quilometragem;
            Observacao = observacao;
        }

        public int Id { get; private set; }
        public string Marca { get; private set; }
        public string Modelo { get; private set; }
        public string Versao { get; private set; }
        public int Ano { get; private set; }
        public int Quilometragem { get; private set; }
        public string Observacao { get; private set; }

    }
}